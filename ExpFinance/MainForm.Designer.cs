namespace ExpFinance
{
    partial class MainForm
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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression1 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue1 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule3 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue2 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule4 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue3 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule5 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue4 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.colEtat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridBordereau = new DevExpress.XtraGrid.GridControl();
            this.bordereauDataSet2 = new ExpFinance.BordereauDataSet();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_GROUPE_FACT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOM_PROMOTION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMontant = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaux = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemise = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemise_supp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColDateDossier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.bordereauDataSet1 = new ExpFinance.BordereauDataSet();
            this.tableLayoutContainer = new System.Windows.Forms.TableLayoutPanel();
            this.panelDetails = new System.Windows.Forms.Panel();
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPromotion = new System.Windows.Forms.TextBox();
            this.textBoxClient = new System.Windows.Forms.TextBox();
            this.textBoxDateD = new System.Windows.Forms.TextBox();
            this.tableFactures = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxMargeRest = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMarge = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxTypePromo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxNumDossier = new System.Windows.Forms.TextBox();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.tableLayoutFooter = new System.Windows.Forms.TableLayoutPanel();
            this.buttonGenerAvoir = new System.Windows.Forms.Button();
            this.buttonNouvelAvoir = new System.Windows.Forms.Button();
            this.buttonRapport = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.panelDate = new System.Windows.Forms.Panel();
            this.textBoxFactures = new System.Windows.Forms.TextBox();
            this.pictureBoxGoDate = new System.Windows.Forms.PictureBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textBoxAlert = new System.Windows.Forms.TextBox();
            this.tableLayoutLegend = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labelRejet = new System.Windows.Forms.Label();
            this.labelRecu = new System.Windows.Forms.Label();
            this.labelInstance = new System.Windows.Forms.Label();
            this.dataTableBordereauTableAdapter1 = new ExpFinance.BordereauDataSetTableAdapters.DossiersPromotionTableAdapter();
            this.dossiersPromotionTableAdapter1 = new ExpFinance.BordereauDataSetTableAdapters.DossiersPromotionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridBordereau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bordereauDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bordereauDataSet1)).BeginInit();
            this.tableLayoutContainer.SuspendLayout();
            this.panelDetails.SuspendLayout();
            this.groupBoxDetails.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.tableLayoutFooter.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panelDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoDate)).BeginInit();
            this.tableLayoutLegend.SuspendLayout();
            this.SuspendLayout();
            // 
            // colEtat
            // 
            this.colEtat.Caption = "État";
            this.colEtat.FieldName = "etat";
            this.colEtat.Name = "colEtat";
            this.colEtat.Visible = true;
            this.colEtat.VisibleIndex = 9;
            // 
            // gridBordereau
            // 
            this.gridBordereau.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutContainer.SetColumnSpan(this.gridBordereau, 2);
            this.gridBordereau.DataMember = "DossiersPromotion";
            this.gridBordereau.DataSource = this.bordereauDataSet2;
            this.gridBordereau.Location = new System.Drawing.Point(3, 84);
            this.gridBordereau.MainView = this.gridView;
            this.gridBordereau.Name = "gridBordereau";
            this.gridBordereau.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1});
            this.gridBordereau.Size = new System.Drawing.Size(987, 215);
            this.gridBordereau.TabIndex = 0;
            this.gridBordereau.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            this.gridBordereau.DoubleClick += new System.EventHandler(this.buttonGenerAvoir_Click);
            this.gridBordereau.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseClick);
            // 
            // bordereauDataSet2
            // 
            this.bordereauDataSet2.DataSetName = "BordereauDataSet";
            this.bordereauDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView
            // 
            this.gridView.Appearance.FocusedRow.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.gridView.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView.Appearance.SelectedRow.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.gridView.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_GROUPE_FACT,
            this.colNOM,
            this.colNOM_PROMOTION,
            this.colMontant,
            this.colTaux,
            this.colRemise,
            this.colRemise_supp,
            this.colTotal,
            this.ColDateDossier,
            this.colEtat});
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Enabled = false;
            gridFormatRule1.Name = "Check_remise/taux";
            formatConditionRuleExpression1.Expression = "Round([Montant] * [Taux]/100,2) !=Round([Remise],2) \r\nAnd [Taux]!=0\r\nAnd( Round([" +
    "Montant] * [Taux]/100,2) + 0.01) !=Round([Remise],2)";
            formatConditionRuleExpression1.PredefinedName = "Red Fill, Red Text";
            gridFormatRule1.Rule = formatConditionRuleExpression1;
            gridFormatRule2.Column = this.colEtat;
            gridFormatRule2.ColumnApplyTo = this.colEtat;
            gridFormatRule2.Name = "rejete";
            formatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(68)))), ((int)(((byte)(36)))));
            formatConditionRuleValue1.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(68)))), ((int)(((byte)(36)))));
            formatConditionRuleValue1.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            formatConditionRuleValue1.Appearance.Options.HighPriority = true;
            formatConditionRuleValue1.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue1.Appearance.Options.UseBorderColor = true;
            formatConditionRuleValue1.Appearance.Options.UseForeColor = true;
            formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Expression;
            formatConditionRuleValue1.Expression = "[etat]=\'REJETÉ\'";
            gridFormatRule2.Rule = formatConditionRuleValue1;
            gridFormatRule3.Column = this.colEtat;
            gridFormatRule3.ColumnApplyTo = this.colEtat;
            gridFormatRule3.Name = "recu";
            formatConditionRuleValue2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(188)))), ((int)(((byte)(219)))));
            formatConditionRuleValue2.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(188)))), ((int)(((byte)(219)))));
            formatConditionRuleValue2.Appearance.ForeColor = System.Drawing.Color.White;
            formatConditionRuleValue2.Appearance.Options.HighPriority = true;
            formatConditionRuleValue2.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue2.Appearance.Options.UseBorderColor = true;
            formatConditionRuleValue2.Appearance.Options.UseForeColor = true;
            formatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Expression;
            formatConditionRuleValue2.Expression = "[etat]=\'REÇU\'";
            gridFormatRule3.Rule = formatConditionRuleValue2;
            gridFormatRule4.Column = this.colEtat;
            gridFormatRule4.ColumnApplyTo = this.colEtat;
            gridFormatRule4.Name = "valide";
            formatConditionRuleValue3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(171)))), ((int)(((byte)(88)))));
            formatConditionRuleValue3.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(171)))), ((int)(((byte)(88)))));
            formatConditionRuleValue3.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            formatConditionRuleValue3.Appearance.Options.HighPriority = true;
            formatConditionRuleValue3.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue3.Appearance.Options.UseBorderColor = true;
            formatConditionRuleValue3.Appearance.Options.UseForeColor = true;
            formatConditionRuleValue3.Condition = DevExpress.XtraEditors.FormatCondition.Expression;
            formatConditionRuleValue3.Expression = "[etat]=\'VALIDÉ\'";
            gridFormatRule4.Rule = formatConditionRuleValue3;
            gridFormatRule5.Column = this.colEtat;
            gridFormatRule5.ColumnApplyTo = this.colEtat;
            gridFormatRule5.Name = "instance";
            formatConditionRuleValue4.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            formatConditionRuleValue4.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue4.Condition = DevExpress.XtraEditors.FormatCondition.Expression;
            formatConditionRuleValue4.Expression = "[etat]==\'EN INSTANCE\'";
            gridFormatRule5.Rule = formatConditionRuleValue4;
            this.gridView.FormatRules.Add(gridFormatRule1);
            this.gridView.FormatRules.Add(gridFormatRule2);
            this.gridView.FormatRules.Add(gridFormatRule3);
            this.gridView.FormatRules.Add(gridFormatRule4);
            this.gridView.FormatRules.Add(gridFormatRule5);
            this.gridView.GridControl = this.gridBordereau;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False;
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsCustomization.AllowColumnMoving = false;
            this.gridView.OptionsCustomization.AllowGroup = false;
            this.gridView.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.False;
            this.gridView.OptionsFilter.AllowColumnMRUFilterList = false;
            this.gridView.OptionsFilter.AllowFilterEditor = false;
            this.gridView.OptionsFilter.AllowMRUFilterList = false;
            this.gridView.OptionsFilter.FilterEditorUseMenuForOperandsAndOperators = false;
            this.gridView.OptionsSelection.CheckBoxSelectorColumnWidth = 20;
            this.gridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView.OptionsSelection.MultiSelect = true;
            this.gridView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridView_SelectionChanged);
            this.gridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_FocusedRowChanged);
            this.gridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView_KeyDown);
            this.gridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridView_MouseDown);
            // 
            // colID_GROUPE_FACT
            // 
            this.colID_GROUPE_FACT.FieldName = "ID_GROUPE_FACT";
            this.colID_GROUPE_FACT.Name = "colID_GROUPE_FACT";
            // 
            // colNOM
            // 
            this.colNOM.FieldName = "NOM";
            this.colNOM.Name = "colNOM";
            this.colNOM.Visible = true;
            this.colNOM.VisibleIndex = 1;
            this.colNOM.Width = 138;
            // 
            // colNOM_PROMOTION
            // 
            this.colNOM_PROMOTION.FieldName = "NOM_PROMOTION";
            this.colNOM_PROMOTION.Name = "colNOM_PROMOTION";
            this.colNOM_PROMOTION.Visible = true;
            this.colNOM_PROMOTION.VisibleIndex = 2;
            this.colNOM_PROMOTION.Width = 160;
            // 
            // colMontant
            // 
            this.colMontant.DisplayFormat.FormatString = "N2";
            this.colMontant.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colMontant.FieldName = "Montant";
            this.colMontant.Name = "colMontant";
            this.colMontant.Visible = true;
            this.colMontant.VisibleIndex = 3;
            this.colMontant.Width = 78;
            // 
            // colTaux
            // 
            this.colTaux.Caption = "Taux %";
            this.colTaux.DisplayFormat.FormatString = "N2";
            this.colTaux.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colTaux.FieldName = "Taux";
            this.colTaux.Name = "colTaux";
            this.colTaux.Visible = true;
            this.colTaux.VisibleIndex = 4;
            this.colTaux.Width = 78;
            // 
            // colRemise
            // 
            this.colRemise.DisplayFormat.FormatString = "N2";
            this.colRemise.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colRemise.FieldName = "Remise";
            this.colRemise.Name = "colRemise";
            this.colRemise.Visible = true;
            this.colRemise.VisibleIndex = 5;
            this.colRemise.Width = 78;
            // 
            // colRemise_supp
            // 
            this.colRemise_supp.Caption = "Remise_UG";
            this.colRemise_supp.DisplayFormat.FormatString = "N2";
            this.colRemise_supp.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colRemise_supp.FieldName = "Remise_supp";
            this.colRemise_supp.Name = "colRemise_supp";
            this.colRemise_supp.Visible = true;
            this.colRemise_supp.VisibleIndex = 6;
            this.colRemise_supp.Width = 78;
            // 
            // colTotal
            // 
            this.colTotal.DisplayFormat.FormatString = "N2";
            this.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colTotal.FieldName = "Total_Remise";
            this.colTotal.Name = "colTotal";
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 7;
            this.colTotal.Width = 86;
            // 
            // ColDateDossier
            // 
            this.ColDateDossier.Caption = "Date Dossier";
            this.ColDateDossier.DisplayFormat.FormatString = "d";
            this.ColDateDossier.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ColDateDossier.FieldName = "date_dossier";
            this.ColDateDossier.Name = "ColDateDossier";
            this.ColDateDossier.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.List;
            this.ColDateDossier.Visible = true;
            this.ColDateDossier.VisibleIndex = 8;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // bordereauDataSet1
            // 
            this.bordereauDataSet1.DataSetName = "BordereauDataSet";
            this.bordereauDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableLayoutContainer
            // 
            this.tableLayoutContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutContainer.ColumnCount = 2;
            this.tableLayoutContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutContainer.Controls.Add(this.gridBordereau, 0, 2);
            this.tableLayoutContainer.Controls.Add(this.panelDetails, 0, 3);
            this.tableLayoutContainer.Controls.Add(this.panelFooter, 0, 4);
            this.tableLayoutContainer.Controls.Add(this.panelLogo, 0, 0);
            this.tableLayoutContainer.Controls.Add(this.panelDate, 1, 0);
            this.tableLayoutContainer.Controls.Add(this.textBoxAlert, 1, 1);
            this.tableLayoutContainer.Controls.Add(this.tableLayoutLegend, 0, 1);
            this.tableLayoutContainer.Location = new System.Drawing.Point(12, 3);
            this.tableLayoutContainer.Name = "tableLayoutContainer";
            this.tableLayoutContainer.RowCount = 5;
            this.tableLayoutContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this.tableLayoutContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this.tableLayoutContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutContainer.Size = new System.Drawing.Size(993, 584);
            this.tableLayoutContainer.TabIndex = 1;
            this.tableLayoutContainer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseClick);
            // 
            // panelDetails
            // 
            this.panelDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutContainer.SetColumnSpan(this.panelDetails, 2);
            this.panelDetails.Controls.Add(this.groupBoxDetails);
            this.panelDetails.Location = new System.Drawing.Point(3, 305);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(987, 215);
            this.panelDetails.TabIndex = 2;
            // 
            // groupBoxDetails
            // 
            this.groupBoxDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDetails.Controls.Add(this.tableLayoutPanel2);
            this.groupBoxDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDetails.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBoxDetails.Location = new System.Drawing.Point(3, 3);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Size = new System.Drawing.Size(975, 209);
            this.groupBoxDetails.TabIndex = 1;
            this.groupBoxDetails.TabStop = false;
            this.groupBoxDetails.Text = "Détails Dossier";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.textBoxPromotion, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxClient, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBoxDateD, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableFactures, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label6, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.textBoxMargeRest, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.label5, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBoxMarge, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.label8, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxTypePromo, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.label7, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBoxNumDossier, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 25);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(963, 183);
            this.tableLayoutPanel2.TabIndex = 0;
            this.tableLayoutPanel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Promotion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(3, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Client";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(3, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Date Dossier";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(3, 138);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Factures";
            // 
            // textBoxPromotion
            // 
            this.textBoxPromotion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxPromotion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPromotion.Enabled = false;
            this.textBoxPromotion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPromotion.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxPromotion.Location = new System.Drawing.Point(147, 3);
            this.textBoxPromotion.Name = "textBoxPromotion";
            this.textBoxPromotion.Size = new System.Drawing.Size(310, 18);
            this.textBoxPromotion.TabIndex = 1;
            // 
            // textBoxClient
            // 
            this.textBoxClient.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxClient.Enabled = false;
            this.textBoxClient.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxClient.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxClient.Location = new System.Drawing.Point(147, 48);
            this.textBoxClient.Name = "textBoxClient";
            this.textBoxClient.Size = new System.Drawing.Size(310, 18);
            this.textBoxClient.TabIndex = 1;
            // 
            // textBoxDateD
            // 
            this.textBoxDateD.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxDateD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDateD.Enabled = false;
            this.textBoxDateD.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDateD.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxDateD.Location = new System.Drawing.Point(147, 93);
            this.textBoxDateD.Name = "textBoxDateD";
            this.textBoxDateD.Size = new System.Drawing.Size(310, 18);
            this.textBoxDateD.TabIndex = 1;
            // 
            // tableFactures
            // 
            this.tableFactures.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableFactures.ColumnCount = 6;
            this.tableFactures.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableFactures.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableFactures.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableFactures.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableFactures.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableFactures.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableFactures.Location = new System.Drawing.Point(144, 138);
            this.tableFactures.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.tableFactures.Name = "tableFactures";
            this.tableFactures.RowCount = 2;
            this.tableFactures.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableFactures.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableFactures.Size = new System.Drawing.Size(334, 42);
            this.tableFactures.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(484, 138);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Marge Rest. / Taux";
            // 
            // textBoxMargeRest
            // 
            this.textBoxMargeRest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMargeRest.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxMargeRest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMargeRest.Enabled = false;
            this.textBoxMargeRest.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMargeRest.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxMargeRest.Location = new System.Drawing.Point(628, 138);
            this.textBoxMargeRest.Name = "textBoxMargeRest";
            this.textBoxMargeRest.Size = new System.Drawing.Size(332, 18);
            this.textBoxMargeRest.TabIndex = 1;
            this.textBoxMargeRest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(484, 93);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Marge / Taux";
            // 
            // textBoxMarge
            // 
            this.textBoxMarge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMarge.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxMarge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMarge.Enabled = false;
            this.textBoxMarge.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMarge.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxMarge.Location = new System.Drawing.Point(628, 93);
            this.textBoxMarge.Name = "textBoxMarge";
            this.textBoxMarge.Size = new System.Drawing.Size(332, 18);
            this.textBoxMarge.TabIndex = 1;
            this.textBoxMarge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(484, 3);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Numéro Dossier";
            // 
            // textBoxTypePromo
            // 
            this.textBoxTypePromo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTypePromo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxTypePromo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTypePromo.Enabled = false;
            this.textBoxTypePromo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTypePromo.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxTypePromo.Location = new System.Drawing.Point(628, 48);
            this.textBoxTypePromo.Name = "textBoxTypePromo";
            this.textBoxTypePromo.Size = new System.Drawing.Size(332, 18);
            this.textBoxTypePromo.TabIndex = 1;
            this.textBoxTypePromo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(484, 48);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Type Promotion";
            // 
            // textBoxNumDossier
            // 
            this.textBoxNumDossier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNumDossier.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxNumDossier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNumDossier.Enabled = false;
            this.textBoxNumDossier.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumDossier.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxNumDossier.Location = new System.Drawing.Point(628, 3);
            this.textBoxNumDossier.Name = "textBoxNumDossier";
            this.textBoxNumDossier.Size = new System.Drawing.Size(332, 18);
            this.textBoxNumDossier.TabIndex = 1;
            this.textBoxNumDossier.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panelFooter
            // 
            this.panelFooter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutContainer.SetColumnSpan(this.panelFooter, 2);
            this.panelFooter.Controls.Add(this.tableLayoutFooter);
            this.panelFooter.Location = new System.Drawing.Point(3, 526);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(987, 55);
            this.panelFooter.TabIndex = 3;
            // 
            // tableLayoutFooter
            // 
            this.tableLayoutFooter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutFooter.ColumnCount = 4;
            this.tableLayoutFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutFooter.Controls.Add(this.buttonGenerAvoir, 0, 0);
            this.tableLayoutFooter.Controls.Add(this.buttonNouvelAvoir, 1, 0);
            this.tableLayoutFooter.Controls.Add(this.buttonRapport, 2, 0);
            this.tableLayoutFooter.Controls.Add(this.buttonCancel, 3, 0);
            this.tableLayoutFooter.Location = new System.Drawing.Point(3, 1);
            this.tableLayoutFooter.Name = "tableLayoutFooter";
            this.tableLayoutFooter.RowCount = 1;
            this.tableLayoutFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutFooter.Size = new System.Drawing.Size(982, 50);
            this.tableLayoutFooter.TabIndex = 0;
            this.tableLayoutFooter.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseClick);
            // 
            // buttonGenerAvoir
            // 
            this.buttonGenerAvoir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonGenerAvoir.Image = global::ExpFinance.Properties.Resources.calculator;
            this.buttonGenerAvoir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGenerAvoir.Location = new System.Drawing.Point(63, 7);
            this.buttonGenerAvoir.Name = "buttonGenerAvoir";
            this.buttonGenerAvoir.Size = new System.Drawing.Size(118, 35);
            this.buttonGenerAvoir.TabIndex = 0;
            this.buttonGenerAvoir.Text = "Créer Avoir F.";
            this.buttonGenerAvoir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonGenerAvoir.UseVisualStyleBackColor = true;
            this.buttonGenerAvoir.Click += new System.EventHandler(this.buttonGenerAvoir_Click);
            // 
            // buttonNouvelAvoir
            // 
            this.buttonNouvelAvoir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNouvelAvoir.Image = global::ExpFinance.Properties.Resources.newavoir;
            this.buttonNouvelAvoir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNouvelAvoir.Location = new System.Drawing.Point(308, 7);
            this.buttonNouvelAvoir.Name = "buttonNouvelAvoir";
            this.buttonNouvelAvoir.Size = new System.Drawing.Size(118, 35);
            this.buttonNouvelAvoir.TabIndex = 0;
            this.buttonNouvelAvoir.Text = "Avoir F. Libre";
            this.buttonNouvelAvoir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonNouvelAvoir.UseVisualStyleBackColor = true;
            this.buttonNouvelAvoir.Click += new System.EventHandler(this.buttonNouvelAvoir_Click);
            // 
            // buttonRapport
            // 
            this.buttonRapport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRapport.Image = global::ExpFinance.Properties.Resources.rapport;
            this.buttonRapport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRapport.Location = new System.Drawing.Point(557, 7);
            this.buttonRapport.Name = "buttonRapport";
            this.buttonRapport.Size = new System.Drawing.Size(110, 35);
            this.buttonRapport.TabIndex = 0;
            this.buttonRapport.Text = "Rapports";
            this.buttonRapport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRapport.UseVisualStyleBackColor = true;
            this.buttonRapport.Click += new System.EventHandler(this.buttonRapport_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCancel.Image = global::ExpFinance.Properties.Resources.cancel;
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.Location = new System.Drawing.Point(803, 7);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(110, 35);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "Annuler";
            this.buttonCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.label9);
            this.panelLogo.Controls.Add(this.logo);
            this.panelLogo.Location = new System.Drawing.Point(3, 3);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(490, 40);
            this.panelLogo.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label9.Location = new System.Drawing.Point(56, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(233, 21);
            this.label9.TabIndex = 6;
            this.label9.Text = "Gestion Des Avoirs Financiers";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // logo
            // 
            this.logo.Image = global::ExpFinance.Properties.Resources.logo;
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(50, 50);
            this.logo.TabIndex = 5;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // panelDate
            // 
            this.panelDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDate.Controls.Add(this.textBoxFactures);
            this.panelDate.Controls.Add(this.pictureBoxGoDate);
            this.panelDate.Controls.Add(this.dateTimePicker);
            this.panelDate.Location = new System.Drawing.Point(499, 3);
            this.panelDate.Name = "panelDate";
            this.panelDate.Size = new System.Drawing.Size(491, 40);
            this.panelDate.TabIndex = 5;
            // 
            // textBoxFactures
            // 
            this.textBoxFactures.Location = new System.Drawing.Point(16, 7);
            this.textBoxFactures.Name = "textBoxFactures";
            this.textBoxFactures.Size = new System.Drawing.Size(211, 25);
            this.textBoxFactures.TabIndex = 6;
            this.textBoxFactures.Visible = false;
            // 
            // pictureBoxGoDate
            // 
            this.pictureBoxGoDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxGoDate.Image = global::ExpFinance.Properties.Resources.tick;
            this.pictureBoxGoDate.Location = new System.Drawing.Point(257, 11);
            this.pictureBoxGoDate.Name = "pictureBoxGoDate";
            this.pictureBoxGoDate.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxGoDate.TabIndex = 5;
            this.pictureBoxGoDate.TabStop = false;
            this.pictureBoxGoDate.Click += new System.EventHandler(this.pictureBoxGoDate_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dateTimePicker.Location = new System.Drawing.Point(289, 8);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            this.dateTimePicker.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker.TabIndex = 4;
            // 
            // textBoxAlert
            // 
            this.textBoxAlert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAlert.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxAlert.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAlert.ForeColor = System.Drawing.Color.Tomato;
            this.textBoxAlert.Location = new System.Drawing.Point(499, 60);
            this.textBoxAlert.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.textBoxAlert.Name = "textBoxAlert";
            this.textBoxAlert.Size = new System.Drawing.Size(484, 18);
            this.textBoxAlert.TabIndex = 7;
            this.textBoxAlert.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tableLayoutLegend
            // 
            this.tableLayoutLegend.ColumnCount = 6;
            this.tableLayoutLegend.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.000799F));
            this.tableLayoutLegend.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.33253F));
            this.tableLayoutLegend.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.000799F));
            this.tableLayoutLegend.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.33253F));
            this.tableLayoutLegend.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.000799F));
            this.tableLayoutLegend.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.33253F));
            this.tableLayoutLegend.Controls.Add(this.label10, 0, 0);
            this.tableLayoutLegend.Controls.Add(this.label11, 2, 0);
            this.tableLayoutLegend.Controls.Add(this.label12, 4, 0);
            this.tableLayoutLegend.Controls.Add(this.labelRejet, 1, 0);
            this.tableLayoutLegend.Controls.Add(this.labelRecu, 3, 0);
            this.tableLayoutLegend.Controls.Add(this.labelInstance, 5, 0);
            this.tableLayoutLegend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutLegend.Location = new System.Drawing.Point(3, 49);
            this.tableLayoutLegend.Name = "tableLayoutLegend";
            this.tableLayoutLegend.RowCount = 1;
            this.tableLayoutLegend.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutLegend.Size = new System.Drawing.Size(490, 29);
            this.tableLayoutLegend.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label10.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label10.Location = new System.Drawing.Point(3, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "F1:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label11.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label11.Location = new System.Drawing.Point(166, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "F2:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label12.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label12.Location = new System.Drawing.Point(329, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "F3:";
            // 
            // labelRejet
            // 
            this.labelRejet.AutoSize = true;
            this.labelRejet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelRejet.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelRejet.Location = new System.Drawing.Point(42, 12);
            this.labelRejet.Name = "labelRejet";
            this.labelRejet.Size = new System.Drawing.Size(118, 17);
            this.labelRejet.TabIndex = 1;
            this.labelRejet.Text = "REJETÉ";
            this.labelRejet.Click += new System.EventHandler(this.labelRejet_Click);
            // 
            // labelRecu
            // 
            this.labelRecu.AutoSize = true;
            this.labelRecu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelRecu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelRecu.Location = new System.Drawing.Point(205, 12);
            this.labelRecu.Name = "labelRecu";
            this.labelRecu.Size = new System.Drawing.Size(118, 17);
            this.labelRecu.TabIndex = 1;
            this.labelRecu.Text = "REÇU";
            this.labelRecu.Click += new System.EventHandler(this.labelRecu_Click);
            // 
            // labelInstance
            // 
            this.labelInstance.AutoSize = true;
            this.labelInstance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelInstance.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelInstance.Location = new System.Drawing.Point(368, 12);
            this.labelInstance.Name = "labelInstance";
            this.labelInstance.Size = new System.Drawing.Size(119, 17);
            this.labelInstance.TabIndex = 1;
            this.labelInstance.Text = "EN INSTANCE";
            this.labelInstance.Click += new System.EventHandler(this.labelInstance_Click);
            // 
            // dataTableBordereauTableAdapter1
            // 
            this.dataTableBordereauTableAdapter1.ClearBeforeFill = true;
            // 
            // dossiersPromotionTableAdapter1
            // 
            this.dossiersPromotionTableAdapter1.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1009, 587);
            this.Controls.Add(this.tableLayoutContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.gridBordereau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bordereauDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bordereauDataSet1)).EndInit();
            this.tableLayoutContainer.ResumeLayout(false);
            this.tableLayoutContainer.PerformLayout();
            this.panelDetails.ResumeLayout(false);
            this.groupBoxDetails.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.tableLayoutFooter.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panelDate.ResumeLayout(false);
            this.panelDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoDate)).EndInit();
            this.tableLayoutLegend.ResumeLayout(false);
            this.tableLayoutLegend.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridBordereau;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutContainer;
        private BordereauDataSet bordereauDataSet1;
        private BordereauDataSetTableAdapters.DossiersPromotionTableAdapter dataTableBordereauTableAdapter1;
        private System.Windows.Forms.Panel panelDetails;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPromotion;
        private System.Windows.Forms.TextBox textBoxClient;
        private System.Windows.Forms.TextBox textBoxDateD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutFooter;
        private System.Windows.Forms.Button buttonGenerAvoir;
        private System.Windows.Forms.Button buttonNouvelAvoir;
        private System.Windows.Forms.Button buttonRapport;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxMarge;
        private System.Windows.Forms.TextBox textBoxMargeRest;
        private System.Windows.Forms.TextBox textBoxTypePromo;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.GroupBox groupBoxDetails;
        private BordereauDataSet bordereauDataSet2;
        private BordereauDataSetTableAdapters.DossiersPromotionTableAdapter dossiersPromotionTableAdapter1;
        private DevExpress.XtraGrid.Columns.GridColumn colID_GROUPE_FACT;
        private DevExpress.XtraGrid.Columns.GridColumn colNOM;
        private DevExpress.XtraGrid.Columns.GridColumn colNOM_PROMOTION;
        private DevExpress.XtraGrid.Columns.GridColumn colMontant;
        private DevExpress.XtraGrid.Columns.GridColumn colTaux;
        private DevExpress.XtraGrid.Columns.GridColumn colRemise;
        private DevExpress.XtraGrid.Columns.GridColumn colRemise_supp;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private System.Windows.Forms.Panel panelDate;
        private System.Windows.Forms.PictureBox pictureBoxGoDate;
        private System.Windows.Forms.TableLayoutPanel tableFactures;
        private System.Windows.Forms.TextBox textBoxFactures;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxNumDossier;
        private DevExpress.XtraGrid.Columns.GridColumn colEtat;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private System.Windows.Forms.TextBox textBoxAlert;
        private System.Windows.Forms.TableLayoutPanel tableLayoutLegend;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelRejet;
        private System.Windows.Forms.Label labelRecu;
        private System.Windows.Forms.Label labelInstance;
        private DevExpress.XtraGrid.Columns.GridColumn ColDateDossier;
    }
}

