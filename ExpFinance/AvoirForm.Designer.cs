namespace ExpFinance
{
    partial class AvoirForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AvoirForm));
            this.tableLayoutContainer = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxAvoir = new System.Windows.Forms.GroupBox();
            this.tableLayoutAvoir = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxRefAvoir = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dateAvoir = new System.Windows.Forms.DateTimePicker();
            this.textBoxMontantAv = new System.Windows.Forms.TextBox();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonValider = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listViewFactures = new System.Windows.Forms.ListView();
            this.columnNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHTRZ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMarge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxCreance = new System.Windows.Forms.TextBox();
            this.textBoxObservation = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxHTRZ = new System.Windows.Forms.TextBox();
            this.textBoxMarge = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelCheque = new System.Windows.Forms.Panel();
            this.pictureBoxRemove = new System.Windows.Forms.PictureBox();
            this.pictureBoxAdd = new System.Windows.Forms.PictureBox();
            this.listBoxCheque = new System.Windows.Forms.ListBox();
            this.panelCheque2 = new System.Windows.Forms.Panel();
            this.textBoxTotalCheque = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxReste = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBoxCreance = new System.Windows.Forms.CheckBox();
            this.checkBoxCheque = new System.Windows.Forms.CheckBox();
            this.pictureBoxLock = new System.Windows.Forms.PictureBox();
            this.tableLayoutContainer.SuspendLayout();
            this.groupBoxAvoir.SuspendLayout();
            this.tableLayoutAvoir.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelCheque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdd)).BeginInit();
            this.panelCheque2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLock)).BeginInit();
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
            this.tableLayoutContainer.Controls.Add(this.groupBoxAvoir, 0, 0);
            this.tableLayoutContainer.Controls.Add(this.panelFooter, 0, 5);
            this.tableLayoutContainer.Controls.Add(this.label2, 0, 1);
            this.tableLayoutContainer.Controls.Add(this.listViewFactures, 1, 1);
            this.tableLayoutContainer.Controls.Add(this.textBoxCreance, 1, 2);
            this.tableLayoutContainer.Controls.Add(this.textBoxObservation, 1, 4);
            this.tableLayoutContainer.Controls.Add(this.panel1, 2, 1);
            this.tableLayoutContainer.Controls.Add(this.panelCheque, 1, 3);
            this.tableLayoutContainer.Controls.Add(this.panelCheque2, 2, 3);
            this.tableLayoutContainer.Controls.Add(this.label6, 0, 4);
            this.tableLayoutContainer.Controls.Add(this.panel2, 2, 4);
            this.tableLayoutContainer.Controls.Add(this.checkBoxCreance, 0, 2);
            this.tableLayoutContainer.Controls.Add(this.checkBoxCheque, 0, 3);
            this.tableLayoutContainer.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutContainer.Name = "tableLayoutContainer";
            this.tableLayoutContainer.RowCount = 6;
            this.tableLayoutContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23F));
            this.tableLayoutContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23F));
            this.tableLayoutContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutContainer.Size = new System.Drawing.Size(840, 531);
            this.tableLayoutContainer.TabIndex = 0;
            // 
            // groupBoxAvoir
            // 
            this.groupBoxAvoir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutContainer.SetColumnSpan(this.groupBoxAvoir, 3);
            this.groupBoxAvoir.Controls.Add(this.tableLayoutAvoir);
            this.groupBoxAvoir.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBoxAvoir.Location = new System.Drawing.Point(3, 3);
            this.groupBoxAvoir.Name = "groupBoxAvoir";
            this.groupBoxAvoir.Size = new System.Drawing.Size(834, 104);
            this.groupBoxAvoir.TabIndex = 5;
            this.groupBoxAvoir.TabStop = false;
            this.groupBoxAvoir.Text = "Avoir Financier";
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
            this.tableLayoutAvoir.Controls.Add(this.label11, 0, 0);
            this.tableLayoutAvoir.Controls.Add(this.textBoxRefAvoir, 1, 0);
            this.tableLayoutAvoir.Controls.Add(this.label14, 2, 0);
            this.tableLayoutAvoir.Controls.Add(this.dateAvoir, 3, 0);
            this.tableLayoutAvoir.Controls.Add(this.textBoxMontantAv, 1, 1);
            this.tableLayoutAvoir.Controls.Add(this.textBoxDesc, 3, 1);
            this.tableLayoutAvoir.Controls.Add(this.label16, 0, 1);
            this.tableLayoutAvoir.Controls.Add(this.label12, 2, 1);
            this.tableLayoutAvoir.Location = new System.Drawing.Point(3, 24);
            this.tableLayoutAvoir.Name = "tableLayoutAvoir";
            this.tableLayoutAvoir.RowCount = 2;
            this.tableLayoutAvoir.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutAvoir.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutAvoir.Size = new System.Drawing.Size(822, 74);
            this.tableLayoutAvoir.TabIndex = 0;
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
            this.dateAvoir.ValueChanged += new System.EventHandler(this.dateAvoir_ValueChanged);
            // 
            // textBoxMontantAv
            // 
            this.textBoxMontantAv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMontantAv.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxMontantAv.Location = new System.Drawing.Point(126, 40);
            this.textBoxMontantAv.MaxLength = 21;
            this.textBoxMontantAv.Name = "textBoxMontantAv";
            this.textBoxMontantAv.Size = new System.Drawing.Size(222, 25);
            this.textBoxMontantAv.TabIndex = 3;
            this.textBoxMontantAv.TabStop = false;
            this.textBoxMontantAv.TextChanged += new System.EventHandler(this.textBoxMontantAv_TextChanged);
            this.textBoxMontantAv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMontantAv_KeyPress);
            this.textBoxMontantAv.Validated += new System.EventHandler(this.textBoxMontantAv_Validated);
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxDesc.Location = new System.Drawing.Point(618, 40);
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(201, 25);
            this.textBoxDesc.TabIndex = 6;
            this.textBoxDesc.TabStop = false;
            this.textBoxDesc.Text = "REMISE FINANCIERE";
            this.textBoxDesc.TextChanged += new System.EventHandler(this.textBoxDesc_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.DimGray;
            this.label16.Location = new System.Drawing.Point(3, 40);
            this.label16.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 17);
            this.label16.TabIndex = 0;
            this.label16.Text = "Montant (DA) *";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(495, 40);
            this.label12.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Description";
            // 
            // panelFooter
            // 
            this.panelFooter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutContainer.SetColumnSpan(this.panelFooter, 3);
            this.panelFooter.Controls.Add(this.tableLayoutPanel1);
            this.panelFooter.Location = new System.Drawing.Point(3, 479);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(834, 49);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(832, 46);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonValider
            // 
            this.buttonValider.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonValider.Image = global::ExpFinance.Properties.Resources.check;
            this.buttonValider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonValider.Location = new System.Drawing.Point(216, 5);
            this.buttonValider.Margin = new System.Windows.Forms.Padding(3, 3, 100, 3);
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
            this.buttonAnnuler.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAnnuler.Image = global::ExpFinance.Properties.Resources.cancel;
            this.buttonAnnuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAnnuler.Location = new System.Drawing.Point(516, 5);
            this.buttonAnnuler.Margin = new System.Windows.Forms.Padding(100, 3, 3, 3);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(100, 35);
            this.buttonAnnuler.TabIndex = 21;
            this.buttonAnnuler.TabStop = false;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Factures *";
            // 
            // listViewFactures
            // 
            this.listViewFactures.CheckBoxes = true;
            this.listViewFactures.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNum,
            this.columnDate,
            this.columnHTRZ,
            this.columnMarge});
            this.listViewFactures.FullRowSelect = true;
            this.listViewFactures.Location = new System.Drawing.Point(129, 125);
            this.listViewFactures.Name = "listViewFactures";
            this.listViewFactures.Size = new System.Drawing.Size(388, 91);
            this.listViewFactures.TabIndex = 8;
            this.listViewFactures.TabStop = false;
            this.listViewFactures.UseCompatibleStateImageBehavior = false;
            this.listViewFactures.View = System.Windows.Forms.View.Details;
            this.listViewFactures.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listViewFactures_ItemChecked);
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
            // textBoxCreance
            // 
            this.textBoxCreance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCreance.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxCreance.Location = new System.Drawing.Point(129, 247);
            this.textBoxCreance.MaxLength = 21;
            this.textBoxCreance.Name = "textBoxCreance";
            this.textBoxCreance.Size = new System.Drawing.Size(222, 25);
            this.textBoxCreance.TabIndex = 3;
            this.textBoxCreance.Text = "0,00";
            this.textBoxCreance.TextChanged += new System.EventHandler(this.textBoxCreance_TextChanged);
            this.textBoxCreance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMontantAv_KeyPress);
            this.textBoxCreance.Validated += new System.EventHandler(this.textBoxMontantAv_Validated);
            // 
            // textBoxObservation
            // 
            this.textBoxObservation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxObservation.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxObservation.Location = new System.Drawing.Point(129, 395);
            this.textBoxObservation.MaxLength = 255;
            this.textBoxObservation.Multiline = true;
            this.textBoxObservation.Name = "textBoxObservation";
            this.textBoxObservation.Size = new System.Drawing.Size(388, 78);
            this.textBoxObservation.TabIndex = 3;
            this.textBoxObservation.TextChanged += new System.EventHandler(this.textBoxObservation_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxHTRZ);
            this.panel1.Controls.Add(this.textBoxMarge);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(591, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 100);
            this.panel1.TabIndex = 9;
            // 
            // textBoxHTRZ
            // 
            this.textBoxHTRZ.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxHTRZ.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxHTRZ.Enabled = false;
            this.textBoxHTRZ.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxHTRZ.Location = new System.Drawing.Point(82, 24);
            this.textBoxHTRZ.Name = "textBoxHTRZ";
            this.textBoxHTRZ.Size = new System.Drawing.Size(137, 18);
            this.textBoxHTRZ.TabIndex = 9;
            this.textBoxHTRZ.Text = "0,00";
            // 
            // textBoxMarge
            // 
            this.textBoxMarge.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxMarge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMarge.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxMarge.Location = new System.Drawing.Point(82, 61);
            this.textBoxMarge.Name = "textBoxMarge";
            this.textBoxMarge.Size = new System.Drawing.Size(137, 18);
            this.textBoxMarge.TabIndex = 9;
            this.textBoxMarge.TabStop = false;
            this.textBoxMarge.Text = "0,00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Marge :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total :";
            // 
            // panelCheque
            // 
            this.panelCheque.Controls.Add(this.pictureBoxRemove);
            this.panelCheque.Controls.Add(this.pictureBoxAdd);
            this.panelCheque.Controls.Add(this.listBoxCheque);
            this.panelCheque.Location = new System.Drawing.Point(129, 289);
            this.panelCheque.Name = "panelCheque";
            this.panelCheque.Size = new System.Drawing.Size(423, 78);
            this.panelCheque.TabIndex = 11;
            // 
            // pictureBoxRemove
            // 
            this.pictureBoxRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxRemove.Image = global::ExpFinance.Properties.Resources.remove;
            this.pictureBoxRemove.Location = new System.Drawing.Point(394, 46);
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
            this.pictureBoxAdd.Location = new System.Drawing.Point(394, 14);
            this.pictureBoxAdd.Name = "pictureBoxAdd";
            this.pictureBoxAdd.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxAdd.TabIndex = 9;
            this.pictureBoxAdd.TabStop = false;
            this.pictureBoxAdd.Click += new System.EventHandler(this.BtnAddCheque_Click);
            // 
            // listBoxCheque
            // 
            this.listBoxCheque.FormattingEnabled = true;
            this.listBoxCheque.ItemHeight = 17;
            this.listBoxCheque.Location = new System.Drawing.Point(0, 2);
            this.listBoxCheque.MultiColumn = true;
            this.listBoxCheque.Name = "listBoxCheque";
            this.listBoxCheque.Size = new System.Drawing.Size(388, 72);
            this.listBoxCheque.TabIndex = 11;
            this.listBoxCheque.TabStop = false;
            // 
            // panelCheque2
            // 
            this.panelCheque2.Controls.Add(this.textBoxTotalCheque);
            this.panelCheque2.Controls.Add(this.label3);
            this.panelCheque2.Location = new System.Drawing.Point(591, 289);
            this.panelCheque2.Name = "panelCheque2";
            this.panelCheque2.Size = new System.Drawing.Size(239, 78);
            this.panelCheque2.TabIndex = 12;
            // 
            // textBoxTotalCheque
            // 
            this.textBoxTotalCheque.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxTotalCheque.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTotalCheque.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxTotalCheque.Location = new System.Drawing.Point(82, 27);
            this.textBoxTotalCheque.Name = "textBoxTotalCheque";
            this.textBoxTotalCheque.Size = new System.Drawing.Size(154, 18);
            this.textBoxTotalCheque.TabIndex = 12;
            this.textBoxTotalCheque.TabStop = false;
            this.textBoxTotalCheque.Text = "0,00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Total :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Observation *";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxReste);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(591, 395);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 78);
            this.panel2.TabIndex = 12;
            // 
            // textBoxReste
            // 
            this.textBoxReste.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxReste.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxReste.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxReste.Location = new System.Drawing.Point(82, 27);
            this.textBoxReste.Name = "textBoxReste";
            this.textBoxReste.Size = new System.Drawing.Size(154, 18);
            this.textBoxReste.TabIndex = 12;
            this.textBoxReste.TabStop = false;
            this.textBoxReste.Text = "0,00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Reste :";
            // 
            // checkBoxCreance
            // 
            this.checkBoxCreance.AutoSize = true;
            this.checkBoxCreance.Location = new System.Drawing.Point(3, 247);
            this.checkBoxCreance.Name = "checkBoxCreance";
            this.checkBoxCreance.Size = new System.Drawing.Size(103, 21);
            this.checkBoxCreance.TabIndex = 13;
            this.checkBoxCreance.TabStop = false;
            this.checkBoxCreance.Text = "Créance (DA)";
            this.checkBoxCreance.UseVisualStyleBackColor = true;
            this.checkBoxCreance.CheckedChanged += new System.EventHandler(this.checkBoxCreance_CheckedChanged);
            // 
            // checkBoxCheque
            // 
            this.checkBoxCheque.AutoSize = true;
            this.checkBoxCheque.Location = new System.Drawing.Point(3, 289);
            this.checkBoxCheque.Name = "checkBoxCheque";
            this.checkBoxCheque.Size = new System.Drawing.Size(71, 21);
            this.checkBoxCheque.TabIndex = 13;
            this.checkBoxCheque.TabStop = false;
            this.checkBoxCheque.Text = "Chèque";
            this.checkBoxCheque.UseVisualStyleBackColor = true;
            this.checkBoxCheque.CheckedChanged += new System.EventHandler(this.checkBoxCheque_CheckedChanged);
            // 
            // pictureBoxLock
            // 
            this.pictureBoxLock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxLock.Image = global::ExpFinance.Properties.Resources._lock;
            this.pictureBoxLock.Location = new System.Drawing.Point(831, 525);
            this.pictureBoxLock.Name = "pictureBoxLock";
            this.pictureBoxLock.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxLock.TabIndex = 1;
            this.pictureBoxLock.TabStop = false;
            this.pictureBoxLock.Visible = false;
            this.pictureBoxLock.DoubleClick += new System.EventHandler(this.pictureBoxLock_DoubleClick);
            // 
            // AvoirForm
            // 
            this.AcceptButton = this.buttonValider;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.buttonAnnuler;
            this.ClientSize = new System.Drawing.Size(858, 555);
            this.Controls.Add(this.pictureBoxLock);
            this.Controls.Add(this.tableLayoutContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AvoirForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nouvel Avoir Financier";
            this.Load += new System.EventHandler(this.AvoirForm_Load);
            this.tableLayoutContainer.ResumeLayout(false);
            this.tableLayoutContainer.PerformLayout();
            this.groupBoxAvoir.ResumeLayout(false);
            this.tableLayoutAvoir.ResumeLayout(false);
            this.tableLayoutAvoir.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelCheque.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdd)).EndInit();
            this.panelCheque2.ResumeLayout(false);
            this.panelCheque2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutContainer;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxDesc;
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
        private System.Windows.Forms.TextBox textBoxHTRZ;
        private System.Windows.Forms.TextBox textBoxMarge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader columnMarge;
        private System.Windows.Forms.PictureBox pictureBoxLock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxObservation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxReste;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxCreance;
        private System.Windows.Forms.CheckBox checkBoxCreance;
        private System.Windows.Forms.CheckBox checkBoxCheque;
    }
}