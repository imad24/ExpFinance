namespace ExpFinance
{
    partial class BulkInserForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Insert2016 = new System.Windows.Forms.Button();
            this.InsertAnt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(146, 212);
            this.listBox1.TabIndex = 0;
            // 
            // Insert2016
            // 
            this.Insert2016.Location = new System.Drawing.Point(234, 46);
            this.Insert2016.Name = "Insert2016";
            this.Insert2016.Size = new System.Drawing.Size(75, 23);
            this.Insert2016.TabIndex = 1;
            this.Insert2016.Text = "Insert 2016";
            this.Insert2016.UseVisualStyleBackColor = true;
            this.Insert2016.Click += new System.EventHandler(this.Insert2016_Click);
            // 
            // InsertAnt
            // 
            this.InsertAnt.Location = new System.Drawing.Point(227, 163);
            this.InsertAnt.Name = "InsertAnt";
            this.InsertAnt.Size = new System.Drawing.Size(82, 25);
            this.InsertAnt.TabIndex = 2;
            this.InsertAnt.Text = "Insert Ant";
            this.InsertAnt.UseVisualStyleBackColor = true;
            this.InsertAnt.Click += new System.EventHandler(this.InsertAnt_Click);
            // 
            // BulkInserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 290);
            this.Controls.Add(this.InsertAnt);
            this.Controls.Add(this.Insert2016);
            this.Controls.Add(this.listBox1);
            this.Name = "BulkInserForm";
            this.Text = "BulkInserForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Insert2016;
        private System.Windows.Forms.Button InsertAnt;
    }
}