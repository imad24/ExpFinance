namespace ExpFinance
{
    partial class NewchequeForm
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
            this.groupBoxCheque = new System.Windows.Forms.GroupBox();
            this.tableLayoutCheque = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxRef = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxBank = new System.Windows.Forms.ComboBox();
            this.banqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.banqueDataSet = new ExpFinance.BanqueDataSet();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxMontant = new System.Windows.Forms.TextBox();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.banqueTableAdapter = new ExpFinance.BanqueDataSetTableAdapters.BANQUETableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.groupBoxCheque.SuspendLayout();
            this.tableLayoutCheque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.banqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banqueDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCheque
            // 
            this.groupBoxCheque.Controls.Add(this.tableLayoutCheque);
            this.groupBoxCheque.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBoxCheque.Location = new System.Drawing.Point(2, 11);
            this.groupBoxCheque.Name = "groupBoxCheque";
            this.groupBoxCheque.Size = new System.Drawing.Size(412, 368);
            this.groupBoxCheque.TabIndex = 6;
            this.groupBoxCheque.TabStop = false;
            this.groupBoxCheque.Text = "Informations Chèque";
            // 
            // tableLayoutCheque
            // 
            this.tableLayoutCheque.ColumnCount = 2;
            this.tableLayoutCheque.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.55721F));
            this.tableLayoutCheque.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.44279F));
            this.tableLayoutCheque.Controls.Add(this.label3, 0, 0);
            this.tableLayoutCheque.Controls.Add(this.textBoxNom, 1, 1);
            this.tableLayoutCheque.Controls.Add(this.textBoxRef, 1, 0);
            this.tableLayoutCheque.Controls.Add(this.label9, 0, 1);
            this.tableLayoutCheque.Controls.Add(this.buttonAjouter, 0, 6);
            this.tableLayoutCheque.Controls.Add(this.label6, 0, 5);
            this.tableLayoutCheque.Controls.Add(this.textBoxMontant, 1, 5);
            this.tableLayoutCheque.Controls.Add(this.label7, 0, 4);
            this.tableLayoutCheque.Controls.Add(this.dateTimePicker, 1, 4);
            this.tableLayoutCheque.Controls.Add(this.label5, 0, 3);
            this.tableLayoutCheque.Controls.Add(this.comboBoxBank, 1, 3);
            this.tableLayoutCheque.Controls.Add(this.label1, 0, 2);
            this.tableLayoutCheque.Controls.Add(this.textBoxDesc, 1, 2);
            this.tableLayoutCheque.Location = new System.Drawing.Point(3, 24);
            this.tableLayoutCheque.Name = "tableLayoutCheque";
            this.tableLayoutCheque.RowCount = 7;
            this.tableLayoutCheque.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutCheque.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutCheque.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutCheque.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutCheque.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutCheque.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutCheque.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutCheque.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutCheque.Size = new System.Drawing.Size(402, 339);
            this.tableLayoutCheque.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Référence";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(157, 50);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(222, 23);
            this.textBoxNom.TabIndex = 1;
            // 
            // textBoxRef
            // 
            this.textBoxRef.Location = new System.Drawing.Point(157, 3);
            this.textBoxRef.Name = "textBoxRef";
            this.textBoxRef.Size = new System.Drawing.Size(222, 23);
            this.textBoxRef.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(3, 50);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "À l\'ordre de";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(3, 144);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Banque";
            // 
            // comboBoxBank
            // 
            this.comboBoxBank.DataSource = this.banqueBindingSource;
            this.comboBoxBank.DisplayMember = "NOM_BANQUE";
            this.comboBoxBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBank.FormattingEnabled = true;
            this.comboBoxBank.Location = new System.Drawing.Point(157, 144);
            this.comboBoxBank.Name = "comboBoxBank";
            this.comboBoxBank.Size = new System.Drawing.Size(222, 23);
            this.comboBoxBank.TabIndex = 2;
            this.comboBoxBank.ValueMember = "CODE_BANQUE";
            // 
            // banqueBindingSource
            // 
            this.banqueBindingSource.DataMember = "Banque";
            this.banqueBindingSource.DataSource = this.banqueDataSet;
            // 
            // banqueDataSet
            // 
            this.banqueDataSet.DataSetName = "BanqueDataSet";
            this.banqueDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(3, 191);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Date";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(157, 191);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(222, 23);
            this.dateTimePicker.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(3, 238);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Montant";
            // 
            // textBoxMontant
            // 
            this.textBoxMontant.Location = new System.Drawing.Point(157, 238);
            this.textBoxMontant.Name = "textBoxMontant";
            this.textBoxMontant.Size = new System.Drawing.Size(222, 23);
            this.textBoxMontant.TabIndex = 5;
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutCheque.SetColumnSpan(this.buttonAjouter, 2);
            this.buttonAjouter.ForeColor = System.Drawing.Color.DimGray;
            this.buttonAjouter.Image = global::ExpFinance.Properties.Resources.add;
            this.buttonAjouter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAjouter.Location = new System.Drawing.Point(163, 295);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(75, 30);
            this.buttonAjouter.TabIndex = 5;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // banqueTableAdapter
            // 
            this.banqueTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(3, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Description";
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Location = new System.Drawing.Point(157, 97);
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(222, 23);
            this.textBoxDesc.TabIndex = 0;
            // 
            // NewchequeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(420, 383);
            this.Controls.Add(this.groupBoxCheque);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewchequeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nouveau chèque";
            this.Load += new System.EventHandler(this.NewchequeForm_Load);
            this.groupBoxCheque.ResumeLayout(false);
            this.tableLayoutCheque.ResumeLayout(false);
            this.tableLayoutCheque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.banqueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banqueDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCheque;
        private System.Windows.Forms.TableLayoutPanel tableLayoutCheque;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxRef;
        private System.Windows.Forms.ComboBox comboBoxBank;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxMontant;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Button buttonAjouter;
        private BanqueDataSet banqueDataSet;
        private System.Windows.Forms.BindingSource banqueBindingSource;
        private BanqueDataSetTableAdapters.BANQUETableAdapter banqueTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDesc;
    }
}