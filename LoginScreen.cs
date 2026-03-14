using clsBusinessLayerDVLD;
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

namespace DVLDApp
{
    public partial class LoginScreen : Form
    {
        clsUserBLL User;
        public LoginScreen()
        {
            InitializeComponent();
            
        }
        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string UserName = TxtUserName.Text;
            string Passwrd = txtPasswd.Text;

            


            if (clsUserBLL.Login(UserName, Passwrd))
            {

                User = clsUserBLL.getUserbyUsername(UserName);
                GlobalClass.CurrentUser = User;

                if (chkboxrememberme.Checked)
                {
                    GlobalClass.RememberUsernameAndPassword(UserName, Passwrd);
                }



                else
                {
                    GlobalClass.RememberUsernameAndPassword("", "");
                }
                if (!User.IsActive)
                {
                    MessageBox.Show("The User Is not active ! you cannot Login. " , "Mission Impossible",MessageBoxButtons.RetryCancel,MessageBoxIcon.Warning);
                    return;
                }


                Form form = new MainScreen();
                this.Hide();


                form.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Username or password is invalid !");
                TxtUserName.Focus();
            }



        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {

            string UserName = "", PassWord = "";

            if (GlobalClass.GetStoredCredential(ref UserName, ref PassWord))
            {
                txtPasswd.Text = PassWord;
                TxtUserName.Text = UserName;
                chkboxrememberme.Checked = true;

            }
            else
            {
                chkboxrememberme.Checked = false;
            }

        }
    }
}
