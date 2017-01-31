using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ExpFinance
{
    public partial class EditAvoirForm : Form
    {
        private bool _isCheque,_isCreance;
        private decimal _reste,_montant,_cheque,_creance;
        private int _typeAvoir;
        public CHEQUE ChequesBuffer;
        private List<CHEQUE> _chequesList = new List<CHEQUE>();
        public AVOIR_FINANCIER AvoirFinancier { get; private set; }
        public EditAvoirForm(int numAvoir)
        {
            InitializeComponent();
            AvoirFinancier = GetAvoirInfo(numAvoir);
            _creance = AvoirFinancier.montantCreance;
            _cheque = AvoirFinancier.montantCheque;
            _reste = 0;
        }

        private void EditAvoirForm_Load(object sender, EventArgs e)
        {
            SetAvoirInfo();
        }

        private AVOIR_FINANCIER GetAvoirInfo(int num)
        {
            using (var model= new ExpFinanceEntities())
            {
                return (from a in model.AVOIR_FINANCIER where a.numAvoir == num select a).FirstOrDefault();
        
            }
        }

        private void SetAvoirInfo()
        {
            textBoxCheque.Text = AvoirFinancier.montantCheque.ToString("#,##0.00");
            textBoxCreance.Text = AvoirFinancier.montantCreance.ToString("#,##0.00");
            textBoxMontantAv.Text = AvoirFinancier.montant.ToString("#,##0.00");
            textBoxReste.Text = 0.ToString("#,##0.00");
            checkBoxCheque.Checked = _isCheque = AvoirFinancier.typeAvoir != 2;
            checkBoxCreance.Checked = _isCreance = AvoirFinancier.typeAvoir != 1;
            textBoxObservation.Text = AvoirFinancier.Observation;
        }

        private void textBoxCreance_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox) == null) return;
            decimal.TryParse((sender as TextBox).Text, out _creance);
            textBoxCreance.Text = $"{_creance:#,##0.00}";
        }

        private void textBoxCheque_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox) == null) return;
            decimal.TryParse((sender as TextBox).Text, out _cheque);
            textBoxCheque.Text = $"{_cheque:#,##0.00}";
        }

        private void textBoxMontantAv_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox) == null) return;
            decimal.TryParse((sender as TextBox).Text, out _montant);
            textBoxMontantAv.Text = $"{_montant:#,##0.00}";
        }

        private void pictureBoxAdd_Click(object sender, EventArgs e)
        {
            if (TotalCheque() == _montant) return;
            if (_reste <= 0) return;
            var cheque = new NewchequeForm(this, _reste,AvoirFinancier.numAvoir);
            cheque.Closing += (sndr, args) => LoadCheque();
            cheque.ShowDialog();
        }

        private void pictureBoxRemove_Click(object sender, EventArgs e)
        {
            if (listBoxCheque.SelectedItem == null) return;
            RemoveCheque(listBoxCheque.GetItemText(listBoxCheque.SelectedItem));
            RebindListBoxCheque();
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

        private void CheckType()
        {
            textBoxObservation.Text = string.Empty;
            _typeAvoir = 0;

            if (_isCheque)
            {
                textBoxCheque.Enabled = true;
                textBoxCheque.Text = $"{_reste:#,##0.00}";
                textBoxObservation.Text = @"CHEQUE" + Environment.NewLine;
                _typeAvoir++;
                
            }
            else
            {
                textBoxCheque.Text = $"{0:#,##0.00}";
                textBoxCheque.Enabled = false;
            }
            if (_isCreance)
            {
                textBoxCreance.Enabled = true;
                textBoxCreance.Text = $"{_reste:#,##0.00}";
                textBoxObservation.Text += @"À VALOIR SUR CREANCE";
                _typeAvoir +=2;

            }
            else
            {
                textBoxCreance.Enabled = false;
                textBoxCreance.Text = $"{0:#,##0.00}";
            }

            Calculation();
        }

        private void Calculation()
        {
            _reste = _montant - (_cheque + _creance);
            textBoxReste.Text = _reste >= 0 ? _reste.ToString("N2") + @" DA" : "MONTANTS INCORRECT !";
            //setcolors
            textBoxCreance.ForeColor = _creance <= _montant ? Color.Green : Color.Coral;
            textBoxCheque.ForeColor = _cheque <= _montant ? Color.Green : Color.Coral;
            textBoxReste.ForeColor = _reste >= 0 ? Color.Green : Color.Coral;

        }


        private void LoadCheque()
        {
            if (ChequesBuffer == null) return;
            _chequesList.Add(ChequesBuffer);
            RebindListBoxCheque();
            textBoxCheque.Text = TotalCheque().ToString("N2") + @" DA";
            textBoxCheque.ForeColor = TotalCheque() >= _montant ? Color.Green : Color.Coral;
            //empty the buffer
            ChequesBuffer = null;
        }

        private void RebindListBoxCheque()
        {
            listBoxCheque.DataSource = null;
            listBoxCheque.Items.Clear();
            listBoxCheque.DataSource = _chequesList;
            listBoxCheque.DisplayMember = "numCheque";
            listBoxCheque.ValueMember = "numCheque";
            textBoxCheque.Text = TotalCheque().ToString("N2") + @" DA";
            textBoxCheque.ForeColor = TotalCheque() >= _montant ? Color.Green : Color.Coral;
        }

        decimal TotalCheque()
        {
            decimal total = 0;
            _chequesList.ForEach(c => total += c.montant);
            _cheque = total;
            Calculation();
            return total;
        }

        private void RemoveCheque(string num)
        {
            var ch = _chequesList.Find(c => c.numCheque == num);
            _chequesList.Remove(ch);
            textBoxCheque.Text = TotalCheque().ToString("N2") + @" DA";
            textBoxCheque.ForeColor = TotalCheque() >= _montant ? Color.Green : Color.Coral;
        }

    }
}
