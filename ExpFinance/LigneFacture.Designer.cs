namespace ExpFinance
{
    partial class LigneFacture
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
            this.listViewLignes = new System.Windows.Forms.ListView();
            this.colNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colProduit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLot = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colQte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMarge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxHTRZ = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMarge = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewLignes
            // 
            this.listViewLignes.CheckBoxes = true;
            this.listViewLignes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNum,
            this.colProduit,
            this.colLot,
            this.colQte,
            this.colHT,
            this.colMarge});
            this.listViewLignes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewLignes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewLignes.FullRowSelect = true;
            this.listViewLignes.Location = new System.Drawing.Point(3, 4);
            this.listViewLignes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewLignes.Name = "listViewLignes";
            this.listViewLignes.ShowGroups = false;
            this.listViewLignes.Size = new System.Drawing.Size(545, 251);
            this.listViewLignes.TabIndex = 0;
            this.listViewLignes.UseCompatibleStateImageBehavior = false;
            this.listViewLignes.View = System.Windows.Forms.View.Details;
            this.listViewLignes.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewLignes_ColumnClick);
            this.listViewLignes.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listViewLignes_ItemChecked);
            // 
            // colNum
            // 
            this.colNum.Text = "Num";
            this.colNum.Width = 40;
            // 
            // colProduit
            // 
            this.colProduit.Text = "Produit";
            this.colProduit.Width = 80;
            // 
            // colLot
            // 
            this.colLot.Text = "Lot";
            this.colLot.Width = 80;
            // 
            // colQte
            // 
            this.colQte.Text = "Quantité";
            // 
            // colHT
            // 
            this.colHT.Text = "Montant HTR";
            this.colHT.Width = 100;
            // 
            // colMarge
            // 
            this.colMarge.Text = "Marge";
            this.colMarge.Width = 80;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.listViewLignes, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonOk, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(551, 370);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBoxHTRZ);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBoxMarge);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 263);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(545, 47);
            this.panel2.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total :";
            // 
            // textBoxHTRZ
            // 
            this.textBoxHTRZ.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxHTRZ.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxHTRZ.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxHTRZ.Location = new System.Drawing.Point(103, 16);
            this.textBoxHTRZ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxHTRZ.Name = "textBoxHTRZ";
            this.textBoxHTRZ.Size = new System.Drawing.Size(160, 18);
            this.textBoxHTRZ.TabIndex = 9;
            this.textBoxHTRZ.TabStop = false;
            this.textBoxHTRZ.Text = "0,00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(285, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Marge :";
            // 
            // textBoxMarge
            // 
            this.textBoxMarge.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxMarge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMarge.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxMarge.Location = new System.Drawing.Point(378, 16);
            this.textBoxMarge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxMarge.Name = "textBoxMarge";
            this.textBoxMarge.Size = new System.Drawing.Size(160, 18);
            this.textBoxMarge.TabIndex = 10;
            this.textBoxMarge.TabStop = false;
            this.textBoxMarge.Text = "0,00";
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonOk.Location = new System.Drawing.Point(232, 327);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(87, 30);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // LigneFacture
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 370);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LigneFacture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lignes Factures";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LigneFacture_FormClosing);
            this.Load += new System.EventHandler(this.LigneFacture_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewLignes;
        private System.Windows.Forms.ColumnHeader colNum;
        private System.Windows.Forms.ColumnHeader colProduit;
        private System.Windows.Forms.ColumnHeader colLot;
        private System.Windows.Forms.ColumnHeader colQte;
        private System.Windows.Forms.ColumnHeader colHT;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.ColumnHeader colMarge;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxHTRZ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxMarge;
    }
}