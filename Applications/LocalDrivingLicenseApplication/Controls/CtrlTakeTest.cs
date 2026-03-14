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
using static clsBusinessLayerDVLD.clstestTypesBLL;

namespace DVLDApp.Applications.LocalDrivingLicenseApplication.Controls
{
    public partial class CtrlTakeTest : UserControl
    {
        public CtrlTakeTest()
        {
            InitializeComponent();
        }
        private int _LocalApplicationID = -1;
        private int _Test = -1;
        private int AppointmentID = -1;

        private clsTestAppointmentsBLL _TestAppointment;
        private clsLocalDLApplicattionBLL _LocalDrivingLicenseApplication;

        private clstestTypesBLL.enTestType CurrentTestType { get; set; }

        public clstestTypesBLL.enTestType TestTypeID
        {
            get 
            {
                return CurrentTestType;
            }
             set
             {

                CurrentTestType = value;

                switch (CurrentTestType)
                {

                    case clstestTypesBLL.enTestType.visionTest:
                        {
                            GbScheduleTestTitle.Text = "Vision Test";
                            pictureboxtest.Image = Resources.Vision_512;
                            break;
                        }

                    case clstestTypesBLL.enTestType.writtenTest:
                        {
                            GbScheduleTestTitle.Text = "Written Test";
                            pictureboxtest.Image = Resources.Written_Test_512;
                            break;
                        }
                    case clstestTypesBLL.enTestType.StreetTest:
                        {
                            GbScheduleTestTitle.Text = "Street Test";
                            pictureboxtest.Image = Resources.driving_test_512;
                            break;


                        }
                }




            }
        }
        public int TestID
        { get {  return TestID; }  }
        public void LoadTakeTestInfo(int TestAppointID)
        {
             AppointmentID = TestAppointID;
            _TestAppointment = clsTestAppointmentsBLL.GettestAppointmentByID(AppointmentID);
            if (_TestAppointment == null)
            {
                
                MessageBox.Show(" Test Appointment not found !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TestAppointID = -1;
                return;
            }

            _LoadAppInfo();
        }
        private void _LoadAppInfo()
        {
            _LocalApplicationID = _TestAppointment.LocalDrivingLicenseApplicationID;
            _LocalDrivingLicenseApplication = clsLocalDLApplicattionBLL.Find(_LocalApplicationID);
                        if (_LocalDrivingLicenseApplication == null)
            {
                MessageBox.Show("Error: No Local Driving License Application with ID = " + _LocalApplicationID.ToString(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lbLocalApplicationID.Text = _TestAppointment.LocalDrivingLicenseApplicationID.ToString();
            LbFee.Text = _TestAppointment.PaidFeeTest.ToString();
            LbDClass.Text = _LocalDrivingLicenseApplication.LicenseClassInfo.LicenseName;
            lbDate.Text = _TestAppointment.AppointmentDate.ToString();
            LbName.Text = _LocalDrivingLicenseApplication.fullName;
            LbTrial.Text = clsTestAppointmentsBLL.TrialCount(_LocalApplicationID,(int)TestTypeID).ToString();



        }
  


    }
}
