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
    public partial class ManageAppTypes : Form
    {
        public ManageAppTypes()
        {
            InitializeComponent();

        }

         

        private void editApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new UpdateAppTypes((int)DatagridAppTypes.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _loadData();
        }

        

        private void _loadData()
        {

            DatagridAppTypes.DataSource = clsAppTypesBLL.getAllApp();
            Lbrecds.Text = clsAppTypesBLL.getAllApp().Rows.Count.ToString();


        }

        private void ManageAppTypes_Load(object sender, EventArgs e)
        {
            _loadData();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
