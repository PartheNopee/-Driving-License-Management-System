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
using DVLDApp.Licenses.InternationalLicenses;

namespace DVLDApp.Applications.IntertnationalLicenseApplication
{
    public partial class NewInternationalLicenseApplication : Form
    {
        int InternationalLicenseID = -1;

        private int _LicenseID = -1;

        private clsLicensesBLL _LocalLicense;
        public NewInternationalLicenseApplication()
        {
            InitializeComponent();
            ctrlLicenseInfoWithFilter1.txtLicenseIDFocus();


        }
        private void _LoadApplicationInfo()
        {
            

            lblLocalLicenseID.Text = _LicenseID.ToString();
            lblIssueDate.Text = DateTime.Now.ToString();
            lblCreatedByUser.Text = GlobalClass.CurrentUser.UserName;
            lblApplicationDate.Text = DateTime.Now.ToString();
            lblFees.Text = clsAppTypesBLL.FindApp((int)clsApplicationBLL.enApplicationType.NewInternationalLicense)._Fee.ToString();
            lblExpirationDate.Text = DateTime.Now.AddYears(clsClassLicenseBLL.Find((int)clsApplicationBLL.enApplicationType.NewInternationalLicense).validity).ToString();
        }

        private void NewInternationalLicenseApplication_Load(object sender, EventArgs e)
        {

            // Inside the Form's constructor or Load event
            ctrlLicenseInfoWithFilter1.OnLicenseSelected += (licenseId) => {
                // This code runs whenever the control sends an ID back
                this._LicenseID = licenseId;
                _LocalLicense = clsLicensesBLL.FindLicense(_LicenseID);

                if (_LocalLicense != null)
                {
                    _LoadApplicationInfo();
                    llShowLicenseHistory.Enabled = true;
                    btnIssueLicense.Enabled = true;
                }

            };

        }

        private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            LicenseHistoryFrm Frm = new LicenseHistoryFrm(_LocalLicense.DriverInfo.PersonID);
            Frm.ShowDialog();



        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool HandleLicencsClass()
        {

            if (_LocalLicense.LicenseInfo.LicenseClassID == 3)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Select license Should be Class 3, select another one.  ","Not Allowed",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }





        }
        private bool HandleElegebilityOfInternationalLicense()
        {
            int InternationalLicenseID = clsIntenationalLicenseBLL.GetActiveInternationalLicenseIDByDriverID(_LocalLicense.DriverID);
            if (InternationalLicenseID != -1)
            {
                MessageBox.Show("This Driver has Already an Active  International License with ID. " + InternationalLicenseID, "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!_LocalLicense.IsActive)
            
                MessageBox.Show("Local License Unactive, please Activate it to proceed further!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            




        }
        private void btnIssueLicense_Click(object sender, EventArgs e)
        {
            if (!HandleLicencsClass())
                return;
            if (!HandleElegebilityOfInternationalLicense())
                return;

            clsIntenationalLicenseBLL _InternationalLicense = new clsIntenationalLicenseBLL();

            _InternationalLicense.Application.ApplicantPersonID = _LocalLicense.DriverInfo.PersonID;
            _InternationalLicense.Application.createdByUserID = GlobalClass.CurrentUser.UserID;

            _InternationalLicense.LocalLicenseIDIssues = _LocalLicense.LicenseID;
            _InternationalLicense.IssueDate = DateTime.Now;
            _InternationalLicense.ExpDate = DateTime.Now.AddYears(_LocalLicense.LicenseInfo.validity);
            _InternationalLicense.DriverID = _LocalLicense.DriverID;

            if (_InternationalLicense.Save())
            {
                InternationalLicenseID = _InternationalLicense.InternationalLicenseID;
                MessageBox.Show($"International License with ID {InternationalLicenseID} Issued succesfully!","Success",MessageBoxButtons.OK, MessageBoxIcon.Information);
                ctrlLicenseInfoWithFilter1.FilterEnabled = false;
                lblInternationalLicenseID.Text = InternationalLicenseID.ToString();
                lblApplicationID.Text = _InternationalLicense.ApplicationID.ToString();
                llShowLicenseHistory.Enabled = true;

            }
            else
            {
                MessageBox.Show("Failed To Issue the International License ! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;


            }


 
        }

        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmShowInternationalLicenseInfo frm = new FrmShowInternationalLicenseInfo(InternationalLicenseID);
            frm.ShowDialog();
        }

        private void ctrlLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
             
        }
    }
}
