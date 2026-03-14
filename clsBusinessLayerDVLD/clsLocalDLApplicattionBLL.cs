using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLLPeople;
using DataAccessLayer;
using static clsBusinessLayerDVLD.clstestTypesBLL;

namespace clsBusinessLayerDVLD
{
    public class clsLocalDLApplicattionBLL : clsApplicationBLL
    {
        enum EnMode { _AddNew = 0, _Update = 1 }
        EnMode _Mode = EnMode._AddNew;
         public int LocalDrivingLicenseApplicationID { get; set; }


        public string fullName {
            get { return clsBLLPeople.Find(ApplicantPersonID).FullName; } 
        }
        
        
        public int LicenseClassID { get; set; }
        public clsClassLicenseBLL LicenseClassInfo { get; set; }
        public clsApplicationBLL Application { get; set;  }
        public clsLocalDLApplicattionBLL()
        {
            this.LocalDrivingLicenseApplicationID = -1;
            this.LicenseClassID = -1;
            this.Application = new clsApplicationBLL();

            _Mode = EnMode._AddNew;

        }

        private clsLocalDLApplicattionBLL(int LocalDrivingLicenseApplicationID, int ApplicationID, int ApplicantPersonID,
            DateTime ApplicationDate, int ApplicationTypeID,
             enApplicationStatus ApplicationStatus, DateTime LastStatusDate,
             float PaidFees, int CreatedByUserID, int LicenseClassID)
        {
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID; ;
            this.ApplicationID = ApplicationID;
            this.ApplicantPersonID = ApplicantPersonID;
            this.ApplicationDate = ApplicationDate;
            this.ApplicationTypeID = (int)ApplicationTypeID;
            this.ApplicationStatus = ApplicationStatus;
            this.LastStatusDate = LastStatusDate;
            this.PaidFee = PaidFees;
            this.createdByUserID = CreatedByUserID;
            this.LicenseClassID = LicenseClassID;
            this.LicenseClassInfo = clsClassLicenseBLL.Find(LicenseClassID);

            _Mode = EnMode._Update;
        }
        
        static public clsLocalDLApplicattionBLL Find(int LocalDrivingLicenseApplicationID)
        {


            int ApplicationID = -1;
            int LicenseClassID = -1;
            
            bool isFound = clsLocaldriverlicenseDAL.GetLocalDriverlicenceAppByID(LocalDrivingLicenseApplicationID, ref ApplicationID,ref LicenseClassID);

            if (isFound)
            {

                clsApplicationBLL Application = clsApplicationBLL.FindApp(ApplicationID);

                return new clsLocalDLApplicattionBLL(
                   LocalDrivingLicenseApplicationID, Application.ApplicationID,
                   Application.ApplicantPersonID,
                                    Application.ApplicationDate, Application.ApplicationTypeID,
                                   (enApplicationStatus)Application.ApplicationStatus, Application.LastStatusDate,
                                    Application.PaidFee, Application.createdByUserID, LicenseClassID);


            }
           return null;


        }

        private bool _AddNew()
        {
            this.LocalDrivingLicenseApplicationID = clsLocaldriverlicenseDAL.AddLocalLDApplication(this.ApplicationID, this.LicenseClassID);

            return (LocalDrivingLicenseApplicationID != -1);
        }

        private bool _Update()
        {
            return clsLocaldriverlicenseDAL.UpdateLocalApplication(this.LocalDrivingLicenseApplicationID, this.ApplicationID, this.LicenseClassID);

        }


        public clsTestBLL GetLastTestPerTestType(clstestTypesBLL.enTestType TestType)
        {
            return clsTestBLL.FindLastTestPerPersonAndLicenseClass(this.ApplicantPersonID, this.LicenseClassID, TestType);
        }
        public static clsLocalDLApplicattionBLL FindByApplicationID(int ApplicationID)
        {
            // 
            int LocalDrivingLicenseApplicationID = -1, LicenseClassID = -1;

            

            bool isFound = clsLocaldriverlicenseDAL.GetLocalDriverlicenceAppByID(LocalDrivingLicenseApplicationID, ref ApplicationID, ref LicenseClassID);

            if (isFound)
            {

                clsApplicationBLL Application = clsApplicationBLL.FindApp(ApplicationID);

                return new clsLocalDLApplicattionBLL(
                   LocalDrivingLicenseApplicationID, Application.ApplicationID,
                   Application.ApplicantPersonID,
                                    Application.ApplicationDate, Application.ApplicationTypeID,
                                   (enApplicationStatus)Application.ApplicationStatus, Application.LastStatusDate,
                                    Application.PaidFee, Application.createdByUserID, LicenseClassID);


            }
            return null;


        }
        public bool DoesAttendTestType(clstestTypesBLL.enTestType TestTypeID)

        {
            return clsLocaldriverlicenseDAL.DoesAttendTestType(this.LocalDrivingLicenseApplicationID, (int)TestTypeID);
        }
        private bool PrepareAppInfo(enApplicationType AppType)
        {


            Application.ApplicationTypeID = (int)AppType;
            Application.ApplicationDate = DateTime.Now;

            Application.PaidFee = clsAppTypesBLL.FindApp(Application.ApplicationTypeID)._Fee;
            Application.ApplicationStatus = enApplicationStatus.New;
            Application.LastStatusDate = DateTime.Now;

            Application.Mode = (clsApplicationBLL.EnMode)Mode;
            if (Application.Save())
            {
                this.ApplicationID = Application.ApplicationID;

                return true;
            }
            
            return false;

        }

        public  bool  Save()
        {

            //Because of inheritance first we call the save method in the base class,
            //it will take care of adding all information to the application table.
           
            
            
            PrepareAppInfo(enApplicationType.NewDrivingLicense);
            switch (_Mode)
                {
                    case EnMode._AddNew:
                        if (_AddNew())
                        {
                            _Mode = EnMode._Update;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    case EnMode._Update:

                        return _Update();


                }
            
            return false;


             

        }




        static public DataTable GetAllApp()
        {
            return clsLocaldriverlicenseDAL.GetAllLocalLDApps();

        }

        public bool Delete()
        {
            bool IsLocalDrivingApplicationDeleted = false;
            bool IsBaseApplicationDeleted = false;
            //First we delete the Local Driving License Application
            IsLocalDrivingApplicationDeleted = clsLocaldriverlicenseDAL.DeleteLocalDriverApplication(this.LocalDrivingLicenseApplicationID);

            if (!IsLocalDrivingApplicationDeleted)
                return false;
            //Then we delete the base Application
            IsBaseApplicationDeleted = base.Delete();
            return IsBaseApplicationDeleted;

        }

        public bool DoesPassTestType(clstestTypesBLL.enTestType enTestType)
        {

            return clsLocaldriverlicenseDAL.DoesPassTestType(this.LocalDrivingLicenseApplicationID, (int)enTestType);
        }

        public bool IsLicenseActive()
        {
            return GetActiveLicense() != -1;
        }
        public int GetActiveLicense()
        {

            return clsLocaldriverlicenseDAL.GetActiveLicenseIDByPersonID(this.ApplicantPersonID, this.LicenseClassID) ;
        }

        public bool DoesPassAllTest()
        {
            return DoesPassTestType(clstestTypesBLL.enTestType.StreetTest);
        }

        public int IssuELicenseForTheFirstTime(string Notes, int CreatedByUserID)
        {


            int DriverID = -1;

            clsDriverBLL Driver = clsDriverBLL.GetDriverByPersonID(this.ApplicantPersonID);

            if (Driver == null)
            {
                //we check if the driver already there for this person.
                Driver = new clsDriverBLL();

                Driver.PersonID = this.ApplicantPersonID;
                Driver.CreatedByUserID = CreatedByUserID;
                if (Driver.SaveDriver())
                {
                    DriverID = Driver.DriverID;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                DriverID = Driver.DriverID;
            }
            //now the diver is there, so we shall add the license
            
                clsLicensesBLL _License = new clsLicensesBLL();
                    _License.DriverID = DriverID;   
                _License.LocalID = this.LocalDrivingLicenseApplicationID;
                _License.ApplicationID = this.ApplicationID;
                _License.LicenseClass = this.LicenseClassID;
                _License.CreatedByUserID = CreatedByUserID;
                _License.IsActive = true;
                _License.IssueReason = clsLicensesBLL.enIssueReason.FirstTime;
                _License.Notes = Notes;
               _License.PaidFees = this.LicenseClassInfo.LicenceFee;
               _License.ExpDate = DateTime.Now.AddYears(this.LicenseClassInfo.validity);
               _License.IssueDate = DateTime.Now;

            if (_License.Save())
            {
                    this.SetComplete();
                    return _License.LicenseID;
            }
                else
                
                     return -1;   
                



        }

        public bool IsLicenseIssued()
        {
            return (GetActiveLicenseID() != -1);

        }



        
        public int GetActiveLicenseID()
        {
            return clsLicensesBLL.GetActiveLicenseIDByPersonID(this.ApplicantPersonID, this.LicenseClassID);
        }

    }
}
