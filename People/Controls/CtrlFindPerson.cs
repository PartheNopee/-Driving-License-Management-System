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
    public partial class CtrlFindPerson : UserControl
    {
        //declare an event 
        public event Action<int> OnPersonSelected;




        //make a method that raise the event 
        protected void PersonSelected(int PersonID)
        {
            //we assign the event to a local variable 
            Action<int> handler = OnPersonSelected;
            //we check if the Event has listners or handlers  subscuriber 
            //to eviter race vulns
            if (handler != null)
            {
                handler(PersonID);

            }



        }
        public void FilterFocus()
        {
            FilterFindPerson.Focus();
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
                FilterFindPerson.Enabled = _FilterEnabled;
            }
        }

        public clsBLLPeople Person{
            get { return personDetailsCtrl2.SelectedPerson; }
        }
        public int PersonId {
            get { return personDetailsCtrl2.PersonID; }
        }

        
            
        public string NationalID { get; set; }
        public CtrlFindPerson()
        {
            InitializeComponent();
        }


        public void LoadPersonInfo(int PersonID)
        {

            CbPersonFilter.SelectedIndex = 1;
            TxtFilterValue.Text = PersonID.ToString();
            FindNow();

        }


         void FindNow()
        {
            switch (CbPersonFilter.Text)
            {
                case "Person ID":
                    personDetailsCtrl2.LoadPersonInfo(int.Parse(TxtFilterValue.Text));

                    break;

                case "National No":

                    personDetailsCtrl2.LoadPersonInfo(TxtFilterValue.Text);


                    break;
                default:
                    break;

            }
            //here goes the event handler...

            if (OnPersonSelected != null) //&& FilterEnabled)
                // Raise the event with a parameter
                 OnPersonSelected(personDetailsCtrl2.PersonID);

 
        }

        private void bntFindPerson_Click(object sender, EventArgs e)
        {
            FindNow();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            AddPersonScreen frm = new AddPersonScreen();
            frm.DataBack += DataBackEvent;
            frm.ShowDialog();


        }

        private void DataBackEvent(object sender, int PersonID)
        {
            TxtFilterValue.Text = PersonID.ToString();
            CbPersonFilter.SelectedIndex = 1;
            personDetailsCtrl2.LoadPersonInfo(PersonID);


        }

        private void FilterFindPerson_Enter(object sender, EventArgs e)
        {

        }
    } 
     
}
