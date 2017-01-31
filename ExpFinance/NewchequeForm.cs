using System;
using System.Linq;
using System.Windows.Forms;

namespace ExpFinance
{
    public partial class NewchequeForm : Form
    {
        private readonly decimal _montant;
        private readonly int _numavoir;
        private readonly AvoirForm _af;
        private readonly NewAvoirForm _naf;
        private readonly EditAvoirForm _eaf;
  
        public NewchequeForm(AvoirForm av,decimal montant)
        {
            InitializeComponent();
            _montant = montant;
            _af = av;
        }

        public NewchequeForm(NewAvoirForm av, decimal montant)
        {
            InitializeComponent();
            _montant = montant;
            _naf = av;
        }

        public NewchequeForm(EditAvoirForm av, decimal montant,int numavoir)
        {
            InitializeComponent();
            _montant = montant;
            _eaf = av;
            _numavoir = numavoir;
        }

        private void NewchequeForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'banqueDataSet.Banque' table. You can move, or remove it, as needed.
            banqueTableAdapter.Fill(banqueDataSet.BANQUE,Properties.Settings.Default.entite);
            textBoxMontant.Text = $"{_montant:#,##0.00}";
            textBoxNom.Text = string.IsNullOrEmpty(MainForm.NomClient) ? NewAvoirForm.NomClient : MainForm.NomClient ;
            if (_eaf != null) textBoxNom.Text = GetNomClientOfAvoir(_numavoir);
        }

        private void InsertCheque(AvoirForm f)
        {
            try
            {   
                    var cheque = new CHEQUE
                    {
                        numCheque = textBoxRef.Text,
                        description = textBoxDesc.Text,
                        codeBank = (int)comboBoxBank.SelectedValue,
                        date = dateTimePicker.Value.Date,
                        nom = textBoxNom.Text,
                        montant = decimal.Parse(textBoxMontant.Text)

                    };
                    f.ChequesBuffer=cheque;
            }

            catch (Exception ex)
            {
                Messages.Error(ex.Message);
                
            }
        }

        private void InsertCheque(NewAvoirForm f)
        {
            try
            {
                var cheque = new CHEQUE
                {
                    numCheque = textBoxRef.Text,
                    description = textBoxDesc.Text,
                    codeBank = (int)comboBoxBank.SelectedValue,
                    date = dateTimePicker.Value.Date,
                    nom = textBoxNom.Text,
                    montant = decimal.Parse(textBoxMontant.Text)

                };
                f.ChequesBuffer = cheque;
            }

            catch (Exception ex)
            {
                Messages.Error(ex.Message);

            }
        }

        private void InsertCheque(EditAvoirForm f)
        {
            try
            {
                var cheque = new CHEQUE
                {
                    numCheque = textBoxRef.Text,
                    description = textBoxDesc.Text,
                    codeBank = (int)comboBoxBank.SelectedValue,
                    date = dateTimePicker.Value.Date,
                    nom = textBoxNom.Text,
                    montant = decimal.Parse(textBoxMontant.Text)

                };
                f.ChequesBuffer = cheque;
            }

            catch (Exception ex)
            {
                Messages.Error(ex.Message);

            }
        }

        public string GetNomClientOfAvoir(int numAvoir)
        {
            var listeAvoir = new ListeAvoirDataSet();
            var liste = listeAvoir.GET_LISTE_AVOIR;
            return liste.Where(l => l.numAvoir == numAvoir).Select(l => l.NomClient).FirstOrDefault();
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxRef.Text)) return;
            if (_af!=null) InsertCheque(_af);
            if (_naf != null) InsertCheque(_naf);
            if (_eaf != null) InsertCheque(_eaf);
            Close();
        }
    }
}
