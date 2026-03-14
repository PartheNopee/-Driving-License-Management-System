using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDApp.Licenses.InternationalLicenses
{
    public partial class FrmShowInternationalLicenseInfo : Form
    {
        int _InternationalLicenseId = -1;
        public FrmShowInternationalLicenseInfo(int LicenseId)
        {
            _InternationalLicenseId = LicenseId;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmShowInternationalLicenseInfo_Load(object sender, EventArgs e)
        {
            if (_InternationalLicenseId != -1)
            {
                ctrlInternationalLicenseInfo1.LoadData(_InternationalLicenseId);
            }
            else
            {
                MessageBox.Show("Invalid License ID !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
