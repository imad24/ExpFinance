using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpFinance
{
    public partial class DetailForm : Form
    {

        private int _numGroupe;
        public DetailForm(int idg)
        {
            InitializeComponent();
            _numGroupe = idg;
        }

        public static List<FACTURE> GetFactures(ExpFinanceEntities model,int id)
        {
                return (from f in model.FACTURE where f.ID_GROUPE_FACT == id
                    select f).Distinct().ToList();          
        }

        private void DetailForm_Load(object sender, EventArgs e)
        {
            using (var model = new ExpFinanceEntities())
            {
                listBoxFactures.DataSource = GetFactures(model,_numGroupe);
                listBoxFactures.ValueMember = "NUM_FACT";
                listBoxFactures.DisplayMember = "NUM_FACT";
            }
        }
        
    }
}
