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

namespace DVLDApp.Applications.ReplaceForLostOrDamaged
{
    public partial class ReplaceForDamageOrLostFrm : Form
    {
        private int _NewLicenseID = -1;
        public ReplaceForDamageOrLostFrm()
        {
            InitializeComponent();
        }
        void _FillLicenseInfo()
        {

            lblOldLicenseID.Text = ctrlLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseID.ToString();
            lblCreatedByUser.Text =clsUserBLL.Find( ctrlLicenseInfoWithFilter1.SelectedLicenseInfo.CreatedByUserID).UserName.ToString();
            lblApplicationDate.Text = DateTime.Now.ToString();
            lblApplicationFees.Text =  clsAppTypesBLL.FindApp((int)clsApplicationBLL.enApplicationType.ReplaceDamagedDrivingLicense)._Fee.ToString(); 

        }
        private void ctrlLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            int _LicenseID = obj;

            if (_LicenseID != -1)
            {
                 llShowLicenseHistory.Enabled = true;
                _FillLicenseInfo();
            }

            // do not allow replacement for inactive License .
            if (!ctrlLicenseInfoWithFilter1.SelectedLicenseInfo.IsActive)
            {
                MessageBox.Show("Local License Unactive, please Activate it to proceed further!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            btnIssueReplacement.Enabled = true;

        }

        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LicenseInfoFrm frm = new LicenseInfoFrm(_NewLicenseID);
            frm.ShowDialog();
        }

        private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LicenseHistoryFrm frm = new LicenseHistoryFrm(ctrlLicenseInfoWithFilter1.SelectedLicenseInfo.DriverInfo.PersonID);
            frm.ShowDialog();
        }


        private void btnIssueReplacement_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Replace the license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            clsLicensesBLL.enIssueReason IssueReason = rbDamagedLicense.Checked ? clsLicensesBLL.enIssueReason.DamagedReplacement : clsLicensesBLL.enIssueReason.LostReplacement;

            clsLicensesBLL NewLicense =
              ctrlLicenseInfoWithFilter1.SelectedLicenseInfo.ReplaceLicense(IssueReason, ctrlLicenseInfoWithFilter1.SelectedLicenseInfo.CreatedByUserID);

            if (NewLicense == null)
            {
                MessageBox.Show("Faild to Renew the License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            lblApplicationID.Text = NewLicense.ApplicationID.ToString();
            _NewLicenseID = NewLicense.LicenseID;
            lblRreplacedLicenseID.Text = _NewLicenseID.ToString();
            MessageBox.Show("License Renewed Successfully with ID = " + _NewLicenseID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnIssueReplacement.Enabled = false;
            ctrlLicenseInfoWithFilter1.FilterEnabled = false;
            llShowLicenseInfo.Enabled = true;
            gbReplacementFor.Enabled = false;


        }

        private void rbDamagedLicense_CheckedChanged(object sender, EventArgs e)
        {
            lblTitle.Text = "Replcacement for Lost License";
            this.Text = lblTitle.Text;
            lblApplicationFees.Text = clsAppTypesBLL.FindApp((int)clsApplicationBLL.enApplicationType.ReplaceDamagedDrivingLicense)._Fee.ToString();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rbLostLicense_CheckedChanged(object sender, EventArgs e)
        {
            lblTitle.Text = "Replcacement for Lost License";
            this.Text = lblTitle.Text;
          lblApplicationFees.Text = clsAppTypesBLL.FindApp((int)clsApplicationBLL.enApplicationType.ReplaceLostDrivingLicense)._Fee.ToString();

        }
    }
}
