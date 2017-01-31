using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraPrinting.Native;
using ExpFinance.Properties;

namespace ExpFinance
{
    public partial class LigneFacture : Form
    {
        private readonly int _numFacture;
        private readonly DateTime _date;
        private decimal _total,_marge;
        private readonly NewAvoirForm _newAvoir;

        private readonly ListViewColumnSorter _lvwColumnSorter;


        public LigneFacture(NewAvoirForm nav,int nf,DateTime dt)
        {
            InitializeComponent();
            _numFacture = nf;
            _date = dt;
            _newAvoir = nav;

            _lvwColumnSorter = new ListViewColumnSorter();
            listViewLignes.ListViewItemSorter = _lvwColumnSorter;
        }

        private void LigneFacture_Load(object sender, EventArgs e)
        {
            var entite = Settings.Default.entite;
            var lignes = GetLignes(entite, _numFacture, _date);
            var sortableLignes = new SortableBindingList<AF_GET_LIGNES_FACTURE_Result>(lignes);
            PopulateFacutresListView(sortableLignes);
        }


        List<AF_GET_LIGNES_FACTURE_Result> GetLignes(string ent, int numFact,DateTime date)
        {
            try
            {
                using (var model = new ExpFinanceEntities())
                {
                    return ( from l in model.AF_GET_LIGNES_FACTURE(ent, numFact, date)
                             select l).ToList();
                }
            }
            catch (Exception ex)
            {
                
                Messages.Error("Erreur: "+ex.Message);
                ErrorLog.LogError("Erreur lignes factures",ex);
                return null;
            }

        }

        private void PopulateFacutresListView(SortableBindingList<AF_GET_LIGNES_FACTURE_Result> liste)
        {
            listViewLignes.Items.Clear();
            //liste = liste.OrderBy(l => l.Ix_Ligne).ToList();
            liste.ForEach(l =>
            {
                var num = l.Ix_Ligne.ToString("");
                var prd = l.CODE_PROD;
                var lot = l.num_lot;
                var qte = l.Qte_Trans.ToString();
                var htr = l.VAL_HT != null && l.Val_Rz != null ? (l.VAL_HT.Value-l.Val_Rz.Value).ToString("N2") : "0";
                var marge = l.Marge != null ? (l.Marge.Value).ToString("N2") : "0";
                listViewLignes.Items.Add(new ListViewItem(new[] { num, prd,lot,qte, htr,marge}));
            });

           
        }

        private void TotalLignes(out decimal tht, out decimal tmarge)
        {    
            tht = tmarge = 0;
            foreach (ListViewItem item in listViewLignes.Items)
            {
                var textHt = item.SubItems[4].Text;
                var textMarge = item.SubItems[5].Text;
                decimal ht, marge;
                if (decimal.TryParse(textHt, out ht) && item.Checked) tht += ht;
                if (decimal.TryParse(textMarge, out marge) && item.Checked) tmarge += marge;
            }
            _total = tht;
            _marge = tmarge;
        }

        private void listViewLignes_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            decimal marge, total;
            TotalLignes(out total, out marge);
            textBoxHTRZ.Text = total.ToString("N2");
            textBoxMarge.Text = marge.ToString("N2");
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (SendLignes() == 0) return;
            Close();
        }

        private int SendLignes()
        {
            _newAvoir.LignesBuffer = GetLignesNum();
            _newAvoir.TotalLigne = _total;
            _newAvoir.MargeLigne = _marge;

            return GetLignesNum().Count();

        }

        private List<int> GetLignesNum()
        {
            try
            {
                return (from ListViewItem item in listViewLignes.CheckedItems select int.Parse(item.SubItems[0].Text)).ToList();
            }
            catch (Exception ex)
            {
                
              Messages.Error("Error getting ligne numbers: "+ex.Message);
               ErrorLog.LogError("Error getting ligne numbers",ex);
                return null;
            }
            
        }

        private void listViewLignes_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == _lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (_lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    _lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    _lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                _lvwColumnSorter.SortColumn = e.Column;
                _lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            listViewLignes.Sort();
        }

        private void LigneFacture_FormClosing(object sender, FormClosingEventArgs e)
        {
           if (listViewLignes.CheckedItems.Count==0) e.Cancel = true;
        }
    }
}
