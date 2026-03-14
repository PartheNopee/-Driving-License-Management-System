namespace DVLDApp
{
    partial class ChangePasswordScreen
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
            this.TxtCurrentPasswd = new System.Windows.Forms.TextBox();
            this.txtNewpasswd = new System.Windows.Forms.TextBox();
            this.TxtconfrmPasswd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSavepasswrd = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrlUserInfo2 = new DVLDApp.CtrlUserInfo();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 514);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Password :";
            // 
            // TxtCurrentPasswd
            // 
            this.TxtCurrentPasswd.Location = new System.Drawing.Point(191, 514);
            this.TxtCurrentPasswd.Name = "TxtCurrentPasswd";
            this.TxtCurrentPasswd.PasswordChar = '*';
            this.TxtCurrentPasswd.Size = new System.Drawing.Size(182, 20);
            this.TxtCurrentPasswd.TabIndex = 2;
            this.TxtCurrentPasswd.Validating += new System.ComponentModel.CancelEventHandler(this.TxtCurrentPasswd_Validating);
            // 
            // txtNewpasswd
            // 
            this.txtNewpasswd.Location = new System.Drawing.Point(191, 557);
            this.txtNewpasswd.Name = "txtNewpasswd";
            this.txtNewpasswd.PasswordChar = '*';
            this.txtNewpasswd.Size = new System.Drawing.Size(182, 20);
            this.txtNewpasswd.TabIndex = 4;
            this.txtNewpasswd.Validating += new System.ComponentModel.CancelEventHandler(this.txtNewpasswd_Validating);
            // 
            // TxtconfrmPasswd
            // 
            this.TxtconfrmPasswd.Location = new System.Drawing.Point(191, 597);
            this.TxtconfrmPasswd.Name = "TxtconfrmPasswd";
            this.TxtconfrmPasswd.PasswordChar = '*';
            this.TxtconfrmPasswd.Size = new System.Drawing.Size(182, 20);
            this.TxtconfrmPasswd.TabIndex = 5;
            this.TxtconfrmPasswd.Validating += new System.ComponentModel.CancelEventHandler(this.TxtconfrmPasswd_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 557);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "New Password :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 597);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Confirm Password :";
            // 
            // btnSavepasswrd
            // 
            this.btnSavepasswrd.BackColor = System.Drawing.Color.White;
            this.btnSavepasswrd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavepasswrd.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavepasswrd.Image = global::DVLDApp.Properties.Resources.Save_32;
            this.btnSavepasswrd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSavepasswrd.Location = new System.Drawing.Point(730, 631);
            this.btnSavepasswrd.Name = "btnSavepasswrd";
            this.btnSavepasswrd.Size = new System.Drawing.Size(123, 33);
            this.btnSavepasswrd.TabIndex = 3;
            this.btnSavepasswrd.Text = "Save";
            this.btnSavepasswrd.UseVisualStyleBackColor = false;
            this.btnSavepasswrd.Click += new System.EventHandler(this.btnSavepasswrd_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::DVLDApp.Properties.Resources.Close_32;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(593, 631);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 33);
            this.button2.TabIndex = 8;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlUserInfo2
            // 
            this.ctrlUserInfo2.Location = new System.Drawing.Point(0, 0);
            this.ctrlUserInfo2.Name = "ctrlUserInfo2";
            this.ctrlUserInfo2.Size = new System.Drawing.Size(841, 478);
            this.ctrlUserInfo2.TabIndex = 9;
            // 
            // ChangePasswordScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 676);
            this.Controls.Add(this.ctrlUserInfo2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtconfrmPasswd);
            this.Controls.Add(this.txtNewpasswd);
            this.Controls.Add(this.btnSavepasswrd);
            this.Controls.Add(this.TxtCurrentPasswd);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ChangePasswordScreen";
            this.Text = "Change Password ";
            this.Load += new System.EventHandler(this.ChangePasswordScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CtrlUserInfo ctrlUserInfo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCurrentPasswd;
        private System.Windows.Forms.Button btnSavepasswrd;
        private System.Windows.Forms.TextBox txtNewpasswd;
        private System.Windows.Forms.TextBox TxtconfrmPasswd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private CtrlUserInfo ctrlUserInfo2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}