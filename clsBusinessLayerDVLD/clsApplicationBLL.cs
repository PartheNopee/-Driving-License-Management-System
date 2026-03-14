using System;
using System.Data;
using BLLPeople;
using DataAccessLayer;
using static clsBusinessLayerDVLD.clsUserBLL;

namespace clsBusinessLayerDVLD
{


    public class clsApplicationBLL 
    {
        public enum enApplicationType
        {
            NewDrivingLicense = 1, RenewDrivingLicense = 2, ReplaceLostDrivingLicense = 3,
            ReplaceDamagedDrivingLicense = 4, ReleaseDetainedDrivingLicsense = 5, NewInternationalLicense = 6, RetakeTest = 7
        };
        public enApplicationType ApplicationType;

        public enum enApplicationStatus { New = 1, Cancelled = 2, Completed = 3 };
       public  enum EnMode { _AddNew = 0, _Update =1}
        public EnMode  Mode = EnMode._AddNew;

        public int ApplicationID { get; set; }

        public int ApplicantPersonID { get; set; }

        public DateTime ApplicationDate { get; set; }

        public int ApplicationTypeID { get; set; }
        
        public clsAppTypesBLL AppTypeInfo { get; set; }
        public DateTime LastStatusDate { get; set; }

        public float PaidFee { get; set; }
        public int createdByUserID { get; set; }
        public enApplicationStatus ApplicationStatus { set; get; }
        public string StatusText
        {
            get
            {

                switch (ApplicationStatus)
                {
                    case enApplicationStatus.New:
                        return "New";
                    case enApplicationStatus.Cancelled:
                        return "Cancelled";
                    case enApplicationStatus.Completed:
                        return "Completed";
                    default:
                        return "Unknown";
                }
            }

        }
        public clsApplicationBLL()
        {
            //for add new
            this.ApplicationID = -1;
            this.ApplicantPersonID = -1;
            this.ApplicationTypeID = -1;
            this.ApplicationDate = DateTime.MaxValue;
            this.ApplicationStatus = enApplicationStatus.New;
            this.LastStatusDate = DateTime.UtcNow;
            this.PaidFee = -1;
            this.createdByUserID = -1;

            Mode = EnMode._AddNew;

        }

        private clsApplicationBLL(int ApplicationID, int applicantPersonID, DateTime applicationDate,
            int applicationTypeID, enApplicationStatus applicationStatus,
                             DateTime lastStatusDate, float paidFees, int CreatedByUserID)
        {
            //for update 

            this.ApplicationID = ApplicationID;
            this.ApplicantPersonID = applicantPersonID;
            this.ApplicationTypeID = applicationTypeID;
            this.ApplicationDate = DateTime.UtcNow;
            this.ApplicationStatus = applicationStatus;
            this.LastStatusDate = lastStatusDate;

          //  this.AppTypeInfo = clsAppTypesBLL.FindApp(ApplicationTypeID);
            this.PaidFee = paidFees;
            this.createdByUserID = CreatedByUserID;



            Mode = EnMode._Update;



        }
        public bool Delete()
        {
            return clsApplicationDAL.DeleteApplication(this.ApplicationID);
        }
        static public clsApplicationBLL FindApp(int ID)
        {

           
            int  applicantPersonID = -1;
            int ApplicationTypeID = -1;
            DateTime  ApplicationDate = DateTime.UtcNow;
            byte ApplicationStatus = 0;
            DateTime  LastStatusDate = DateTime.UtcNow;
            decimal  PaidFee = 0;
            int createdByUserID = -1;

            if (clsApplicationDAL.GetApplicationByID(ID, ref applicantPersonID, ref ApplicationDate, ref ApplicationTypeID, ref ApplicationStatus, ref
              LastStatusDate, ref PaidFee, ref createdByUserID))

             return   new clsApplicationBLL(ID, applicantPersonID, ApplicationDate, ApplicationTypeID, (enApplicationStatus)ApplicationStatus,
              LastStatusDate, (float)PaidFee, createdByUserID);

            else
                return null;





        }

        private bool _AddNewApp()
        {
            this.ApplicationID = clsApplicationDAL.AddApplication(this.ApplicantPersonID, this.ApplicationDate, (int)this.ApplicationTypeID, (byte)this.ApplicationStatus,
              this.LastStatusDate, this.PaidFee, this.createdByUserID);
            return (ApplicationID != -1);


        }

        private bool _UpdateApp()
        {

            return clsApplicationDAL.UpdateApplication( this.ApplicationID,this.ApplicantPersonID, this.ApplicationDate, this.ApplicationTypeID, (byte)this.ApplicationStatus,
              this.LastStatusDate, this.PaidFee, this.createdByUserID);


        }

        public  virtual bool Save()
        {
            switch (Mode)
            {
                case EnMode._AddNew:
                    if (_AddNewApp())
                    {

                        Mode = EnMode._Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case EnMode._Update:

                    return _UpdateApp();

            }

            return false;
        }
        static public DataTable GetAllApp()
        {
            return clsApplicationDAL.GetAllApps();

        }

        static public bool DeleteApp(int ID)
        {
            return clsApplicationDAL.DeleteApplication(ID);

        }
                    

        public static bool HasApplied(int ID, int LicenseClassID)
        {

            return clsApplicationDAL.HasApplied(ID, LicenseClassID);
        }

        public bool Cancel()
        {

            return clsApplicationDAL.UpdateStatus(ApplicationID, 2);

        }
        public bool SetComplete()
        {

            return clsApplicationDAL.UpdateStatus(ApplicationID, 3);

        }

        public static int DoesPersonHaveActiveApplication(int personID, enApplicationType ApplicationID)
        {
            return clsApplicationDAL.GetActiveApplicationID(personID, (int)ApplicationID);
        }

        public static int GetActiveApplicationIDForLicenseClass(int PersonID, enApplicationType ApplicationTypeID , int LicenseClass)
        {

            return clsApplicationDAL.GetActiveApplicationIDForLicenseClass(PersonID, (int)ApplicationTypeID, LicenseClass);
        }

    }

}
