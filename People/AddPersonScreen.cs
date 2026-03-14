using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLLPeople;
using clsBusinessLayerDVLD;
using DVLDApp.Properties;
using Microsoft.Win32;


namespace DVLDApp
{
    public partial class AddPersonScreen : Form
    {

        public delegate void DataBackEventHandler(object sender, int PersonID);

        public event DataBackEventHandler  DataBack;

        public enum enGendor { Male = 0, Female = 1 };

        private string newFileName = "";
 

        clsBLLPeople _clsPeople;
        public enum enMode
        {
            _Add = 0, _Update  = 1
        }
        private enMode _Mode;

        int _PersonID ;

        public AddPersonScreen()
        {
            InitializeComponent();
            _Mode = enMode._Add;
            _clsPeople = new clsBLLPeople();
        }
        public AddPersonScreen(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;

            _clsPeople = clsBLLPeople.Find(_PersonID);


            _Mode = enMode._Update ;

            _LoadDate();

        }

        
        private void femaleRB_Click(object sender, EventArgs e)
        {
            //change the defualt image to female incase there is no image set.
            if (pictureBox1.ImageLocation == null)
                pictureBox1.Image = Resources.pic4;
        }

        private void MaleRD_Click(object sender, EventArgs e)
        {
            //change the defualt image to male incase there is no image set.
            if (pictureBox1.ImageLocation == null)
                pictureBox1.Image = Resources.EvandroSoldati;
        }
        private void LoadCountry()
        {
            DataTable Countries = clsCountryBLL.GetCountries();

            CountryCB.DataSource = Countries;
            CountryCB.DisplayMember = "CountryName";   // The column to show in the list
            CountryCB.ValueMember = "CountryID"; //The Actual FK
            CountryCB.SelectedIndex = 10;
            CountryCB.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        void _LoadDate()
        {



            if (_clsPeople == null)
            {
                MessageBox.Show("Person with" + _PersonID + " is not found");
                this.Close();
                return;
            }
            //int CountryID = clsCountryBLL.Find(cbCountry.Text).ID;
             LoadCountry();
                        if (_Mode == enMode._Add )
                        {
                            LbAddUpdate.Text = "Add New Person";
                            _clsPeople = new clsBLLPeople();
            
            
                            return;
                        }
            _clsPeople = clsBLLPeople.Find(_PersonID);

            LbAddUpdate.Text = "Edit Person " + _PersonID;
            LbID.Text = _clsPeople.ID.ToString();
            firstNametxt.Text = _clsPeople.firstName;
            Secnametxt.Text = _clsPeople.SecName;
            thirdnametxt.Text = _clsPeople.ThirdName;
            Lastnametxt.Text = _clsPeople.lastName;
            NationIDtxt.Text = _clsPeople.Email;
            PhoneTxt.Text = _clsPeople.Phone;

            if (_clsPeople.Gendor == 0)
                MaleRD.Checked = true;
            else
             femaleRB.Checked = true;

             NationIDtxt.Text = _clsPeople.NationalID;
             DatePickerDOB.Value = _clsPeople.DOB;
             AdressTxt.Text   = _clsPeople.Address;
             CountryCB.SelectedValue = _clsPeople.Country;
             
             pictureBox1.ImageLocation = string.IsNullOrEmpty(_clsPeople.ImagePath) ? "" : _clsPeople.ImagePath;



        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
          private bool _HandlePersonImage()
        {

            // Check if the image has been changed.
            if (_clsPeople.ImagePath != pictureBox1.ImageLocation)
            {
                // Delete old image if it exists.
                if (!string.IsNullOrEmpty(_clsPeople.ImagePath) && File.Exists(_clsPeople.ImagePath))
                {
                    try
                    {
                        File.Delete(_clsPeople.ImagePath);
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show($"Error deleting old image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

                // Save new image if necessary.
                if (!string.IsNullOrEmpty(pictureBox1.ImageLocation) && File.Exists(pictureBox1.ImageLocation))
                {
                    try
                    {
                        if (FileSaver.SaveImageToProjectFolder(ref newFileName) == true)
                        {
                            pictureBox1.ImageLocation = newFileName;
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Error saving new image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error saving image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }

            return true;
        }




        private void BtnSave_Click(object sender, EventArgs e)
        {


            if (!_HandlePersonImage())
                return;

            
            _clsPeople.firstName = firstNametxt.Text;
            _clsPeople.SecName = Secnametxt.Text;
            _clsPeople.ThirdName = thirdnametxt.Text;
            _clsPeople.lastName = Lastnametxt.Text;
            _clsPeople.Email = Emailtxt.Text;
            _clsPeople.Phone = PhoneTxt.Text;
            _clsPeople.Address = AdressTxt.Text;
            _clsPeople.DOB = DatePickerDOB.Value;
            _clsPeople.ImagePath = string.IsNullOrEmpty(pictureBox1.ImageLocation) ? "" : newFileName;
            _clsPeople.NationalID = NationIDtxt.Text;

            if (MaleRD.Checked)
                _clsPeople.Gendor = (byte)enGendor.Male;
            else
                _clsPeople.Gendor = (byte)enGendor.Female;

            _clsPeople.Country = (int)CountryCB.SelectedValue;

            try
            {
               
                
             

                if (_clsPeople.Save())
                {
                    MessageBox.Show("Person saved successfully!");
                    _Mode = enMode._Update;
                    _PersonID = _clsPeople.ID;
                    LbAddUpdate.Text = $"Edit Person {_PersonID}";
                    LbID.Text = _PersonID.ToString();

                    DataBack?.Invoke(this, _PersonID);
                }
                else
                {
                    MessageBox.Show("Error: Data was not saved successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the person: {ex.Message}");
            }
        }


        private void addPersonUserCtrl1_Load(object sender, EventArgs e)
        {

        }

        private void AddPersonScreen_Load(object sender, EventArgs e)
        {
            LoadCountry();
            LbdeleteImg.Visible = false;

        }

        private void linkEditImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                newFileName = openFileDialog1.FileName;
                pictureBox1.Load(newFileName);
                LbdeleteImg.Visible = true;
                // ...
            }
        }
    }
}
