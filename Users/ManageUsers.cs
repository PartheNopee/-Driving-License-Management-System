using BLLPeople;
using clsBusinessLayerDVLD;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLDApp
{
    public partial class ManageUsers : Form
    {
        private DataTable dt;

        public ManageUsers()
        {
            InitializeComponent();
        }

        private void _RefreshData()
        {
            dt = clsUserBLL.GetAllUser(); // Load data once
            dataGridViewUsers.DataSource = dt;
            LbRecords.Text = dt.Rows.Count.ToString();
            dataGridViewUsers.Columns[2].HeaderText = "Full Name";
            dataGridViewUsers.Columns[2].Width = 350;
        }

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            using (Form frm = new AddUserScreen())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    _RefreshData(); // Refresh after adding user
                }
            }
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            textBoxInput.Visible = false;
            ComboBoIsActive.Visible = false;

            // Populate filter columns
            dt = clsUserBLL.GetAllUser();
            comboBoxFilter.Items.Clear();
            foreach (DataColumn col in dt.Columns)
                comboBoxFilter.Items.Add(col.ColumnName);

            if (!comboBoxFilter.Items.Contains("IsActive"))
                comboBoxFilter.Items.Add("IsActive");

            comboBoxFilter.SelectedIndex = 0;

            // Populate IsActive combo
            ComboBoIsActive.Items.Clear();
            ComboBoIsActive.Items.Add("All");
            ComboBoIsActive.Items.Add("Yes");
            ComboBoIsActive.Items.Add("No");
            ComboBoIsActive.SelectedIndex = 0;

            // Wire up events
            comboBoxFilter.SelectedIndexChanged += comboBoxFilter_SelectedIndexChanged;
            ComboBoIsActive.SelectedIndexChanged += ComboBoIsActive_SelectedIndexChanged;
            textBoxInput.Enter += textBoxInput_Enter;

            _RefreshData();
        }

        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFilter.SelectedItem == null)
            {
                textBoxInput.Visible = false;
                ComboBoIsActive.Visible = false;
                return;
            }

            string selected = comboBoxFilter.SelectedItem.ToString();

            if (selected == "IsActive")
            {
                textBoxInput.Visible = false;
                ComboBoIsActive.Visible = true;
            }
            else
            {
                textBoxInput.Visible = true;
                textBoxInput.Clear();
                textBoxInput.Focus();
                ComboBoIsActive.Visible = false;
            }
        }

        private void ComboBoIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFilter.SelectedItem?.ToString() != "IsActive")
                return;

            string filterExpression = "";
            string selectedValue = ComboBoIsActive.SelectedItem?.ToString();

            switch (selectedValue)
            {
                case "Yes":
                    filterExpression = "IsActive = true";
                    break;

                case "No":
                    filterExpression = "IsActive = false";
                    break;

                case "All":
                    // Reset to show all data
                    dt.DefaultView.RowFilter = string.Empty;
                    return;

                default:
                    dt.DefaultView.RowFilter = string.Empty;
                    return;
            }

            try
            {
                // Apply RowFilter directly on DefaultView
                dt.DefaultView.RowFilter = filterExpression;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during filtering:\n" + ex.Message);
            }
        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxFilter.SelectedItem == null)
                return;

            string selectedColumn = comboBoxFilter.SelectedItem.ToString();
            string userInput = textBoxInput.Text.Trim();

            if (string.IsNullOrWhiteSpace(userInput))
            {
                // Clear filter to show all data
                dt.DefaultView.RowFilter = string.Empty;
                return;
            }

            try
            {
                if (!dt.Columns.Contains(selectedColumn))
                    return;

                DataColumn col = dt.Columns[selectedColumn];
                string filterExpression = "";

                // Construct RowFilter expression based on column type
                switch (Type.GetTypeCode(col.DataType))
                {
                    case TypeCode.String:
                        // Escape single quotes to avoid SQL injection-like issues
                        userInput = userInput.Replace("'", "''");
                        filterExpression = $"[{selectedColumn}] LIKE '%{userInput}%'";
                        break;

                    case TypeCode.Int32:
                        if (int.TryParse(userInput, out _))
                            filterExpression = $"[{selectedColumn}] = {userInput}";
                        else
                        {
                            // Invalid input for integer field, clear filter
                            dt.DefaultView.RowFilter = string.Empty;
                            MessageBox.Show("Please enter a valid number for this field.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        break;

                    default:
                        // For other types, treat as string
                        userInput = userInput.Replace("'", "''");
                        filterExpression = $"[{selectedColumn}] LIKE '%{userInput}%'";
                        break;
                }

                // Apply the RowFilter to the DefaultView
                dt.DefaultView.RowFilter = filterExpression;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during filtering:\n" + ex.Message);
            }
        }

        private void textBoxInput_Enter(object sender, EventArgs e)
        {
            textBoxInput.SelectionStart = textBoxInput.Text.Length;
            textBoxInput.SelectionLength = 0;
        }

        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optional: Handle clicks on cells if needed
        }

        private void showUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUserInfoScreen from1 = new FrmUserInfoScreen((int)dataGridViewUsers.CurrentRow.Cells[0].Value);
            from1.ShowDialog();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUserScreen form2 = new AddUserScreen((int)dataGridViewUsers.CurrentRow.Cells[0].Value);
            form2.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = (int)dataGridViewUsers.CurrentRow.Cells[0].Value;
            if (clsUserBLL.DeleteUser(UserID))
            {
                MessageBox.Show("User has been deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _RefreshData(); // Refresh the data after deletion
            }
            else
            {
                MessageBox.Show("User is not deleted due to data connected to it.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ContextUserManegment_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
