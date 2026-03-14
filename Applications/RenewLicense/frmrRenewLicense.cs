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
using DVLDApp.Licenses.Controls;

namespace DVLDApp.Applications.RenewLicense
{
    public partial class frmrRenewLicense : Form
    {
        private int _LicenseID = -1;

        private int _NewLicenseID = -1;

         public frmrRenewLicense()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        void _FillLicenseInfo()
        {
          
            lblOldLicenseID.Text = ctrlLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseID.ToString();
            lblLicenseFees.Text = ctrlLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseInfo.LicenceFee.ToString();
            int Validity = ctrlLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseInfo.validity;
            lblExpirationDate.Text = DateTime.Now.AddYears(Validity).ToString();
            lblTotalFees.Text = (Convert.ToSingle(lblApplicationFees.Text) + Convert.ToSingle(lblLicenseFees.Text)).ToString();
            txtNotes.Text = ctrlLicenseInfoWithFilter1.SelectedLicenseInfo.Notes.ToString();

        }
        private void ctrlLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            _LicenseID = obj;


            if (_LicenseID != -1)
            {
                btnRenewLicense.Enabled = true;
                llShowLicenseHistory.Enabled = true;
                _FillLicenseInfo();
            }
            else
            {
                MessageBox.Show("Invalid License Id, choose another one", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(!_HandleLicenseEligibilty())
            btnRenewLicense.Enabled=false;
            return;

        }
        private bool _HandleLicenseEligibilty()
        {
            if (ctrlLicenseInfoWithFilter1.SelectedLicenseInfo.IsLicenseExpired())
            {
                return true;
            }
            else
                MessageBox.Show($"This license is not expired until {ctrlLicenseInfoWithFilter1.SelectedLicenseInfo.ExpDate} ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;


        }
        private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LicenseHistoryFrm frm = new LicenseHistoryFrm(ctrlLicenseInfoWithFilter1.SelectedLicenseInfo.DriverInfo.PersonID);
            frm.ShowDialog();
        }

        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LicenseInfoFrm frm = new LicenseInfoFrm(_NewLicenseID);
            frm.ShowDialog();

        }

        private void btnRenewLicense_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to Renew the license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            clsLicensesBLL NewLicense =
              ctrlLicenseInfoWithFilter1.SelectedLicenseInfo.RenewLicense(GlobalClass.CurrentUser.UserID , txtNotes.Text.Trim());

            if (NewLicense == null)
            {
                MessageBox.Show("Faild to Renew the License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            lblApplicationID.Text = NewLicense.ApplicationID.ToString();
            _NewLicenseID = NewLicense.LicenseID;
            lblRenewedLicenseID.Text = _NewLicenseID.ToString();
            MessageBox.Show("Licensed Renewed Successfully with ID = " + _NewLicenseID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnRenewLicense.Enabled = false;
            ctrlLicenseInfoWithFilter1.FilterEnabled = false;
            llShowLicenseInfo.Enabled = true;



        }
      
        private void frmrRenewLicense_Load(object sender, EventArgs e)
        {
            ctrlLicenseInfoWithFilter1.txtLicenseIDFocus();

            lblApplicationDate.Text = DateTime.Now.ToString();
            lblCreatedByUser.Text = GlobalClass.CurrentUser.UserName;
            lblIssueDate.Text = DateTime.Now.ToString();
            lblApplicationFees.Text = clsAppTypesBLL.FindApp((int)clsApplicationBLL.enApplicationType.RenewDrivingLicense)._Fee.ToString();



        }
    }
}
