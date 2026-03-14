using System;
using System.Windows.Forms;
using clsBusinessLayerDVLD;

namespace DVLDApp.Licenses.Controls
{
    public partial class CtrlLicenseInfoWithFilter : UserControl
    {
        public CtrlLicenseInfoWithFilter()
        {
            InitializeComponent();
        }
        public clsLicensesBLL SelectedLicenseInfo
        {
            get
            {
                return ctrlLicenseInfo1.SelectedLicenseInfo;
            }

        }
        int _LicenseID = -1;

        public event Action<int> OnLicenseSelected;




        //make a method that raise the event 
        protected virtual void LicenseSelected(int LicenseID)
        {
            //we assign the event to a local variable 
            Action<int> handler = OnLicenseSelected;
            //we check if the Event has listners or handlers  subscuriber 
            //to eviter race vulns
            if (handler != null)
            {
                handler(LicenseID);

            }



        }

        private void ctrlLicenseInfo1_Load(object sender, EventArgs e)
        {

        }

        private bool _FilterEnabled = true;
        public bool FilterEnabled
        {
            get
            {
                return _FilterEnabled;
            }
            set
            {
                _FilterEnabled = value;
                gbFilters.Enabled = _FilterEnabled;
            }
        }

        public void LoadLicenseInfo(int LicenseID)
        {
           

          
            txtLicenseID.Text = LicenseID.ToString();
            ctrlLicenseInfo1.LoadLicenseData(LicenseID);
            _LicenseID = ctrlLicenseInfo1.LicenseID;
            if (OnLicenseSelected != null && FilterEnabled)
                // Raise the event with a parameter
                OnLicenseSelected(_LicenseID);




        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLicenseID.Focus();
                return;

            }
            _LicenseID = int.Parse(txtLicenseID.Text);

            LoadLicenseInfo(_LicenseID);
                

            
            
            
        }

        public void txtLicenseIDFocus()
        {
            txtLicenseID.Focus();
        }
        private void txtLicenseID_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits (0-9) and the Backspace key (for deleting text)
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;


            if (e.KeyChar == (char)13)
            {
                btnFind.PerformClick();
            }
        }
    }
}
