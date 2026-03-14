using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clsBusinessLayerDVLD;
using DVLDApp.Applications.LocalDrivingLicenseApplication.Controls;

namespace DVLDApp.Applications.LocalDrivingLicenseApplication
{
    public partial class ScheduleTestFrm : Form
    {
        private int _LocalAppID = -1;

        private int _AppointmentID = -1;

        private clstestTypesBLL.enTestType _TestType = clstestTypesBLL.enTestType.visionTest;

        public ScheduleTestFrm(int LocalDrivingLicenseApplicationID, clstestTypesBLL.enTestType TestTypeID, int AppointmentID = -1)
        {
            
            InitializeComponent();
            _LocalAppID = LocalDrivingLicenseApplicationID;
            _AppointmentID = AppointmentID;
            _TestType = TestTypeID;


        }
        
 
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ScheduleTestFrm_Load(object sender, EventArgs e)
        {
            ctrlscheduleTest2.TestType = _TestType;
            ctrlscheduleTest2.LoadInfo(_LocalAppID,_AppointmentID);

        }
    }
}
