using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clsBusinessLayerDVLD;

namespace DVLDApp.Applications
{
    public partial class TakeTestFrm : Form
    {

        clsTestBLL _Test;
        private int _TestAppointmentID = -1;
        private clsTestAppointmentsBLL _TestAppointment;

        private clstestTypesBLL.enTestType _TestType;
        public TakeTestFrm(int ID, clstestTypesBLL.enTestType TestType )
        {
            InitializeComponent();
            _TestAppointmentID = ID;
            _TestType = TestType;
            
           
           
            
        }
        
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void btnSave_Click(object sender, EventArgs e)
        {
            _TestAppointment = clsTestAppointmentsBLL.GettestAppointmentByID(this._TestAppointmentID);
            if (MessageBox.Show("Are you sure you want to save ? After that you cannot change Pass/Fail result! ", "Confirm",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }

                

            _Test.TestAppointmentID = _TestAppointmentID;
            _Test.CreatedByUserID = GlobalClass.CurrentUser.UserID;
            _Test.Result = rdPass.Checked;
            _Test.Notes = TxtNotes.Text.Trim();

            
            
                  if(_Test.Save())
                  {
                     _TestAppointment.LockTestAppointment();
                      MessageBox.Show("Test Result saved successfully.", "Saved",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);

                  }
                  else
                  {
                      MessageBox.Show("failed to save Test Result ." , "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                  
                  
                  }



        }


        private void gbRetake_Enter(object sender, EventArgs e)
        {

        }

        private void TakeTestFrm_Load(object sender, EventArgs e)
        {
            ctrlTakeTest2.TestTypeID = _TestType;
            ctrlTakeTest2.LoadTakeTestInfo(_TestAppointmentID);



            _Test = new clsTestBLL();
        }
    }
}
