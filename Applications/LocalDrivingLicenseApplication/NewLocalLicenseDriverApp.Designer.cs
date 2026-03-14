namespace DVLDApp
{
    partial class NewLocalLicenseDriverApp
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
            System.Windows.Forms.Button btnSave;
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.personInfoTab = new System.Windows.Forms.TabPage();
            this.ctrlFindPerson1 = new DVLDApp.CtrlFindPerson();
            this.btnNext = new System.Windows.Forms.Button();
            this.ApplicationInfoTab = new System.Windows.Forms.TabPage();
            this.cbLicenseClass = new System.Windows.Forms.ComboBox();
            this.LbCreatedBy = new System.Windows.Forms.Label();
            this.LbFee = new System.Windows.Forms.Label();
            this.LbDate = new System.Windows.Forms.Label();
            this.LbAppID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ApplicatioFee = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.personInfoTab.SuspendLayout();
            this.ApplicationInfoTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackColor = System.Drawing.Color.White;
            btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnSave.Image = global::DVLDApp.Properties.Resources.Save_32;
            btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnSave.Location = new System.Drawing.Point(812, 705);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(133, 32);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(195, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(498, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Local Driver License Application";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.personInfoTab);
            this.tabControl1.Controls.Add(this.ApplicationInfoTab);
            this.tabControl1.Location = new System.Drawing.Point(21, 119);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(928, 574);
            this.tabControl1.TabIndex = 1;
            // 
            // personInfoTab
            // 
            this.personInfoTab.Controls.Add(this.ctrlFindPerson1);
            this.personInfoTab.Controls.Add(this.btnNext);
            this.personInfoTab.Location = new System.Drawing.Point(4, 22);
            this.personInfoTab.Name = "personInfoTab";
            this.personInfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.personInfoTab.Size = new System.Drawing.Size(920, 548);
            this.personInfoTab.TabIndex = 0;
            this.personInfoTab.Text = "Person Info";
            this.personInfoTab.UseVisualStyleBackColor = true;
            // 
            // ctrlFindPerson1
            // 
            this.ctrlFindPerson1.FilterEnabled = true;
            this.ctrlFindPerson1.Location = new System.Drawing.Point(17, 3);
            this.ctrlFindPerson1.Name = "ctrlFindPerson1";
            this.ctrlFindPerson1.NationalID = null;
            this.ctrlFindPerson1.Size = new System.Drawing.Size(858, 483);
            this.ctrlFindPerson1.TabIndex = 3;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.White;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(742, 493);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(133, 32);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ApplicationInfoTab
            // 
            this.ApplicationInfoTab.Controls.Add(this.cbLicenseClass);
            this.ApplicationInfoTab.Controls.Add(this.LbCreatedBy);
            this.ApplicationInfoTab.Controls.Add(this.LbFee);
            this.ApplicationInfoTab.Controls.Add(this.LbDate);
            this.ApplicationInfoTab.Controls.Add(this.LbAppID);
            this.ApplicationInfoTab.Controls.Add(this.label6);
            this.ApplicationInfoTab.Controls.Add(this.ApplicatioFee);
            this.ApplicationInfoTab.Controls.Add(this.label4);
            this.ApplicationInfoTab.Controls.Add(this.label3);
            this.ApplicationInfoTab.Controls.Add(this.label2);
            this.ApplicationInfoTab.Location = new System.Drawing.Point(4, 22);
            this.ApplicationInfoTab.Name = "ApplicationInfoTab";
            this.ApplicationInfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.ApplicationInfoTab.Size = new System.Drawing.Size(920, 548);
            this.ApplicationInfoTab.TabIndex = 1;
            this.ApplicationInfoTab.Text = "Application Info";
            this.ApplicationInfoTab.UseVisualStyleBackColor = true;
            // 
            // cbLicenseClass
            // 
            this.cbLicenseClass.AllowDrop = true;
            this.cbLicenseClass.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbLicenseClass.FormattingEnabled = true;
            this.cbLicenseClass.Location = new System.Drawing.Point(311, 196);
            this.cbLicenseClass.Name = "cbLicenseClass";
            this.cbLicenseClass.Size = new System.Drawing.Size(196, 21);
            this.cbLicenseClass.TabIndex = 9;
            // 
            // LbCreatedBy
            // 
            this.LbCreatedBy.AutoSize = true;
            this.LbCreatedBy.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCreatedBy.Location = new System.Drawing.Point(307, 302);
            this.LbCreatedBy.Name = "LbCreatedBy";
            this.LbCreatedBy.Size = new System.Drawing.Size(58, 22);
            this.LbCreatedBy.TabIndex = 8;
            this.LbCreatedBy.Text = "????";
            // 
            // LbFee
            // 
            this.LbFee.AutoSize = true;
            this.LbFee.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbFee.Location = new System.Drawing.Point(307, 247);
            this.LbFee.Name = "LbFee";
            this.LbFee.Size = new System.Drawing.Size(46, 22);
            this.LbFee.TabIndex = 7;
            this.LbFee.Text = "???";
            // 
            // LbDate
            // 
            this.LbDate.AutoSize = true;
            this.LbDate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbDate.Location = new System.Drawing.Point(307, 137);
            this.LbDate.Name = "LbDate";
            this.LbDate.Size = new System.Drawing.Size(116, 22);
            this.LbDate.TabIndex = 6;
            this.LbDate.Text = "??.??.????";
            // 
            // LbAppID
            // 
            this.LbAppID.AutoSize = true;
            this.LbAppID.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbAppID.Location = new System.Drawing.Point(307, 82);
            this.LbAppID.Name = "LbAppID";
            this.LbAppID.Size = new System.Drawing.Size(46, 22);
            this.LbAppID.TabIndex = 5;
            this.LbAppID.Text = "???";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(83, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 22);
            this.label6.TabIndex = 4;
            this.label6.Text = "CreatedBy : ";
            // 
            // ApplicatioFee
            // 
            this.ApplicatioFee.AutoSize = true;
            this.ApplicatioFee.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplicatioFee.Location = new System.Drawing.Point(83, 247);
            this.ApplicatioFee.Name = "ApplicatioFee";
            this.ApplicatioFee.Size = new System.Drawing.Size(165, 22);
            this.ApplicatioFee.TabIndex = 3;
            this.ApplicatioFee.Text = "Application Fee :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 192);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(152, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "License Class :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Application Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "D.L.Application.ID :";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLDApp.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(655, 705);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(133, 32);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // NewLocalLicenseDriverApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 749);
            this.Controls.Add(btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "NewLocalLicenseDriverApp";
            this.Text = "NewLocalLicenseDriverApp";
            this.Load += new System.EventHandler(this.NewLocalLicenseDriverApp_Load);
            this.tabControl1.ResumeLayout(false);
            this.personInfoTab.ResumeLayout(false);
            this.ApplicationInfoTab.ResumeLayout(false);
            this.ApplicationInfoTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage personInfoTab;
        private System.Windows.Forms.TabPage ApplicationInfoTab;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label ApplicatioFee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LbCreatedBy;
        private System.Windows.Forms.Label LbFee;
        private System.Windows.Forms.Label LbDate;
        private System.Windows.Forms.Label LbAppID;
        private System.Windows.Forms.ComboBox cbLicenseClass;
        private CtrlFindPerson ctrlFindPerson1;
    }
}