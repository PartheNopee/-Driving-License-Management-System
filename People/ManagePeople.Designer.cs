namespace DVLDApp
{
    partial class ManagePeople
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagePeople));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.btnCloseManage = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.LbPersonnum = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.dataGridViewPeople = new System.Windows.Forms.DataGridView();
            this.ContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.EmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PhoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeople)).BeginInit();
            this.ContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(586, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 115);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(571, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Manage People";
            this.label2.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Filter By :";
            this.label3.UseWaitCursor = true;
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Items.AddRange(new object[] {
            "None",
            "PersonID",
            "NationalNo",
            "FirstName",
            "SecondName",
            "ThirdName",
            "LastName",
            "DateOfBirth",
            "Gendor",
            "Email",
            "Phone"});
            this.comboBoxFilter.Location = new System.Drawing.Point(79, 136);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(138, 21);
            this.comboBoxFilter.TabIndex = 12;
            this.comboBoxFilter.UseWaitCursor = true;
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.BackColor = System.Drawing.Color.Snow;
            this.btnAddPerson.Image = ((System.Drawing.Image)(resources.GetObject("btnAddPerson.Image")));
            this.btnAddPerson.Location = new System.Drawing.Point(1204, 133);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(42, 40);
            this.btnAddPerson.TabIndex = 13;
            this.btnAddPerson.Text = " ";
            this.btnAddPerson.UseVisualStyleBackColor = false;
            this.btnAddPerson.UseWaitCursor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // btnCloseManage
            // 
            this.btnCloseManage.BackColor = System.Drawing.Color.Snow;
            this.btnCloseManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseManage.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseManage.Image")));
            this.btnCloseManage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseManage.Location = new System.Drawing.Point(1177, 430);
            this.btnCloseManage.Name = "btnCloseManage";
            this.btnCloseManage.Size = new System.Drawing.Size(69, 33);
            this.btnCloseManage.TabIndex = 14;
            this.btnCloseManage.Text = "Close";
            this.btnCloseManage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCloseManage.UseVisualStyleBackColor = false;
            this.btnCloseManage.UseWaitCursor = true;
            this.btnCloseManage.Click += new System.EventHandler(this.btnCloseManage_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 433);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Record : ";
            this.label4.UseWaitCursor = true;
            // 
            // LbPersonnum
            // 
            this.LbPersonnum.AutoSize = true;
            this.LbPersonnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPersonnum.Location = new System.Drawing.Point(85, 433);
            this.LbPersonnum.Name = "LbPersonnum";
            this.LbPersonnum.Size = new System.Drawing.Size(15, 16);
            this.LbPersonnum.TabIndex = 16;
            this.LbPersonnum.Text = "#";
            this.LbPersonnum.UseWaitCursor = true;
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(223, 136);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(141, 20);
            this.textBoxInput.TabIndex = 17;
            this.textBoxInput.UseWaitCursor = true;
            this.textBoxInput.TextChanged += new System.EventHandler(this.textBoxInput_TextChanged);
            // 
            // dataGridViewPeople
            // 
            this.dataGridViewPeople.AllowUserToAddRows = false;
            this.dataGridViewPeople.AllowUserToDeleteRows = false;
            this.dataGridViewPeople.AllowUserToOrderColumns = true;
            this.dataGridViewPeople.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPeople.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewPeople.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPeople.ContextMenuStrip = this.ContextMenuStrip1;
            this.dataGridViewPeople.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewPeople.Location = new System.Drawing.Point(0, 179);
            this.dataGridViewPeople.Name = "dataGridViewPeople";
            this.dataGridViewPeople.ReadOnly = true;
            this.dataGridViewPeople.Size = new System.Drawing.Size(1258, 296);
            this.dataGridViewPeople.TabIndex = 18;
            this.dataGridViewPeople.UseWaitCursor = true;
            // 
            // ContextMenuStrip1
            // 
            this.ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.toolStripSeparator1,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator2,
            this.EmailToolStripMenuItem,
            this.PhoneToolStripMenuItem});
            this.ContextMenuStrip1.Name = "contextMenuStrip1";
            this.ContextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ContextMenuStrip1.Size = new System.Drawing.Size(142, 126);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(138, 6);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(138, 6);
            // 
            // EmailToolStripMenuItem
            // 
            this.EmailToolStripMenuItem.Name = "EmailToolStripMenuItem";
            this.EmailToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.EmailToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.EmailToolStripMenuItem.Text = "Send Email";
            // 
            // PhoneToolStripMenuItem
            // 
            this.PhoneToolStripMenuItem.Name = "PhoneToolStripMenuItem";
            this.PhoneToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.PhoneToolStripMenuItem.Text = "Phone Call";
            // 
            // ManagePeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 488);
            this.Controls.Add(this.dataGridViewPeople);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.LbPersonnum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCloseManage);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.comboBoxFilter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ManagePeople";
            this.Text = "Manage People";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.ManagePeople_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeople)).EndInit();
            this.ContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Button btnCloseManage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LbPersonnum;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.DataGridView dataGridViewPeople;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PhoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}