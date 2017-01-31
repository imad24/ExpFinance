namespace ExpFinance
{
    partial class EditAvoirsForm
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
            this.layoutContainer = new System.Windows.Forms.TableLayoutPanel();
            this.buttonEditAvoir = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonCancelAvoir = new System.Windows.Forms.Button();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gETLISTEAVOIRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listeAvoirDataSet1 = new ExpFinance.ListeAvoirDataSet();
            this.gridViewAvoir = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnumAvoir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcode_clien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomClient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldateAvoir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmontant = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmontantCheque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmontantCreance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLibre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gET_LISTE_AVOIRTableAdapter = new ExpFinance.ListeAvoirDataSetTableAdapters.GET_LISTE_AVOIRTableAdapter();
            this.layoutContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gETLISTEAVOIRBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listeAvoirDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAvoir)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutContainer
            // 
            this.layoutContainer.ColumnCount = 3;
            this.layoutContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.layoutContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.layoutContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.layoutContainer.Controls.Add(this.buttonEditAvoir, 0, 1);
            this.layoutContainer.Controls.Add(this.buttonClose, 0, 1);
            this.layoutContainer.Controls.Add(this.buttonCancelAvoir, 0, 1);
            this.layoutContainer.Controls.Add(this.gridControl, 0, 0);
            this.layoutContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutContainer.Location = new System.Drawing.Point(0, 0);
            this.layoutContainer.Name = "layoutContainer";
            this.layoutContainer.RowCount = 2;
            this.layoutContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.layoutContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.layoutContainer.Size = new System.Drawing.Size(996, 532);
            this.layoutContainer.TabIndex = 0;
            // 
            // buttonEditAvoir
            // 
            this.buttonEditAvoir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEditAvoir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEditAvoir.Location = new System.Drawing.Point(107, 487);
            this.buttonEditAvoir.Name = "buttonEditAvoir";
            this.buttonEditAvoir.Size = new System.Drawing.Size(118, 35);
            this.buttonEditAvoir.TabIndex = 3;
            this.buttonEditAvoir.Text = "Modifier Avoir";
            this.buttonEditAvoir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEditAvoir.UseVisualStyleBackColor = true;
            this.buttonEditAvoir.Click += new System.EventHandler(this.buttonEditAvoir_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClose.Location = new System.Drawing.Point(771, 487);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(118, 35);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "Fermer";
            this.buttonClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // buttonCancelAvoir
            // 
            this.buttonCancelAvoir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCancelAvoir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelAvoir.Location = new System.Drawing.Point(439, 487);
            this.buttonCancelAvoir.Name = "buttonCancelAvoir";
            this.buttonCancelAvoir.Size = new System.Drawing.Size(118, 35);
            this.buttonCancelAvoir.TabIndex = 1;
            this.buttonCancelAvoir.Text = "Annuler Avoir";
            this.buttonCancelAvoir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCancelAvoir.UseVisualStyleBackColor = true;
            // 
            // gridControl
            // 
            this.layoutContainer.SetColumnSpan(this.gridControl, 3);
            this.gridControl.DataSource = this.gETLISTEAVOIRBindingSource;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(3, 3);
            this.gridControl.MainView = this.gridViewAvoir;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(990, 472);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewAvoir});
            // 
            // gETLISTEAVOIRBindingSource
            // 
            this.gETLISTEAVOIRBindingSource.DataMember = "GET_LISTE_AVOIR";
            this.gETLISTEAVOIRBindingSource.DataSource = this.listeAvoirDataSet1;
            // 
            // listeAvoirDataSet1
            // 
            this.listeAvoirDataSet1.DataSetName = "ListeAvoirDataSet";
            this.listeAvoirDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewAvoir
            // 
            this.gridViewAvoir.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnumAvoir,
            this.colcode_clien,
            this.colNomClient,
            this.coldateAvoir,
            this.colmontant,
            this.colmontantCheque,
            this.colmontantCreance,
            this.colObservation,
            this.colLibre});
            this.gridViewAvoir.GridControl = this.gridControl;
            this.gridViewAvoir.Name = "gridViewAvoir";
            this.gridViewAvoir.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewAvoir.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewAvoir.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewAvoir.OptionsBehavior.Editable = false;
            this.gridViewAvoir.OptionsCustomization.AllowColumnMoving = false;
            this.gridViewAvoir.OptionsCustomization.AllowGroup = false;
            this.gridViewAvoir.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewAvoir.OptionsEditForm.ShowOnEnterKey = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewAvoir.OptionsEditForm.ShowOnF2Key = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewAvoir.OptionsFilter.AllowColumnMRUFilterList = false;
            this.gridViewAvoir.OptionsFilter.AllowFilterEditor = false;
            this.gridViewAvoir.OptionsFilter.FilterEditorUseMenuForOperandsAndOperators = false;
            this.gridViewAvoir.OptionsView.RowAutoHeight = true;
            this.gridViewAvoir.OptionsView.ShowGroupPanel = false;
            this.gridViewAvoir.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colnumAvoir, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // colnumAvoir
            // 
            this.colnumAvoir.Caption = "Numéro";
            this.colnumAvoir.FieldName = "numAvoir";
            this.colnumAvoir.Name = "colnumAvoir";
            this.colnumAvoir.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText;
            this.colnumAvoir.Visible = true;
            this.colnumAvoir.VisibleIndex = 0;
            this.colnumAvoir.Width = 60;
            // 
            // colcode_clien
            // 
            this.colcode_clien.Caption = "Code Client";
            this.colcode_clien.FieldName = "code_clien";
            this.colcode_clien.Name = "colcode_clien";
            this.colcode_clien.Visible = true;
            this.colcode_clien.VisibleIndex = 1;
            this.colcode_clien.Width = 66;
            // 
            // colNomClient
            // 
            this.colNomClient.FieldName = "NomClient";
            this.colNomClient.Name = "colNomClient";
            this.colNomClient.Visible = true;
            this.colNomClient.VisibleIndex = 2;
            this.colNomClient.Width = 156;
            // 
            // coldateAvoir
            // 
            this.coldateAvoir.Caption = "Date Avoir";
            this.coldateAvoir.DisplayFormat.FormatString = "d";
            this.coldateAvoir.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.coldateAvoir.FieldName = "dateAvoir";
            this.coldateAvoir.Name = "coldateAvoir";
            this.coldateAvoir.Visible = true;
            this.coldateAvoir.VisibleIndex = 3;
            this.coldateAvoir.Width = 104;
            // 
            // colmontant
            // 
            this.colmontant.Caption = "Montant";
            this.colmontant.DisplayFormat.FormatString = "N2";
            this.colmontant.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colmontant.FieldName = "montant";
            this.colmontant.Name = "colmontant";
            this.colmontant.Visible = true;
            this.colmontant.VisibleIndex = 4;
            this.colmontant.Width = 60;
            // 
            // colmontantCheque
            // 
            this.colmontantCheque.Caption = "Chèque";
            this.colmontantCheque.DisplayFormat.FormatString = "N2";
            this.colmontantCheque.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colmontantCheque.FieldName = "montantCheque";
            this.colmontantCheque.Name = "colmontantCheque";
            this.colmontantCheque.Visible = true;
            this.colmontantCheque.VisibleIndex = 5;
            this.colmontantCheque.Width = 81;
            // 
            // colmontantCreance
            // 
            this.colmontantCreance.Caption = "Créance";
            this.colmontantCreance.DisplayFormat.FormatString = "N2";
            this.colmontantCreance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colmontantCreance.FieldName = "montantCreance";
            this.colmontantCreance.Name = "colmontantCreance";
            this.colmontantCreance.Visible = true;
            this.colmontantCreance.VisibleIndex = 6;
            this.colmontantCreance.Width = 68;
            // 
            // colObservation
            // 
            this.colObservation.AppearanceCell.Options.UseTextOptions = true;
            this.colObservation.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colObservation.Caption = "Observation";
            this.colObservation.FieldName = "Observation";
            this.colObservation.Name = "colObservation";
            this.colObservation.Visible = true;
            this.colObservation.VisibleIndex = 7;
            this.colObservation.Width = 198;
            // 
            // colLibre
            // 
            this.colLibre.Caption = "Avoir Libre";
            this.colLibre.FieldName = "Libre";
            this.colLibre.Name = "colLibre";
            this.colLibre.Visible = true;
            this.colLibre.VisibleIndex = 8;
            this.colLibre.Width = 179;
            // 
            // gET_LISTE_AVOIRTableAdapter
            // 
            this.gET_LISTE_AVOIRTableAdapter.ClearBeforeFill = true;
            // 
            // EditAvoirsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 532);
            this.Controls.Add(this.layoutContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DimGray;
            this.Name = "EditAvoirsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste des Avoirs Validés";
            this.Load += new System.EventHandler(this.EditAvoir_Load);
            this.layoutContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gETLISTEAVOIRBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listeAvoirDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAvoir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutContainer;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewAvoir;
        private ListeAvoirDataSet listeAvoirDataSet1;
        private DevExpress.XtraGrid.Columns.GridColumn colnumAvoir;
        private DevExpress.XtraGrid.Columns.GridColumn coldateAvoir;
        private DevExpress.XtraGrid.Columns.GridColumn colmontant;
        private DevExpress.XtraGrid.Columns.GridColumn colmontantCheque;
        private DevExpress.XtraGrid.Columns.GridColumn colmontantCreance;
        private DevExpress.XtraGrid.Columns.GridColumn colObservation;
        private DevExpress.XtraGrid.Columns.GridColumn colNomClient;
        private DevExpress.XtraGrid.Columns.GridColumn colcode_clien;
        private DevExpress.XtraGrid.Columns.GridColumn colLibre;
        private System.Windows.Forms.BindingSource gETLISTEAVOIRBindingSource;
        private ListeAvoirDataSetTableAdapters.GET_LISTE_AVOIRTableAdapter gET_LISTE_AVOIRTableAdapter;
        private System.Windows.Forms.Button buttonEditAvoir;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonCancelAvoir;
    }
}