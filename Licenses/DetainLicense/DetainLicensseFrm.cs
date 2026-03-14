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

namespace DVLDApp.Applications.DetainLicense
{
    public partial class DetainLicensseFrm : Form
    {
        private int _LicenseID = -1;
        public DetainLicensseFrm()
        {
            InitializeComponent();
        }

        private void ctrlLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {

            _LicenseID = obj;
            if (_LicenseID != -1)
            {
                lblLicenseID.Text = _LicenseID.ToString();
                llShowLicenseHistory.Enabled = true;
                
                llShowLicenseInfo.Enabled = true;
            }

            if (ctrlLicenseInfoWithFilter1.SelectedLicenseInfo.IsDetained())
            {
                MessageBox.Show("Local License is already Detained!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            txtFineFees.Focus();    
            btnDetain.Enabled = true;

        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            if (clsDetainedBLL.IsDetained(_LicenseID))
            {
                MessageBox.Show("Local License is already Detained!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure you want to Detain the license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            int DetainID = ctrlLicenseInfoWithFilter1.SelectedLicenseInfo.Detain(Convert.ToSingle(txtFineFees.Text),GlobalClass.CurrentUser.UserID);
            if (DetainID == -1)
            {
                MessageBox.Show("Faild to Release the License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            lblDetainID.Text = DetainID.ToString();
            MessageBox.Show($"Licensed with ID {_LicenseID} Detained Successfully !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnDetain.Enabled = false;
            llShowLicenseInfo.Enabled = true;

        }

        private void DetainLicensseFrm_Load(object sender, EventArgs e)
        {
            lblCreatedByUser.Text = GlobalClass.CurrentUser.UserName;
            lblDetainDate.Text = DateTime.Now.ToString();

        }
    }
}
