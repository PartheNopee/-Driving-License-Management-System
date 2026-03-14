using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clsBusinessLayerDVLD;
using DVLDApp.Licenses;

namespace DVLDApp.Drivers
{
    public partial class ManageDriversFrm : Form
    {
        public ManageDriversFrm()
        {
            InitializeComponent();
        }

        
        private void ManageDriversFrm_Load(object sender, EventArgs e)
        {
            DataTable dt = clsDriverBLL.GetAllDrivers();
            DGVDrivers.DataSource = dt;

            // Compact columns
            if (DGVDrivers.Rows.Count > 0)
            {
                DGVDrivers.Columns[0].HeaderText = "Driver ID";
                DGVDrivers.Columns[0].Width = 120;

                DGVDrivers.Columns[1].HeaderText = "Person ID";
                DGVDrivers.Columns[1].Width = 120;

                DGVDrivers.Columns[2].HeaderText = "National No.";
                DGVDrivers.Columns[2].Width = 140;

                DGVDrivers.Columns[3].HeaderText = "Full Name";
                DGVDrivers.Columns[3].Width = 320;

                DGVDrivers.Columns[4].HeaderText = "Date";
                DGVDrivers.Columns[4].Width = 170;

                DGVDrivers.Columns[5].HeaderText = "Active Licenses";
                DGVDrivers.Columns[5].Width = 150;
            }

            LbRecords.Text = dt.Rows.Count.ToString();
        }

        private void bntClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showPersonInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)DGVDrivers.CurrentRow.Cells[1].Value;
            PersonInfoScreen frm = new PersonInfoScreen(PersonID);
            frm.ShowDialog();
            //refresh
            ManageDriversFrm_Load(null, null);

        }

        private void showLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)DGVDrivers.CurrentRow.Cells[1].Value;
            LicenseHistoryFrm frm1 = new LicenseHistoryFrm(PersonID);
            frm1.ShowDialog();
        }
    }
}
