using clsBusinessLayerDVLD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDApp
{
    public partial class ChangePasswordScreen : Form
    {
        private int? UserID;
        private clsUserBLL _User;


        public ChangePasswordScreen(int _UserID)
        {
            InitializeComponent();
            UserID = _UserID;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void ChangePasswordScreen_Load(object sender, EventArgs e)
        {

            _User = clsUserBLL.Find(UserID ?? 0);

            if (_User == null)
            {
                MessageBox.Show($"The User with the ID : {_User} doesn't not exist !","User Not Found", MessageBoxButtons.AbortRetryIgnore,MessageBoxIcon.Error);

            }

            ctrlUserInfo2.LoadData(UserID ?? 0 );



        }
        private void TxtCurrentPasswd_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TxtCurrentPasswd.Text.Trim()))
            {
                e.Cancel = true;

                errorProvider1.SetError(TxtCurrentPasswd, " This Field Can't Be Empty!");
                return;
            }
            else
            {
                errorProvider1.SetError(TxtCurrentPasswd, null);
            };
            if (_User.Password!= TxtCurrentPasswd.Text.Trim())
            {
                e.Cancel = true;

                errorProvider1.SetError(TxtCurrentPasswd, " Incorrect password !");
                return;
            }
            else
            {
                errorProvider1.SetError(TxtCurrentPasswd, null);
            };

        }

      
        private void txtNewpasswd_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewpasswd.Text.Trim()))
            {
                e.Cancel = true;

                errorProvider1.SetError(txtNewpasswd, " This Field Can't Be Empty!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtNewpasswd, null);
            }
           

        }

        private void TxtconfrmPasswd_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TxtconfrmPasswd.Text.Trim()))
            {
                e.Cancel = true;

                errorProvider1.SetError(TxtconfrmPasswd, " This Field Can't Be Empty!");
                return;
            }
            else
            {
                errorProvider1.SetError(TxtconfrmPasswd, null);
            }
            ;
            if (TxtconfrmPasswd.Text.Trim() != TxtCurrentPasswd.Text.Trim())
            {
                e.Cancel = true;

                errorProvider1.SetError(TxtconfrmPasswd, " unmatched passwords ! ");
                return;
            }
            else
            {
                errorProvider1.SetError(TxtconfrmPasswd, null);
            }
            ;
        } 
        private void btnSavepasswrd_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _User.Password = txtNewpasswd.Text;

            if(_User._Save())
            {

                MessageBox.Show("Password Changed Successfully.",
                  "Saved.", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
            else
            {
                MessageBox.Show("An Erro Occured, Password did not change.",
                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        

    }
}
