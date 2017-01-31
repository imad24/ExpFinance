namespace ExpFinance
{
    partial class BulkPrintingForm
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.numericFrom = new System.Windows.Forms.NumericUpDown();
            this.numericTo = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericCopies = new System.Windows.Forms.NumericUpDown();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.printingWorker = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCopies)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.numericFrom, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.numericTo, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.numericCopies, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.progressBar, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.buttonPrint, 0, 3);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 4;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(331, 251);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // numericFrom
            // 
            this.numericFrom.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericFrom.Location = new System.Drawing.Point(175, 10);
            this.numericFrom.Margin = new System.Windows.Forms.Padding(10);
            this.numericFrom.Maximum = new decimal(new int[] {
            1699999,
            0,
            0,
            0});
            this.numericFrom.Minimum = new decimal(new int[] {
            1600001,
            0,
            0,
            0});
            this.numericFrom.Name = "numericFrom";
            this.numericFrom.Size = new System.Drawing.Size(120, 25);
            this.numericFrom.TabIndex = 0;
            this.numericFrom.Value = new decimal(new int[] {
            1601000,
            0,
            0,
            0});
            // 
            // numericTo
            // 
            this.numericTo.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericTo.Location = new System.Drawing.Point(175, 72);
            this.numericTo.Margin = new System.Windows.Forms.Padding(10);
            this.numericTo.Maximum = new decimal(new int[] {
            1600002,
            0,
            0,
            0});
            this.numericTo.Minimum = new decimal(new int[] {
            1600002,
            0,
            0,
            0});
            this.numericTo.Name = "numericTo";
            this.numericTo.Size = new System.Drawing.Size(120, 25);
            this.numericTo.TabIndex = 1;
            this.numericTo.Value = new decimal(new int[] {
            1600002,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "À Partir de";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Jusqu\'à";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre de copies";
            // 
            // numericCopies
            // 
            this.numericCopies.Location = new System.Drawing.Point(175, 134);
            this.numericCopies.Margin = new System.Windows.Forms.Padding(10);
            this.numericCopies.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericCopies.Name = "numericCopies";
            this.numericCopies.Size = new System.Drawing.Size(52, 25);
            this.numericCopies.TabIndex = 1;
            this.numericCopies.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(175, 202);
            this.progressBar.Margin = new System.Windows.Forms.Padding(10, 16, 10, 10);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(120, 23);
            this.progressBar.TabIndex = 4;
            // 
            // buttonPrint
            // 
            this.buttonPrint.Location = new System.Drawing.Point(10, 196);
            this.buttonPrint.Margin = new System.Windows.Forms.Padding(10);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(75, 34);
            this.buttonPrint.TabIndex = 3;
            this.buttonPrint.Text = "Imprimer";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // printingWorker
            // 
            this.printingWorker.WorkerReportsProgress = true;
            this.printingWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.printingWorker_DoWork);
            this.printingWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.printingWorker_ProgressChanged);
            this.printingWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.printingWorker_RunWorkerCompleted);
            // 
            // BulkPrintingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 251);
            this.Controls.Add(this.tableLayoutPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BulkPrintingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Impression Groupée";
            this.Load += new System.EventHandler(this.BulkPrintingForm_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCopies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.NumericUpDown numericFrom;
        private System.Windows.Forms.NumericUpDown numericTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker printingWorker;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.NumericUpDown numericCopies;
        private System.Windows.Forms.Label label3;
    }
}