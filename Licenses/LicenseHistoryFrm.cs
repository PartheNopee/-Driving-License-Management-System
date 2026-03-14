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
    public partial class LicenseHistoryFrm : Form
    {
       private int _LocalID = -1;
       private clsLocalDLApplicattionBLL _LocalApp;
        private int _PersonID = -1;
        public LicenseHistoryFrm(int PersonID)
        {
            _PersonID = PersonID;
            InitializeComponent();
        }

        private void _FillData()
        {

            if (_PersonID != -1)
            {
                ctrlFindPerson1.LoadPersonInfo(_PersonID);
                ctrlFindPerson1.FilterEnabled = false;

            }
           else
                ctrlFindPerson1.FilterEnabled=true;
                ctrlFindPerson1.FilterFocus();

            _FillLicenseInfo();

        }
        private void _FillLicenseInfo()
        {
            if (_PersonID == -1)
            {
                return;
            }

            DataTable dtlOCAL;
            dtlOCAL =  clsLicensesBLL.GetLocalLicenses(_PersonID);

            DGVLocal.DataSource = dtlOCAL;
            DGVLocal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            LbRecords.Text = dtlOCAL.Rows.Count.ToString();

            DataTable DtInternational = clsIntenationalLicenseBLL.GetAllinternationlLicenseWithPersonID( _PersonID );
            DGVInternationalLincesHistory.DataSource = DtInternational;
            DGVInternationalLincesHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LbRecorsInternational.Text = DtInternational.Rows.Count.ToString();

        }

       
        private void LicenseHistoryFrm_Load(object sender, EventArgs e)
        {
            _FillData();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
