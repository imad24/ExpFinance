using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ExpFinance.Properties;


namespace ExpFinance
{
    public partial class NewAvoirForm
    {
        private bool _isEf;
        private int? _codePromo=0,_codePalier=0;

        private void checkBoxEf_CheckedChanged(object sender, EventArgs e)
        {
            if (!_isFacture) checkBoxEf.Checked = false;
 
            _isEf = checkBoxEf.Checked && _isFacture;
            textBoxDesc.Text = _isEf ? @"ESCOMPTE FINANCIER" : _isFacture ? "REMISE FINANCIERE" : "CONVENTION ANNUELLE";
            comboBoxPalierEf.Enabled = _isEf;
            //buttonShow_Click(comboBoxClient,new EventArgs());
        }
        private void LoadFacturesAll(string code)
        {
            try
            {
                //reset ligne storings
                LignesBuffer.Clear();
                _lignesList.Clear();

                var detail = new DetailsDossier();
                var fact = detail.GetClientFacturesAll(code);
                PopulateFacutresListView(fact);
            }
            catch (Exception e)
            {
                Messages.Error("Error loading factures: "+e.Message);
                ErrorLog.LogError("Error loading factures",e);
                throw;
            }

        }
        private void PopulateFacutresListView(List<AF_FACTURES_CLIENTS_ALL> liste)
        {
            listViewFactures.Items.Clear();
            liste = liste.OrderByDescending(f => f.date_trans).ToList();
            liste.ForEach(f =>
            {
                var date = f.date_trans?.Date ?? DateTime.MinValue.Date;
                var num = f.num_trans.ToString("");
                var htr = f.total_HT != null ? f.total_HT.Value.ToString("N2") : "0";
                var remise = f.Marge != null ? f.Marge.Value.ToString("N2") : "0";
                listViewFactures.Items.Add(new ListViewItem(new[] { num, date.ToShortDateString(), htr, remise }));
            });
        }
        private void PopulateComboxBoxPalierEf()
        {
           var detail = new DetailsDossier();

            var listPalier =
                detail.GetListPalier()
                    .Select(
                        p =>
                            new
                            {
                                val = p.idPalier,
                                display =$"ESCOMPTE FINANCIER  ({p.Percentage}%)"
                            })
                    .ToList();

            listPalier.Add(new { val = 0, display = " - AUTRE" });

            comboBoxPalierEf.DataSource = listPalier;
            comboBoxPalierEf.ValueMember = "val";
            comboBoxPalierEf.DisplayMember = "display";

        }
        private void PopulateComboboxPromotion()
        {
            var detail = new DetailsDossier();
            var list= detail.GetListOfPromotions().Select(
                p=> new 
                {
                    CODE = p.CODE_PROMOTION,
                    NOM = p.NOM_PROMOTION
                }).ToList();

            list.Add(new {CODE=0,NOM=" - N/A"});
            
            comboBoxPromotions.DataSource = list.OrderBy(p=>p.NOM).ToList();
            comboBoxPromotions.ValueMember = "CODE";
            comboBoxPromotions.DisplayMember = "NOM";
        }
        private void comboBoxPromotions_SelectedValueChanged(object sender, EventArgs e)
        {
            int p;
            if (!int.TryParse(comboBoxPromotions.SelectedValue.ToString(), out p)) return;
            _codePromo = p;
        }
        private void comboBoxPalierEf_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!textBoxTauxMontant.Enabled) return;
                var d= new DetailsDossier();
                int p;
                if (!int.TryParse(comboBoxPalierEf.SelectedValue.ToString(), out p)) return;
                   decimal t = d.GetTauxPalier(p);
                _codePalier = p;
                textBoxTauxMontant.Text = t.ToString("N2");
            
        }

        private void NatureEf()
        {
            if (_isFacture & _isEf)
            {
                listViewFactures.Enabled = true;
                dateExercice.Enabled = false;
                textBoxDesc.Text = @"ESCOMPTE FINANCIER";
                EnableTextBox(false, textBoxHTRZ);
                textBoxTauxMontant.Enabled = false;
            }
            if (_isFacture)
            {
                listViewFactures.Enabled = true;
                checkBoxEf.Enabled = comboBoxPalierEf.Enabled = true;
                dateExercice.Enabled = false;
                textBoxDesc.Text = @"REMISE FINANCIERE";
                EnableTextBox(false, textBoxHTRZ);
                textBoxTauxMontant.Enabled = false;
            }

            else if (!_isFacture)
            {
                listViewFactures.Enabled = false;
                checkBoxEf.Enabled = checkBoxEf.Checked = comboBoxPalierEf.Enabled = false;
                dateExercice.Enabled = true;
                textBoxDesc.Text = @"CONVENTION ANNUELLE";
                listViewFactures.Items.Clear();
                EnableTextBox(true, textBoxHTRZ, textBoxTauxMontant);
                TotalFactures();
            }
        }

        private bool ValidationEf()
        {


            if (comboBoxClient.SelectedValue==null || string.IsNullOrEmpty(comboBoxClient.Text))
            {
                Messages.Warning(@"Veuillez saisir séléctionner un client !");
                return false;
            }



            if (_isEf & _codePalier == null)
            {
                Messages.Warning(@"Veuillez saisir le type de la remise complémentaire !");
                return false;
            }

            return true;
        }


        private void comboBoxPromotions_DropDown(object sender, EventArgs e)
        {
         //   AdjustWidthComboBox_DropDown(sender,e);
        }


        private void AdjustWidthComboBox_DropDown(object sender, EventArgs e)
        {
            var senderComboBox = (ComboBox)sender;
            int width = senderComboBox.DropDownWidth;
            Graphics g = senderComboBox.CreateGraphics();
            Font font = senderComboBox.Font;

            int vertScrollBarWidth = (senderComboBox.Items.Count > senderComboBox.MaxDropDownItems)
                    ? SystemInformation.VerticalScrollBarWidth : 0;

            var itemsList = senderComboBox.Items.Cast<object>().Select(item => item.ToString());

            foreach (string s in itemsList)
            {
                int newWidth = (int)g.MeasureString(s, font).Width + vertScrollBarWidth;

                if (width < newWidth)
                {
                    width = newWidth;
                }
            }

            senderComboBox.DropDownWidth = width;
        }

        #region data

        private bool InsertFacturesEf(List<string> listeCode)
        {
            try
            {
                   using (var model = new ExpFinanceEntities())
                {
                    var detail = new DetailsDossier();

                    //Get the liste of facture
                    var liste = detail.GetListeFacturesClientAll(listeCode);


                   

                    //Creating Groupe Details
                    var entite = liste.Select(f => f.entite).FirstOrDefault();
                    var codeClient = liste.Select(f => f.code_clien).FirstOrDefault();
                    decimal? mntHt = 0, mntRz = 0, mntTtc = 0, mntTva = 0, marge = 0;

                    //calculating totales in factures
                    liste.ForEach(f =>
                    {
                        mntHt += f.total_HT; //this is HTR !!
                        mntRz += f.T_remise;
                        mntTtc += f.total_TTC;
                        mntTva += f.total_TVA;
                        marge += f.Marge;
                    });


                    //Escompte Financier without factures
                    if (liste.Count == 0)
                    {
                        codeClient = comboBoxClient.SelectedValue.ToString();
                        entite = Settings.Default.entite;
                    }

                    var margeRest = marge - _montant;

                    var etat = 5;

                    var newGroupe = new AF_EF_GROUPE_FACTURE
                    {
                        ENTITE = entite,
                        CODE_CLIENT = codeClient,
                        MNT_HT = mntHt,
                        MNT_RZ = mntRz,
                        MNT_TVA = mntTva,
                        MNT_TTC = mntTtc,
                        MARGE = marge,
                        MARGE_REST = margeRest,
                        ETAT = etat,
                        DATE_DOSSIER = DateTime.Today,
                        ID_LIGNE = _codePromo, //we store promotion here
                        NB_CADEAU = _codePalier //we store wich palier here
                    };

                    model.AF_EF_GROUPE_FACTURE.Add(newGroupe);
                    model.SaveChanges();
                    _numGroupe = newGroupe.ID_GROUPE_FACT;

                    liste.ForEach(facture =>
                    {
                        var newFacture = new AF_EF_FACTURE
                        {
                            NUM_FACT = facture.num_trans,
                            CODE_CLIENT = facture.code_clien,
                            DATE_FACT = facture.date_trans ?? default(DateTime),
                            ENTITE = facture.entite,
                            MARGE = facture.Marge,
                            MNT_HT_RZ = facture.total_HT - facture.T_remise,
                            MNT_TTC = facture.total_TTC,
                            MNT_RZ = facture.T_remise,
                            MNT_TVA = facture.total_TVA,
                            ID_GROUPE_FACT = newGroupe.ID_GROUPE_FACT
                        };

                        model.AF_EF_FACTURE.Add(newFacture);

                        //Insert lines if there is


                        if (_lignesList.Count > 0 && _lignesList.ContainsKey((int)newFacture.NUM_FACT))
                        {
                            var lignes = _lignesList[(int)newFacture.NUM_FACT];

                            lignes.ForEach(ligne =>
                            {
                                var newLigne = new AF_EF_LIGNE_FACTURE
                                {
                                    NUM_FACT = newFacture.NUM_FACT,
                                    DATE_FACT = newFacture.DATE_FACT,
                                    ENTITE = newFacture.ENTITE,
                                    NUM_LIGNE = ligne
                                };

                                model.AF_EF_LIGNE_FACTURE.Add(newLigne);
                            });
                        }

                    });

                    model.SaveChanges();
                    _numGroupe = newGroupe.ID_GROUPE_FACT;
                    return true;
                }

            }
            catch (Exception e)
            {
                Messages.Error($@"Erreur insertion factures: \n {e.Message}
                                 \n {e.InnerException?.Message}
                                   \n {e.InnerException?.InnerException?.Message}" );

                _numGroupe = 0;
                ErrorLog.LogError("Erreur insertion factures",e);
                return false;
            }

        }
        private bool InsertAvoirEf(AVOIR_FINANCIER avoir)
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


                    avoir.numAvoir = _numAvoir;
                    avoir.montant = mntAv;
                    avoir.dateAvoir = dateAvoir.Value.Date;
                    avoir.designation = textBoxDesc.Text;
                    avoir.montantCheque = _cheque;
                    avoir.montantCreance = _creance;
                    avoir.Observation = _observation;
                    avoir.typeAvoir = (byte)_typeAvoir;


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

                    var libre = (byte) 3;

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
                Messages.Error(@"Erreur insertion avoir financier: " + e.InnerException.Message);
                ErrorLog.LogError("Erreur insertion avoir financier",e);
                return false;
            }

        }

        #endregion

    }
}
