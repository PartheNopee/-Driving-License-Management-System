namespace DVLDApp
{
    partial class ManageLocalApplications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageLocalApplications));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLocalDrivingLicenseApplications = new System.Windows.Forms.DataGridView();
            this.cMSManageAp = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.cancelApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.schedualeTestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schedualeVisionTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schedualeWritingTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleStreetTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.issueDrivingLicenseFirstTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.showLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.lbRecs = new System.Windows.Forms.Label();
            this.btnAddApp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalDrivingLicenseApplications)).BeginInit();
            this.cMSManageAp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(371, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Local Driving License Applications";
            // 
            // dgvLocalDrivingLicenseApplications
            // 
            this.dgvLocalDrivingLicenseApplications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLocalDrivingLicenseApplications.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLocalDrivingLicenseApplications.BackgroundColor = System.Drawing.Color.White;
            this.dgvLocalDrivingLicenseApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalDrivingLicenseApplications.ContextMenuStrip = this.cMSManageAp;
            this.dgvLocalDrivingLicenseApplications.Location = new System.Drawing.Point(36, 323);
            this.dgvLocalDrivingLicenseApplications.Name = "dgvLocalDrivingLicenseApplications";
            this.dgvLocalDrivingLicenseApplications.Size = new System.Drawing.Size(1146, 398);
            this.dgvLocalDrivingLicenseApplications.TabIndex = 2;
            // 
            // cMSManageAp
            // 
            this.cMSManageAp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showInfoToolStripMenuItem,
            this.toolStripMenuItem1,
            this.deleteToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolStripMenuItem2,
            this.cancelApplicationToolStripMenuItem,
            this.toolStripMenuItem3,
            this.schedualeTestsToolStripMenuItem,
            this.toolStripMenuItem4,
            this.issueDrivingLicenseFirstTimeToolStripMenuItem,
            this.toolStripMenuItem5,
            this.showLicenseToolStripMenuItem,
            this.toolStripMenuItem6,
            this.showPersonLicenseHistoryToolStripMenuItem});
            this.cMSManageAp.Name = "contextMenuStrip1";
            this.cMSManageAp.Size = new System.Drawing.Size(246, 216);
            this.cMSManageAp.Opening += new System.ComponentModel.CancelEventHandler(this.cMSManageAp_Opening);
            // 
            // showInfoToolStripMenuItem
            // 
            this.showInfoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showInfoToolStripMenuItem.Image")));
            this.showInfoToolStripMenuItem.Name = "showInfoToolStripMenuItem";
            this.showInfoToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.showInfoToolStripMenuItem.Text = "Show Info";
            this.showInfoToolStripMenuItem.Click += new System.EventHandler(this.showInfoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(242, 6);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem.Image")));
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editToolStripMenuItem.Image")));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(242, 6);
            // 
            // cancelApplicationToolStripMenuItem
            // 
            this.cancelApplicationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cancelApplicationToolStripMenuItem.Image")));
            this.cancelApplicationToolStripMenuItem.Name = "cancelApplicationToolStripMenuItem";
            this.cancelApplicationToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.cancelApplicationToolStripMenuItem.Text = "Cancel Application";
            this.cancelApplicationToolStripMenuItem.Click += new System.EventHandler(this.cancelApplicationToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(242, 6);
            // 
            // schedualeTestsToolStripMenuItem
            // 
            this.schedualeTestsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schedualeVisionTestToolStripMenuItem,
            this.schedualeWritingTestToolStripMenuItem,
            this.scheduleStreetTestToolStripMenuItem});
            this.schedualeTestsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("schedualeTestsToolStripMenuItem.Image")));
            this.schedualeTestsToolStripMenuItem.Name = "schedualeTestsToolStripMenuItem";
            this.schedualeTestsToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.schedualeTestsToolStripMenuItem.Text = "schedule Tests";
            this.schedualeTestsToolStripMenuItem.Click += new System.EventHandler(this.schedualeTestsToolStripMenuItem_Click);
            // 
            // schedualeVisionTestToolStripMenuItem
            // 
            this.schedualeVisionTestToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("schedualeVisionTestToolStripMenuItem.Image")));
            this.schedualeVisionTestToolStripMenuItem.Name = "schedualeVisionTestToolStripMenuItem";
            this.schedualeVisionTestToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.schedualeVisionTestToolStripMenuItem.Text = "Schedule vision Test";
            this.schedualeVisionTestToolStripMenuItem.Click += new System.EventHandler(this.schedualeVisionTestToolStripMenuItem_Click);
            // 
            // schedualeWritingTestToolStripMenuItem
            // 
            this.schedualeWritingTestToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("schedualeWritingTestToolStripMenuItem.Image")));
            this.schedualeWritingTestToolStripMenuItem.Name = "schedualeWritingTestToolStripMenuItem";
            this.schedualeWritingTestToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.schedualeWritingTestToolStripMenuItem.Text = "Schedule Writing Test";
            this.schedualeWritingTestToolStripMenuItem.Click += new System.EventHandler(this.schedualeWritingTestToolStripMenuItem_Click);
            // 
            // scheduleStreetTestToolStripMenuItem
            // 
            this.scheduleStreetTestToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("scheduleStreetTestToolStripMenuItem.Image")));
            this.scheduleStreetTestToolStripMenuItem.Name = "scheduleStreetTestToolStripMenuItem";
            this.scheduleStreetTestToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.scheduleStreetTestToolStripMenuItem.Text = "Schedule Street Test";
            this.scheduleStreetTestToolStripMenuItem.Click += new System.EventHandler(this.scheduleStreetTestToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(242, 6);
            // 
            // issueDrivingLicenseFirstTimeToolStripMenuItem
            // 
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("issueDrivingLicenseFirstTimeToolStripMenuItem.Image")));
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Name = "issueDrivingLicenseFirstTimeToolStripMenuItem";
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Text = "Issue Driving License (First Time)";
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Click += new System.EventHandler(this.issueDrivingLicenseFirstTimeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(242, 6);
            // 
            // showLicenseToolStripMenuItem
            // 
            this.showLicenseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showLicenseToolStripMenuItem.Image")));
            this.showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            this.showLicenseToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.showLicenseToolStripMenuItem.Text = "Show License";
            this.showLicenseToolStripMenuItem.Click += new System.EventHandler(this.showLicenseToolStripMenuItem_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(242, 6);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showPersonLicenseHistoryToolStripMenuItem.Image")));
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(33, 741);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Record : ";
            // 
            // lbRecs
            // 
            this.lbRecs.AutoSize = true;
            this.lbRecs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecs.ForeColor = System.Drawing.Color.Black;
            this.lbRecs.Location = new System.Drawing.Point(109, 741);
            this.lbRecs.Name = "lbRecs";
            this.lbRecs.Size = new System.Drawing.Size(15, 16);
            this.lbRecs.TabIndex = 4;
            this.lbRecs.Text = "#";
            // 
            // btnAddApp
            // 
            this.btnAddApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddApp.Image = global::DVLDApp.Properties.Resources.New_Application_64;
            this.btnAddApp.Location = new System.Drawing.Point(1114, 238);
            this.btnAddApp.Name = "btnAddApp";
            this.btnAddApp.Size = new System.Drawing.Size(68, 69);
            this.btnAddApp.TabIndex = 5;
            this.btnAddApp.UseVisualStyleBackColor = true;
            this.btnAddApp.Click += new System.EventHandler(this.btnAddApp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(539, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(680, 74);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "L.D.L.AppID",
            "National No.",
            "Full Name",
            "Status"});
            this.cbFilterBy.Location = new System.Drawing.Point(118, 269);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(210, 21);
            this.cbFilterBy.TabIndex = 130;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterValue.Location = new System.Drawing.Point(353, 269);
            this.txtFilterValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(256, 20);
            this.txtFilterValue.TabIndex = 129;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 128;
            this.label4.Text = "Filter By:";
            // 
            // ManageLocalApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 772);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnAddApp);
            this.Controls.Add(this.lbRecs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvLocalDrivingLicenseApplications);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ManageLocalApplications";
            this.Text = "ManageApplications";
            this.Load += new System.EventHandler(this.ManageApplications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalDrivingLicenseApplications)).EndInit();
            this.cMSManageAp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLocalDrivingLicenseApplications;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbRecs;
        private System.Windows.Forms.Button btnAddApp;
        private System.Windows.Forms.ContextMenuStrip cMSManageAp;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cancelApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem schedualeTestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schedualeVisionTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schedualeWritingTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleStreetTestToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem issueDrivingLicenseFirstTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem showLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.Label label4;
    }
}