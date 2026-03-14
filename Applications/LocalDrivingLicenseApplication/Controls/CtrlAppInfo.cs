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

namespace DVLDApp.Applications.LocalDrivingLicenseApplication.Controls
{
    public partial class CtrlAppInfo : UserControl
    {
        int LocalAppID = -1;
        clsLocalDLApplicattionBLL LocalApp;
        private int _TestIndex = -1;
        

        public CtrlAppInfo()
        {
            //this is a user control
            InitializeComponent();
        }
        public int TestIndex
        {
            get
            {
                return _TestIndex; // Get the value
            }
            set
            {
                if (_TestIndex != value)  // Optionally check if it's actually changing
                {
                    _TestIndex = value;  // Set the value
                }
            }
        }

        public void LoadAppData (int LocalAppIDD)
        {
                
            LocalApp = clsLocalDLApplicattionBLL.Find(LocalAppIDD);
            clsTestAppointmentsBLL TestApp;
            TestApp = clsTestAppointmentsBLL.GettestAppointbyLocalAppID(LocalAppIDD);

            if (LocalApp == null)
            {
                MessageBox.Show($"Application with the ID {LocalAppIDD} is not found! ", " Invailable Local Application ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                
            }
            LocalAppID = LocalAppIDD;

            _FillAppData();

            //It will be sat with the other properities in the switch case depends on the test ID...




        }

        private void _FillAppData()
        {
            
             LbDLAppID.Text = LocalAppID.ToString();
            LbLicenseClass.Text = LocalApp.LicenseClassInfo.LicenseName;
            LbAppID.Text = LocalApp.ApplicationID.ToString();
            lbStatus.Text = LocalApp.StatusText;
            LbLastDate.Text = LocalApp.LastStatusDate.ToString();
            LbFee.Text = LocalApp.PaidFee.ToString();

            LbCreatedBy.Text = clsUserBLL.Find(LocalApp.createdByUserID).UserName;
            LbDate.Text = LocalApp.ApplicationDate.ToString();
            lbApplicantName.Text = LocalApp.fullName;
            LbPaasedExamcount.Text = $"{_TestIndex}/3";
            LbType.Text =clsAppTypesBLL.FindApp( LocalApp.ApplicationTypeID)._Title;


        }

        private void CtrlAppInfo_Load(object sender, EventArgs e)
        {
           
        }

        private void LibkLbPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new PersonInfoScreen(LocalApp.ApplicantPersonID);
            frm.ShowDialog();
        }
    }
}
