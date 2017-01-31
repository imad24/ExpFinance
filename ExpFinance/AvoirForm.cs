using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraPrinting.Native;


namespace ExpFinance
{
    public partial class AvoirForm : Form
    {
        private int _typeAvoir=2;
        private List<int> _numGroupe;
        private decimal _montant, _cheque, _total, _marge,_creance,_reste;
        private int _numAvoir;
        private bool _locked=true,_isCheque,_isCreance=true;
        public CHEQUE  ChequesBuffer;
        private List<CHEQUE> _chequesList=new List<CHEQUE>();
        private string _observation,_designation;
        private AVOIR_FINANCIER _avoir;

        private bool Editing { get; set; }


        public AvoirForm()
        {
            InitializeComponent();
            _numGroupe = null;
        }

        public AvoirForm(List<int> idg,decimal mnt)
        {
            InitializeComponent();
            _numGroupe = idg;
            _montant = mnt;
            _creance = 0;
            _reste = _montant;
            Lock(true);
            Editing = false;

        }

        public AvoirForm(AVOIR_FINANCIER avoir)
        {
            InitializeComponent();
            _avoir = avoir;
            Editing = true;
        }


        #region View
        private void AvoirForm_Load(object sender, EventArgs e)
        {

                if (_avoir != null) LoadAvoir(_avoir);
                else LoadNewAvoir();
      
        }

        private void LoadAvoir(AVOIR_FINANCIER avoir)
        {
            try
            {
                using (var model = new ExpFinanceEntities())
                {
                    var detail = new DetailsDossier();
                    //Set références
                    _numAvoir = avoir.numAvoir;
                    textBoxRefAvoir.Text = _numAvoir.ToString("D");
                    _montant = avoir.montant;
                    _cheque = avoir.montantCheque;
                    _creance = avoir.montantCreance;
                    _observation = avoir.Observation;
                    textBoxDesc.Text = avoir.designation;
                    textBoxObservation.Text = avoir.Observation;
                    dateAvoir.Value = avoir.dateAvoir;

                    //Get cheques
                    _chequesList = (from c in model.CHEQUE where c.numAvoir == avoir.numAvoir select c).ToList();
                    RebindListBoxCheque();
                    TotalCheque();

                    //Set type
                    switch (avoir.typeAvoir)
                    {
                        case 1:
                            _isCheque = true;
                            _isCreance = false;
                            break;
                        case 2:
                            _isCreance = true;
                            _isCheque = false;
                            break;
                        case 3:
                            _isCheque = _isCreance = true;
                            break;
                        default:
                            _isCheque = _isCreance = false;
                            break;
                    }

                  
                    //Get Groupe Factures related to the avoir
                    _numGroupe = (from afg in model.AF_AVOIR_GROUPE
                        where afg.numAvoir == _numAvoir
                        select afg.IDG).ToList();


                    // ReSharper disable once ConstantNullCoalescingCondition
                    if (_numGroupe.Count==0)  throw new NullReferenceException("Les groupse factures liés à cette avoir n'existe plus !");

                       // var factures = detail.GetFactures(_numGroupe);
                        var factures = new List<FACTURE>();
                        
                        //Get factures of each groupe then put them all in one list
                        _numGroupe.ForEach(g =>
                        {
                            var groupeFactures = detail.GetFactures(g);
                            //add each groupe factures to the global list
                            groupeFactures.ForEach(factures.Add);
                        });

                        PopulateFacutresListView(factures);

                    //disable facture item check
                    listViewFactures.ItemCheck -= listViewFactures_ItemCheck;
                    foreach (ListViewItem item in listViewFactures.Items)
                        {
                            item.Checked = true;
                        }



                    //set totals values
                    decimal t, m;
                    TotalFactures(out t, out m);

                    //set reste
                    _reste = _montant - (_creance + _cheque);

                    textBoxMontantAv.Text = $"{_montant:#,##0.00}";
                    textBoxCreance.Text = $"{_creance:#,##0.00}";

                    //enable facture item check
                    listViewFactures.ItemCheck += listViewFactures_ItemCheck;

                    CheckType();
                }
            }
            catch (Exception e)
            {

                Messages.Error("Error Loading avoir :" + e.Message);
                ErrorLog.LogError("Error Loading avoir",e);
                Close();
            }
        }

        private void LoadNewAvoir()
        {
            try
            {
                    var detail = new DetailsDossier();

                    //Set référence
                    _numAvoir = detail.GetLastAvoirId(dateAvoir.Value);
                    textBoxRefAvoir.Text = _numAvoir.ToString("D");

                    if (_numGroupe.Count != 0)
                    {
                        // _montant = detail.GetGroupeInfo(_numGroupe).MNT_HT ?? 0;

                        // var factures = detail.GetFactures(_numGroupe);
                        var factures = new List<FACTURE>();

                        //Get factures of each groupe then put them all in one list
                        _numGroupe.ForEach(g =>
                        {
                            var groupeFactures = detail.GetFactures(g);
                            //add each groupe factures to the global list
                            groupeFactures.ForEach(factures.Add);
                        });

                        PopulateFacutresListView(factures);
                        foreach (ListViewItem item in listViewFactures.Items)
                        {
                            item.Checked = true;
                        }
                        textBoxMontantAv.Text = string.Format("{0:#,##0.00}", _montant);
                        textBoxCreance.Text = string.Format("{0:#,##0.00}", _reste);
                    }
                    //set totals values
                    decimal t, m;
                    TotalFactures(out t, out m);

                    //disable facture item check
                    listViewFactures.ItemCheck += listViewFactures_ItemCheck;
                    _designation = textBoxDesc.Text;
                    Calculation();
                    CheckType();
                
            }
            catch (Exception e)
            {
                Messages.Error("Error Creating avoir :"+e.Message);
                ErrorLog.LogError("Error Creating avoir",e);
                Close();
            }
        }

        void PopulateFacutresListView(List<FACTURE> liste)
        {
            
            liste = liste.OrderByDescending(f => f.DATE_FACT).ToList();
            liste.ForEach(f =>
            {
                var date = f.DATE_FACT.Date;
                var num = f.NUM_FACT.ToString("");
                var htr = f.MNT_HT_RZ != null ? f.MNT_HT_RZ.Value.ToString("N2") : "0";
                var remise = f.MARGE != null ? f.MARGE.Value.ToString("N2") : "0";
                listViewFactures.Items.Add(new ListViewItem(new[] { num, date.ToShortDateString(), htr, remise }));
            });
        }

        private void LoadCheque()
        {
            if (ChequesBuffer == null) return;
            _chequesList.Add(ChequesBuffer);
            RebindListBoxCheque();
            textBoxTotalCheque.Text = TotalCheque().ToString("N2") + @" DA";
            textBoxTotalCheque.ForeColor = TotalCheque() >= _montant ? Color.Green : Color.Coral;
            //empty the buffer
            ChequesBuffer = null;
        }

        private void RemoveCheque(string num)
        {
            var ch = _chequesList.Find(c => c.numCheque == num);
            _chequesList.Remove(ch);
            textBoxTotalCheque.Text = TotalCheque().ToString("N2") + @" DA";
            textBoxTotalCheque.ForeColor = TotalCheque() >= _montant ? Color.Green : Color.Coral;
        }

        private void RebindListBoxCheque()
        {
            listBoxCheque.DataSource = null;
            listBoxCheque.Items.Clear();
            listBoxCheque.DataSource = _chequesList;
            listBoxCheque.DisplayMember = "numCheque";
            listBoxCheque.ValueMember = "numCheque";
            textBoxTotalCheque.Text = TotalCheque().ToString("N2") + @" DA";
            textBoxTotalCheque.ForeColor = TotalCheque() >= _montant ? Color.Green : Color.Coral;
        }

        decimal TotalCheque()
        {
            decimal total = 0;
            _chequesList.ForEach(c => total += c.montant);
            _cheque = total;
            Calculation();
            return total;
        }

        private void TotalFactures(out decimal tht, out decimal tmarge)
        {
            tht = tmarge = 0;
            foreach (ListViewItem item in listViewFactures.Items)
            {
                var textHt = item.SubItems[2].Text;
                var textMarge = item.SubItems[3].Text;
                decimal ht, marge;
                if (decimal.TryParse(textHt, out ht) && item.Checked) tht += ht;
                if (decimal.TryParse(textMarge, out marge) && item.Checked) tmarge += marge;
            }
            _total = tht;
            _marge = tmarge;

            textBoxHTRZ.Text = tht.ToString("N2")+@" DA";
            textBoxMarge.Text = tmarge.ToString("N2")+@" DA";
            
            //setcolors
            textBoxMontantAv.ForeColor = _montant <= _marge ? Color.Green : Color.Coral;
        }

        private void Calculation()
        {
            _reste = _montant - (_cheque + _creance);
            textBoxReste.Text = _reste >= 0 ? _reste.ToString("N2") + @" DA" : "MONTANTS INCORRECT !";
            //setcolors
            textBoxMontantAv.ForeColor = _montant <= _marge ? Color.Green : Color.Coral;
            textBoxCreance.ForeColor = _creance <= _montant ? Color.Green : Color.Coral;
            textBoxReste.ForeColor = _reste >= 0 ? Color.Green : Color.Coral;

        }
        
        private void listViewFactures_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (!_locked)
            e.NewValue = e.CurrentValue;
        }

        private void pictureBoxLock_DoubleClick(object sender, EventArgs e)
        {
            Lock(_locked);
        }

        private void Lock(bool lk)
        {
            textBoxMontantAv.ReadOnly =  lk;
            pictureBoxLock.Image = lk ? Properties.Resources._lock : Properties.Resources.unlock;
            textBoxMontantAv.BorderStyle =  lk ? BorderStyle.None : BorderStyle.Fixed3D;
            textBoxMontantAv.BackColor = lk ? Color.WhiteSmoke: Color.White;
            _locked = ! _locked;

        }

       

        #endregion
        
        #region Actions

        private void BtnAddCheque_Click(object sender, EventArgs e)
        {
            if (TotalCheque() == _montant) return;
            if (_reste <= 0) return;
            var cheque = new NewchequeForm(this,_reste);
            cheque.Closing += (sndr,args)=>LoadCheque();
            cheque.ShowDialog();
        }
        private void btnRempveCheque_Click(object sender, EventArgs e)
        {
            if (listBoxCheque.SelectedItem == null) return;
            RemoveCheque(listBoxCheque.GetItemText(listBoxCheque.SelectedItem));
            RebindListBoxCheque();
        }

        private void textBoxMontantAv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((sender as TextBox) == null) return;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {             
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {              
                e.Handled = true;
            }          
        }

        //private void textBoxNAC_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if ((sender as TextBox) == null) return;
        //    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        //    {
        //        e.Handled = true;
        //    }
        //}


        private void buttonValider_Click(object sender, EventArgs e)
        {

            if (!FormValidation()) return;

            var avoir = new AVOIR_FINANCIER();
            var success=InsertAvoir(avoir);

            if (!success) return;

            if (_chequesList.Count>0)
            {
                _chequesList.ForEach(c => c.numAvoir = avoir.numAvoir);
                success=InsertCheques(_chequesList);
            }

            if (success) Messages.Success("Données insérées avec succès !");
            Close();
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listViewFactures_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            //set totals values
            decimal t, m;
            TotalFactures(out t, out m);
        }

        private void textBoxMontantAv_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox) == null) return;
            decimal.TryParse((sender as TextBox).Text, out _montant);
        }

        private void textBoxCreance_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox) == null) return;
            decimal.TryParse((sender as TextBox).Text, out _creance);
        }

        private void textBoxMontantAv_Validated(object sender, EventArgs e)
        {
            if ((sender as TextBox) == null) return;
            if (String.IsNullOrEmpty((sender as TextBox).Text)) return;
            (sender as TextBox).Text = string.Format("{0:#,##0.00}", decimal.Parse((sender as TextBox).Text));

            Calculation();
        }
        private void textBoxObservation_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox) == null) return;
            if (String.IsNullOrEmpty((sender as TextBox).Text)) return;
            _observation = textBoxObservation.Text;
        }

        private void textBoxDesc_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox) == null) return;
            if (String.IsNullOrEmpty((sender as TextBox).Text)) return;
            _designation = textBoxDesc.Text;
        }
        private void dateAvoir_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CheckType()
        {
            
            textBoxObservation.Text = _observation = String.Empty;
            _typeAvoir = 0;

            if (_isCheque)
            {
                pictureBoxAdd.Enabled  = pictureBoxRemove.Enabled = true;
                textBoxObservation.Text = @"CHEQUE"+Environment.NewLine;
                _typeAvoir++;
            }
            else
            {
                //checkBoxCheque.Checked = false;
                _chequesList.Clear();
                RebindListBoxCheque();
                TotalCheque();

                pictureBoxAdd.Enabled = pictureBoxRemove.Enabled = false;
            }
            if (_isCreance)
            {
                textBoxCreance.Enabled  = true;
                textBoxCreance.Text = $"{_reste:#,##0.00}";
                textBoxObservation.Text += @"À VALOIR SUR CREANCE";
                _typeAvoir = _typeAvoir + 2;

            }
            else
            {
                textBoxCreance.Enabled  = false;
                textBoxCreance.Text = $"{0:#,##0.00}";
            }



            Calculation();
        }

        #endregion
 
        #region Data

        private bool InsertAvoir(AVOIR_FINANCIER avoir)
        {
            try
            {
                decimal mntAv;
                decimal.TryParse(textBoxMontantAv.Text, out mntAv);

                using (var model = new ExpFinanceEntities())
                {
                    var detail = new DetailsDossier();

                    
                    //Set référence (if new avoir get the new num according to the year)
                    if (_avoir==null)  _numAvoir = detail.GetLastAvoirId(dateAvoir.Value);
                    
                    avoir.numAvoir = _numAvoir;
                    avoir.montant = mntAv;
                    avoir.dateAvoir = dateAvoir.Value.Date;
                    avoir.designation = _designation;
                    avoir.montantCheque = _cheque;
                    avoir.montantCreance = _creance;
                    avoir.Observation = _observation;
                    avoir.typeAvoir = (byte)_typeAvoir;
                    model.AVOIR_FINANCIER.AddOrUpdate(avoir);


                    var op = new AF_OPS_LOG
                    {
                        instant = DateTime.Now,
                        username = Environment.UserName,
                        numavoir = _numAvoir,
                        Operation = "Avoir inséré"
                    };

                    model.AF_OPS_LOG.Add(op);


                    //insert the related groups
                    foreach (int g in _numGroupe)
                    {
                        var avoirGroupe = new AF_AVOIR_GROUPE
                        {
                            numAvoir = avoir.numAvoir,
                            IDG = g,
                            Libre = 0
                        };

                        model.AF_AVOIR_GROUPE.Add(avoirGroupe);
                    }

                    //Insert in the etat table
                    foreach (int g in _numGroupe)
                    {
                        var etat = new AF_ETAT_AVOIR
                        {
                            numDossier = detail.GetGroupeInfo(g).NDOSSIER,
                            numAvoir = avoir.numAvoir,
                            IDG = g,
                            Etat = 3,
                            dateHeure = DateTime.Now
                        };

                        model.AF_ETAT_AVOIR.Add(etat);
                    }
 

                    model.SaveChanges();
                    return true;
                }
            }

            catch (Exception ex)
            {
                Messages.Error("Erreur insertion avoir:"+ex.Message);
                ErrorLog.LogError("Erreur insertion avoir",ex);
                return false;
            }
            
        }

        private bool InsertCheques(List<CHEQUE> cheques)
        {
            try
            {
                using (var model = new ExpFinanceEntities())
                {
                    //remove old entries
                    
                    // ReSharper disable once AccessToDisposedClosure
                    (from c in model.CHEQUE where c.numAvoir==_numAvoir select c).ForEach(c=>model.CHEQUE.Remove(c));

                    //insert new entries
                    cheques.ForEach(c => model.CHEQUE.Add(c));
                    model.SaveChanges();
                }
                return true;
            }
            catch (Exception ex) 
            {
                Messages.Error("Erreur insertion chèques:" + ex.Message);
                ErrorLog.LogError("Erreur insertion chèques",ex);
                return false;
            }

        }

        #endregion

        #region validation
        private bool FormValidation()
        {
            if (_montant == 0)
            {
                Messages.Warning(@"Veuillez saisir le montant de l'avoir financier !");
                return false;
            }


            if (_total == 0)
            {
                Messages.Warning(@"Veuillez sélectionner au moins une facture !");
                return false;
            }

            if (string.IsNullOrEmpty(_observation))
            {
                Messages.Warning(@"Veuillez saisir une observation !");
                return false;
            }

            //if (comboBoxType.SelectedIndex == 0 && _cheque == 0)
            //{
            //    Messages.Warning(@"Veuillez ajouter au moins un chèque !");
            //    return false;
            //}


            if (_reste > 0)
            {
                Messages.Warning(@"Le montant de l'avoir financier n'est pas totalement réglé !");
                return false;
            }

            if (_reste < 0)
            {
                Messages.Warning(@"Le montant total des chèques et créances est supérieur au montant de l'avoir financier !");
                return false;
            }

            if (_cheque>_total)
            {
                Messages.Warning(@"Le montant du cheque est supérieur au montant de l'avoir financier !");
                return false;
            }

            if (string.IsNullOrEmpty(textBoxDesc.Text))
            {
                Messages.Warning(@"Veuillez renseigner une designation !");
                return false;
            }
            return true;
        }
        #endregion

        private void checkBoxCreance_CheckedChanged(object sender, EventArgs e)
        {
            _isCheque = checkBoxCheque.Checked;
            _isCreance = checkBoxCreance.Checked;
            CheckType();
        }

        private void checkBoxCheque_CheckedChanged(object sender, EventArgs e)
        {
            _isCheque = checkBoxCheque.Checked;
            _isCreance = checkBoxCreance.Checked;
            CheckType();
        }





 






      







        
    }
}
