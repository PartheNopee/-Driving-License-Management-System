using BLLPeople;
using clsBusinessLayerDVLD;
using System;
using System.Data;
using System.Windows.Forms;

using Tita = System.Windows.Forms.MessageBox;
namespace DVLDApp
{
    public partial class AddUserScreen : Form
    {
        clsUserBLL User;
        private int _UserID = -1;
        private int PersonID = -1;

        enum enMode  { AddNew = 0, Update = 1 }

        private enMode _Mode;
        public AddUserScreen()
        {
            InitializeComponent();

            _Mode = enMode.AddNew;


        }
        public AddUserScreen(int ID)
        {
            InitializeComponent();

            _Mode = enMode.Update;
            _UserID = ID;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            PersonID = ctrlFindPerson1.PersonId;
            if (PersonID == 0)
            {
                MessageBox.Show("please select a person first !");
                return;

            }


            if (clsUserBLL.IsUserRelated(PersonID))
            {
                MessageBox.Show("This Person Is Already related to a User !");

            }
            else
            {
                AddUserTab.SelectedTab = tpLoginInfo;
                btnNext.Visible = false;
            }


        }

        void _LoadData()
        {
            User = clsUserBLL.Find(_UserID);
            ctrlFindPerson1.FilterEnabled = false;

            if (User == null)
            {
                Tita.Show("No User with ID = " + User, "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();

                return;
            }

            LbUserId.Text = _UserID.ToString();
            txtUserName.Text = User.UserName;
            TxtPassw.Text = User.Password;
            TxtConfPasswd.Text = User.Password;
            ChkboxIsActive.Checked = User.IsActive;
            btnNext.Enabled = false;
            ctrlFindPerson1.LoadPersonInfo(User.PersonID);
 
        }


       
        private void _ResetDefualtValues()
        {
            //this will initialize the reset the defaule values

            if (_Mode == enMode.AddNew)
            {
                LbTitle.Text = "Add New User";
                this.Text = "Add New User";
                User = new clsUserBLL();

                tpLoginInfo.Enabled = true;

                ctrlFindPerson1.FilterFocus();
            }
            else
            {
                LbTitle.Text = "Update User";
                this.Text = "Update User";

                tpLoginInfo.Enabled = true;
                btnSave.Enabled = true;


            }

            txtUserName.Text = "";
            TxtPassw.Text = "";
            TxtConfPasswd.Text = "";
            ChkboxIsActive.Checked = true;


        }

        private void AddUserScreen_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();
            if (_Mode == enMode.Update)
            
                _LoadData();
            


        }

        private void txtUserName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUserName, "Username cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(txtUserName, null);
            }
            ;


            if (_Mode == enMode.AddNew)
            {

                if (clsUserBLL.IsExist(txtUserName.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtUserName, "username is used by another user");
                }
                else
                {
                    errorProvider1.SetError(txtUserName, null);
                }
                ;
            }
            else
            {
                //incase update make sure not to use anothers user name
                if (User.UserName != txtUserName.Text.Trim())
                {
                    if (clsUserBLL.IsExist(txtUserName.Text.Trim()))
                    {
                        e.Cancel = true;
                        errorProvider1.SetError(txtUserName, "username is used by another user");
                        return;
                    }
                    else
                    {
                        errorProvider1.SetError(txtUserName, null);
                    }
                    ;
                }
            }


        }


        private void TxtPassw_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TxtPassw.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(TxtPassw, "Password cannot be blank");
            }
            else
            {
                errorProvider1.SetError(TxtPassw, null);
            }
            

        }

        private void TxtConfPasswd_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(TxtConfPasswd.Text.Trim()!= TxtPassw.Text.Trim() )
            {

                e.Cancel = true;
                errorProvider1.SetError(TxtConfPasswd, "Passwords don't match");


            }
            else
            {
                errorProvider1.SetError(TxtConfPasswd, null);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {

                //Here we dont continue becuase the form is not valid
                Tita.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;


            }


            User.PersonID = ctrlFindPerson1.PersonId;
            User.UserName = txtUserName.Text.Trim();
            User.Password = TxtPassw.Text.Trim();
            User.IsActive = (ChkboxIsActive.Checked) ? true : false;
            try
            {

                if (User._Save())
                {

                    LbTitle.Text = $"Update User {User.UserID}";
                    LbUserId.Text = User.UserID.ToString();
                    _Mode = enMode.Update;


                    Tita.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Error: Data was not saved successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the person: {ex.Message}");
            }
        }
    }
}
