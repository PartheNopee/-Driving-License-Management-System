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

namespace DVLDApp.Applications.DetainLicense
{
    public partial class ReleaseDetainedLicenseFrm : Form
    {

        private int _LicenseID = -1;

        public ReleaseDetainedLicenseFrm()
        {
            InitializeComponent();
        }
        public ReleaseDetainedLicenseFrm(int LicenseID)
        {
            InitializeComponent();
            _LicenseID = LicenseID;
            ctrlLicenseInfoWithFilter1.LoadLicenseInfo(_LicenseID);
            ctrlLicenseInfoWithFilter1.FilterEnabled = false;
             
        }
        private void _FillDetainLicenseInfo()
        {
            

            lblDetainID.Text = ctrlLicenseInfoWithFilter1.SelectedLicenseInfo.DetainedInfo.DetainID.ToString();
            lblLicenseID.Text = ctrlLicenseInfoWithFilter1.SelectedLicenseInfo.DetainedInfo.LicenseID.ToString();
            lblDetainDate.Text = ctrlLicenseInfoWithFilter1.SelectedLicenseInfo.DetainedInfo.DetainDate.ToString();
            lblCreatedByUser.Text =clsUserBLL.Find(ctrlLicenseInfoWithFilter1.SelectedLicenseInfo.DetainedInfo.CreatedByUserID).UserName.ToString();    
            lblApplicationFees.Text = clsAppTypesBLL.FindApp((int)clsApplicationBLL.enApplicationType.ReleaseDetainedDrivingLicsense)._Fee.ToString();
            lblFineFees.Text = ctrlLicenseInfoWithFilter1.SelectedLicenseInfo.DetainedInfo.FineFees.ToString();
            lblTotalFees.Text = (Convert.ToSingle(lblApplicationFees.Text) + Convert.ToSingle(lblFineFees.Text)).ToString();


        }
        private void ctrlLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
             _LicenseID = obj;
            if (_LicenseID != -1)
            {
                llShowLicenseHistory.Enabled = true;
                _FillDetainLicenseInfo();
            }
            if (!clsDetainedBLL.IsDetained(_LicenseID))
            {
                MessageBox.Show("License Is Not Detained !", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnRelease.Enabled = false;
                return;

            }
            // do not allow replacement for inactive License .
            if (!ctrlLicenseInfoWithFilter1.SelectedLicenseInfo.IsActive)
            {
                MessageBox.Show("Local License Unactive, please Activate it to proceed further!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            btnRelease.Enabled = true;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Renew the license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            int ApplicationID = -1;
            bool IsReleased = ctrlLicenseInfoWithFilter1.SelectedLicenseInfo.ReleaseLicense(GlobalClass.CurrentUser.UserID, ref ApplicationID);

            if (!IsReleased)
            {
                MessageBox.Show("Faild to Release the License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            lblApplicationID.Text = ApplicationID.ToString();

            MessageBox.Show("Licensed Released Successfully !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnRelease.Enabled = false;
            ctrlLicenseInfoWithFilter1.FilterEnabled = false;
            llShowLicenseInfo.Enabled = true;



        }

        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LicenseInfoFrm frm = new LicenseInfoFrm(_LicenseID);
            frm.ShowDialog();
        }

        private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LicenseHistoryFrm frm = new LicenseHistoryFrm(ctrlLicenseInfoWithFilter1.SelectedLicenseInfo.DriverInfo.PersonID);
            frm.ShowDialog();
        }
    }
}
