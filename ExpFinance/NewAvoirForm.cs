using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ExpFinance.Properties;


namespace ExpFinance
{
    public partial class NewAvoirForm : Form
    {
        public static string NomClient;
        private int _numGroupe, _typeAvoir = 2;
        private decimal _montant, _total, _marge, _cheque,_creance,_reste;
        private int _numAvoir;
        private bool _isCheque, _isCreance=true,_isFacture=true;
        public CHEQUE  ChequesBuffer;
        private List<CHEQUE> _chequesList=new List<CHEQUE>();

        public List<int> LignesBuffer = new List<int>();
        public decimal TotalLigne, MargeLigne;
        private int _currentNumFac;
        private Dictionary<int, List<int>> _lignesList = new Dictionary<int, List<int>>(); 
        private string _observation,_nDossier;


        public NewAvoirForm()
        {
            InitializeComponent();
            _numGroupe = 0;
            _montant = _creance = _reste = 0;
           
        }


        #region View

        private void AvoirForm_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'clientDataSet.Client' table. You can move, or remove it, as needed.
                clientTableAdapter.Fill(clientDataSet.AF_CLIENT,Settings.Default.entite);
                    var detail = new DetailsDossier();
                    //Set référence
                    _numAvoir = detail.GetLastAvoirId(dateAvoir.Value);
                    textBoxRefAvoir.Text = _numAvoir.ToString("D");
                    dateExercice.Value = dateExercice.Maximum = DateTime.Now.Year - 1;
                    Calculation();
                    CheckType();
                PopulateComboxBoxPalierEf();
                PopulateComboboxPromotion();
                
            }
            catch (Exception ex)
            {
                Messages.Error(ex.Message);
                ErrorLog.LogError("Load",ex);
                Close();
            }

        }


        private void PopulateFacutresListView(List<AF_FACTURES_CLIENTS> liste)
        {
            listViewFactures.Items.Clear();
            liste=liste.OrderByDescending(f => f.date_trans).ToList();
            liste.ForEach(f =>
            {
                var date = f.date_trans != null ? f.date_trans.Value.Date : DateTime.MinValue.Date;
                var num = f.num_trans.ToString("");
                var htr = f.total_HT != null ? f.total_HT.Value.ToString("N2") : "0";
                var remise = f.Marge != null ? f.Marge.Value.ToString("N2") : "0";
                listViewFactures.Items.Add( new ListViewItem(new[] {num, date.ToShortDateString(),htr,remise}));
            });
        }  
    
        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void LoadLignes()
        {
            try
            {
                //Store each facture with its lines
                if (LignesBuffer == null) return;

                _lignesList.Remove(_currentNumFac);
                _lignesList.Add(_currentNumFac, LignesBuffer);

                //Set only the HTR and Marge of those lines not the entire facture
                var item = (from ListViewItem i in listViewFactures.CheckedItems
                            where int.Parse(i.SubItems[0].Text) == _currentNumFac
                            select i).FirstOrDefault();
                if (item == null) return;
                item.SubItems[2].Text = TotalLigne.ToString("N2");
                item.SubItems[3].Text = MargeLigne.ToString("N2");


                TotalFactures();
            }
            catch (Exception ex)
            {
                
                Messages.Error("Error Getting lignes factures: "+ex.Message);
                ErrorLog.LogError("Error Getting lignes factures:", ex);
            }

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

        private void LoadFactures(string code)
        {
            try
            {
                    //reset ligne storings
                    LignesBuffer.Clear();
                    _lignesList.Clear();

                    var detail = new DetailsDossier();
                    var fact = detail.GetClientFactures(code);
                    PopulateFacutresListView(fact);
            }
            catch (Exception e)
            {
                Messages.Error(e.Message);
                ErrorLog.LogError("Load Factures",e);
                throw;
            }

        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            if (comboBoxClient.SelectedValue == null) return;
            Cursor.Current = Cursors.WaitCursor;
            if(_isEf) LoadFacturesAll(comboBoxClient.SelectedValue.ToString());
            else LoadFactures(comboBoxClient.SelectedValue.ToString());
            NomClient = comboBoxClient.Text;
            Cursor.Current = Cursors.Default;
        }

        private void TotalFactures()
        {
            decimal tht=0 ,tmarge = 0;
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


            textBoxHTRZ.Text = _total.ToString("N2");
            textBoxMarge.Text = _marge.ToString("N2");
            textBoxMontantAv.ForeColor = _montant <= _marge ? Color.DimGray : Color.Red;

            textBoxTauxMontant.Enabled = _total > 0 || !_isFacture;

            Calculation();
        }       

        private decimal TotalCheque()
        {
            decimal total = 0;
            _chequesList.ForEach(c => total += c.montant);
            _cheque = total;
            Calculation();
            return total;
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

        private void listViewFactures_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            TotalFactures();

        }

        private void EnableTextBox(bool state,params TextBox[] textboxes)
        {
            foreach (TextBox textbox in textboxes)
            {
                textbox.Enabled = state;
                textbox.ReadOnly = !state;

                textbox.BackColor = state ? Color.White : Color.WhiteSmoke;
                textbox.BorderStyle = state ? BorderStyle.Fixed3D : BorderStyle.None;

                textbox.Text = $"{0:#,##0.00}";  
            }

        }

        #endregion

        #region Actions
        private void buttonValider_Click(object sender, EventArgs e)
        {
            if (!FormValidation()) return;

            //Insert factures et groupe factures
            var listeCode=ReadFactures();


            if (!_isEf)
            {

                var success = InsertFactures(listeCode);

                if (!success) return;
                //Insert Avoir
                var avoir = new AVOIR_FINANCIER();
                success = InsertAvoir(avoir);

                if (_chequesList.Count > 0)
                {
                    //Insert CHEQUE if so
                    _chequesList.ForEach(c => c.numAvoir = avoir.numAvoir);
                    success = InsertCheques(_chequesList);
                }
                if (success) Messages.Success("Données insérées avec succès !");
                Close();
            }
            else
            {
                // ReSharper disable once RedundantAssignment
                var success = InsertFacturesEf(listeCode);

                if (!success) return;
                //Insert Avoir
                var avoir = new AVOIR_FINANCIER();
                success = InsertAvoirEf(avoir);

                if (_chequesList.Count > 0)
                {
                    //Insert CHEQUE if so
                    _chequesList.ForEach(c => c.numAvoir = avoir.numAvoir);
                    success = InsertCheques(_chequesList);
                }
                if (success) Messages.Success("Données insérées avec succès !");
                Close();
            }
            
            



        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAddCheque_Click(object sender, EventArgs e)
        {
            if (TotalCheque() == _montant) return;
            if (_reste <= 0) return;
            var cheque = new NewchequeForm(this, _reste);
            cheque.Closing += (sndr, args) => LoadCheque();
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

        private void listViewFactures_DoubleClick(object sender, EventArgs e)
        {
            if (listViewFactures.FocusedItem == null) return;
            var nfv = listViewFactures.FocusedItem.SubItems[0].Text;

            listViewFactures.FocusedItem.Checked = true;
            if (int.TryParse(nfv, out _currentNumFac))
            {
                var lignes = new LigneFacture(this, _currentNumFac, DateTime.Today);
                lignes.Closed += (sndr, args) => LoadLignes();
                lignes.ShowDialog();
            }

        }

        private void textBoxTauxMontant_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox) == null) return;
            decimal taux;
            if (decimal.TryParse(textBoxTauxMontant.Text, out taux))
            {
                textBoxMontantAv.Text = $"{_total*taux/100:#,##0.00}";
                Calculation();
            }
        }

        private void textBoxMontantAv_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox) == null) return;
            decimal.TryParse(((TextBox) sender).Text, out _montant);
            
        }

        private void textBoxCreance_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox) == null) return;
            decimal.TryParse((sender as TextBox).Text, out _creance);

        }

        private void textBoxHTRZ_TextChanged(object sender, EventArgs e)
        {
            decimal t;
            _total = decimal.TryParse(textBoxHTRZ.Text, out t) ? t : 0;
        }

        private void textBoxMontantAv_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty((sender as TextBox)?.Text)) return;
            (sender as TextBox).Text = $"{decimal.Parse((sender as TextBox).Text):#,##0.00}";
            Calculation();
        }

        private void textBoxObservation_TextChanged(object sender, EventArgs e)
        {
            _observation = textBoxObservation.Text;
        }

        //private void textBoxNAC_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if ((sender as TextBox) == null) return;
        //    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        //    {
        //        e.Handled = true;
        //    }          
        //}

        #endregion

        
        
        #region Data

        private List<string> ReadFactures()
        {
            return (from ListViewItem item in listViewFactures.Items 
                    where item.Checked
                    select item.SubItems[0].Text).ToList();
        }

        private bool InsertFactures(List<string> listeCode)
        {
            try
            {


                using (var model = new ExpFinanceEntities())
                {

                    //EXERCICE ANTERIEUR
                    if (!_isFacture)
                    {
                        var ent = Settings.Default.entite;
                        var cli = comboBoxClient.SelectedValue.ToString();
                        //store the date just to keep the date
                        var year = new DateTime((int) dateExercice.Value, 1, 1);

                        var newGroupeCvn = new AF_GROUPE_FACTURE
                        {
                            ENTITE = ent,
                            CODE_CLIENT = cli,
                            MNT_HT = _total,
                            DATE_CADEAU = year,
                            DATE_DOSSIER = DateTime.Today,
                        };

                        model.AF_GROUPE_FACTURE.Add(newGroupeCvn);
                        model.SaveChanges();
                        _numGroupe = newGroupeCvn.ID_GROUPE_FACT;
                        return true;
                    }


                    var detail = new DetailsDossier();

                    //Get the liste of facture
                    var liste = detail.GetListeFacturesClient(listeCode);

                    //Creating Groupe Details
                    var entite = liste.Select(f => f.entite).First();
                    var codeClient = liste.Select(f => f.code_clien).First();
                    decimal? mntHt=0,mntRz=0,mntTtc=0,mntTva=0,marge=0;

                    //calculating totales in factures
                    liste.ForEach(f =>
                    {
                        mntHt += f.total_HT; //this is HTR !!
                        mntRz += f.T_remise;
                        mntTtc += f.total_TTC;
                        mntTva += f.total_TVA;
                        marge += f.Marge;
                    });                          
                    
                    var margeRest=marge-_montant;

                    var etat = 5;
                    
                    var newGroupe = new AF_GROUPE_FACTURE
                    {
                        ENTITE = entite,
                        CODE_CLIENT = codeClient,
                        MNT_HT = mntHt,
                        MNT_RZ = mntRz,MNT_TVA = mntTva,
                        MNT_TTC = mntTtc,
                        MARGE = marge,
                        MARGE_REST = margeRest,
                        ETAT = etat,
                        DATE_DOSSIER = DateTime.Today,                       
                    };

                    model.AF_GROUPE_FACTURE.Add(newGroupe);
                    model.SaveChanges();
                    _numGroupe = newGroupe.ID_GROUPE_FACT;

                    liste.ForEach(facture =>
                    {
                            var newFacture = new AF_FACTURE
                            {
                                NUM_FACT = facture.num_trans,
                                CODE_CLIENT = facture.code_clien,
                                DATE_FACT = facture.date_trans ?? default(DateTime),
                                ENTITE = facture.entite,
                                MARGE = facture.Marge,
                                MNT_HT_RZ = facture.total_HT-facture.T_remise,
                                MNT_TTC = facture.total_TTC,
                                MNT_RZ = facture.T_remise,
                                MNT_TVA = facture.total_TVA,
                                ID_GROUPE_FACT =newGroupe.ID_GROUPE_FACT
                            };

                        model.AF_FACTURE.Add(newFacture);

                        //Insert lines if there is


                        if (_lignesList.Count > 0 && _lignesList.ContainsKey((int) newFacture.NUM_FACT))
                        {
                            var lignes = _lignesList[(int)newFacture.NUM_FACT];

                            lignes.ForEach(ligne =>
                            {
                                var newLigne = new AF_LIGNE_FACTURE
                                {
                                    NUM_FACT = newFacture.NUM_FACT,
                                    DATE_FACT = newFacture.DATE_FACT,
                                    ENTITE = newFacture.ENTITE,
                                    NUM_LIGNE = ligne
                                };

                                model.AF_LIGNE_FACTURE.Add(newLigne);
                            });
                        }

                    });

                    model.SaveChanges();
                    _numGroupe= newGroupe.ID_GROUPE_FACT;
                    return true;
                }
                
            }
            catch (Exception e)
            {
                Messages.Error(@"Erreur insertion factures: " + e.Message);
                ErrorLog.LogError(@"Erreur insertion factures: ",e);
                _numGroupe = 0;
                return false;
            }

        }

        private bool InsertAvoir(AVOIR_FINANCIER avoir)
        {
            try
            {
                decimal mntAv;
                decimal.TryParse(textBoxMontantAv.Text, out mntAv);

                using (var model = new ExpFinanceEntities())
                {
                    var detail = new DetailsDossier();

                    //Set référence
                    _numAvoir = detail.GetLastAvoirId(dateAvoir.Value);
                    textBoxRefAvoir.Text = _numAvoir.ToString("D");
                    int codePromo;
                    int.TryParse(comboBoxPromotions.SelectedValue?.ToString(),out codePromo);

                    avoir.numAvoir = _numAvoir;
                    avoir.montant = mntAv;
                    avoir.dateAvoir = dateAvoir.Value.Date;
                    avoir.designation = textBoxDesc.Text;
                    avoir.montantCheque = _cheque;
                    avoir.montantCreance = _creance;
                    avoir.Observation = _observation;
                    avoir.typeAvoir = (byte)_typeAvoir;
                    avoir.numAvoirComptable = codePromo;

                    var op = new AF_OPS_LOG
                    {
                        instant = DateTime.Now,
                        username = Environment.UserName,
                        numavoir = _numAvoir,
                        Operation = "Avoir inséré"
                    };

                    model.AF_OPS_LOG.Add(op);
                    //int nac;
                    //if (int.TryParse(textBoxNAC.Text, out nac))
                    //{
                    //    avoir.numAvoirComptable = nac;
                    //}

                    var libre = _isFacture ? (byte)1 : (byte)2;

                    //insert the related group
                    var avoirGroupe = new AF_AVOIR_GROUPE
                    {
                        numAvoir = avoir.numAvoir,
                        IDG = _numGroupe,
                        Libre = libre
                    };

                    model.AF_AVOIR_GROUPE.Add(avoirGroupe);
           

                    //Insert in the etat table
                    var etat = new AF_ETAT_AVOIR
                    {
                        numDossier = _nDossier,
                        numAvoir = avoir.numAvoir,
                        IDG = _numGroupe,
                        Etat = 3,
                        dateHeure = DateTime.Now
                    };

                    model.AF_ETAT_AVOIR.Add(etat);

                    model.AVOIR_FINANCIER.Add(avoir);
                    model.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                Messages.Error(@"Erreur insertion avoir financier: ");
                ErrorLog.LogError(@"Erreur insertion avoir financier: ",e);
                return false;
            }

        }


        private bool InsertCheques(List<CHEQUE> cheques)
        {
            try
            {
                using (var model = new ExpFinanceEntities())
                {
                    cheques.ForEach(c => model.CHEQUE.Add(c));
                    model.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                Messages.Error(@"Erreur insertion cheques: " + e.InnerException.Message);
                ErrorLog.LogError(@"Erreur insertion cheques: ", e);
                return false;
            }

        }

        #endregion



        #region Validation

        private bool FormValidation()
        {
            if (_montant == 0)
            {
                Messages.Warning(@"Veuillez saisir le montant de l'avoir financier !");
                return false;
            }

            if (_total == 0 && _isFacture && !_isEf) //!_isEF for GH when they do it in advance
            {
                Messages.Warning(@"Veuillez sélectionner au moins une facture !");
                return false;
            }

            if (_total == 0 && !_isFacture)
            {
                Messages.Warning(@"Veuillez saisir le montant de l'exercice !");
                return false;
            }

            if (_creance + _cheque == 0)
            {
                Messages.Warning(@"Veuillez définier le montant et le moyen de paiement (Créance ou chèque) de l'avoir finanicer !");
                return false;
            }

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

            if (_cheque > _total)
            {
                Messages.Warning(@"Le montant du cheque est supérieur au montant de l'avoir financier !");
                return false;
            }
            //if (comboBoxType.SelectedIndex == 0 && _cheque == 0)
            //{
            //    Messages.Warning(@"Veuillez ajouter au moins un chèque !");
            //    return false;
            //}

            if (string.IsNullOrEmpty(textBoxNDossier.Text))
            {
                Messages.Warning(@"Veuillez renseigner le numéro de dossier !");
                return false;
            }

            if (string.IsNullOrEmpty(textBoxDesc.Text))
            {
                Messages.Warning(@"Veuillez renseigner une designation !");
                return false;
            }

            if (string.IsNullOrEmpty(_observation))
            {
                Messages.Warning(@"Veuillez saisir une observation !");
                return false;
            }

            return ValidationEf();
        }

        #endregion

        private void NewAvoirForm_ResizeEnd(object sender, EventArgs e)
        {
            tableLayoutContainer.Width = Width - (35);
        }

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

        private void cbFactures_CheckedChanged(object sender, EventArgs e)
        {
            cbEE.Checked = !cbFactures.Checked;
            _isFacture = cbFactures.Checked;
            CheckNature();
        }

        private void cbEE_CheckedChanged(object sender, EventArgs e)
        {
            cbFactures.Checked = !cbEE.Checked;
            _isFacture = cbFactures.Checked;
            CheckNature();
        }

        private void CheckType()
        {

            textBoxObservation.Text = String.Empty;
            _typeAvoir = 0;

            if (_isCheque)
            {
                pictureBoxAdd.Enabled = pictureBoxRemove.Enabled = true;
                textBoxObservation.Text = @"CHEQUE" + Environment.NewLine;
                _typeAvoir++;
            }
            else
            {
                _chequesList.Clear();
                RebindListBoxCheque();
                TotalCheque();

                pictureBoxAdd.Enabled = pictureBoxRemove.Enabled = false;
            }
            if (_isCreance)
            {
                textBoxCreance.Enabled = true;
                textBoxCreance.Text = string.Format("{0:#,##0.00}", _reste);
                textBoxObservation.Text += @"À VALOIR SUR CREANCE";
                _typeAvoir = _typeAvoir + 2;

            }
            else
            {
                textBoxCreance.Enabled = false;
                textBoxCreance.Text = string.Format("{0:#,##0.00}", 0);
            }
            Calculation();
            
        }

        private void CheckNature()
        {
            if (_isFacture)
            {
                listViewFactures.Enabled = true;
                dateExercice.Enabled = false;
                textBoxDesc.Text = @"REMISE FINANCIERE";
                EnableTextBox(false, textBoxHTRZ);
                textBoxTauxMontant.Enabled = false;
            }
            else
            {
                listViewFactures.Enabled = false;
                dateExercice.Enabled = true;
                textBoxDesc.Text = @"CONVENTION ANNUELLE";
                listViewFactures.Items.Clear();
                EnableTextBox(true, textBoxHTRZ, textBoxTauxMontant);
                TotalFactures();
            }
            NatureEf();
            Calculation();

        }

        private void textBoxNDossier_TextChanged(object sender, EventArgs e)
        {
            _nDossier = textBoxNDossier.Text.ToUpper();
        }




    }
}
