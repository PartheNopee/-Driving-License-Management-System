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
using DVLDApp.Applications.LocalDrivingLicenseApplication;
using DVLDApp.Licenses;

namespace DVLDApp
{
    public partial class ManageLocalApplications : Form
    {
        DataTable dt;
        clsLocalDLApplicattionBLL LocalDrivingLicenseApplication;

        public ManageLocalApplications()
        {
            InitializeComponent();
        }
        void _RefreshApp()
        {

            dt = clsApplicationBLL.GetAllApp();
            dgvLocalDrivingLicenseApplications.DataSource = dt;
            lbRecs.Text = dt.Rows.Count.ToString();


        }

        private void ManageApplications_Load(object sender, EventArgs e)
        {
            _RefreshApp();

            if (dgvLocalDrivingLicenseApplications.Rows.Count > 0)
            {

                dgvLocalDrivingLicenseApplications.Columns[0].HeaderText = "L.D.L.AppID";
                dgvLocalDrivingLicenseApplications.Columns[0].Width = 120;

                dgvLocalDrivingLicenseApplications.Columns[1].HeaderText = "Driving Class";
                dgvLocalDrivingLicenseApplications.Columns[1].Width = 300;

                dgvLocalDrivingLicenseApplications.Columns[2].HeaderText = "National No.";
                dgvLocalDrivingLicenseApplications.Columns[2].Width = 150;

                dgvLocalDrivingLicenseApplications.Columns[3].HeaderText = "Full Name";
                dgvLocalDrivingLicenseApplications.Columns[3].Width = 350;

                dgvLocalDrivingLicenseApplications.Columns[4].HeaderText = "Application Date";
                dgvLocalDrivingLicenseApplications.Columns[4].Width = 170;

                dgvLocalDrivingLicenseApplications.Columns[5].HeaderText = "Passed Tests";
                dgvLocalDrivingLicenseApplications.Columns[5].Width = 150;
            }

            cbFilterBy.SelectedIndex = 0; 
        }

        private void btnAddApp_Click(object sender, EventArgs e)
        {
            Form frm1 = new NewLocalLicenseDriverApp();
            frm1.ShowDialog();
            _RefreshApp();

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            int App = (int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value;
            if (clsLocalDLApplicattionBLL.DeleteApp(App))
            {
                MessageBox.Show("Application has been deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _RefreshApp();

            }
            else
            {
                MessageBox.Show("Application is not deleted due to data connected to it.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void schedualeWritingTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form3 = new testAppointmentFrm(clstestTypesBLL.enTestType.writtenTest, (int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value);
            form3.ShowDialog();
            _RefreshApp();

        }

        private void schedualeVisionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Form form3 = new testAppointmentFrm(clstestTypesBLL.enTestType.visionTest, (int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value);
            form3.ShowDialog();
            _RefreshApp();

        }
        private void scheduleStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form3 = new testAppointmentFrm(clstestTypesBLL.enTestType.StreetTest, (int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value);
            form3.ShowDialog();
            _RefreshApp();

        }
        private void showInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formInfo = new ApplicationInfoFrm((int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value);
           formInfo.ShowDialog();
            _RefreshApp();

        }

        private void schedualeTestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
        }

        private void cMSManageAp_Opening(object sender, CancelEventArgs e)
        {
            int LocalLicenseID = (int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value;
            LocalDrivingLicenseApplication = clsLocalDLApplicattionBLL.Find(LocalLicenseID);
           
            
            int totalPassedTests = (int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[5].Value;
            bool LicenseExists = LocalDrivingLicenseApplication.IsLicenseActive();

            //issue license for the first time
            issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = (totalPassedTests == 3) && !LicenseExists;

            showLicenseToolStripMenuItem.Enabled = LicenseExists;
            editToolStripMenuItem.Enabled = !LicenseExists && (LocalDrivingLicenseApplication.ApplicationStatus == 
                clsApplicationBLL.enApplicationStatus.New);
            schedualeTestsToolStripMenuItem.Enabled = !LicenseExists;

            cancelApplicationToolStripMenuItem.Enabled = (LocalDrivingLicenseApplication.ApplicationStatus == clsApplicationBLL.enApplicationStatus.New);
              //Enable/Disable Delete Menue Item
            //We only allow delete incase the application status is new not complete or Cancelled.
            deleteToolStripMenuItem.Enabled =
                (LocalDrivingLicenseApplication.ApplicationStatus == clsApplicationBLL.enApplicationStatus.New);


            bool PassedVisionTest = LocalDrivingLicenseApplication.DoesPassTestType(clstestTypesBLL.enTestType.visionTest); ;
            bool PassedWrittenTest = LocalDrivingLicenseApplication.DoesPassTestType(clstestTypesBLL.enTestType.writtenTest);
            bool PassedStreetTest = LocalDrivingLicenseApplication.DoesPassTestType(clstestTypesBLL.enTestType.StreetTest);

            schedualeTestsToolStripMenuItem.Enabled = (!PassedVisionTest || !PassedWrittenTest || !PassedStreetTest) && (LocalDrivingLicenseApplication.ApplicationStatus == clsApplicationBLL.enApplicationStatus.New);

            if (schedualeTestsToolStripMenuItem.Enabled)
            {
                //To Allow Schdule vision test, Person must not passed the same test before.
                schedualeVisionTestToolStripMenuItem.Enabled = !PassedVisionTest;

                //To Allow Schdule written test, Person must pass the vision test and must not passed the same test before.
                schedualeWritingTestToolStripMenuItem.Enabled = PassedVisionTest && !PassedWrittenTest;

                //To Allow Schdule steet test, Person must pass the vision * written tests, and must not passed the same test before.
                scheduleStreetTestToolStripMenuItem.Enabled = PassedVisionTest && PassedWrittenTest && !PassedStreetTest;

            }




        }

        private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(LocalDrivingLicenseApplication.Cancel())
            {
                MessageBox.Show("Application status has been updated succussefully ! ", "Operation Successed ");
                _RefreshApp();

            }

        }


       

        private void issueDrivingLicenseFirstTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LocalID = (int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value;

          
              //  issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = true;
                Form IssueFrm = new issueDriverLicenseFrm(LocalID);
                IssueFrm.ShowDialog();
                _RefreshApp();



        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LocalDrivingLicenseApplication = clsLocalDLApplicattionBLL.Find((int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value);
            Form form = new LicenseHistoryFrm(LocalDrivingLicenseApplication.ApplicantPersonID);
            form.ShowDialog();

        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
                int LocalDrivingLicenseApplicationID = (int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value;

            int LicenseID = clsLocalDLApplicattionBLL.Find(
                   LocalDrivingLicenseApplicationID).GetActiveLicenseID();

                if (LicenseID != -1)
                {
                    Form form = new LicenseInfoFrm(LicenseID);
                    form.ShowDialog();

                }
                else
                {
                    MessageBox.Show("No License Found!", "No License", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
               
             }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cbFilterBy.Text)
            {

                case "L.D.L.AppID":
                    FilterColumn = "LocalDrivingLicenseApplicationID";
                    break;

                case "National No.":
                    FilterColumn = "NationalNo";
                    break;


                case "Full Name":
                    FilterColumn = "FullName";
                    break;

                case "Status":
                    FilterColumn = "Status";
                    break;


                default:
                    FilterColumn = "None";
                    break;

            }

            //Reset the filters in case nothing selected or filter value conains nothing.
            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                dt.DefaultView.RowFilter = "";
                lbRecs.Text = dgvLocalDrivingLicenseApplications.Rows.Count.ToString();
                return;
            }


            if (FilterColumn == "LocalDrivingLicenseApplicationID")
                //in this case we deal with integer not string.
                dt.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
            else
                dt.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());

            lbRecs.Text = dgvLocalDrivingLicenseApplications.Rows.Count.ToString();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbFilterBy.Text != "None");

            if (txtFilterValue.Visible)
            {
                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }

            dt.DefaultView.RowFilter = "";
            lbRecs.Text = dgvLocalDrivingLicenseApplications.Rows.Count.ToString();
        }
    }
}

