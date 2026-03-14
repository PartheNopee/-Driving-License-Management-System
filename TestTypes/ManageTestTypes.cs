using clsBusinessLayerDVLD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDApp
{
    public partial class ManageTestTypes : Form
    {
        public ManageTestTypes()
        {
            InitializeComponent();
        }

         

        private void ManageTestTypes_Load(object sender, EventArgs e)
        {
            _LoadDataTests();
        }
        private void _LoadDataTests()
        {
            DataTable dt =  clstestTypesBLL.GetAllTest();
            DataGridTest.DataSource = dt;
            LbRec.Text = dt.Rows.Count.ToString();


        }

        private void editTestTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new UpdateTestTypes((clstestTypesBLL.enTestType)DataGridTest.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            ManageTestTypes_Load(null, null);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
