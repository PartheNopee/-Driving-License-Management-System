using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using static clsBusinessLayerDVLD.clsApplicationBLL;
using static clsBusinessLayerDVLD.clsUserBLL;

namespace clsBusinessLayerDVLD
{
    public  class clsTestAppointmentsBLL 
    {
        enum EnModeAppontment { _AddNew = 0, _Update = 1 }
        EnModeAppontment _Mode = EnModeAppontment._AddNew;

        public int TestAppointmentID { get; set; }


        public int LocalDrivingLicenseApplicationID { get; set; }

        public clsLocalDLApplicattionBLL LocalApp { get; set;  }
        public DateTime AppointmentDate { get; set; }

        public int TestTypeID { get; set; }

        public clstestTypesBLL TestTypeInfo { get; set; }
        public int RetakeTestApplicationID {  get; set; }
        public float PaidFeeTest { get; set; }
        public int createdByUserID { get; set; }
        public clsApplicationBLL RetakeTestAppInfo {  get; set; }
        public bool IsLocked {  get; set; }

        public clsTestAppointmentsBLL()
        {
            this.TestAppointmentID = -1;
            this.AppointmentDate = DateTime.Now;
            this.TestTypeID = -1;
            this.PaidFeeTest = 0;
            this.createdByUserID = -1;

            this.RetakeTestApplicationID = -1;

           _Mode = EnModeAppontment._AddNew;
        
        }
        private clsTestAppointmentsBLL(int testAppointmentID, int TestTypeID, int LocalAppID, DateTime AppointmentDate, float paidFee,
            int CreatedByUserID, bool isLocked, int retakeAppID)
        {
            this.TestAppointmentID = testAppointmentID;
            this.LocalDrivingLicenseApplicationID = LocalAppID; 
            this.AppointmentDate = AppointmentDate;
            this.TestTypeID = TestTypeID;
            this.PaidFeeTest = paidFee;
            this.createdByUserID = CreatedByUserID;
            this.IsLocked = isLocked;
            this.TestTypeInfo = clstestTypesBLL.FindTest((clstestTypesBLL.enTestType)TestTypeID);
            this.RetakeTestApplicationID = retakeAppID;
            this.RetakeTestAppInfo = clsApplicationBLL.FindApp((int)RetakeTestApplicationID);

            _Mode = EnModeAppontment._Update;


        }

        static public clsTestAppointmentsBLL GettestAppointmentByID(int ID)
        {
            int LocalAppID = -1;
            DateTime AppointmentDate = DateTime.Now;
            int TestTypeID = -1;
            float paidFeeT = 0;
            int createdByUserID = -1;
            bool IsLocked = false;
            int RetakeTestApplicationID = -1;


            if (clsTestAppointmentDAL.GetTestAppointmentID(ID, ref TestTypeID, ref LocalAppID, ref AppointmentDate, ref IsLocked, ref
              paidFeeT, ref createdByUserID, ref RetakeTestApplicationID))

                return new clsTestAppointmentsBLL(ID, TestTypeID, LocalAppID,
                     AppointmentDate, paidFeeT, createdByUserID, IsLocked, RetakeTestApplicationID);

            else
                return null;





        }

        static public clsTestAppointmentsBLL GettestAppointbyLocalAppID(int ID)
        {
            int TestApointmentID = -1;
            DateTime AppointmentDate = DateTime.Now;
            int TestTypeID = -1;
            float PaidFee = 0;
            int createdByUserID = -1;
            bool IsLocked = false;
            int RetakeTestApplicationID = -1;


            if (clsTestAppointmentDAL.GetTestAppointmentbyLocalAppID(ID, ref TestTypeID, ref TestApointmentID, ref AppointmentDate, ref IsLocked, ref
              PaidFee, ref createdByUserID, ref RetakeTestApplicationID))

                return new clsTestAppointmentsBLL(TestApointmentID, TestTypeID, ID,
                     AppointmentDate, PaidFee, createdByUserID, IsLocked, RetakeTestApplicationID);

            else
                return null;





        }

        private bool _AddTestAppointment()
        {

            this.TestAppointmentID = clsTestAppointmentDAL.AddTestAppointment(this.TestTypeID, this.LocalDrivingLicenseApplicationID, this.AppointmentDate
                , this.PaidFeeTest, this.createdByUserID,  this.RetakeTestApplicationID);
            return (this.TestAppointmentID != -1);

        }
        private bool _UpdateAppointment()
        {
            return clsTestAppointmentDAL.UpdateAppointment(this.TestAppointmentID, this.AppointmentDate);


        }

        public bool SaveAppointment()
         {
            switch (_Mode)
            {
                case EnModeAppontment._AddNew:
                    if (_AddTestAppointment())
                    {

                        _Mode = EnModeAppontment._Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case EnModeAppontment._Update:

                    return _UpdateAppointment();

            }

            return false;
        }

        static public DataTable getAppointmentsByLocalAppID(int appID , int TestID)
        {

            return clsTestAppointmentDAL.GetAllAppointmentsByAppID(appID, TestID);

        }
        //UI should never do logic work... it just asks BLL i also should have put all these methods in the LocalDrivingLicense

        static public bool HasUnlockedAppointment(int TestID)
        {
            return clsTestAppointmentDAL.HasUnlockedAppointmet( TestID);

        }
        static public bool HasUnlockedAppointment(int LocalID, int TestID)
        {
            return clsTestAppointmentDAL.HasUnlockedAppointmet(LocalID, TestID);

        }
       
        public bool LockTestAppointment()
        {
            //no parameter and not static means it's checking an already filled object 
            return clsTestAppointmentDAL.LockTestAppointment(this.TestAppointmentID);


        }
        static public bool HasPassed(int LocalAppID, int TestTypeID)
        {
            return clsTestAppointmentDAL.HasPassedTest(LocalAppID, TestTypeID);
          

        }
        public  static int TrialCount(int LocalAppID, int TestTypeID)
        {
            return clsTestAppointmentDAL.GetFailedTestsCount(LocalAppID, TestTypeID);


        }
        public static bool HasFailedBefore(int localAppId, int testTypeId)
        {
            int failedCount =
                clsTestAppointmentDAL.GetFailedTestsCount(localAppId, testTypeId);

            return failedCount > 0;
        }


    }
}
