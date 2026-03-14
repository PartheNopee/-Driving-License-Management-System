using System;
using System.IO;
using System.Windows.Forms;
using BLLPeople;
using clsBusinessLayerDVLD;
using DVLDApp.Properties;
using static DVLDApp.AddPersonScreen;

namespace DVLDApp
{
    public partial class PersonDetailsCtrl : UserControl
    {

        private int _PersonID = -1;

        private clsBLLPeople _Person;

        public clsBLLPeople SelectedPerson
        {
            get { return _Person; }
        }
        public int PersonID
        {
            get { return _PersonID; }
        }

        public PersonDetailsCtrl()
        {
            InitializeComponent();
        }

        private void _FillPersonInfo()
        {
            EditpersonLink.Visible = true;
            _PersonID = SelectedPerson.ID;
            lbID.Text = PersonID.ToString();
            LbPhone.Text = SelectedPerson.Phone;
            lbName.Text = SelectedPerson.FullName;
            LbCountry.Text = clsCountryBLL.Find(SelectedPerson.Country).CountryName;
            GendorLb.Text = SelectedPerson.Gendor == 0 ? "Male" : "Female";
            LbEmail.Text = SelectedPerson.Email;
            LbDOB.Text = SelectedPerson.DOB.ToShortDateString();
            NationalLb.Text = SelectedPerson.NationalID;
            lbAddress.Text = SelectedPerson.Address;

            LoadImage();
             
        }

        public void ResetPersonInfo()
        {
            _PersonID = -1;
            lbID.Text = "[????]";
            NationalLb.Text = "[????]";
            lbName.Text = "[????]";
            Picture.Image = Resources.female;
            GendorLb.Text = "[????]";
            LbEmail.Text = "[????]";
            LbPhone.Text = "[????]";
            LbDOB.Text = "[????]";
            LbCountry.Text = "[????]";
            lbAddress.Text = "[????]";
            Picture.Image = Resources.boy;

        }
        public void LoadPersonInfo(int PersonID)
        {
            _Person = clsBLLPeople.Find(PersonID);
            if (_Person == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Person with PersonID = " + PersonID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillPersonInfo();

        }

        public void LoadPersonInfo(string nationalNo)
        {
             _Person = clsBLLPeople.Find(nationalNo);
            if (_Person == null)
            {
                // ResetPersonInfo();
                MessageBox.Show("No Person with National No = " + nationalNo , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillPersonInfo();

        }

        private void LoadImage()
        {
            string ImagePath = _Person.ImagePath;
            
                // Default to gender-based image
                Picture.Image = _Person.Gendor == 0 ? Resources.boy : Resources.female;


            if (ImagePath != "")

                if (File.Exists(ImagePath))
                
                    Picture.ImageLocation = ImagePath;
                
                else
                
                    MessageBox.Show("Could not find the image! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            



        }


        private void EditpersonLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
                Form form = new AddPersonScreen(_PersonID);
                form.ShowDialog();
            
            
            
            
        }


        


        private void Picture_Click(object sender, EventArgs e)
        {

        }

        private void PersonDetailsCtrl_Load(object sender, EventArgs e)
        {

        }
    }
}
