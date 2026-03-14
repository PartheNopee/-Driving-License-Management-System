namespace DVLDApp.Applications.LocalDrivingLicenseApplication
{
    partial class ScheduleTestFrm
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
            this.BtnClose = new System.Windows.Forms.Button();
            this.ctrlscheduleTest2 = new DVLDApp.Applications.LocalDrivingLicenseApplication.Controls.ctrlscheduleTest();
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Image = global::DVLDApp.Properties.Resources.Close_32;
            this.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClose.Location = new System.Drawing.Point(140, 648);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(113, 37);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // ctrlscheduleTest2
            // 
            this.ctrlscheduleTest2.Location = new System.Drawing.Point(3, 12);
            this.ctrlscheduleTest2.Name = "ctrlscheduleTest2";
            this.ctrlscheduleTest2.Size = new System.Drawing.Size(419, 620);
            this.ctrlscheduleTest2.TabIndex = 4;
            this.ctrlscheduleTest2.TestType = clsBusinessLayerDVLD.clstestTypesBLL.enTestType.visionTest;
            // 
            // ScheduleTestFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 699);
            this.Controls.Add(this.ctrlscheduleTest2);
            this.Controls.Add(this.BtnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ScheduleTestFrm";
            this.Text = "ScheduleTest";
            this.Load += new System.EventHandler(this.ScheduleTestFrm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnClose;
        private Controls.ctrlscheduleTest ctrlscheduleTest1;
        private Controls.ctrlscheduleTest ctrlscheduleTest2;
    }
}