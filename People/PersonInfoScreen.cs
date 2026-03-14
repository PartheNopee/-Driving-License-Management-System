using BLLPeople;
using clsBusinessLayerDVLD;
using System;

using System.Windows.Forms;

namespace DVLDApp
{
    public partial class PersonInfoScreen : Form
    {
        public PersonInfoScreen(int ID)
        {
            InitializeComponent();
            personDetailsCtrl2.LoadPersonInfo(ID);

        }
       

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void personDetailsCtrl2_Load(object sender, EventArgs e)
        {

        }
    }
}
