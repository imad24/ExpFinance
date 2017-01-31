namespace ExpFinance
{
    partial class NewAvoirForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewAvoirForm));
            this.tableLayoutContainer = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxObservation = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxReste = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listViewFactures = new System.Windows.Forms.ListView();
            this.columnNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHTRZ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMarge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxAvoir = new System.Windows.Forms.GroupBox();
            this.tableLayoutAvoir = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxMontantAv = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxRefAvoir = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dateAvoir = new System.Windows.Forms.DateTimePicker();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonValider = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxHTRZ = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxTauxMontant = new System.Windows.Forms.TextBox();
            this.textBoxMarge = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxClient = new System.Windows.Forms.GroupBox();
            this.tableLayoutClient = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxPromotions = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panelClientSelect = new System.Windows.Forms.Panel();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientDataSet = new ExpFinance.ClientDataSet();
            this.buttonShow = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxNDossier = new System.Windows.Forms.TextBox();
            this.checkBoxCreance = new System.Windows.Forms.CheckBox();
            this.textBoxCreance = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbEE = new System.Windows.Forms.CheckBox();
            this.panelCheque = new System.Windows.Forms.Panel();
            this.pictureBoxRemove = new System.Windows.Forms.PictureBox();
            this.pictureBoxAdd = new System.Windows.Forms.PictureBox();
            this.listBoxCheque = new System.Windows.Forms.ListBox();
            this.panelCheque2 = new System.Windows.Forms.Panel();
            this.textBoxTotalCheque = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxCheque = new System.Windows.Forms.CheckBox();
            this.cbFactures = new System.Windows.Forms.CheckBox();
            this.checkBoxEf = new System.Windows.Forms.CheckBox();
            this.comboBoxPalierEf = new System.Windows.Forms.ComboBox();
            this.dateExercice = new System.Windows.Forms.NumericUpDown();
            this.clientTableAdapter = new ExpFinance.ClientDataSetTableAdapters.AF_CLIENTTableAdapter();
            this.tableLayoutContainer.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBoxAvoir.SuspendLayout();
            this.tableLayoutAvoir.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxClient.SuspendLayout();
            this.tableLayoutClient.SuspendLayout();
            this.panelClientSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataSet)).BeginInit();
            this.panelCheque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdd)).BeginInit();
            this.panelCheque2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateExercice)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutContainer
            // 
            this.tableLayoutContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutContainer.ColumnCount = 3;
            this.tableLayoutContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutContainer.Controls.Add(this.textBoxObservation, 1, 6);
            this.tableLayoutContainer.Controls.Add(this.panel2, 2, 6);
            this.tableLayoutContainer.Controls.Add(this.listViewFactures, 1, 2);
            this.tableLayoutContainer.Controls.Add(this.groupBoxAvoir, 0, 0);
            this.tableLayoutContainer.Controls.Add(this.panelFooter, 0, 7);
            this.tableLayoutContainer.Controls.Add(this.panel1, 2, 2);
            this.tableLayoutContainer.Controls.Add(this.groupBoxClient, 0, 1);
            this.tableLayoutContainer.Controls.Add(this.cbEE, 0, 4);
            this.tableLayoutContainer.Controls.Add(this.panelCheque, 1, 5);
            this.tableLayoutContainer.Controls.Add(this.panelCheque2, 2, 5);
            this.tableLayoutContainer.Controls.Add(this.label1, 0, 6);
            this.tableLayoutContainer.Controls.Add(this.checkBoxCheque, 0, 5);
            this.tableLayoutContainer.Controls.Add(this.cbFactures, 0, 2);
            this.tableLayoutContainer.Controls.Add(this.checkBoxEf, 0, 3);
            this.tableLayoutContainer.Controls.Add(this.comboBoxPalierEf, 1, 3);
            this.tableLayoutContainer.Controls.Add(this.dateExercice, 1, 4);
            this.tableLayoutContainer.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutContainer.Name = "tableLayoutContainer";
            this.tableLayoutContainer.RowCount = 8;
            this.tableLayoutContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutContainer.Size = new System.Drawing.Size(840, 560);
            this.tableLayoutContainer.TabIndex = 0;
            // 
            // textBoxObservation
            // 
            this.textBoxObservation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxObservation.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxObservation.Location = new System.Drawing.Point(129, 460);
            this.textBoxObservation.MaxLength = 21;
            this.textBoxObservation.Multiline = true;
            this.textBoxObservation.Name = "textBoxObservation";
            this.textBoxObservation.Size = new System.Drawing.Size(388, 44);
            this.textBoxObservation.TabIndex = 6;
            this.textBoxObservation.TextChanged += new System.EventHandler(this.textBoxObservation_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxReste);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(591, 460);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 44);
            this.panel2.TabIndex = 13;
            // 
            // textBoxReste
            // 
            this.textBoxReste.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxReste.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxReste.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxReste.Location = new System.Drawing.Point(82, 14);
            this.textBoxReste.Name = "textBoxReste";
            this.textBoxReste.Size = new System.Drawing.Size(154, 18);
            this.textBoxReste.TabIndex = 12;
            this.textBoxReste.TabStop = false;
            this.textBoxReste.Text = "0,00";
            this.textBoxReste.TextChanged += new System.EventHandler(this.textBoxObservation_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Reste :";
            // 
            // listViewFactures
            // 
            this.listViewFactures.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listViewFactures.CheckBoxes = true;
            this.listViewFactures.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNum,
            this.columnDate,
            this.columnHTRZ,
            this.columnMarge});
            this.listViewFactures.FullRowSelect = true;
            this.listViewFactures.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewFactures.Location = new System.Drawing.Point(129, 227);
            this.listViewFactures.Name = "listViewFactures";
            this.listViewFactures.Size = new System.Drawing.Size(388, 89);
            this.listViewFactures.TabIndex = 0;
            this.listViewFactures.TabStop = false;
            this.listViewFactures.UseCompatibleStateImageBehavior = false;
            this.listViewFactures.View = System.Windows.Forms.View.Details;
            this.listViewFactures.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listViewFactures_ItemChecked);
            this.listViewFactures.DoubleClick += new System.EventHandler(this.listViewFactures_DoubleClick);
            // 
            // columnNum
            // 
            this.columnNum.Text = "Num";
            this.columnNum.Width = 80;
            // 
            // columnDate
            // 
            this.columnDate.Text = "Date";
            this.columnDate.Width = 80;
            // 
            // columnHTRZ
            // 
            this.columnHTRZ.Text = "Montant HTR";
            this.columnHTRZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHTRZ.Width = 100;
            // 
            // columnMarge
            // 
            this.columnMarge.Text = "Marge";
            this.columnMarge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnMarge.Width = 100;
            // 
            // groupBoxAvoir
            // 
            this.groupBoxAvoir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutContainer.SetColumnSpan(this.groupBoxAvoir, 3);
            this.groupBoxAvoir.Controls.Add(this.tableLayoutAvoir);
            this.groupBoxAvoir.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBoxAvoir.Location = new System.Drawing.Point(3, 3);
            this.groupBoxAvoir.Name = "groupBoxAvoir";
            this.groupBoxAvoir.Size = new System.Drawing.Size(834, 106);
            this.groupBoxAvoir.TabIndex = 0;
            this.groupBoxAvoir.TabStop = false;
            this.groupBoxAvoir.Text = "Références Avoir";
            // 
            // tableLayoutAvoir
            // 
            this.tableLayoutAvoir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutAvoir.ColumnCount = 4;
            this.tableLayoutAvoir.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutAvoir.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutAvoir.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutAvoir.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutAvoir.Controls.Add(this.textBoxMontantAv, 1, 1);
            this.tableLayoutAvoir.Controls.Add(this.label11, 0, 0);
            this.tableLayoutAvoir.Controls.Add(this.textBoxRefAvoir, 1, 0);
            this.tableLayoutAvoir.Controls.Add(this.label14, 2, 0);
            this.tableLayoutAvoir.Controls.Add(this.dateAvoir, 3, 0);
            this.tableLayoutAvoir.Controls.Add(this.textBoxDesc, 3, 1);
            this.tableLayoutAvoir.Controls.Add(this.label2, 2, 1);
            this.tableLayoutAvoir.Controls.Add(this.label16, 0, 1);
            this.tableLayoutAvoir.Location = new System.Drawing.Point(3, 24);
            this.tableLayoutAvoir.Name = "tableLayoutAvoir";
            this.tableLayoutAvoir.RowCount = 2;
            this.tableLayoutAvoir.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutAvoir.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutAvoir.Size = new System.Drawing.Size(822, 70);
            this.tableLayoutAvoir.TabIndex = 0;
            // 
            // textBoxMontantAv
            // 
            this.textBoxMontantAv.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxMontantAv.Location = new System.Drawing.Point(126, 38);
            this.textBoxMontantAv.MaxLength = 21;
            this.textBoxMontantAv.Name = "textBoxMontantAv";
            this.textBoxMontantAv.Size = new System.Drawing.Size(222, 25);
            this.textBoxMontantAv.TabIndex = 1;
            this.textBoxMontantAv.Text = "0,00";
            this.textBoxMontantAv.TextChanged += new System.EventHandler(this.textBoxMontantAv_TextChanged);
            this.textBoxMontantAv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMontantAv_KeyPress);
            this.textBoxMontantAv.Validated += new System.EventHandler(this.textBoxMontantAv_Validated);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(3, 3);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Référence Avoir";
            // 
            // textBoxRefAvoir
            // 
            this.textBoxRefAvoir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxRefAvoir.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRefAvoir.Enabled = false;
            this.textBoxRefAvoir.Location = new System.Drawing.Point(126, 3);
            this.textBoxRefAvoir.Name = "textBoxRefAvoir";
            this.textBoxRefAvoir.ReadOnly = true;
            this.textBoxRefAvoir.Size = new System.Drawing.Size(222, 18);
            this.textBoxRefAvoir.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.DimGray;
            this.label14.Location = new System.Drawing.Point(495, 3);
            this.label14.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "Date Avoir";
            // 
            // dateAvoir
            // 
            this.dateAvoir.Location = new System.Drawing.Point(618, 3);
            this.dateAvoir.Name = "dateAvoir";
            this.dateAvoir.Size = new System.Drawing.Size(201, 25);
            this.dateAvoir.TabIndex = 1;
            this.dateAvoir.TabStop = false;
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxDesc.Location = new System.Drawing.Point(618, 38);
            this.textBoxDesc.MaxLength = 250;
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(201, 25);
            this.textBoxDesc.TabIndex = 2;
            this.textBoxDesc.Text = "REMISE FINANCIERE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(495, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Description *";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.DimGray;
            this.label16.Location = new System.Drawing.Point(3, 38);
            this.label16.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(91, 17);
            this.label16.TabIndex = 0;
            this.label16.Text = "Montant (DA)*";
            // 
            // panelFooter
            // 
            this.panelFooter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutContainer.SetColumnSpan(this.panelFooter, 3);
            this.panelFooter.Controls.Add(this.tableLayoutPanel1);
            this.panelFooter.Location = new System.Drawing.Point(3, 510);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(834, 47);
            this.panelFooter.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.buttonValider, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonAnnuler, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(832, 44);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonValider
            // 
            this.buttonValider.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonValider.Image = global::ExpFinance.Properties.Resources.check;
            this.buttonValider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonValider.Location = new System.Drawing.Point(158, 4);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(100, 35);
            this.buttonValider.TabIndex = 20;
            this.buttonValider.TabStop = false;
            this.buttonValider.Text = "Valider";
            this.buttonValider.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAnnuler.Image = global::ExpFinance.Properties.Resources.cancel;
            this.buttonAnnuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAnnuler.Location = new System.Drawing.Point(574, 4);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(100, 35);
            this.buttonAnnuler.TabIndex = 21;
            this.buttonAnnuler.TabStop = false;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.textBoxHTRZ);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBoxTauxMontant);
            this.panel1.Controls.Add(this.textBoxMarge);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(591, 227);
            this.panel1.Name = "panel1";
            this.tableLayoutContainer.SetRowSpan(this.panel1, 3);
            this.panel1.Size = new System.Drawing.Size(246, 177);
            this.panel1.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(184, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "%";
            // 
            // textBoxHTRZ
            // 
            this.textBoxHTRZ.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxHTRZ.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxHTRZ.Enabled = false;
            this.textBoxHTRZ.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxHTRZ.Location = new System.Drawing.Point(101, 50);
            this.textBoxHTRZ.Name = "textBoxHTRZ";
            this.textBoxHTRZ.Size = new System.Drawing.Size(137, 18);
            this.textBoxHTRZ.TabIndex = 9;
            this.textBoxHTRZ.TabStop = false;
            this.textBoxHTRZ.Text = "0,00";
            this.textBoxHTRZ.TextChanged += new System.EventHandler(this.textBoxHTRZ_TextChanged);
            this.textBoxHTRZ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMontantAv_KeyPress);
            this.textBoxHTRZ.Validated += new System.EventHandler(this.textBoxMontantAv_Validated);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(22, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Taux Rz:";
            // 
            // textBoxTauxMontant
            // 
            this.textBoxTauxMontant.Enabled = false;
            this.textBoxTauxMontant.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxTauxMontant.Location = new System.Drawing.Point(101, 104);
            this.textBoxTauxMontant.MaxLength = 5;
            this.textBoxTauxMontant.Name = "textBoxTauxMontant";
            this.textBoxTauxMontant.Size = new System.Drawing.Size(69, 25);
            this.textBoxTauxMontant.TabIndex = 5;
            this.textBoxTauxMontant.Text = "0,00";
            this.textBoxTauxMontant.TextChanged += new System.EventHandler(this.textBoxTauxMontant_TextChanged);
            this.textBoxTauxMontant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMontantAv_KeyPress);
            // 
            // textBoxMarge
            // 
            this.textBoxMarge.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxMarge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMarge.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxMarge.Location = new System.Drawing.Point(101, 78);
            this.textBoxMarge.Name = "textBoxMarge";
            this.textBoxMarge.Size = new System.Drawing.Size(137, 18);
            this.textBoxMarge.TabIndex = 10;
            this.textBoxMarge.TabStop = false;
            this.textBoxMarge.Text = "0,00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Marge :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total :";
            // 
            // groupBoxClient
            // 
            this.groupBoxClient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutContainer.SetColumnSpan(this.groupBoxClient, 3);
            this.groupBoxClient.Controls.Add(this.tableLayoutClient);
            this.groupBoxClient.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBoxClient.Location = new System.Drawing.Point(3, 115);
            this.groupBoxClient.Name = "groupBoxClient";
            this.groupBoxClient.Size = new System.Drawing.Size(834, 106);
            this.groupBoxClient.TabIndex = 0;
            this.groupBoxClient.TabStop = false;
            this.groupBoxClient.Text = "Informations Avoir";
            // 
            // tableLayoutClient
            // 
            this.tableLayoutClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutClient.ColumnCount = 4;
            this.tableLayoutClient.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutClient.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutClient.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutClient.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutClient.Controls.Add(this.comboBoxPromotions, 3, 0);
            this.tableLayoutClient.Controls.Add(this.label15, 0, 0);
            this.tableLayoutClient.Controls.Add(this.panelClientSelect, 1, 0);
            this.tableLayoutClient.Controls.Add(this.label10, 0, 1);
            this.tableLayoutClient.Controls.Add(this.textBoxNDossier, 1, 1);
            this.tableLayoutClient.Controls.Add(this.checkBoxCreance, 2, 1);
            this.tableLayoutClient.Controls.Add(this.textBoxCreance, 3, 1);
            this.tableLayoutClient.Controls.Add(this.label8, 2, 0);
            this.tableLayoutClient.Location = new System.Drawing.Point(3, 24);
            this.tableLayoutClient.Name = "tableLayoutClient";
            this.tableLayoutClient.RowCount = 2;
            this.tableLayoutClient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutClient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutClient.Size = new System.Drawing.Size(822, 75);
            this.tableLayoutClient.TabIndex = 0;
            // 
            // comboBoxPromotions
            // 
            this.comboBoxPromotions.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxPromotions.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxPromotions.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxPromotions.FormattingEnabled = true;
            this.comboBoxPromotions.Location = new System.Drawing.Point(618, 6);
            this.comboBoxPromotions.Name = "comboBoxPromotions";
            this.comboBoxPromotions.Size = new System.Drawing.Size(201, 25);
            this.comboBoxPromotions.TabIndex = 3;
            this.comboBoxPromotions.DropDown += new System.EventHandler(this.comboBoxPromotions_DropDown);
            this.comboBoxPromotions.SelectedValueChanged += new System.EventHandler(this.comboBoxPromotions_SelectedValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.DimGray;
            this.label15.Location = new System.Drawing.Point(3, 3);
            this.label15.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 17);
            this.label15.TabIndex = 0;
            this.label15.Text = "Client *";
            // 
            // panelClientSelect
            // 
            this.panelClientSelect.Controls.Add(this.comboBoxClient);
            this.panelClientSelect.Controls.Add(this.buttonShow);
            this.panelClientSelect.Location = new System.Drawing.Point(126, 3);
            this.panelClientSelect.Name = "panelClientSelect";
            this.panelClientSelect.Size = new System.Drawing.Size(363, 30);
            this.panelClientSelect.TabIndex = 0;
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxClient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxClient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxClient.DataSource = this.clientBindingSource;
            this.comboBoxClient.DisplayMember = "NOM";
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(3, 3);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(264, 25);
            this.comboBoxClient.TabIndex = 3;
            this.comboBoxClient.ValueMember = "code_clien";
            this.comboBoxClient.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "AF_CLIENT";
            this.clientBindingSource.DataSource = this.clientDataSet;
            // 
            // clientDataSet
            // 
            this.clientDataSet.DataSetName = "ClientDataSet";
            this.clientDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonShow
            // 
            this.buttonShow.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonShow.ForeColor = System.Drawing.Color.DimGray;
            this.buttonShow.Location = new System.Drawing.Point(273, 0);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(90, 30);
            this.buttonShow.TabIndex = 5;
            this.buttonShow.TabStop = false;
            this.buttonShow.Text = "Sélectionner";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(3, 40);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Numéro Dossier";
            // 
            // textBoxNDossier
            // 
            this.textBoxNDossier.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxNDossier.Location = new System.Drawing.Point(126, 40);
            this.textBoxNDossier.MaxLength = 250;
            this.textBoxNDossier.Name = "textBoxNDossier";
            this.textBoxNDossier.Size = new System.Drawing.Size(267, 25);
            this.textBoxNDossier.TabIndex = 2;
            this.textBoxNDossier.TextChanged += new System.EventHandler(this.textBoxNDossier_TextChanged);
            // 
            // checkBoxCreance
            // 
            this.checkBoxCreance.AutoSize = true;
            this.checkBoxCreance.ForeColor = System.Drawing.Color.DimGray;
            this.checkBoxCreance.Location = new System.Drawing.Point(500, 43);
            this.checkBoxCreance.Margin = new System.Windows.Forms.Padding(8, 6, 3, 3);
            this.checkBoxCreance.Name = "checkBoxCreance";
            this.checkBoxCreance.Size = new System.Drawing.Size(103, 21);
            this.checkBoxCreance.TabIndex = 8;
            this.checkBoxCreance.TabStop = false;
            this.checkBoxCreance.Text = "Créance (DA)";
            this.checkBoxCreance.UseVisualStyleBackColor = true;
            this.checkBoxCreance.CheckedChanged += new System.EventHandler(this.checkBoxCreance_CheckedChanged);
            // 
            // textBoxCreance
            // 
            this.textBoxCreance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCreance.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxCreance.Location = new System.Drawing.Point(618, 41);
            this.textBoxCreance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.textBoxCreance.MaxLength = 21;
            this.textBoxCreance.Name = "textBoxCreance";
            this.textBoxCreance.Size = new System.Drawing.Size(201, 25);
            this.textBoxCreance.TabIndex = 4;
            this.textBoxCreance.Text = "0,00";
            this.textBoxCreance.TextChanged += new System.EventHandler(this.textBoxCreance_TextChanged);
            this.textBoxCreance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMontantAv_KeyPress);
            this.textBoxCreance.Validated += new System.EventHandler(this.textBoxMontantAv_Validated);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(500, 11);
            this.label8.Margin = new System.Windows.Forms.Padding(8, 3, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Promotion";
            // 
            // cbEE
            // 
            this.cbEE.AutoSize = true;
            this.cbEE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbEE.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEE.Location = new System.Drawing.Point(3, 366);
            this.cbEE.Name = "cbEE";
            this.cbEE.Size = new System.Drawing.Size(120, 38);
            this.cbEE.TabIndex = 10;
            this.cbEE.TabStop = false;
            this.cbEE.Text = "Exercice Antérieur";
            this.cbEE.UseVisualStyleBackColor = true;
            this.cbEE.CheckedChanged += new System.EventHandler(this.cbEE_CheckedChanged);
            // 
            // panelCheque
            // 
            this.panelCheque.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelCheque.Controls.Add(this.pictureBoxRemove);
            this.panelCheque.Controls.Add(this.pictureBoxAdd);
            this.panelCheque.Controls.Add(this.listBoxCheque);
            this.panelCheque.Location = new System.Drawing.Point(129, 410);
            this.panelCheque.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.panelCheque.Name = "panelCheque";
            this.panelCheque.Size = new System.Drawing.Size(449, 47);
            this.panelCheque.TabIndex = 7;
            // 
            // pictureBoxRemove
            // 
            this.pictureBoxRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxRemove.Image = global::ExpFinance.Properties.Resources.remove;
            this.pictureBoxRemove.Location = new System.Drawing.Point(422, 18);
            this.pictureBoxRemove.Name = "pictureBoxRemove";
            this.pictureBoxRemove.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxRemove.TabIndex = 9;
            this.pictureBoxRemove.TabStop = false;
            this.pictureBoxRemove.Click += new System.EventHandler(this.btnRempveCheque_Click);
            // 
            // pictureBoxAdd
            // 
            this.pictureBoxAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAdd.Image = global::ExpFinance.Properties.Resources.add;
            this.pictureBoxAdd.Location = new System.Drawing.Point(394, 18);
            this.pictureBoxAdd.Name = "pictureBoxAdd";
            this.pictureBoxAdd.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxAdd.TabIndex = 9;
            this.pictureBoxAdd.TabStop = false;
            this.pictureBoxAdd.Click += new System.EventHandler(this.BtnAddCheque_Click);
            // 
            // listBoxCheque
            // 
            this.listBoxCheque.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxCheque.FormattingEnabled = true;
            this.listBoxCheque.ItemHeight = 17;
            this.listBoxCheque.Location = new System.Drawing.Point(0, 0);
            this.listBoxCheque.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.listBoxCheque.MultiColumn = true;
            this.listBoxCheque.Name = "listBoxCheque";
            this.listBoxCheque.Size = new System.Drawing.Size(388, 38);
            this.listBoxCheque.TabIndex = 0;
            this.listBoxCheque.TabStop = false;
            // 
            // panelCheque2
            // 
            this.panelCheque2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCheque2.Controls.Add(this.textBoxTotalCheque);
            this.panelCheque2.Controls.Add(this.label3);
            this.panelCheque2.Location = new System.Drawing.Point(591, 410);
            this.panelCheque2.Name = "panelCheque2";
            this.panelCheque2.Size = new System.Drawing.Size(246, 44);
            this.panelCheque2.TabIndex = 8;
            // 
            // textBoxTotalCheque
            // 
            this.textBoxTotalCheque.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxTotalCheque.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTotalCheque.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxTotalCheque.Location = new System.Drawing.Point(82, 15);
            this.textBoxTotalCheque.Name = "textBoxTotalCheque";
            this.textBoxTotalCheque.Size = new System.Drawing.Size(135, 18);
            this.textBoxTotalCheque.TabIndex = 16;
            this.textBoxTotalCheque.TabStop = false;
            this.textBoxTotalCheque.Text = "0,00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Total :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 457);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Observation *";
            // 
            // checkBoxCheque
            // 
            this.checkBoxCheque.AutoSize = true;
            this.checkBoxCheque.Location = new System.Drawing.Point(3, 410);
            this.checkBoxCheque.Name = "checkBoxCheque";
            this.checkBoxCheque.Size = new System.Drawing.Size(71, 21);
            this.checkBoxCheque.TabIndex = 10;
            this.checkBoxCheque.TabStop = false;
            this.checkBoxCheque.Text = "Chèque";
            this.checkBoxCheque.UseVisualStyleBackColor = true;
            this.checkBoxCheque.CheckedChanged += new System.EventHandler(this.checkBoxCheque_CheckedChanged);
            // 
            // cbFactures
            // 
            this.cbFactures.AutoSize = true;
            this.cbFactures.Checked = true;
            this.cbFactures.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbFactures.Location = new System.Drawing.Point(3, 227);
            this.cbFactures.Name = "cbFactures";
            this.cbFactures.Size = new System.Drawing.Size(80, 21);
            this.cbFactures.TabIndex = 10;
            this.cbFactures.TabStop = false;
            this.cbFactures.Text = "Factures*";
            this.cbFactures.UseVisualStyleBackColor = true;
            this.cbFactures.CheckedChanged += new System.EventHandler(this.cbFactures_CheckedChanged);
            // 
            // checkBoxEf
            // 
            this.checkBoxEf.AutoSize = true;
            this.checkBoxEf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxEf.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEf.ForeColor = System.Drawing.Color.DimGray;
            this.checkBoxEf.Location = new System.Drawing.Point(3, 322);
            this.checkBoxEf.Name = "checkBoxEf";
            this.checkBoxEf.Size = new System.Drawing.Size(120, 38);
            this.checkBoxEf.TabIndex = 8;
            this.checkBoxEf.TabStop = false;
            this.checkBoxEf.Text = "Remise Comp.";
            this.checkBoxEf.UseVisualStyleBackColor = true;
            this.checkBoxEf.CheckedChanged += new System.EventHandler(this.checkBoxEf_CheckedChanged);
            // 
            // comboBoxPalierEf
            // 
            this.comboBoxPalierEf.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxPalierEf.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxPalierEf.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxPalierEf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPalierEf.Enabled = false;
            this.comboBoxPalierEf.FormattingEnabled = true;
            this.comboBoxPalierEf.Location = new System.Drawing.Point(129, 330);
            this.comboBoxPalierEf.Name = "comboBoxPalierEf";
            this.comboBoxPalierEf.Size = new System.Drawing.Size(270, 25);
            this.comboBoxPalierEf.TabIndex = 3;
            this.comboBoxPalierEf.SelectedValueChanged += new System.EventHandler(this.comboBoxPalierEf_SelectedValueChanged);
            // 
            // dateExercice
            // 
            this.dateExercice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateExercice.ForeColor = System.Drawing.Color.DimGray;
            this.dateExercice.Location = new System.Drawing.Point(129, 372);
            this.dateExercice.Maximum = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            this.dateExercice.Minimum = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            this.dateExercice.Name = "dateExercice";
            this.dateExercice.Size = new System.Drawing.Size(120, 25);
            this.dateExercice.TabIndex = 14;
            this.dateExercice.Value = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // NewAvoirForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(858, 571);
            this.Controls.Add(this.tableLayoutContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "NewAvoirForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nouvel Avoir Financier";
            this.Load += new System.EventHandler(this.AvoirForm_Load);
            this.ResizeEnd += new System.EventHandler(this.NewAvoirForm_ResizeEnd);
            this.tableLayoutContainer.ResumeLayout(false);
            this.tableLayoutContainer.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBoxAvoir.ResumeLayout(false);
            this.tableLayoutAvoir.ResumeLayout(false);
            this.tableLayoutAvoir.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxClient.ResumeLayout(false);
            this.tableLayoutClient.ResumeLayout(false);
            this.tableLayoutClient.PerformLayout();
            this.panelClientSelect.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataSet)).EndInit();
            this.panelCheque.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdd)).EndInit();
            this.panelCheque2.ResumeLayout(false);
            this.panelCheque2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateExercice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutContainer;
        private System.Windows.Forms.GroupBox groupBoxClient;
        private System.Windows.Forms.TableLayoutPanel tableLayoutClient;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBoxAvoir;
        private System.Windows.Forms.TableLayoutPanel tableLayoutAvoir;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxRefAvoir;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dateAvoir;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxMontantAv;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.ListView listViewFactures;
        private System.Windows.Forms.ColumnHeader columnNum;
        private System.Windows.Forms.ColumnHeader columnDate;
        private System.Windows.Forms.ColumnHeader columnHTRZ;
        private System.Windows.Forms.ListBox listBoxCheque;
        private System.Windows.Forms.Panel panelCheque;
        private System.Windows.Forms.TextBox textBoxTotalCheque;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelCheque2;
        private System.Windows.Forms.PictureBox pictureBoxRemove;
        private System.Windows.Forms.PictureBox pictureBoxAdd;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.TextBox textBoxHTRZ;
        private System.Windows.Forms.TextBox textBoxMarge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private ClientDataSet clientDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private ClientDataSetTableAdapters.AF_CLIENTTableAdapter clientTableAdapter;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.ColumnHeader columnMarge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxReste;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelClientSelect;
        private System.Windows.Forms.TextBox textBoxCreance;
        private System.Windows.Forms.TextBox textBoxObservation;
        private System.Windows.Forms.CheckBox checkBoxCreance;
        private System.Windows.Forms.CheckBox checkBoxCheque;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxTauxMontant;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxNDossier;
        private System.Windows.Forms.CheckBox cbEE;
        private System.Windows.Forms.CheckBox cbFactures;
        private System.Windows.Forms.NumericUpDown dateExercice;
        private System.Windows.Forms.CheckBox checkBoxEf;
        private System.Windows.Forms.ComboBox comboBoxPalierEf;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxPromotions;
    }
}