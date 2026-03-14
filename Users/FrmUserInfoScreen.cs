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
    public partial class FrmUserInfoScreen : Form
    {
        private int _userID;
        public FrmUserInfoScreen(int UserID)
        {
            _userID = UserID;
            InitializeComponent();

        }
        

        private void FrmUserInfoScreen_Load(object sender, EventArgs e)
        {
            ctrlUserInfo1.LoadData(_userID);
            

        }

        private void ctrlUserInfo1_Load(object sender, EventArgs e)
        {

        }
    }
}
