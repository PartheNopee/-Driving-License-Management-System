using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDApp.Licenses
{
    public partial class LicenseInfoFrm : Form
    {
        int _LicenseId = -1;
        public LicenseInfoFrm(int LicenseID)
        {
            _LicenseId = LicenseID;
            InitializeComponent();
         }

       

        private void LicenseInfoFrm_Load(object sender, EventArgs e)
        {
            ctrlLicenseInfo1.LoadLicenseData(_LicenseId);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
