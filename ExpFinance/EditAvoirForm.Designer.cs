namespace ExpFinance
{
    partial class EditAvoirForm
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
            this.layoutContainer = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.labelDes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxReste = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxObservation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMontantAv = new System.Windows.Forms.TextBox();
            this.textBoxCreance = new System.Windows.Forms.TextBox();
            this.checkBoxCheque = new System.Windows.Forms.CheckBox();
            this.panelCheque = new System.Windows.Forms.Panel();
            this.pictureBoxRemove = new System.Windows.Forms.PictureBox();
            this.pictureBoxAdd = new System.Windows.Forms.PictureBox();
            this.listBoxCheque = new System.Windows.Forms.ListBox();
            this.textBoxCheque = new System.Windows.Forms.TextBox();
            this.checkBoxCreance = new System.Windows.Forms.CheckBox();
            this.layoutContainer.SuspendLayout();
            this.panelCheque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutContainer
            // 
            this.layoutContainer.ColumnCount = 2;
            this.layoutContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutContainer.Controls.Add(this.textBoxDesc, 1, 0);
            this.layoutContainer.Controls.Add(this.labelDes, 0, 0);
            this.layoutContainer.Controls.Add(this.label2, 0, 4);
            this.layoutContainer.Controls.Add(this.textBoxReste, 1, 4);
            this.layoutContainer.Controls.Add(this.btnCancel, 1, 6);
            this.layoutContainer.Controls.Add(this.button1, 0, 6);
            this.layoutContainer.Controls.Add(this.label3, 0, 5);
            this.layoutContainer.Controls.Add(this.textBoxObservation, 1, 5);
            this.layoutContainer.Controls.Add(this.label1, 0, 1);
            this.layoutContainer.Controls.Add(this.textBoxMontantAv, 1, 1);
            this.layoutContainer.Controls.Add(this.textBoxCreance, 1, 2);
            this.layoutContainer.Controls.Add(this.checkBoxCheque, 0, 3);
            this.layoutContainer.Controls.Add(this.panelCheque, 1, 3);
            this.layoutContainer.Controls.Add(this.checkBoxCreance, 0, 2);
            this.layoutContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutContainer.Location = new System.Drawing.Point(0, 0);
            this.layoutContainer.Name = "layoutContainer";
            this.layoutContainer.RowCount = 7;
            this.layoutContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.layoutContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.layoutContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.layoutContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.layoutContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.layoutContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.layoutContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.layoutContainer.Size = new System.Drawing.Size(538, 430);
            this.layoutContainer.TabIndex = 0;
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxDesc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDesc.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxDesc.Location = new System.Drawing.Point(272, 19);
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(222, 25);
            this.textBoxDesc.TabIndex = 19;
            this.textBoxDesc.TabStop = false;
            this.textBoxDesc.Text = "REMISE FINANCIERE";
            // 
            // labelDes
            // 
            this.labelDes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelDes.AutoSize = true;
            this.labelDes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDes.Location = new System.Drawing.Point(3, 22);
            this.labelDes.Name = "labelDes";
            this.labelDes.Size = new System.Drawing.Size(78, 19);
            this.labelDes.TabIndex = 0;
            this.labelDes.Text = "Description";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Reste";
            // 
            // textBoxReste
            // 
            this.textBoxReste.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxReste.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxReste.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxReste.Enabled = false;
            this.textBoxReste.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxReste.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxReste.Location = new System.Drawing.Point(272, 279);
            this.textBoxReste.MaxLength = 21;
            this.textBoxReste.Name = "textBoxReste";
            this.textBoxReste.ReadOnly = true;
            this.textBoxReste.Size = new System.Drawing.Size(222, 18);
            this.textBoxReste.TabIndex = 20;
            this.textBoxReste.Text = "0,00";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.Location = new System.Drawing.Point(366, 395);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(97, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Observation";
            // 
            // textBoxObservation
            // 
            this.textBoxObservation.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxObservation.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxObservation.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxObservation.Location = new System.Drawing.Point(272, 329);
            this.textBoxObservation.Multiline = true;
            this.textBoxObservation.Name = "textBoxObservation";
            this.textBoxObservation.Size = new System.Drawing.Size(222, 45);
            this.textBoxObservation.TabIndex = 19;
            this.textBoxObservation.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Montant Global";
            // 
            // textBoxMontantAv
            // 
            this.textBoxMontantAv.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxMontantAv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMontantAv.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMontantAv.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxMontantAv.Location = new System.Drawing.Point(272, 83);
            this.textBoxMontantAv.MaxLength = 21;
            this.textBoxMontantAv.Name = "textBoxMontantAv";
            this.textBoxMontantAv.Size = new System.Drawing.Size(222, 25);
            this.textBoxMontantAv.TabIndex = 20;
            this.textBoxMontantAv.Text = "0,00";
            this.textBoxMontantAv.TextChanged += new System.EventHandler(this.textBoxMontantAv_TextChanged);
            // 
            // textBoxCreance
            // 
            this.textBoxCreance.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxCreance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCreance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCreance.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxCreance.Location = new System.Drawing.Point(272, 147);
            this.textBoxCreance.MaxLength = 21;
            this.textBoxCreance.Name = "textBoxCreance";
            this.textBoxCreance.Size = new System.Drawing.Size(222, 25);
            this.textBoxCreance.TabIndex = 17;
            this.textBoxCreance.Text = "0,00";
            this.textBoxCreance.TextChanged += new System.EventHandler(this.textBoxCreance_TextChanged);
            // 
            // checkBoxCheque
            // 
            this.checkBoxCheque.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxCheque.AutoSize = true;
            this.checkBoxCheque.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCheque.Location = new System.Drawing.Point(3, 212);
            this.checkBoxCheque.Name = "checkBoxCheque";
            this.checkBoxCheque.Size = new System.Drawing.Size(75, 23);
            this.checkBoxCheque.TabIndex = 15;
            this.checkBoxCheque.TabStop = false;
            this.checkBoxCheque.Text = "Chèque";
            this.checkBoxCheque.UseVisualStyleBackColor = true;
            this.checkBoxCheque.CheckedChanged += new System.EventHandler(this.checkBoxCheque_CheckedChanged);
            // 
            // panelCheque
            // 
            this.panelCheque.Controls.Add(this.pictureBoxRemove);
            this.panelCheque.Controls.Add(this.pictureBoxAdd);
            this.panelCheque.Controls.Add(this.listBoxCheque);
            this.panelCheque.Controls.Add(this.textBoxCheque);
            this.panelCheque.Location = new System.Drawing.Point(272, 195);
            this.panelCheque.Name = "panelCheque";
            this.panelCheque.Size = new System.Drawing.Size(259, 58);
            this.panelCheque.TabIndex = 21;
            // 
            // pictureBoxRemove
            // 
            this.pictureBoxRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxRemove.Image = global::ExpFinance.Properties.Resources.remove;
            this.pictureBoxRemove.Location = new System.Drawing.Point(228, 28);
            this.pictureBoxRemove.Name = "pictureBoxRemove";
            this.pictureBoxRemove.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxRemove.TabIndex = 9;
            this.pictureBoxRemove.TabStop = false;
            this.pictureBoxRemove.Click += new System.EventHandler(this.pictureBoxRemove_Click);
            // 
            // pictureBoxAdd
            // 
            this.pictureBoxAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAdd.Image = global::ExpFinance.Properties.Resources.add;
            this.pictureBoxAdd.Location = new System.Drawing.Point(228, 3);
            this.pictureBoxAdd.Name = "pictureBoxAdd";
            this.pictureBoxAdd.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxAdd.TabIndex = 9;
            this.pictureBoxAdd.TabStop = false;
            this.pictureBoxAdd.Click += new System.EventHandler(this.pictureBoxAdd_Click);
            // 
            // listBoxCheque
            // 
            this.listBoxCheque.FormattingEnabled = true;
            this.listBoxCheque.Location = new System.Drawing.Point(3, 3);
            this.listBoxCheque.MultiColumn = true;
            this.listBoxCheque.Name = "listBoxCheque";
            this.listBoxCheque.Size = new System.Drawing.Size(219, 43);
            this.listBoxCheque.TabIndex = 11;
            this.listBoxCheque.TabStop = false;
            // 
            // textBoxCheque
            // 
            this.textBoxCheque.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxCheque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCheque.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCheque.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxCheque.Location = new System.Drawing.Point(3, 39);
            this.textBoxCheque.MaxLength = 21;
            this.textBoxCheque.Name = "textBoxCheque";
            this.textBoxCheque.Size = new System.Drawing.Size(219, 25);
            this.textBoxCheque.TabIndex = 17;
            this.textBoxCheque.Text = "0,00";
            this.textBoxCheque.TextChanged += new System.EventHandler(this.textBoxCreance_TextChanged);
            // 
            // checkBoxCreance
            // 
            this.checkBoxCreance.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxCreance.AutoSize = true;
            this.checkBoxCreance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCreance.Location = new System.Drawing.Point(3, 148);
            this.checkBoxCreance.Name = "checkBoxCreance";
            this.checkBoxCreance.Size = new System.Drawing.Size(108, 23);
            this.checkBoxCreance.TabIndex = 14;
            this.checkBoxCreance.TabStop = false;
            this.checkBoxCreance.Text = "Créance (DA)";
            this.checkBoxCreance.UseVisualStyleBackColor = true;
            this.checkBoxCreance.CheckedChanged += new System.EventHandler(this.checkBoxCreance_CheckedChanged);
            // 
            // EditAvoirForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 430);
            this.Controls.Add(this.layoutContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditAvoirForm";
            this.Text = "Editer l\'Avoir";
            this.Load += new System.EventHandler(this.EditAvoirForm_Load);
            this.layoutContainer.ResumeLayout(false);
            this.layoutContainer.PerformLayout();
            this.panelCheque.ResumeLayout(false);
            this.panelCheque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutContainer;
        private System.Windows.Forms.Label labelDes;
        private System.Windows.Forms.CheckBox checkBoxCreance;
        private System.Windows.Forms.CheckBox checkBoxCheque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox textBoxCreance;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.TextBox textBoxMontantAv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxReste;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxObservation;
        private System.Windows.Forms.Panel panelCheque;
        private System.Windows.Forms.PictureBox pictureBoxRemove;
        private System.Windows.Forms.PictureBox pictureBoxAdd;
        private System.Windows.Forms.ListBox listBoxCheque;
        private System.Windows.Forms.TextBox textBoxCheque;
    }
}