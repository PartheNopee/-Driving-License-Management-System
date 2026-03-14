namespace DVLDApp.Applications.LocalDrivingLicenseApplication
{
    partial class testAppointmentFrm
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LbRecords = new System.Windows.Forms.Label();
            this.dGVAppointmts = new System.Windows.Forms.DataGridView();
            this.cmsAppointmt = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.takeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnAddAppointmnt = new System.Windows.Forms.Button();
            this.pbTestType = new System.Windows.Forms.PictureBox();
            this.ctrlAppInfo2 = new DVLDApp.Applications.LocalDrivingLicenseApplication.Controls.CtrlAppInfo();
            ((System.ComponentModel.ISupportInitialize)(this.dGVAppointmts)).BeginInit();
            this.cmsAppointmt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTestType)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Brown;
            this.lbTitle.Location = new System.Drawing.Point(278, 150);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(331, 31);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Vision Test Appointment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 525);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = " Appointments:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(27, 752);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "# Records:";
            // 
            // LbRecords
            // 
            this.LbRecords.AutoSize = true;
            this.LbRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbRecords.ForeColor = System.Drawing.Color.Black;
            this.LbRecords.Location = new System.Drawing.Point(115, 752);
            this.LbRecords.Name = "LbRecords";
            this.LbRecords.Size = new System.Drawing.Size(15, 16);
            this.LbRecords.TabIndex = 5;
            this.LbRecords.Text = "0";
            // 
            // dGVAppointmts
            // 
            this.dGVAppointmts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVAppointmts.ContextMenuStrip = this.cmsAppointmt;
            this.dGVAppointmts.Location = new System.Drawing.Point(16, 562);
            this.dGVAppointmts.Name = "dGVAppointmts";
            this.dGVAppointmts.Size = new System.Drawing.Size(863, 177);
            this.dGVAppointmts.TabIndex = 6;
            // 
            // cmsAppointmt
            // 
            this.cmsAppointmt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.toolStripMenuItem1,
            this.takeTestToolStripMenuItem});
            this.cmsAppointmt.Name = "cmsAppointmt";
            this.cmsAppointmt.Size = new System.Drawing.Size(181, 76);
            this.cmsAppointmt.Opening += new System.ComponentModel.CancelEventHandler(this.cmsAppointmt_Opening);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::DVLDApp.Properties.Resources.edit_32;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // takeTestToolStripMenuItem
            // 
            this.takeTestToolStripMenuItem.Image = global::DVLDApp.Properties.Resources.Test_32;
            this.takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            this.takeTestToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.takeTestToolStripMenuItem.Text = "Take Test";
            this.takeTestToolStripMenuItem.Click += new System.EventHandler(this.takeTestToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::DVLDApp.Properties.Resources.Close_32;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(767, 752);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 30);
            this.button2.TabIndex = 8;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnAddAppointmnt
            // 
            this.BtnAddAppointmnt.Image = global::DVLDApp.Properties.Resources.AddAppointment_32;
            this.BtnAddAppointmnt.Location = new System.Drawing.Point(834, 517);
            this.BtnAddAppointmnt.Name = "BtnAddAppointmnt";
            this.BtnAddAppointmnt.Size = new System.Drawing.Size(45, 39);
            this.BtnAddAppointmnt.TabIndex = 7;
            this.BtnAddAppointmnt.UseVisualStyleBackColor = true;
            this.BtnAddAppointmnt.Click += new System.EventHandler(this.BtnAddAppointmnt_Click);
            // 
            // pbTestType
            // 
            this.pbTestType.Image = global::DVLDApp.Properties.Resources.Vision_512;
            this.pbTestType.Location = new System.Drawing.Point(349, 12);
            this.pbTestType.Name = "pbTestType";
            this.pbTestType.Size = new System.Drawing.Size(189, 110);
            this.pbTestType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTestType.TabIndex = 0;
            this.pbTestType.TabStop = false;
            // 
            // ctrlAppInfo2
            // 
            this.ctrlAppInfo2.Location = new System.Drawing.Point(4, 201);
            this.ctrlAppInfo2.Name = "ctrlAppInfo2";
            this.ctrlAppInfo2.Size = new System.Drawing.Size(875, 310);
            this.ctrlAppInfo2.TabIndex = 9;
            this.ctrlAppInfo2.TestIndex = -1;
            // 
            // testAppointmentFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 789);
            this.Controls.Add(this.ctrlAppInfo2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnAddAppointmnt);
            this.Controls.Add(this.dGVAppointmts);
            this.Controls.Add(this.LbRecords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.pbTestType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "testAppointmentFrm";
            this.Text = "Vision Test Appointment";
            this.Load += new System.EventHandler(this.testAppointmentFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVAppointmts)).EndInit();
            this.cmsAppointmt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbTestType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTestType;
        private System.Windows.Forms.Label lbTitle;
        private Controls.CtrlAppInfo ctrlAppInfo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LbRecords;
        private System.Windows.Forms.DataGridView dGVAppointmts;
        private System.Windows.Forms.Button BtnAddAppointmnt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ContextMenuStrip cmsAppointmt;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem takeTestToolStripMenuItem;
        private Controls.CtrlAppInfo ctrlAppInfo2;
    }
}