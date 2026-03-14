namespace DVLDApp.Drivers
{
    partial class ManageDriversFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DGVDrivers = new System.Windows.Forms.DataGridView();
            this.cmsDrivers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPersonInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.showLicenseInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LbRecords = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bntClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDrivers)).BeginInit();
            this.cmsDrivers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(325, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Drivers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 600);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "# Records:";
            // 
            // DGVDrivers
            // 
            this.DGVDrivers.BackgroundColor = System.Drawing.Color.White;
            this.DGVDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDrivers.ContextMenuStrip = this.cmsDrivers;
            this.DGVDrivers.GridColor = System.Drawing.Color.White;
            this.DGVDrivers.Location = new System.Drawing.Point(12, 305);
            this.DGVDrivers.Name = "DGVDrivers";
            this.DGVDrivers.Size = new System.Drawing.Size(887, 277);
            this.DGVDrivers.TabIndex = 3;
            // 
            // cmsDrivers
            // 
            this.cmsDrivers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonInfoToolStripMenuItem,
            this.toolStripMenuItem2,
            this.showLicenseInfoToolStripMenuItem});
            this.cmsDrivers.Name = "cmsDrivers";
            this.cmsDrivers.Size = new System.Drawing.Size(181, 76);
            // 
            // showPersonInfoToolStripMenuItem
            // 
            this.showPersonInfoToolStripMenuItem.Image = global::DVLDApp.Properties.Resources.PersonDetails_32;
            this.showPersonInfoToolStripMenuItem.Name = "showPersonInfoToolStripMenuItem";
            this.showPersonInfoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showPersonInfoToolStripMenuItem.Text = "Show Person Info";
            this.showPersonInfoToolStripMenuItem.Click += new System.EventHandler(this.showPersonInfoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // showLicenseInfoToolStripMenuItem
            // 
            this.showLicenseInfoToolStripMenuItem.Image = global::DVLDApp.Properties.Resources.Driver_License_48;
            this.showLicenseInfoToolStripMenuItem.Name = "showLicenseInfoToolStripMenuItem";
            this.showLicenseInfoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showLicenseInfoToolStripMenuItem.Text = "Show License Info";
            this.showLicenseInfoToolStripMenuItem.Click += new System.EventHandler(this.showLicenseInfoToolStripMenuItem_Click);
            // 
            // LbRecords
            // 
            this.LbRecords.AutoSize = true;
            this.LbRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbRecords.Location = new System.Drawing.Point(91, 600);
            this.LbRecords.Name = "LbRecords";
            this.LbRecords.Size = new System.Drawing.Size(15, 16);
            this.LbRecords.TabIndex = 5;
            this.LbRecords.Text = "#";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Filter By:";
            // 
            // bntClose
            // 
            this.bntClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntClose.Image = global::DVLDApp.Properties.Resources.Close_32;
            this.bntClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntClose.Location = new System.Drawing.Point(781, 594);
            this.bntClose.Name = "bntClose";
            this.bntClose.Size = new System.Drawing.Size(118, 29);
            this.bntClose.TabIndex = 4;
            this.bntClose.Text = "Close";
            this.bntClose.UseVisualStyleBackColor = true;
            this.bntClose.Click += new System.EventHandler(this.bntClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLDApp.Properties.Resources.Driver_Main;
            this.pictureBox1.Location = new System.Drawing.Point(327, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // ManageDriversFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 635);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LbRecords);
            this.Controls.Add(this.bntClose);
            this.Controls.Add(this.DGVDrivers);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ManageDriversFrm";
            this.Text = "Manage Drivers ";
            this.Load += new System.EventHandler(this.ManageDriversFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVDrivers)).EndInit();
            this.cmsDrivers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView DGVDrivers;
        private System.Windows.Forms.Button bntClose;
        private System.Windows.Forms.Label LbRecords;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip cmsDrivers;
        private System.Windows.Forms.ToolStripMenuItem showPersonInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem showLicenseInfoToolStripMenuItem;
    }
}