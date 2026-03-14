namespace DVLDApp.Applications
{
    partial class TakeTestFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TakeTestFrm));
            this.rdPass = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.rdFail = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtNotes = new System.Windows.Forms.TextBox();
            this.gbRetake = new System.Windows.Forms.GroupBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.ctrlTakeTest2 = new DVLDApp.Applications.LocalDrivingLicenseApplication.Controls.CtrlTakeTest();
            this.gbRetake.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // rdPass
            // 
            this.rdPass.AutoSize = true;
            this.rdPass.Checked = true;
            this.rdPass.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdPass.Location = new System.Drawing.Point(114, 29);
            this.rdPass.Name = "rdPass";
            this.rdPass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdPass.Size = new System.Drawing.Size(53, 21);
            this.rdPass.TabIndex = 24;
            this.rdPass.TabStop = true;
            this.rdPass.Tag = "1";
            this.rdPass.Text = "Pass";
            this.rdPass.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(10, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 16);
            this.label12.TabIndex = 29;
            this.label12.Text = "Result:";
            // 
            // rdFail
            // 
            this.rdFail.AutoSize = true;
            this.rdFail.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdFail.Location = new System.Drawing.Point(173, 31);
            this.rdFail.Name = "rdFail";
            this.rdFail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdFail.Size = new System.Drawing.Size(48, 21);
            this.rdFail.TabIndex = 32;
            this.rdFail.Tag = "2";
            this.rdFail.Text = "Fail";
            this.rdFail.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 16);
            this.label11.TabIndex = 33;
            this.label11.Text = "Result:";
            // 
            // TxtNotes
            // 
            this.TxtNotes.Location = new System.Drawing.Point(123, 58);
            this.TxtNotes.Multiline = true;
            this.TxtNotes.Name = "TxtNotes";
            this.TxtNotes.Size = new System.Drawing.Size(285, 76);
            this.TxtNotes.TabIndex = 35;
            // 
            // gbRetake
            // 
            this.gbRetake.Controls.Add(this.TxtNotes);
            this.gbRetake.Controls.Add(this.pictureBox9);
            this.gbRetake.Controls.Add(this.rdPass);
            this.gbRetake.Controls.Add(this.label11);
            this.gbRetake.Controls.Add(this.label12);
            this.gbRetake.Controls.Add(this.rdFail);
            this.gbRetake.Controls.Add(this.pictureBox8);
            this.gbRetake.Location = new System.Drawing.Point(12, 513);
            this.gbRetake.Name = "gbRetake";
            this.gbRetake.Size = new System.Drawing.Size(410, 149);
            this.gbRetake.TabIndex = 36;
            this.gbRetake.TabStop = false;
            this.gbRetake.Text = "Retake Test ";
            this.gbRetake.Enter += new System.EventHandler(this.gbRetake_Enter);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::DVLDApp.Properties.Resources.Notes_32;
            this.pictureBox9.Location = new System.Drawing.Point(73, 58);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(26, 20);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 34;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(73, 26);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(26, 20);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 30;
            this.pictureBox8.TabStop = false;
            // 
            // BtnClose
            // 
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Image = global::DVLDApp.Properties.Resources.Close_32;
            this.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClose.Location = new System.Drawing.Point(192, 668);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(107, 30);
            this.BtnClose.TabIndex = 5;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::DVLDApp.Properties.Resources.Save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(315, 668);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 30);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ctrlTakeTest2
            // 
            this.ctrlTakeTest2.Location = new System.Drawing.Point(1, 12);
            this.ctrlTakeTest2.Name = "ctrlTakeTest2";
            this.ctrlTakeTest2.Size = new System.Drawing.Size(421, 481);
            this.ctrlTakeTest2.TabIndex = 36;
            // 
            // TakeTestFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 710);
            this.Controls.Add(this.ctrlTakeTest2);
            this.Controls.Add(this.gbRetake);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TakeTestFrm";
            this.Text = "Take Test";
            this.Load += new System.EventHandler(this.TakeTestFrm_Load);
            this.gbRetake.ResumeLayout(false);
            this.gbRetake.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton rdPass;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton rdFail;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtNotes;
        private System.Windows.Forms.GroupBox gbRetake;
        private LocalDrivingLicenseApplication.Controls.CtrlTakeTest ctrlTakeTest2;
    }
}