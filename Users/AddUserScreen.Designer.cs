namespace DVLDApp
{
    partial class AddUserScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUserScreen));
            this.TxtConfPasswd = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.LbTitle = new System.Windows.Forms.Label();
            this.ChkboxIsActive = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddUserTab = new System.Windows.Forms.TabControl();
            this.tpPerosnINfo = new System.Windows.Forms.TabPage();
            this.ctrlFindPerson1 = new DVLDApp.CtrlFindPerson();
            this.tpLoginInfo = new System.Windows.Forms.TabPage();
            this.LbUserId = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LbConfirmPsswd = new System.Windows.Forms.Label();
            this.TxtPassw = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.AddUserTab.SuspendLayout();
            this.tpPerosnINfo.SuspendLayout();
            this.tpLoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtConfPasswd
            // 
            this.TxtConfPasswd.Location = new System.Drawing.Point(669, 267);
            this.TxtConfPasswd.Name = "TxtConfPasswd";
            this.TxtConfPasswd.PasswordChar = '*';
            this.TxtConfPasswd.Size = new System.Drawing.Size(167, 26);
            this.TxtConfPasswd.TabIndex = 0;
            this.TxtConfPasswd.UseSystemPasswordChar = true;
            this.TxtConfPasswd.Validating += new System.ComponentModel.CancelEventHandler(this.TxtConfPasswd_Validating);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(669, 163);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(167, 26);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserName_Validating);
            // 
            // LbTitle
            // 
            this.LbTitle.AutoSize = true;
            this.LbTitle.BackColor = System.Drawing.Color.White;
            this.LbTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTitle.ForeColor = System.Drawing.Color.Brown;
            this.LbTitle.Location = new System.Drawing.Point(604, 116);
            this.LbTitle.Name = "LbTitle";
            this.LbTitle.Size = new System.Drawing.Size(135, 31);
            this.LbTitle.TabIndex = 2;
            this.LbTitle.Text = "Add User";
            // 
            // ChkboxIsActive
            // 
            this.ChkboxIsActive.AutoSize = true;
            this.ChkboxIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkboxIsActive.Location = new System.Drawing.Point(692, 313);
            this.ChkboxIsActive.Name = "ChkboxIsActive";
            this.ChkboxIsActive.Size = new System.Drawing.Size(76, 17);
            this.ChkboxIsActive.TabIndex = 4;
            this.ChkboxIsActive.Text = "Is Active";
            this.ChkboxIsActive.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(487, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "UserName :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(487, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password : ";
            // 
            // AddUserTab
            // 
            this.AddUserTab.Controls.Add(this.tpPerosnINfo);
            this.AddUserTab.Controls.Add(this.tpLoginInfo);
            this.AddUserTab.Location = new System.Drawing.Point(12, 160);
            this.AddUserTab.Name = "AddUserTab";
            this.AddUserTab.SelectedIndex = 0;
            this.AddUserTab.Size = new System.Drawing.Size(1297, 595);
            this.AddUserTab.TabIndex = 8;
            // 
            // tpPerosnINfo
            // 
            this.tpPerosnINfo.Controls.Add(this.ctrlFindPerson1);
            this.tpPerosnINfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpPerosnINfo.Location = new System.Drawing.Point(4, 22);
            this.tpPerosnINfo.Name = "tpPerosnINfo";
            this.tpPerosnINfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpPerosnINfo.Size = new System.Drawing.Size(1289, 569);
            this.tpPerosnINfo.TabIndex = 0;
            this.tpPerosnINfo.Text = "Person Info";
            this.tpPerosnINfo.UseVisualStyleBackColor = true;
            // 
            // ctrlFindPerson1
            // 
            this.ctrlFindPerson1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ctrlFindPerson1.FilterEnabled = true;
            this.ctrlFindPerson1.Location = new System.Drawing.Point(24, 19);
            this.ctrlFindPerson1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlFindPerson1.Name = "ctrlFindPerson1";
            this.ctrlFindPerson1.NationalID = null;
            this.ctrlFindPerson1.Size = new System.Drawing.Size(1258, 580);
            this.ctrlFindPerson1.TabIndex = 13;
            // 
            // tpLoginInfo
            // 
            this.tpLoginInfo.Controls.Add(this.LbUserId);
            this.tpLoginInfo.Controls.Add(this.label5);
            this.tpLoginInfo.Controls.Add(this.LbConfirmPsswd);
            this.tpLoginInfo.Controls.Add(this.TxtPassw);
            this.tpLoginInfo.Controls.Add(this.TxtConfPasswd);
            this.tpLoginInfo.Controls.Add(this.label3);
            this.tpLoginInfo.Controls.Add(this.txtUserName);
            this.tpLoginInfo.Controls.Add(this.label2);
            this.tpLoginInfo.Controls.Add(this.ChkboxIsActive);
            this.tpLoginInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpLoginInfo.Location = new System.Drawing.Point(4, 22);
            this.tpLoginInfo.Name = "tpLoginInfo";
            this.tpLoginInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpLoginInfo.Size = new System.Drawing.Size(1289, 569);
            this.tpLoginInfo.TabIndex = 1;
            this.tpLoginInfo.Text = "Login Info";
            this.tpLoginInfo.UseVisualStyleBackColor = true;
            // 
            // LbUserId
            // 
            this.LbUserId.AutoSize = true;
            this.LbUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbUserId.Location = new System.Drawing.Point(665, 116);
            this.LbUserId.Name = "LbUserId";
            this.LbUserId.Size = new System.Drawing.Size(49, 20);
            this.LbUserId.TabIndex = 10;
            this.LbUserId.Text = "[???]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(487, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "User ID : ";
            // 
            // LbConfirmPsswd
            // 
            this.LbConfirmPsswd.AutoSize = true;
            this.LbConfirmPsswd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbConfirmPsswd.Location = new System.Drawing.Point(487, 269);
            this.LbConfirmPsswd.Name = "LbConfirmPsswd";
            this.LbConfirmPsswd.Size = new System.Drawing.Size(154, 20);
            this.LbConfirmPsswd.TabIndex = 8;
            this.LbConfirmPsswd.Text = "Confirm Pasword :";
            // 
            // TxtPassw
            // 
            this.TxtPassw.Location = new System.Drawing.Point(669, 215);
            this.TxtPassw.Name = "TxtPassw";
            this.TxtPassw.PasswordChar = '*';
            this.TxtPassw.Size = new System.Drawing.Size(167, 26);
            this.TxtPassw.TabIndex = 7;
            this.TxtPassw.UseSystemPasswordChar = true;
            this.TxtPassw.Validating += new System.ComponentModel.CancelEventHandler(this.TxtPassw_Validating);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.White;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Image = global::DVLDApp.Properties.Resources.Next_32;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.Location = new System.Drawing.Point(1172, 761);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(131, 36);
            this.btnNext.TabIndex = 11;
            this.btnNext.Text = " Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::DVLDApp.Properties.Resources.Save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(1172, 813);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(137, 31);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLDApp.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1018, 813);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(137, 31);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = " Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(645, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddUserScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1321, 896);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AddUserTab);
            this.Controls.Add(this.LbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "AddUserScreen";
            this.Text = "Add User";
            this.Load += new System.EventHandler(this.AddUserScreen_Load);
            this.AddUserTab.ResumeLayout(false);
            this.tpPerosnINfo.ResumeLayout(false);
            this.tpLoginInfo.ResumeLayout(false);
            this.tpLoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtConfPasswd;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label LbTitle;
        private System.Windows.Forms.CheckBox ChkboxIsActive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl AddUserTab;
        private System.Windows.Forms.TabPage tpLoginInfo;
        private System.Windows.Forms.TabPage tpPerosnINfo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox TxtPassw;
        private System.Windows.Forms.Label LbConfirmPsswd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LbUserId;
        private CtrlFindPerson ctrlFindPerson1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}