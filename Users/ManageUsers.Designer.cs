namespace DVLDApp
{
    partial class ManageUsers
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
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.ContextUserManegment = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.showUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LbRecords = new System.Windows.Forms.Label();
            this.BtnAddUser = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ComboBoIsActive = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.ContextUserManegment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(263, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Users";
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Items.AddRange(new object[] {
            "None",
            "UserID",
            "PersonID",
            "FullName",
            "Username",
            "IsActive"});
            this.comboBoxFilter.Location = new System.Drawing.Point(126, 166);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(144, 21);
            this.comboBoxFilter.TabIndex = 3;
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(290, 166);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(143, 20);
            this.textBoxInput.TabIndex = 4;
            this.textBoxInput.TextChanged += new System.EventHandler(this.textBoxInput_TextChanged);
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewUsers.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.ContextMenuStrip = this.ContextUserManegment;
            this.dataGridViewUsers.Location = new System.Drawing.Point(33, 218);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.Size = new System.Drawing.Size(600, 263);
            this.dataGridViewUsers.TabIndex = 5;
            this.dataGridViewUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsers_CellContentClick);
            // 
            // ContextUserManegment
            // 
            this.ContextUserManegment.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.showUserToolStripMenuItem,
            this.toolStripMenuItem2,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripMenuItem3,
            this.changePasswordToolStripMenuItem});
            this.ContextUserManegment.Name = "ContextUserManegment";
            this.ContextUserManegment.Size = new System.Drawing.Size(181, 132);
            this.ContextUserManegment.Opening += new System.ComponentModel.CancelEventHandler(this.ContextUserManegment_Opening);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // showUserToolStripMenuItem
            // 
            this.showUserToolStripMenuItem.Image = global::DVLDApp.Properties.Resources.account_settings_64;
            this.showUserToolStripMenuItem.Name = "showUserToolStripMenuItem";
            this.showUserToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showUserToolStripMenuItem.Text = "show User";
            this.showUserToolStripMenuItem.Click += new System.EventHandler(this.showUserToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(177, 6);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(30, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Filter By :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(30, 495);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Records :";
            // 
            // LbRecords
            // 
            this.LbRecords.AutoSize = true;
            this.LbRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbRecords.ForeColor = System.Drawing.Color.Black;
            this.LbRecords.Location = new System.Drawing.Point(108, 495);
            this.LbRecords.Name = "LbRecords";
            this.LbRecords.Size = new System.Drawing.Size(15, 16);
            this.LbRecords.TabIndex = 8;
            this.LbRecords.Text = "#";
            // 
            // BtnAddUser
            // 
            this.BtnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddUser.Image = global::DVLDApp.Properties.Resources.Add_New_User_32;
            this.BtnAddUser.Location = new System.Drawing.Point(574, 156);
            this.BtnAddUser.Name = "BtnAddUser";
            this.BtnAddUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnAddUser.Size = new System.Drawing.Size(59, 46);
            this.BtnAddUser.TabIndex = 2;
            this.BtnAddUser.Text = " ";
            this.BtnAddUser.UseVisualStyleBackColor = true;
            this.BtnAddUser.Click += new System.EventHandler(this.BtnAddUser_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLDApp.Properties.Resources.Users_2_400;
            this.pictureBox1.Location = new System.Drawing.Point(248, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ComboBoIsActive
            // 
            this.ComboBoIsActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoIsActive.FormattingEnabled = true;
            this.ComboBoIsActive.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.ComboBoIsActive.Location = new System.Drawing.Point(290, 165);
            this.ComboBoIsActive.Name = "ComboBoIsActive";
            this.ComboBoIsActive.Size = new System.Drawing.Size(143, 21);
            this.ComboBoIsActive.TabIndex = 9;
            this.ComboBoIsActive.Visible = false;
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(668, 536);
            this.Controls.Add(this.ComboBoIsActive);
            this.Controls.Add(this.LbRecords);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewUsers);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.comboBoxFilter);
            this.Controls.Add(this.BtnAddUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ManageUsers";
            this.Text = "ManageUsers";
            this.Load += new System.EventHandler(this.ManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.ContextUserManegment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAddUser;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LbRecords;
        private System.Windows.Forms.ContextMenuStrip ContextUserManegment;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ComboBox ComboBoIsActive;
        private System.Windows.Forms.ToolStripMenuItem showUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
    }
}