namespace DVLDApp
{
    partial class CtrlFindPerson
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
            this.FilterFindPerson = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.bntFindPerson = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtFilterValue = new System.Windows.Forms.TextBox();
            this.CbPersonFilter = new System.Windows.Forms.ComboBox();
            this.personDetailsCtrl2 = new DVLDApp.PersonDetailsCtrl();
            this.FilterFindPerson.SuspendLayout();
            this.SuspendLayout();
            // 
            // FilterFindPerson
            // 
            this.FilterFindPerson.Controls.Add(this.button2);
            this.FilterFindPerson.Controls.Add(this.bntFindPerson);
            this.FilterFindPerson.Controls.Add(this.label4);
            this.FilterFindPerson.Controls.Add(this.TxtFilterValue);
            this.FilterFindPerson.Controls.Add(this.CbPersonFilter);
            this.FilterFindPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterFindPerson.Location = new System.Drawing.Point(14, 14);
            this.FilterFindPerson.Name = "FilterFindPerson";
            this.FilterFindPerson.Size = new System.Drawing.Size(702, 70);
            this.FilterFindPerson.TabIndex = 13;
            this.FilterFindPerson.TabStop = false;
            this.FilterFindPerson.Text = "Filter";
            this.FilterFindPerson.Enter += new System.EventHandler(this.FilterFindPerson_Enter);
            // 
            // button2
            // 
            this.button2.Image = global::DVLDApp.Properties.Resources.AddPerson_32;
            this.button2.Location = new System.Drawing.Point(641, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 42);
            this.button2.TabIndex = 4;
            this.button2.Text = " ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bntFindPerson
            // 
            this.bntFindPerson.Image = global::DVLDApp.Properties.Resources.SearchPerson1;
            this.bntFindPerson.Location = new System.Drawing.Point(567, 21);
            this.bntFindPerson.Name = "bntFindPerson";
            this.bntFindPerson.Size = new System.Drawing.Size(48, 42);
            this.bntFindPerson.TabIndex = 3;
            this.bntFindPerson.Text = " ";
            this.bntFindPerson.UseVisualStyleBackColor = true;
            this.bntFindPerson.Click += new System.EventHandler(this.bntFindPerson_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Find By :";
            // 
            // TxtFilterValue
            // 
            this.TxtFilterValue.Location = new System.Drawing.Point(316, 33);
            this.TxtFilterValue.Name = "TxtFilterValue";
            this.TxtFilterValue.Size = new System.Drawing.Size(234, 22);
            this.TxtFilterValue.TabIndex = 1;
            // 
            // CbPersonFilter
            // 
            this.CbPersonFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbPersonFilter.FormattingEnabled = true;
            this.CbPersonFilter.Items.AddRange(new object[] {
            "None",
            "Person ID",
            "National No",
            " "});
            this.CbPersonFilter.Location = new System.Drawing.Point(90, 33);
            this.CbPersonFilter.Name = "CbPersonFilter";
            this.CbPersonFilter.Size = new System.Drawing.Size(220, 24);
            this.CbPersonFilter.TabIndex = 0;
            // 
            // personDetailsCtrl2
            // 
            this.personDetailsCtrl2.AutoSize = true;
            this.personDetailsCtrl2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.personDetailsCtrl2.Location = new System.Drawing.Point(0, 90);
            this.personDetailsCtrl2.Name = "personDetailsCtrl2";
            this.personDetailsCtrl2.Size = new System.Drawing.Size(713, 313);
            this.personDetailsCtrl2.TabIndex = 14;
            // 
            // CtrlFindPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.personDetailsCtrl2);
            this.Controls.Add(this.FilterFindPerson);
            this.Name = "CtrlFindPerson";
            this.Size = new System.Drawing.Size(727, 413);
            this.FilterFindPerson.ResumeLayout(false);
            this.FilterFindPerson.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox FilterFindPerson;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bntFindPerson;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtFilterValue;
        private System.Windows.Forms.ComboBox CbPersonFilter;
        private PersonDetailsCtrl personDetailsCtrl1;
        private PersonDetailsCtrl personDetailsCtrl2;
    }
}
