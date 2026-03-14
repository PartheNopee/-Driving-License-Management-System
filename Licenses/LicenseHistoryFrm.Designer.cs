namespace DVLDApp.Licenses
{
    partial class LicenseHistoryFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TabDrivingLicense = new System.Windows.Forms.TabControl();
            this.TabLocal = new System.Windows.Forms.TabPage();
            this.LbRecords = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DGVLocal = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.TabInternational = new System.Windows.Forms.TabPage();
            this.LbRecorsInternational = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DGVInternationalLincesHistory = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.ctrlFindPerson1 = new DVLDApp.CtrlFindPerson();
            this.groupBox1.SuspendLayout();
            this.TabDrivingLicense.SuspendLayout();
            this.TabLocal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVLocal)).BeginInit();
            this.TabInternational.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVInternationalLincesHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(337, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "License History";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TabDrivingLicense);
            this.groupBox1.Location = new System.Drawing.Point(23, 467);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(922, 293);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Driver License";
            // 
            // TabDrivingLicense
            // 
            this.TabDrivingLicense.Controls.Add(this.TabLocal);
            this.TabDrivingLicense.Controls.Add(this.TabInternational);
            this.TabDrivingLicense.Location = new System.Drawing.Point(6, 19);
            this.TabDrivingLicense.Name = "TabDrivingLicense";
            this.TabDrivingLicense.SelectedIndex = 0;
            this.TabDrivingLicense.Size = new System.Drawing.Size(910, 261);
            this.TabDrivingLicense.TabIndex = 0;
            // 
            // TabLocal
            // 
            this.TabLocal.Controls.Add(this.LbRecords);
            this.TabLocal.Controls.Add(this.label3);
            this.TabLocal.Controls.Add(this.DGVLocal);
            this.TabLocal.Controls.Add(this.label2);
            this.TabLocal.Location = new System.Drawing.Point(4, 22);
            this.TabLocal.Name = "TabLocal";
            this.TabLocal.Padding = new System.Windows.Forms.Padding(3);
            this.TabLocal.Size = new System.Drawing.Size(902, 235);
            this.TabLocal.TabIndex = 0;
            this.TabLocal.Text = "Local";
            this.TabLocal.UseVisualStyleBackColor = true;
            // 
            // LbRecords
            // 
            this.LbRecords.AutoSize = true;
            this.LbRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbRecords.ForeColor = System.Drawing.Color.Black;
            this.LbRecords.Location = new System.Drawing.Point(97, 204);
            this.LbRecords.Name = "LbRecords";
            this.LbRecords.Size = new System.Drawing.Size(15, 16);
            this.LbRecords.TabIndex = 3;
            this.LbRecords.Text = "#";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(21, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Records:";
            // 
            // DGVLocal
            // 
            this.DGVLocal.BackgroundColor = System.Drawing.Color.White;
            this.DGVLocal.GridColor = System.Drawing.SystemColors.Control;
            this.DGVLocal.Location = new System.Drawing.Point(23, 36);
            this.DGVLocal.Name = "DGVLocal";
            this.DGVLocal.Size = new System.Drawing.Size(863, 165);
            this.DGVLocal.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(20, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Local License History:";
            // 
            // TabInternational
            // 
            this.TabInternational.Controls.Add(this.LbRecorsInternational);
            this.TabInternational.Controls.Add(this.label5);
            this.TabInternational.Controls.Add(this.DGVInternationalLincesHistory);
            this.TabInternational.Controls.Add(this.label6);
            this.TabInternational.Location = new System.Drawing.Point(4, 22);
            this.TabInternational.Name = "TabInternational";
            this.TabInternational.Padding = new System.Windows.Forms.Padding(3);
            this.TabInternational.Size = new System.Drawing.Size(902, 235);
            this.TabInternational.TabIndex = 1;
            this.TabInternational.Text = "International";
            this.TabInternational.UseVisualStyleBackColor = true;
            // 
            // LbRecorsInternational
            // 
            this.LbRecorsInternational.AutoSize = true;
            this.LbRecorsInternational.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbRecorsInternational.ForeColor = System.Drawing.Color.Black;
            this.LbRecorsInternational.Location = new System.Drawing.Point(95, 203);
            this.LbRecorsInternational.Name = "LbRecorsInternational";
            this.LbRecorsInternational.Size = new System.Drawing.Size(15, 16);
            this.LbRecorsInternational.TabIndex = 7;
            this.LbRecorsInternational.Text = "#";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(19, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Records:";
            // 
            // DGVInternationalLincesHistory
            // 
            this.DGVInternationalLincesHistory.BackgroundColor = System.Drawing.Color.White;
            this.DGVInternationalLincesHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVInternationalLincesHistory.GridColor = System.Drawing.SystemColors.Control;
            this.DGVInternationalLincesHistory.Location = new System.Drawing.Point(21, 35);
            this.DGVInternationalLincesHistory.Name = "DGVInternationalLincesHistory";
            this.DGVInternationalLincesHistory.Size = new System.Drawing.Size(863, 165);
            this.DGVInternationalLincesHistory.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(18, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "International License History:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLDApp.Properties.Resources.PersonLicenseHistory_512;
            this.pictureBox1.Location = new System.Drawing.Point(23, 131);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // BtnClose
            // 
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Image = global::DVLDApp.Properties.Resources.Close_32;
            this.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClose.Location = new System.Drawing.Point(823, 766);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(122, 37);
            this.BtnClose.TabIndex = 0;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // ctrlFindPerson1
            // 
            this.ctrlFindPerson1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ctrlFindPerson1.FilterEnabled = true;
            this.ctrlFindPerson1.Location = new System.Drawing.Point(231, 57);
            this.ctrlFindPerson1.Name = "ctrlFindPerson1";
            this.ctrlFindPerson1.NationalID = null;
            this.ctrlFindPerson1.Size = new System.Drawing.Size(727, 413);
            this.ctrlFindPerson1.TabIndex = 0;
            // 
            // LicenseHistoryFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 806);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.ctrlFindPerson1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "LicenseHistoryFrm";
            this.Text = "License History";
            this.Load += new System.EventHandler(this.LicenseHistoryFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.TabDrivingLicense.ResumeLayout(false);
            this.TabLocal.ResumeLayout(false);
            this.TabLocal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVLocal)).EndInit();
            this.TabInternational.ResumeLayout(false);
            this.TabInternational.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVInternationalLincesHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl TabDrivingLicense;
        private System.Windows.Forms.DataGridView DGVLocal;
        private CtrlFindPerson ctrlFindPerson1;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.TabPage TabInternational;
        private System.Windows.Forms.TabPage TabLocal;
        private System.Windows.Forms.Label LbRecords;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LbRecorsInternational;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DGVInternationalLincesHistory;
        private System.Windows.Forms.Label label6;
    }
}