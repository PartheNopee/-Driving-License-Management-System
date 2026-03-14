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
using DVLDApp.Properties;

namespace DVLDApp.Applications.LocalDrivingLicenseApplication
{
    public partial class testAppointmentFrm : Form
    {
        private int LocalAppID = -1;
         private DataTable dt;
         private clstestTypesBLL.enTestType _TestType = clstestTypesBLL.enTestType.visionTest;
        private clsLocalDLApplicattionBLL localDrivingLicenseApplication;
        public testAppointmentFrm(clstestTypesBLL.enTestType TestID, int ID)
        {
            LocalAppID = ID;
            InitializeComponent();
            _TestType = TestID;
        }

        //  Single Responsibility Principle (SRP)


        // Updates the UI components based on the selected test type


        private void SetTestProperties(clstestTypesBLL.enTestType testType)
        {
 
            clstestTypesBLL _TestTypeInfo = clstestTypesBLL.FindTest(testType);
            string title = _TestTypeInfo.TestTitle;
            Image testImage = null;
            int testIndex = -1;

            switch (testType)
            {
                case clstestTypesBLL.enTestType.visionTest:
                    testImage = Resources.Vision_512;
                    //enum better than magic number...
                    testIndex = 0;
                    break;

                case clstestTypesBLL.enTestType.writtenTest:
                    testImage = Resources.Written_Test_512;
                    testIndex = 1;
                    break;

                case clstestTypesBLL.enTestType.StreetTest:
                    testImage = Resources.driving_test_512;
                    testIndex = 2;
                    break;
            }

            lbTitle.Text = title + " Appointment";
            pbTestType.Image = testImage;
            this.Text = title;
            ctrlAppInfo2.TestIndex = testIndex;
        }
        private void testAppointmentFrm_Load(object sender, EventArgs e)
        {

            SetTestProperties(_TestType);
            ctrlAppInfo2.LoadAppData(LocalAppID);
            _RefreshData();


        }

        private void _RefreshData()
        {
            dt = clsTestAppointmentsBLL.getAppointmentsByLocalAppID(LocalAppID, (int)_TestType);
            dGVAppointmts.DataSource = dt;
            LbRecords.Text = dt.Rows.Count.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAddAppointmnt_Click(object sender, EventArgs e)
        {
            localDrivingLicenseApplication = clsLocalDLApplicattionBLL.Find(LocalAppID);

            if (clsTestAppointmentsBLL.HasUnlockedAppointment(LocalAppID, (int)_TestType))
            {
                MessageBox.Show(
                    "This person already has an active appointment!",
                    "Not Allowed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            if (clsTestAppointmentsBLL.HasPassed(LocalAppID, (int)_TestType))
            {
                MessageBox.Show(
                    "This person has already passed the test!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            clsTestBLL LastTest = localDrivingLicenseApplication.GetLastTestPerTestType(_TestType);

            if (LastTest == null)
            {
                ScheduleTestFrm ScheduleFrm = new ScheduleTestFrm(LocalAppID, _TestType);

                ScheduleFrm.ShowDialog();
                testAppointmentFrm_Load(null, null);
                return;
            }

            //if person already passed the test s/he cannot retak it.
            if (LastTest.Result == true)
            {
                MessageBox.Show("This person already passed this test before, you can only retake faild test", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ScheduleTestFrm frm2 = new ScheduleTestFrm
                (LastTest.TestAppointment.LocalDrivingLicenseApplicationID, _TestType);
            frm2.ShowDialog();
            testAppointmentFrm_Load(null, null);
            //---
            
            
        }

            
        

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {

             Form Taketest = new TakeTestFrm((int)dGVAppointmts.CurrentRow.Cells[0].Value,_TestType);
            Taketest.ShowDialog();
            testAppointmentFrm_Load(null, null);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int AppointmentID = (int)dGVAppointmts.CurrentRow.Cells[0].Value;
            Form FrmTest = new ScheduleTestFrm(LocalAppID, _TestType, AppointmentID);
            FrmTest.ShowDialog();
            _RefreshData();
            testAppointmentFrm_Load(null, null);
        }

        private void cmsAppointmt_Opening(object sender, CancelEventArgs e)
        {
            bool Lock = false;
            int TestAppID = (int)dGVAppointmts.CurrentRow.Cells[0].Value;
            if (!clsTestAppointmentsBLL.HasUnlockedAppointment(TestAppID))
            {
                Lock = false;

            }
            else
            {
                Lock = true;
            }
            takeTestToolStripMenuItem.Enabled = Lock;
            editToolStripMenuItem.Enabled = Lock;
        }
    }
}
