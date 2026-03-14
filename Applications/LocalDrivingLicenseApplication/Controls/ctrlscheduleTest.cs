using System;
using System.Diagnostics;
using System.Windows.Forms;
using clsBusinessLayerDVLD;
using DVLDApp.Properties;

namespace DVLDApp.Applications.LocalDrivingLicenseApplication.Controls
{
    public partial class ctrlscheduleTest : UserControl
    {

        enum EnMode { _Add = 0, _Edit = 1 }
        EnMode enMode = EnMode._Add;

        public enum enCreationMode { FirstTimeSchedule = 0, RetakeTestSchedule = 1 };
        private enCreationMode _CreationMode = enCreationMode.FirstTimeSchedule;

        public ctrlscheduleTest()
        {
            InitializeComponent();

        }

        private int _LocalID = -1;

        private int _AppointmentID = -1;

        private float Fee = 0;

        private clsTestAppointmentsBLL TestAppointment;

        private clsLocalDLApplicattionBLL _LocalApp;
        private clstestTypesBLL.enTestType CurrentTestType = clstestTypesBLL.enTestType.visionTest;

        public clstestTypesBLL.enTestType TestType
        {

            get { return CurrentTestType; }



            set
            {
                CurrentTestType = value;

                switch (CurrentTestType)
                {

                    case clstestTypesBLL.enTestType.visionTest:
                        {
                            GbScheduleTest.Text = "Vision Test";
                            pbTestIcon.Image = Resources.Vision_512;
                            break;
                        }

                    case clstestTypesBLL.enTestType.writtenTest:
                        {
                            GbScheduleTest.Text = "Written Test";
                            pbTestIcon.Image = Resources.Written_Test_512;
                            break;
                        }
                    case clstestTypesBLL.enTestType.StreetTest:
                        {
                            GbScheduleTest.Text = "Street Test";
                            pbTestIcon.Image = Resources.driving_test_512;
                            break;


                        }
                }



            }




        }

        private bool _LoadTestAppointmentData()
        {
            TestAppointment = clsTestAppointmentsBLL.GettestAppointmentByID(_AppointmentID);

            if (TestAppointment == null)
            {
                MessageBox.Show("Error: No Appointment with ID = " + _AppointmentID.ToString(),
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                return false;
            }

            LbFee.Text = TestAppointment.PaidFeeTest.ToString();

            //we compare the current date with the appointment date to set the min date.
            //the condition here is : DateTime.Now < TestAppointment.AppointmentDate
            if (DateTime.Compare(DateTime.Now, TestAppointment.AppointmentDate) < 0)
                DateSchedule.MinDate = DateTime.Now;
            else
                DateSchedule.MinDate = TestAppointment.AppointmentDate;

            DateSchedule.Value = TestAppointment.AppointmentDate;

            if (TestAppointment.RetakeTestApplicationID == -1)
            {
                lbRAppFee.Text = "0";
                LbrTestAppId.Text = "N/A";
            }
            else
            {
                lbRAppFee.Text = TestAppointment.RetakeTestAppInfo.PaidFee.ToString();
                GbRetakeTest.Enabled = true;
                lbTitle.Text = "Schedule Retake Test";
                LbrTestAppId.Text = TestAppointment.RetakeTestApplicationID.ToString();

            }
            return true;
        }

        public void LoadInfo(int LocalAppID, int AppointmentID = -1)
        {
            if (AppointmentID == -1)
                enMode = EnMode._Add;
            else
                enMode = EnMode._Edit;

            _AppointmentID = AppointmentID;
            _LocalID = LocalAppID;
            _LocalApp = clsLocalDLApplicattionBLL.Find(_LocalID);
            if (_LocalApp == null)
            {
                MessageBox.Show("Error: No Local Driving License Application with ID = " + _LocalID.ToString(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                return;
            }
            // we decide if it's a retake test or first time 
            if (_LocalApp.DoesAttendTestType(TestType))

                _CreationMode = enCreationMode.RetakeTestSchedule;
            else
                _CreationMode = enCreationMode.FirstTimeSchedule;

            if (_CreationMode == enCreationMode.RetakeTestSchedule)
            {
                GbRetakeTest.Enabled = true;

                lbRAppFee.Text = clsAppTypesBLL.FindApp((int)clsApplicationBLL.enApplicationType.RetakeTest)._Fee.ToString();
                lbTitle.Text = "Schedule Retake Test";
                LbrTestAppId.Text = "0";

            }
            else
            {
                lbRAppFee.Text = "0";
                GbRetakeTest.Enabled = false;
                lbTitle.Text = "Schedule Test";
                LbrTestAppId.Text = "N/A";
            }

            lbLocalApplicationID.Text = _LocalApp.LocalDrivingLicenseApplicationID.ToString();
            LbName.Text = _LocalApp.fullName;
            LbDClass.Text = _LocalApp.LicenseClassInfo.LicenseName;


            LbTrial.Text = clsTestAppointmentsBLL.TrialCount(_LocalID, (int)CurrentTestType).ToString();

            if (enMode == EnMode._Add)
            {
                LbFee.Text = clstestTypesBLL.FindTest(TestType).FeesTest.ToString();
                DateSchedule.MinDate = DateTime.Now;
                LbrTestAppId.Text = "N/A";

                TestAppointment = new clsTestAppointmentsBLL();
            }
            else
            {
                if (!_LoadTestAppointmentData())
                    return;
            }
            LbTotaleFee.Text = (Convert.ToSingle(LbFee.Text) + Convert.ToSingle(lbRAppFee.Text)).ToString();

            // i did it in the test appointment form 
            //if (!_HandleActiveTestAppointmentConstraint())
            //    return;

            //if (!_HandleAppointmentLockedConstraint())
            //    return;

            if (!_HandlePrviousTestConstraint())
                return;



        }

        private bool _HandlePrviousTestConstraint()
        {


            //we need to make sure that this person passed the prvious required test before apply to the new test.
            //person cannno apply for written test unless s/he passes the vision test.
            //person cannot apply for street test unless s/he passes the written test.

            switch (TestType)
            {
                case clstestTypesBLL.enTestType.visionTest:
                    //in this case no required prvious test to pass.
                    lblUserMessage.Visible = false;

                    return true;

                case clstestTypesBLL.enTestType.writtenTest:
                    //Written Test, you cannot sechdule it before person passes the vision test.
                    //we check if pass visiontest 1.
                    if (!_LocalApp.DoesPassTestType(clstestTypesBLL.enTestType.visionTest))
                    {
                        lblUserMessage.Text = "Cannot Sechule, Vision Test should be passed first";
                        lblUserMessage.Visible = true;
                        btnSave.Enabled = false;
                        DateSchedule.Enabled = false;
                        return false;
                    }
                    else
                    {
                        lblUserMessage.Visible = false;
                        btnSave.Enabled = true;
                        DateSchedule.Enabled = true;
                    }


                    return true;

                case clstestTypesBLL.enTestType.StreetTest:

                    //Street Test, you cannot sechdule it before person passes the written test.
                    //we check if pass Written 2.
                    if (!_LocalApp.DoesPassTestType(clstestTypesBLL.enTestType.writtenTest))
                    {
                        lblUserMessage.Text = "Cannot Sechule, Written Test should be passed first";
                        lblUserMessage.Visible = true;
                        btnSave.Enabled = false;
                        DateSchedule.Enabled = false;
                        return false;
                    }
                    else
                    {
                        lblUserMessage.Visible = false;
                        btnSave.Enabled = true;
                        DateSchedule.Enabled = true;
                    }


                    return true;

            }
            return true;




        }

        private bool _HandleRetakeApplication()
        {
            //this will decide to create a seperate application for retake test or not.
            // and will create it if needed , then it will link it to the appoinment.
            if (enMode == EnMode._Add && _CreationMode == enCreationMode.RetakeTestSchedule)
            {
                //incase the mode is add new and creation mode is retake test we should create a seperate application for it.
                //then we link it with the appointment.

                //First Create Applicaiton 
                clsApplicationBLL Application = new clsApplicationBLL();

                Application.ApplicantPersonID = _LocalApp.ApplicantPersonID;
                Application.ApplicationDate = DateTime.Now;
                Application.ApplicationTypeID = (int)clsApplicationBLL.enApplicationType.RetakeTest;
                Application.ApplicationStatus = clsApplicationBLL.enApplicationStatus.Completed;
                Application.LastStatusDate = DateTime.Now;
                Application.PaidFee = clsAppTypesBLL.FindApp((int)clsApplicationBLL.enApplicationType.RetakeTest)._Fee;
                Application.createdByUserID = GlobalClass.CurrentUser.UserID;

                if (!Application.Save())
                {
                    TestAppointment.RetakeTestApplicationID = -1;
                    MessageBox.Show("Faild to Create application", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                TestAppointment.RetakeTestApplicationID = Application.ApplicationID;

            }
            return true;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!_HandleRetakeApplication())
                return;

           

                TestAppointment.TestTypeID = (int)CurrentTestType;
                TestAppointment.LocalDrivingLicenseApplicationID = _LocalApp.LocalDrivingLicenseApplicationID;
                TestAppointment.AppointmentDate = DateSchedule.Value;
               TestAppointment.PaidFeeTest = Convert.ToSingle(LbFee.Text);
                TestAppointment.createdByUserID = GlobalClass.CurrentUser.UserID;
                // the retake app id is handled already


            


            try
            {
                if (TestAppointment.SaveAppointment())
                {
                    enMode = EnMode._Edit;
                    _AppointmentID = TestAppointment.TestAppointmentID;
                    MessageBox.Show($"Appointment with the ID : {_AppointmentID} has been saved Seccesfully!", "Operation successed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


                else
                {
                    MessageBox.Show(" Can not make an Appointment !", "Saving Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {

            }

        }


    }
}
