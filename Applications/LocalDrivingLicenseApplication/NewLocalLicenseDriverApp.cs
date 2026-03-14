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

namespace DVLDApp
{
    public partial class NewLocalLicenseDriverApp : Form
    {
        int PersonID = -1;
        clsLocalDLApplicattionBLL  LocalApp;
        int locaAppID = -1;



        public NewLocalLicenseDriverApp()
        {
            InitializeComponent();
        }

        void _LoadCountry()
        {
            DataTable dt = clsClassLicenseBLL.GetAllClasses();
            cbLicenseClass.DataSource = dt;
            cbLicenseClass.DisplayMember = "ClassName";
            cbLicenseClass.ValueMember = "LicenseClassID";
            cbLicenseClass.SelectedIndex = 3;
            cbLicenseClass.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        

        private void NewLocalLicenseDriverApp_Load(object sender, EventArgs e)
        {
            _LoadCountry();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            PersonID = ctrlFindPerson1.PersonId;
            if (PersonID == 0)
            {
                MessageBox.Show("please select a person first !");
                return;

            }

            tabControl1.SelectedTab = ApplicationInfoTab;




        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            

            int LC = (int)cbLicenseClass.SelectedValue;
            if (clsApplicationBLL.HasApplied(PersonID,LC ))
            {
                MessageBox.Show("the person has already applied to this class"," Error",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                return;
            }
            LocalApp = new clsLocalDLApplicattionBLL();

            LocalApp.Application.ApplicantPersonID = PersonID;
            LocalApp.Application.createdByUserID = GlobalClass.CurrentUser.UserID;
            LocalApp.LicenseClassID = (int)cbLicenseClass.SelectedValue;


            if (LocalApp.Save())

                {
                
                    locaAppID = LocalApp.LocalDrivingLicenseApplicationID;

                    MessageBox.Show($"Local Application with the ID {locaAppID} has been succesfully created ! ", "Succesful Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _LoadData();

                }

            
            else
            {
                MessageBox.Show("an error was occure while creating the Application please try Again !", "Internal error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return;
            }



        }
        private void _LoadData()
        {
            LbAppID.Text = locaAppID.ToString();
            LbFee.Text = LocalApp.Application.PaidFee.ToString();
            LbDate.Text = LocalApp.Application.ApplicationDate.ToString();
            LbCreatedBy.Text = LocalApp.Application.createdByUserID.ToString();

        }
    }
}
