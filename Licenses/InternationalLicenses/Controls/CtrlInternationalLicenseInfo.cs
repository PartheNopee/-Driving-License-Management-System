using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clsBusinessLayerDVLD;
using DVLDApp.Properties;

namespace DVLDApp.Licenses.InternationalLicenses
{
    public partial class CtrlInternationalLicenseInfo : UserControl
    {
        private int _InternationalLicenseID = -1;
        private clsIntenationalLicenseBLL _InternationalLicense;

        public CtrlInternationalLicenseInfo()
        {
            InitializeComponent();
        }

        public void LoadData(int ILicenseID)
        {
            _InternationalLicenseID = ILicenseID;
            _InternationalLicense = clsIntenationalLicenseBLL.Find(_InternationalLicenseID);
            if (_InternationalLicense == null)
            {
                MessageBox.Show("International License not found !","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return ;
            }

          _FillLicenseData();

        }

        private void _HandlePicture()
        {
            if (_InternationalLicense.DriverInfo.PersonInfo.Gendor == 0)
                pbPersonImage.Image = Resources.boy;
            else
                pbPersonImage.Image = Resources.female;

            string ImagePath = _InternationalLicense.DriverInfo.PersonInfo.ImagePath;

            if (ImagePath != "")
                if (File.Exists(ImagePath))
                {
                    pbPersonImage.Load(ImagePath);
                }
            else
                    MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   return;


        }
        private void _FillLicenseData()
        {

            lblFullName.Text = _InternationalLicense.DriverInfo.PersonInfo.FullName;
            lblInternationalLicenseID.Text = _InternationalLicenseID.ToString();
            lblLocalLicenseID.Text = _InternationalLicense.LocalLicenseIDIssues.ToString();
            lblNationalNo.Text = _InternationalLicense.DriverInfo.PersonInfo.NationalID;
            lblGendor.Text = _InternationalLicense.DriverInfo.PersonInfo.Gendor == 0 ? "Male" : "Female";
            lblIssueDate.Text = _InternationalLicense.IssueDate.ToString();
            lblApplicationID.Text = _InternationalLicense.ApplicationID.ToString();
            lblIsActive.Text = _InternationalLicense.IsActive ? "Yes" : "No";
            lblDateOfBirth.Text = _InternationalLicense.DriverInfo.PersonInfo.DOB.ToString();
            lblDriverID.Text = _InternationalLicense.DriverID.ToString();
            lblExpirationDate.Text = _InternationalLicense.ExpDate.ToString();
            _HandlePicture();
        }
    }
}
