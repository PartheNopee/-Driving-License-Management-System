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
    public partial class UpdateAppTypes : Form
    {
        int AppID = -1;
        clsAppTypesBLL AppTypes;
        public UpdateAppTypes(int ID)
        {
            InitializeComponent();
            AppID = ID;
            _LoadData();
        }

        void _LoadData()
        {
            AppTypes = clsAppTypesBLL.FindApp(AppID);
            LbID.Text = AppID.ToString();
            txtTitle.Text = AppTypes._Title;
            txtFee.Text = AppTypes._Fee.ToString();

 
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AppTypes._Title = txtTitle.Text;
            AppTypes._Fee = Convert.ToSingle( txtFee.Text);
            if (AppTypes.updateApp())
            {
                MessageBox.Show("Application Updated Succesfully ! ");

            }
            else
            {
                MessageBox.Show("The Operation is Invalid, try again !");
            }

        }
    }
}
