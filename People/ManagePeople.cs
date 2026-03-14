using BLLPeople;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLDApp
{
    public partial class ManagePeople : Form
    {
        DataTable dt = clsBLLPeople.GetAllPeople();

        public ManagePeople()
        {
            InitializeComponent();
            
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            Form frm1 = new AddPersonScreen();
            frm1.ShowDialog();
            _RefreshPeopleList();
            
        }



        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxInput.Visible = (comboBoxFilter.Text != "None");         

            textBoxInput.Visible = true;
            textBoxInput.Clear();
            textBoxInput.Focus();
        }

        // Handle filtering based on input text
        


        // Remove any selection when user enters the textbox (prevent text highlight)
        private void textBoxInput_Enter(object sender, EventArgs e)
        {
            textBoxInput.SelectionStart = textBoxInput.Text.Length;
            textBoxInput.SelectionLength = 0;
        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxFilter.SelectedItem == null)
            {
                return;
            }

            string selectedColumn = comboBoxFilter.SelectedItem.ToString();
            string userInput = textBoxInput.Text.Trim();

            if (string.IsNullOrWhiteSpace(userInput))
            {
                // If input is cleared, show all data again
                dataGridViewPeople.DataSource = dt;
                return;
            }

            try
            {
                DataColumn col = dt.Columns[selectedColumn];
                string filterExpression = "";

                switch (Type.GetTypeCode(col.DataType))
                {
                    case TypeCode.String:
                        userInput = userInput.Replace("'", "''");
                        filterExpression = $"{selectedColumn} LIKE '%{userInput}%'";
                        break;

                    case TypeCode.Int32:
                         if (decimal.TryParse(userInput, out _))
                        {
                            filterExpression = $"{selectedColumn} = {userInput}";
                        }
                        else
                        {
                            // Invalid numeric input → show nothing
                            dataGridViewPeople.DataSource = dt.Clone();
                            return;
                        }
                        break;

                    case TypeCode.DateTime:
                        if (DateTime.TryParse(userInput, out DateTime dateValue))
                        {

                            filterExpression = $"{selectedColumn} = #{dateValue:yyyy-MM-dd}#";
                        }
                        else
                        {
                            dataGridViewPeople.DataSource = dt.Clone();
                            return;
                        }
                        break;

                    default:
                        userInput = userInput.Replace("'", "''");
                        filterExpression = $"{selectedColumn} LIKE '%{userInput}%'";
                        break;
                }

                DataRow[] filteredRows = dt.Select(filterExpression);
                DataTable filteredTable = dt.Clone();

                foreach (DataRow row in filteredRows)
                {
                    filteredTable.ImportRow(row);
                }

                dataGridViewPeople.DataSource = filteredTable;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during filtering:\n" + ex.Message);
            }
        }



        private void btnCloseManage_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
           

        private void _RefreshPeopleList()
        {
            dataGridViewPeople.DataSource = clsBLLPeople.GetAllPeople();
            LbPersonnum.Text = clsBLLPeople.GetAllPeople().Rows.Count.ToString();

        }
        private void ManagePeople_Load(object sender, EventArgs e)
        {
            // Hide textBoxInput on load
            textBoxInput.Visible = false;

            // Set default selected item for comboBoxFilter
            comboBoxFilter.SelectedItem = "None";

            // Wire up event handlers
            comboBoxFilter.SelectedIndexChanged += comboBoxFilter_SelectedIndexChanged;
            textBoxInput.Enter += textBoxInput_Enter;
            _RefreshPeopleList();

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ( MessageBox.Show(" Are you sure you want to delete this Person [" + dataGridViewPeople.CurrentRow.Cells[0].Value.ToString(), "Confirm ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                if (clsBLLPeople.DeletePersonbyID((int)dataGridViewPeople.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Person deleted Successfully ");
                    _RefreshPeopleList();

                }
                else
                {
                    MessageBox.Show(" The person was not deleted");

                }


            }
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new PersonInfoScreen((int)dataGridViewPeople.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

            _RefreshPeopleList();

        }



        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new AddPersonScreen((int)dataGridViewPeople.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshPeopleList();

        }
    }
}
