namespace DVLDApp
{
    partial class CtrlUserInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LbIsActive = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LbUserName = new System.Windows.Forms.Label();
            this.LbUserID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.personDetailsCtrl2 = new DVLDApp.PersonDetailsCtrl();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LbIsActive);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.LbUserName);
            this.groupBox1.Controls.Add(this.LbUserID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 394);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(817, 71);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login Info";
            // 
            // LbIsActive
            // 
            this.LbIsActive.AutoSize = true;
            this.LbIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbIsActive.Location = new System.Drawing.Point(625, 34);
            this.LbIsActive.Name = "LbIsActive";
            this.LbIsActive.Size = new System.Drawing.Size(28, 16);
            this.LbIsActive.TabIndex = 5;
            this.LbIsActive.Text = "???";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(532, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Is Active :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(257, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Username : ";
            // 
            // LbUserName
            // 
            this.LbUserName.AutoSize = true;
            this.LbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbUserName.Location = new System.Drawing.Point(342, 34);
            this.LbUserName.Name = "LbUserName";
            this.LbUserName.Size = new System.Drawing.Size(28, 16);
            this.LbUserName.TabIndex = 2;
            this.LbUserName.Text = "???";
            // 
            // LbUserID
            // 
            this.LbUserID.AutoSize = true;
            this.LbUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbUserID.Location = new System.Drawing.Point(137, 34);
            this.LbUserID.Name = "LbUserID";
            this.LbUserID.Size = new System.Drawing.Size(28, 16);
            this.LbUserID.TabIndex = 1;
            this.LbUserID.Text = "???";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID : ";
            // 
            // personDetailsCtrl2
            // 
            this.personDetailsCtrl2.Location = new System.Drawing.Point(-1, -1);
            this.personDetailsCtrl2.Name = "personDetailsCtrl2";
            this.personDetailsCtrl2.Size = new System.Drawing.Size(834, 389);
            this.personDetailsCtrl2.TabIndex = 2;
            // 
            // CtrlUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.personDetailsCtrl2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CtrlUserInfo";
            this.Size = new System.Drawing.Size(841, 478);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PersonDetailsCtrl personDetailsCtrl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbUserID;
        private System.Windows.Forms.Label LbIsActive;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LbUserName;
        private PersonDetailsCtrl personDetailsCtrl2;
    }
}
