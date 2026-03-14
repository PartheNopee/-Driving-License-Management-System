using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDApp.Applications.LocalDrivingLicenseApplication
{
    public partial class ApplicationInfoFrm : Form
    {
        public ApplicationInfoFrm(int ID)
        {
            InitializeComponent();
            ctrlAppInfo2.LoadAppData(ID);


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
