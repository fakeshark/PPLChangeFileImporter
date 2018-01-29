namespace PPLChangeFileImporter
{
    partial class FrmPPLChangeImporter
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbxImport = new System.Windows.Forms.GroupBox();
            this.lblPercentComplete = new System.Windows.Forms.Label();
            this.pgbProgressBar = new System.Windows.Forms.ProgressBar();
            this.dgvExcelImport = new System.Windows.Forms.DataGridView();
            this.lblLogOutput = new System.Windows.Forms.Label();
            this.lbxChangeLog = new System.Windows.Forms.ListBox();
            this.btnImportChangeFile = new System.Windows.Forms.Button();
            this.btnImportPPL = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExportChanges = new System.Windows.Forms.Button();
            this.gbxImport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcelImport)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxImport
            // 
            this.gbxImport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxImport.Controls.Add(this.lblPercentComplete);
            this.gbxImport.Controls.Add(this.pgbProgressBar);
            this.gbxImport.Controls.Add(this.dgvExcelImport);
            this.gbxImport.Controls.Add(this.lblLogOutput);
            this.gbxImport.Controls.Add(this.lbxChangeLog);
            this.gbxImport.Controls.Add(this.btnImportChangeFile);
            this.gbxImport.Controls.Add(this.btnImportPPL);
            this.gbxImport.Location = new System.Drawing.Point(12, 8);
            this.gbxImport.Name = "gbxImport";
            this.gbxImport.Size = new System.Drawing.Size(959, 604);
            this.gbxImport.TabIndex = 0;
            this.gbxImport.TabStop = false;
            this.gbxImport.Text = "Import:";
            // 
            // lblPercentComplete
            // 
            this.lblPercentComplete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPercentComplete.AutoSize = true;
            this.lblPercentComplete.Location = new System.Drawing.Point(856, 56);
            this.lblPercentComplete.Name = "lblPercentComplete";
            this.lblPercentComplete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPercentComplete.Size = new System.Drawing.Size(0, 13);
            this.lblPercentComplete.TabIndex = 5;
            this.lblPercentComplete.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pgbProgressBar
            // 
            this.pgbProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pgbProgressBar.Location = new System.Drawing.Point(726, 19);
            this.pgbProgressBar.Name = "pgbProgressBar";
            this.pgbProgressBar.Size = new System.Drawing.Size(226, 34);
            this.pgbProgressBar.TabIndex = 3;
            // 
            // dgvExcelImport
            // 
            this.dgvExcelImport.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvExcelImport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvExcelImport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvExcelImport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvExcelImport.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvExcelImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExcelImport.Location = new System.Drawing.Point(7, 166);
            this.dgvExcelImport.Name = "dgvExcelImport";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExcelImport.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvExcelImport.Size = new System.Drawing.Size(945, 432);
            this.dgvExcelImport.TabIndex = 2;
            // 
            // lblLogOutput
            // 
            this.lblLogOutput.AutoSize = true;
            this.lblLogOutput.Location = new System.Drawing.Point(6, 56);
            this.lblLogOutput.Name = "lblLogOutput";
            this.lblLogOutput.Size = new System.Drawing.Size(65, 13);
            this.lblLogOutput.TabIndex = 0;
            this.lblLogOutput.Text = "Activity Log:";
            // 
            // lbxChangeLog
            // 
            this.lbxChangeLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxChangeLog.FormattingEnabled = true;
            this.lbxChangeLog.Location = new System.Drawing.Point(7, 77);
            this.lbxChangeLog.Name = "lbxChangeLog";
            this.lbxChangeLog.Size = new System.Drawing.Size(945, 82);
            this.lbxChangeLog.TabIndex = 0;
            this.lbxChangeLog.TabStop = false;
            // 
            // btnImportChangeFile
            // 
            this.btnImportChangeFile.Enabled = false;
            this.btnImportChangeFile.Location = new System.Drawing.Point(188, 19);
            this.btnImportChangeFile.Name = "btnImportChangeFile";
            this.btnImportChangeFile.Size = new System.Drawing.Size(175, 34);
            this.btnImportChangeFile.TabIndex = 1;
            this.btnImportChangeFile.Text = "&Import change file (.txt)";
            this.btnImportChangeFile.UseVisualStyleBackColor = true;
            this.btnImportChangeFile.Click += new System.EventHandler(this.BtnImportChangeFile_Click);
            // 
            // btnImportPPL
            // 
            this.btnImportPPL.Location = new System.Drawing.Point(7, 19);
            this.btnImportPPL.Name = "btnImportPPL";
            this.btnImportPPL.Size = new System.Drawing.Size(175, 34);
            this.btnImportPPL.TabIndex = 0;
            this.btnImportPPL.Text = "Import &PPL (.xlsx)";
            this.btnImportPPL.UseVisualStyleBackColor = true;
            this.btnImportPPL.Click += new System.EventHandler(this.BtnImportPPL_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReset.Location = new System.Drawing.Point(12, 618);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(182, 34);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "&Reset form";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnExportChanges
            // 
            this.btnExportChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportChanges.Enabled = false;
            this.btnExportChanges.Location = new System.Drawing.Point(789, 618);
            this.btnExportChanges.Name = "btnExportChanges";
            this.btnExportChanges.Size = new System.Drawing.Size(182, 34);
            this.btnExportChanges.TabIndex = 3;
            this.btnExportChanges.Text = "&Export changes";
            this.btnExportChanges.UseVisualStyleBackColor = true;
            this.btnExportChanges.Click += new System.EventHandler(this.BtnExportChanges_Click);
            // 
            // FrmPPLChangeImporter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.btnExportChanges);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.gbxImport);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "FrmPPLChangeImporter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PPL Change File Importer";
            this.gbxImport.ResumeLayout(false);
            this.gbxImport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcelImport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxImport;
        private System.Windows.Forms.Label lblLogOutput;
        private System.Windows.Forms.ListBox lbxChangeLog;
        private System.Windows.Forms.Button btnImportChangeFile;
        private System.Windows.Forms.Button btnImportPPL;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExportChanges;
        private System.Windows.Forms.DataGridView dgvExcelImport;
        private System.Windows.Forms.Label lblPercentComplete;
        private System.Windows.Forms.ProgressBar pgbProgressBar;
    }
}

