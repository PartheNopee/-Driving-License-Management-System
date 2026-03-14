namespace DVLDApp
{
    partial class AddPersonScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPersonScreen));
            this.LbAddUpdate = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.LbID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LbdeleteImg = new System.Windows.Forms.LinkLabel();
            this.linkEditImage = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CountryCB = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.MaleRD = new System.Windows.Forms.RadioButton();
            this.DatePickerDOB = new System.Windows.Forms.DateTimePicker();
            this.femaleRB = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.Emailtxt = new System.Windows.Forms.TextBox();
            this.Secnametxt = new System.Windows.Forms.TextBox();
            this.AdressTxt = new System.Windows.Forms.TextBox();
            this.PhoneTxt = new System.Windows.Forms.TextBox();
            this.firstNametxt = new System.Windows.Forms.TextBox();
            this.thirdnametxt = new System.Windows.Forms.TextBox();
            this.Lastnametxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NationIDtxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LbAddUpdate
            // 
            this.LbAddUpdate.AutoSize = true;
            this.LbAddUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbAddUpdate.ForeColor = System.Drawing.Color.Brown;
            this.LbAddUpdate.Location = new System.Drawing.Point(276, 66);
            this.LbAddUpdate.Name = "LbAddUpdate";
            this.LbAddUpdate.Size = new System.Drawing.Size(231, 31);
            this.LbAddUpdate.TabIndex = 1;
            this.LbAddUpdate.Text = "Add New Person";
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(550, 434);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 31);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.Image")));
            this.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSave.Location = new System.Drawing.Point(662, 434);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(85, 31);
            this.BtnSave.TabIndex = 4;
            this.BtnSave.Text = "Save";
            this.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // LbID
            // 
            this.LbID.AutoSize = true;
            this.LbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbID.Location = new System.Drawing.Point(144, 128);
            this.LbID.Name = "LbID";
            this.LbID.Size = new System.Drawing.Size(29, 15);
            this.LbID.TabIndex = 19;
            this.LbID.Text = "N/A";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LbdeleteImg);
            this.groupBox1.Controls.Add(this.linkEditImage);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.CountryCB);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.MaleRD);
            this.groupBox1.Controls.Add(this.DatePickerDOB);
            this.groupBox1.Controls.Add(this.femaleRB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Emailtxt);
            this.groupBox1.Controls.Add(this.Secnametxt);
            this.groupBox1.Controls.Add(this.AdressTxt);
            this.groupBox1.Controls.Add(this.PhoneTxt);
            this.groupBox1.Controls.Add(this.firstNametxt);
            this.groupBox1.Controls.Add(this.thirdnametxt);
            this.groupBox1.Controls.Add(this.Lastnametxt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.NationIDtxt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(57, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(690, 255);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // LbdeleteImg
            // 
            this.LbdeleteImg.AutoSize = true;
            this.LbdeleteImg.Location = new System.Drawing.Point(584, 184);
            this.LbdeleteImg.Name = "LbdeleteImg";
            this.LbdeleteImg.Size = new System.Drawing.Size(70, 13);
            this.LbdeleteImg.TabIndex = 31;
            this.LbdeleteImg.TabStop = true;
            this.LbdeleteImg.Text = "Delete Image";
            // 
            // linkEditImage
            // 
            this.linkEditImage.AutoSize = true;
            this.linkEditImage.Location = new System.Drawing.Point(521, 184);
            this.linkEditImage.Name = "linkEditImage";
            this.linkEditImage.Size = new System.Drawing.Size(57, 13);
            this.linkEditImage.TabIndex = 16;
            this.linkEditImage.TabStop = true;
            this.linkEditImage.Text = "Edit Image";
            this.linkEditImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkEditImage_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLDApp.Properties.Resources.pic4;
            this.pictureBox1.Location = new System.Drawing.Point(524, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // CountryCB
            // 
            this.CountryCB.FormattingEnabled = true;
            this.CountryCB.Location = new System.Drawing.Point(392, 127);
            this.CountryCB.Name = "CountryCB";
            this.CountryCB.Size = new System.Drawing.Size(100, 21);
            this.CountryCB.TabIndex = 30;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(282, 13);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 13);
            this.label15.TabIndex = 28;
            this.label15.Text = "SecondName";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(417, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "ThirdName";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(549, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "LastName";
            // 
            // MaleRD
            // 
            this.MaleRD.AutoSize = true;
            this.MaleRD.Location = new System.Drawing.Point(199, 97);
            this.MaleRD.Name = "MaleRD";
            this.MaleRD.Size = new System.Drawing.Size(48, 17);
            this.MaleRD.TabIndex = 25;
            this.MaleRD.TabStop = true;
            this.MaleRD.Tag = "0";
            this.MaleRD.Text = "Male";
            this.MaleRD.UseVisualStyleBackColor = true;
            this.MaleRD.CheckedChanged += new System.EventHandler(this.MaleRD_Click);
            // 
            // DatePickerDOB
            // 
            this.DatePickerDOB.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePickerDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePickerDOB.Location = new System.Drawing.Point(392, 60);
            this.DatePickerDOB.MaxDate = new System.DateTime(2006, 12, 31, 0, 0, 0, 0);
            this.DatePickerDOB.Name = "DatePickerDOB";
            this.DatePickerDOB.Size = new System.Drawing.Size(100, 20);
            this.DatePickerDOB.TabIndex = 23;
            this.DatePickerDOB.Value = new System.DateTime(2006, 12, 31, 0, 0, 0, 0);
            // 
            // femaleRB
            // 
            this.femaleRB.AutoSize = true;
            this.femaleRB.Location = new System.Drawing.Point(134, 97);
            this.femaleRB.Name = "femaleRB";
            this.femaleRB.Size = new System.Drawing.Size(59, 17);
            this.femaleRB.TabIndex = 22;
            this.femaleRB.TabStop = true;
            this.femaleRB.Tag = "1";
            this.femaleRB.Text = "Female";
            this.femaleRB.UseVisualStyleBackColor = true;
            this.femaleRB.CheckedChanged += new System.EventHandler(this.femaleRB_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(155, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "FirstName";
            // 
            // Emailtxt
            // 
            this.Emailtxt.AccessibleName = "";
            this.Emailtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Emailtxt.Location = new System.Drawing.Point(134, 127);
            this.Emailtxt.Name = "Emailtxt";
            this.Emailtxt.Size = new System.Drawing.Size(100, 20);
            this.Emailtxt.TabIndex = 20;
            // 
            // Secnametxt
            // 
            this.Secnametxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Secnametxt.Location = new System.Drawing.Point(269, 29);
            this.Secnametxt.Name = "Secnametxt";
            this.Secnametxt.Size = new System.Drawing.Size(100, 20);
            this.Secnametxt.TabIndex = 19;
            // 
            // AdressTxt
            // 
            this.AdressTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AdressTxt.Location = new System.Drawing.Point(112, 169);
            this.AdressTxt.Multiline = true;
            this.AdressTxt.Name = "AdressTxt";
            this.AdressTxt.Size = new System.Drawing.Size(338, 58);
            this.AdressTxt.TabIndex = 18;
            // 
            // PhoneTxt
            // 
            this.PhoneTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhoneTxt.Location = new System.Drawing.Point(392, 94);
            this.PhoneTxt.Name = "PhoneTxt";
            this.PhoneTxt.Size = new System.Drawing.Size(100, 20);
            this.PhoneTxt.TabIndex = 16;
            // 
            // firstNametxt
            // 
            this.firstNametxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstNametxt.Location = new System.Drawing.Point(134, 29);
            this.firstNametxt.MaxLength = 50;
            this.firstNametxt.Name = "firstNametxt";
            this.firstNametxt.Size = new System.Drawing.Size(100, 20);
            this.firstNametxt.TabIndex = 15;
            // 
            // thirdnametxt
            // 
            this.thirdnametxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.thirdnametxt.Location = new System.Drawing.Point(392, 29);
            this.thirdnametxt.Name = "thirdnametxt";
            this.thirdnametxt.Size = new System.Drawing.Size(100, 20);
            this.thirdnametxt.TabIndex = 14;
            // 
            // Lastnametxt
            // 
            this.Lastnametxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lastnametxt.Location = new System.Drawing.Point(524, 29);
            this.Lastnametxt.Name = "Lastnametxt";
            this.Lastnametxt.Size = new System.Drawing.Size(112, 20);
            this.Lastnametxt.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Name :";
            // 
            // NationIDtxt
            // 
            this.NationIDtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NationIDtxt.Location = new System.Drawing.Point(134, 62);
            this.NationIDtxt.Name = "NationIDtxt";
            this.NationIDtxt.Size = new System.Drawing.Size(100, 20);
            this.NationIDtxt.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "National ID :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(19, 124);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 15);
            this.label12.TabIndex = 11;
            this.label12.Text = "Email :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Gendor :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(266, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 15);
            this.label11.TabIndex = 10;
            this.label11.Text = "Country :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Adresse : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(266, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "Phone :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(266, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Date Of Birth :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Person ID :";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AddPersonScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 483);
            this.Controls.Add(this.LbID);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.LbAddUpdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddPersonScreen";
            this.Text = "AddPersonScreen";
            this.Load += new System.EventHandler(this.AddPersonScreen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LbAddUpdate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label LbID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkEditImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox CountryCB;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton MaleRD;
        private System.Windows.Forms.DateTimePicker DatePickerDOB;
        private System.Windows.Forms.RadioButton femaleRB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Emailtxt;
        private System.Windows.Forms.TextBox Secnametxt;
        private System.Windows.Forms.TextBox AdressTxt;
        private System.Windows.Forms.TextBox PhoneTxt;
        private System.Windows.Forms.TextBox firstNametxt;
        private System.Windows.Forms.TextBox thirdnametxt;
        private System.Windows.Forms.TextBox Lastnametxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NationIDtxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.LinkLabel LbdeleteImg;
    }
}