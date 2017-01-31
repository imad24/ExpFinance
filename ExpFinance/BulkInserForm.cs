using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpFinance
{
    public partial class BulkInserForm : Form
    {
        private int _numAvoir;
        private string _entite=Properties.Settings.Default.entite;

        public BulkInserForm()
        {
            InitializeComponent();
        }

        private void Insert2016_Click(object sender, EventArgs e)
        {
            InsertAvoir2016();
            Messages.Success("Done");
        }

        private void InsertAnt_Click(object sender, EventArgs e)
        {
            InsertAnte();
            Messages.Success("Done");
        }

        private bool InsertAnte()
        {
            try
            {
                using (var model = new ExpFinanceEntities())
                {
                    var detail = new DetailsDossier();

                    var tempdata = (from temp in model.AF_TEMP_DATA_ANT
                        where temp.entite == _entite
                        select temp);


                    foreach (var temp in tempdata)
                    {
                        //EXERCICE ANTERIEUR
                        ErrorLog.LogMessage($"treating avoir{temp.numAvoir}");
                        var year = temp.Exercice;
                        var factures = temp.factures.Split('-').ToList();
                        

                        //Get the liste of facture
                        var liste = detail.GetListeFacturesClientAllYears(factures,year.Value.Year);

                        if (liste.Count == 0 || liste.All(f => f == null))
                        {
                            ErrorLog.LogMessage($"No factures in avoir{temp.numAvoir}");
                        }
                        //Creating Groupe Details
                        //var entite = liste.Where(f=>f!=null).Select(f => f.entite).First();
                        //var codeClient = liste.Where(f => f != null).Select(f => f.code_clien).First();
                        decimal? mntHt = 0, mntRz = 0, mntTtc = 0, mntTva = 0, marge = 0;

                        if (liste.Count != 0 || liste.All(f => f != null))
                        {
                            //calculating totales in factures
                            liste.ForEach(f =>
                            {
                                mntHt += f?.total_HT; //this is HTR !!
                                mntRz += f?.T_remise;
                                mntTtc += f?.total_TTC;
                                mntTva += f?.total_TVA;
                                marge += f?.Marge;
                            });
                        }
                 
                        var newGroupeCvn = new AF_TEMP_GROUPE_FACTURE
                        {
                            ID_GROUPE_FACT = temp.idgroupe ?? 0,
                            DATE_CADEAU = year,
                            DATE_DOSSIER = DateTime.Today,
                            ENTITE = _entite,
                            CODE_CLIENT = temp.codeClient,
                            //MNT_HT = temp.CA, //this info is given by entite (we switch to avoid to insert les avoirs clients)
                            MNT_HT = mntHt,
                            MNT_RZ = mntRz,
                            MNT_TVA = mntTva,
                            MNT_TTC = mntTtc,
                            MONTANT_CHEQUE = mntHt,//this by the db
                            MARGE = marge,
                            ETAT = 20,
                        };

                        model.AF_TEMP_GROUPE_FACTURE.Add(newGroupeCvn);


                        if (liste.Count != 0 || liste.All(f => f != null))
                        {
                            liste.ForEach(facture =>
                            {
                                if (facture != null)
                                {
                                    var newFacture = new AF_TEMP_FACTURE
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
                                        ID_GROUPE_FACT = temp.idgroupe ?? 0,
                                    };

                                    model.AF_TEMP_FACTURE.Add(newFacture);
                                }

                            });
                        }

                        //model.SaveChanges();
                        //_numGroupe = newGroupeCvn.ID_GROUPE_FACT;



                        //Insert AVOIR


                        _numAvoir = temp.numAvoir;


                        var avoir = new AF_TEMP_AVOIR_FINANCIER
                        {
                            numAvoir = _numAvoir,
                            montant = temp.Montant ?? 0,
                            dateAvoir = temp.dateAvoir ?? DateTime.Now,
                            designation = "REMISE FINANCIERE",
                            montantCheque = temp.cheque ?? 0,
                            montantCreance = temp.creance ?? 0,
                            Observation = "",
                            typeAvoir = byte.Parse(temp.typeAvoir),
                            numAvoirComptable = 20,
                        };


                        var libre = (byte) 2;

                        //insert the related group
                        var avoirGroupe = new AF_TEMP_AVOIR_GROUPE
                        {
                            numAvoir = avoir.numAvoir,
                            IDG = temp.idgroupe ?? 0,
                            Libre = libre
                        };

                        model.AF_TEMP_AVOIR_GROUPE.Add(avoirGroupe);


                        //Insert in the etat table
                        var etat = new AF_TEMP_ETAT_AVOIR
                        {
                            numDossier = temp.refAvoir,
                            numAvoir = avoir.numAvoir,
                            IDG = temp.idgroupe ?? 0,
                            Etat = 3,
                            dateHeure = DateTime.Today
                        };

                        model.AF_TEMP_ETAT_AVOIR.Add(etat);

                        model.AF_TEMP_AVOIR_FINANCIER.Add(avoir);

                        //model.SaveChanges();                       
                    }
                    model.SaveChanges();
                    
                    return true;
                }
            }
            catch (Exception e)
            {
                Messages.Error(@"Erreur insertion factures: " + e.Message);
                ErrorLog.LogError(@"Erreur insertion factures: ", e);
                return false;
            }

        }

        private bool InsertAvoir2016()
        {
            try
            {
                using (var model = new ExpFinanceEntities())
                {
                    var detail = new DetailsDossier();

                    var tempdata = (from temp in model.AF_TEMP_DATA
                                    where temp.entite == _entite
                                    select temp);

                    foreach (var temp in tempdata)
                    {
                        //EXERCICE 2016
                        var factures = temp.factures.Split('-').ToList();
                        ErrorLog.LogMessage($"treating avoir{temp.numAvoir}");


                        //Get the liste of facture
                        var liste = detail.GetListeFacturesClientAll(factures);
                        if (liste.Count == 0 || liste.All(f => f == null))
                        {
                            ErrorLog.LogMessage($"No factures in avoir{temp.numAvoir}");
                        }
                        //Creating Groupe Details
                        //var entite = liste.Where(f => f != null).Select(f => f.entite).First();
                        //var codeClient = liste.Where(f => f != null).Select(f => f.code_clien).First();
                        decimal? mntHt = 0, mntRz = 0, mntTtc = 0, mntTva = 0, marge = 0;

                        //calculating totales in factures
                        if (liste.Count != 0 || liste.All(f => f != null))
                        {
                            //calculating totales in factures
                            liste.ForEach(f =>
                            {
                                mntHt += f?.total_HT; //this is HTR !!
                                mntRz += f?.T_remise;
                                mntTtc += f?.total_TTC;
                                mntTva += f?.total_TVA;
                                marge += f?.Marge;
                            });
                        }


                        var newGroupeCvn = new AF_TEMP_GROUPE_FACTURE
                        {
                            ID_GROUPE_FACT = temp.idgroupe ?? 0,
                            DATE_DOSSIER = DateTime.Today,
                            ENTITE = _entite,
                            CODE_CLIENT = temp.codeClient,
                            MNT_HT = mntHt,
                            MNT_RZ = mntRz,
                            MNT_TVA = mntTva,
                            MNT_TTC = mntTtc,
                            MARGE = marge,
                            ETAT = 10,
                        };

                        model.AF_TEMP_GROUPE_FACTURE.Add(newGroupeCvn);

                        if (liste.Count != 0 || liste.All(f => f != null))
                        {
                            liste.ForEach(facture =>
                            {
                                if (facture != null)
                                {
                                    var newFacture = new AF_TEMP_FACTURE
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
                                        ID_GROUPE_FACT = temp.idgroupe ?? 0,
                                    };

                                    model.AF_TEMP_FACTURE.Add(newFacture);
                                }

                            });
                        }

                        //Insert AVOIR


                        _numAvoir = temp.numAvoir;


                        var avoir = new AF_TEMP_AVOIR_FINANCIER
                        {
                            numAvoir = _numAvoir,
                            montant = temp.Montant ?? 0,
                            dateAvoir = temp.dateAvoir,
                            designation = "REMISE FINANCIERE",
                            montantCheque = temp.cheque ?? 0,
                            montantCreance = temp.creance ?? 0,
                            Observation = "",
                            typeAvoir = byte.Parse(temp.typeAvoir),
                            numAvoirComptable = 10,
                        };


                        var libre = (byte)1;

                        //insert the related group
                        var avoirGroupe = new AF_TEMP_AVOIR_GROUPE
                        {
                            numAvoir = avoir.numAvoir,
                            IDG =  temp.idgroupe ?? 0,
                            Libre = libre
                        };

                        model.AF_TEMP_AVOIR_GROUPE.Add(avoirGroupe);


                        //Insert in the etat table
                        var etat = new AF_TEMP_ETAT_AVOIR
                        {
                            numDossier = temp.refAvoir,
                            numAvoir = avoir.numAvoir,
                            IDG = temp.idgroupe ?? 0,
                            Etat = 3,
                            dateHeure = DateTime.Today
                        };

                        model.AF_TEMP_ETAT_AVOIR.Add(etat);

                        model.AF_TEMP_AVOIR_FINANCIER.Add(avoir);
                       
                    }

                    model.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                Messages.Error(@"Erreur insertion factures: " + e.Message);
                ErrorLog.LogError(@"Erreur insertion factures: ", e);
                return false;
            }

            //catch (DbEntityValidationException e)
            //{
            //    foreach (var eve in e.EntityValidationErrors)
            //    {
            //        ErrorLog.LogError($"Entity of type \"{ eve.Entry.Entity.GetType().Name}\" in state \"{eve.Entry.State}\" has the following validation errors:");
            //        foreach (var ve in eve.ValidationErrors)
            //        {
            //            ErrorLog.LogError($"- Property: \"{ ve.PropertyName}\", Error: \"{ve.ErrorMessage}\"");
            //        }
            //    }
            //    throw;
            //}

        }

    }
}
