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

namespace DVLDApp.Licenses
{
    public partial class issueDriverLicenseFrm : Form
    {
        private int _LocalID = -1;
        clsLocalDLApplicattionBLL _LocalApp;
        public issueDriverLicenseFrm(int LocalID)
        {
            InitializeComponent();
            _LocalID = LocalID;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            //  license should be created within the localapp BLL
            int _licenseID = _LocalApp.IssuELicenseForTheFirstTime(txtNotes.Text.Trim(), GlobalClass.CurrentUser.UserID);

                if (_licenseID != -1)
                {
                    
                    MessageBox.Show($"License with the ID {_licenseID} was Succesfully Issued ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close ();
                }
                else
                {
                    MessageBox.Show($"License with the ID {_licenseID} Failed to be Issued ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            
        }

        private void issueDriverLicenseFrm_Load(object sender, EventArgs e)
        {
            txtNotes.Focus();
             _LocalApp = clsLocalDLApplicattionBLL.Find(_LocalID);

            if (_LocalApp == null)
            {

                MessageBox.Show("No Applicaiton with ID=" +  _LocalID.ToString(), "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            if (!_LocalApp.DoesPassAllTest())
            {
                MessageBox.Show("Person Should Pass All Tests First.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;

            }
            int _LicenseID = _LocalApp.GetActiveLicenseID();
            if (_LicenseID != -1)
            {
                MessageBox.Show("Person already has License before with License ID=" + _LicenseID.ToString(), "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }


            ctrlAppInfo1.LoadAppData(_LocalID);

        }
    }
}
