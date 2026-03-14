using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace clsBusinessLayerDVLD
{
    public class clsTestBLL  
    {
        public int TestID { get; set; }
        public int TestAppointmentID { get; set; }
        public string Notes { get; set; }
        public bool Result { get; set; }
        public int CreatedByUserID { get; set; }
        public clsTestAppointmentsBLL TestAppointment { get; set; }

         

        
        public clsTestBLL()
        {
            this.TestID = -1;
            this.TestAppointmentID = -1;
            this.Notes = null;
            this.Result = false;
            this.CreatedByUserID = -1;


            


        }
        private clsTestBLL(int ID,int TestAppointmentID, bool TestResult, string Notes, int CreatedByUser)
        {
            this.TestID = ID;
            this.TestAppointmentID = TestAppointmentID;
            this.Notes = Notes;
            this.Result = TestResult;
            this.CreatedByUserID = CreatedByUser;
            this.TestAppointment = clsTestAppointmentsBLL.GettestAppointmentByID(this.TestAppointmentID);





        }

        public static clsTestBLL FindTestByID(int ID)
        {

            int testAppointID = -1;
            int createdByUser = -1;
            bool result = false;
            string Notes = null;
            if (clsTestsDAL.GetTakeTestByID(ID, ref testAppointID, ref result, ref Notes, ref createdByUser))
            {

               return new clsTestBLL(ID, testAppointID, result, Notes, createdByUser);
            }
            else
                return null;




        }
        public static clsTestBLL FindLastTestPerPersonAndLicenseClass
        (int PersonID, int LicenseClassID, clstestTypesBLL.enTestType TestTypeID)
        {
            int TestID = -1;
            int TestAppointmentID = -1;
            bool TestResult = false; string Notes = ""; int CreatedByUserID = -1;

            if (clsTestsDAL.GetLastTestByPersonAndTestTypeAndLicenseClass
                (PersonID, LicenseClassID, (int)TestTypeID, ref TestID,
            ref TestAppointmentID, ref TestResult,
            ref Notes, ref CreatedByUserID))

                return new clsTestBLL(TestID,
                        TestAppointmentID, TestResult,
                        Notes, CreatedByUserID);
            else
                return null;

        }
        private bool _AddTest()
        {

            this.TestID = clsTestsDAL.AddTest(this.TestAppointmentID,this.Result,this.Notes,this.CreatedByUserID);
            return (this.TestID != -1);

        }


        public bool Save()
        {
            if (_AddTest())
            
                return true;
            else
                return false;
            
             

        }







    }
}
