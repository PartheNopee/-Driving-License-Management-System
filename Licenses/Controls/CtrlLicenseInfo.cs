using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLLPeople;
using clsBusinessLayerDVLD;
using DVLDApp.Properties;
using System.IO;


namespace DVLDApp.Licenses.Controls
{
    public partial class CtrlLicenseInfo : UserControl
    {
        clsLicensesBLL _License;
        private int _LicenseID = -1;

        public int LicenseID
        {
            get { return _LicenseID; }
        }
        public clsLicensesBLL SelectedLicenseInfo { get { return _License; } }

        public CtrlLicenseInfo()
        {
            InitializeComponent();
        }

        public void LoadLicenseData(int LicenseID)
        {
            _LicenseID = LicenseID;
            _License = clsLicensesBLL.FindLicense(_LicenseID);
            if (_License == null)
            {
                MessageBox.Show("License not found !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            else
                _FillLicenseInfo();
            


        }
        private void _LoadPersonImage()
        {
            if (_License.DriverInfo.PersonInfo.Gendor == 0)
                pbPersonImage.Image = Resources.boy;
            else
                pbPersonImage.Image = Resources.female;

            string ImagePath = _License.DriverInfo.PersonInfo.ImagePath;

            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    pbPersonImage.Load(ImagePath);
                else
                    MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void _FillLicenseInfo()
        {


            lbClass.Text = _License.LicenseInfo.LicenseName;
            lbName.Text = _License.DriverInfo.PersonInfo.FullName;
            LBNationalID.Text = _License.DriverInfo.PersonInfo.NationalID;
            LbDOB.Text = _License.DriverInfo.PersonInfo.DOB.ToShortDateString();
            GendorLb.Text = _License.DriverInfo.PersonInfo.Gendor == 0 ? "Male" : "Female";
            LbLicenseID.Text = _License.LicenseID.ToString();
            LbIssueDate.Text = _License.IssueDate.ToShortDateString();
            LbExpDate.Text = _License.ExpDate.ToShortDateString();
            LbDriverID.Text = _License.DriverID.ToString();
            lbIsActve.Text = _License.IsActive == true ? "Yes" : "No";
            LbNotes.Text = _License.Notes == "" ? "No Notes" : _License.Notes;
            lbIssueReason.Text = _License.IssueReasonText;
            LbIsDetained.Text = clsDetainedBLL.IsDetained(_LicenseID)== true? "Hell Yes" : "No";
            
            _LoadPersonImage();

        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
