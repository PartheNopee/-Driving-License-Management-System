namespace DVLDApp
{
    partial class PersonInfoScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.personDetailsCtrl2 = new DVLDApp.PersonDetailsCtrl();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(308, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Person Details";
            // 
            // personDetailsCtrl2
            // 
            this.personDetailsCtrl2.Location = new System.Drawing.Point(22, 79);
            this.personDetailsCtrl2.Name = "personDetailsCtrl2";
            this.personDetailsCtrl2.Size = new System.Drawing.Size(834, 389);
            this.personDetailsCtrl2.TabIndex = 2;
            this.personDetailsCtrl2.Load += new System.EventHandler(this.personDetailsCtrl2_Load);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLDApp.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(739, 459);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(117, 29);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // PersonInfoScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(877, 525);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.personDetailsCtrl2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "PersonInfoScreen";
            this.Text = "Person Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PersonDetailsCtrl personDetailsCtrl1;
        private System.Windows.Forms.Label label1;
        private PersonDetailsCtrl personDetailsCtrl2;
        private System.Windows.Forms.Button btnClose;
    }
}