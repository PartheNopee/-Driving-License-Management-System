using BLLPeople;
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
    public partial class CtrlUserInfo : UserControl
    {
        private clsUserBLL User;

        public CtrlUserInfo()
          {
            InitializeComponent();
          }
 
        
        public  void LoadData(int _UserID)
        {
            User = clsUserBLL.Find(_UserID);

            if (User == null)
            {
                _ResetPersonInfo();
                MessageBox.Show("No User with UserID = " + _UserID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;


            }

            _FillInfo();




        }
        private void _FillInfo()
        {
            personDetailsCtrl2.LoadPersonInfo(User.PersonID);

            LbUserID.Text = User.UserID.ToString();
            LbUserName.Text = User.UserName.ToString();
            LbIsActive.Text = (User.IsActive == true) ? "Yes" : "No";


        }
        private void _ResetPersonInfo()
        {

            personDetailsCtrl2.ResetPersonInfo();
            LbUserID.Text = "[???]";
            LbUserName.Text = "[???]";
            LbIsActive.Text = "[???]";


        }




    }
}
