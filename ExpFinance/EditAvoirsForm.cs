using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Data;
using ExpFinance.ListeAvoirDataSetTableAdapters;
using ExpFinance.Properties;

namespace ExpFinance
{
    public partial class EditAvoirsForm : Form
    {

        private AvoirController _controller;
        public EditAvoirsForm()
        {
            InitializeComponent();
            _controller = new AvoirController();
        }

        private void EditAvoir_Load(object sender, EventArgs e)
        {
            var entite = Settings.Default.entite;
            gET_LISTE_AVOIRTableAdapter.Fill(listeAvoirDataSet1.GET_LISTE_AVOIR, entite, DateTime.Now);
            gridViewAvoir.BestFitColumns();
        }

        private void buttonEditAvoir_Click(object sender, EventArgs e)
        {
            var selectedrows = gridViewAvoir.GetSelectedRows();
            if (selectedrows.Length != 1) return;
            var numAvoirValue = gridViewAvoir.GetRowCellValue(selectedrows[0],colnumAvoir);
            var numAvoir = Convert.ToInt32(numAvoirValue);
            if (numAvoir!=0) EditAvoir(numAvoir);
        }

        private void EditAvoir(int numAvoir)
        {
            var editAvoir = new EditAvoirForm(numAvoir);
            editAvoir.ShowDialog();
        }
    }
}
