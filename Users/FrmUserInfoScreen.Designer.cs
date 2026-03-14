namespace DVLDApp
{
    partial class FrmUserInfoScreen
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
            this.button1 = new System.Windows.Forms.Button();
            this.ctrlUserInfo1 = new DVLDApp.CtrlUserInfo();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::DVLDApp.Properties.Resources.Close_32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(719, 475);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ctrlUserInfo1
            // 
            this.ctrlUserInfo1.Location = new System.Drawing.Point(0, 0);
            this.ctrlUserInfo1.Name = "ctrlUserInfo1";
            this.ctrlUserInfo1.Size = new System.Drawing.Size(841, 478);
            this.ctrlUserInfo1.TabIndex = 0;
            this.ctrlUserInfo1.Load += new System.EventHandler(this.ctrlUserInfo1_Load);
            // 
            // FrmUserInfoScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 520);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ctrlUserInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmUserInfoScreen";
            this.Text = "UserInfoScreen";
            this.Load += new System.EventHandler(this.FrmUserInfoScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CtrlUserInfo ctrlUserInfo1;
        private System.Windows.Forms.Button button1;
    }
}