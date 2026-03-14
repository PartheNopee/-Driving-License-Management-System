using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace clsBusinessLayerDVLD
{
    public class clsLicensesBLL 
    {
        enum EnMode { _AddNew = 0, _Update = 1 }
        EnMode _Mode = EnMode._AddNew;

        public enum enIssueReason { FirstTime = 1, Renew = 2, DamagedReplacement = 3, LostReplacement = 4 };

        public int LicenseID { get; set; }


        public int ApplicationID { get; set; }

        public DateTime IssueDate { get; set; }
        public DateTime ExpDate { get; set; }
        public clsDetainedBLL DetainedInfo { get; set; }
        public clsDriverBLL DriverInfo {  get; set; }
        public int DriverID { get; set; }
        public int LicenseClass {  get; set; }
        public string Notes { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public clsClassLicenseBLL LicenseInfo {  get; set; }
        public bool IsActive {  get; set; }

        public enIssueReason IssueReason { get; set; }

        public string IssueReasonText { 
            get
            {
                return GetIssueReasonText(IssueReason);
            } 
        }
        public int LocalID { get; set; }

        public static string GetIssueReasonText(enIssueReason IssueReason)
        {

            switch (IssueReason)
            {
                case enIssueReason.FirstTime:
                    return "First Time";
                case enIssueReason.Renew:
                    return "Renew";
                case enIssueReason.DamagedReplacement:
                    return "Replacement for Damaged";
                case enIssueReason.LostReplacement:
                    return "Replacement for Lost";
                default:
                    return "First Time";
            }
        }
        public clsLicensesBLL()
        {
            this.LicenseID = -1;
            this.ApplicationID = -1;
            this.IssueDate = DateTime.UtcNow;
            this.LicenseClass = -1;
            this.DriverID = -1;
            this.CreatedByUserID = -1;
            this.Notes = null;
            this.IsActive = true;
            this.IssueReason = enIssueReason.FirstTime; 
           this.ExpDate = DateTime.UtcNow;
           this.PaidFees = 0;
            this.LocalID = -1;

            _Mode = EnMode._AddNew;

        }
        public bool ReleaseLicense(int ReleasedByUserID , ref  int ApplicationID )
        {
            

            clsApplicationBLL application = new clsApplicationBLL();
            application.ApplicantPersonID = DriverInfo.PersonID;
            application.ApplicationDate = DateTime.Now;
            application.LastStatusDate = DateTime.Now;
            application.ApplicationStatus = clsApplicationBLL.enApplicationStatus.Completed;
            application.ApplicationTypeID = (int)clsApplicationBLL.enApplicationType.ReleaseDetainedDrivingLicsense;
            application.createdByUserID = this.CreatedByUserID;
            application.PaidFee = clsAppTypesBLL.FindApp(application.ApplicationTypeID)._Fee;

            if (!application.Save())
            {
                ApplicationID = -1;
                return false;
            }
            ApplicationID = application.ApplicationID;

            return this.DetainedInfo.ReleaseDetainedLicense( ReleasedByUserID, ApplicationID);


            


        }


        
        public int Detain(float FineFees, int CreatedByUserID)
        {
            clsDetainedBLL detainedLicense = new clsDetainedBLL();
            detainedLicense.LicenseID = this.LicenseID;
            detainedLicense.DetainDate = DateTime.Now;
            detainedLicense.FineFees = Convert.ToSingle(FineFees);
            detainedLicense.CreatedByUserID = CreatedByUserID;

            if (!detainedLicense.Save())
            {

                return -1;
            }

            return detainedLicense.DetainID;

        }
        public bool IsDetained()
        {
            return clsDetainedBLL.IsDetained(this.LicenseID);

        }
        private clsLicensesBLL(int licenseID, int ApplicationID, int DriverID, int LicenseClass, DateTime IssueDate,
            DateTime ExpDate, string Notes, decimal PaidFees, bool IsActive
           , enIssueReason IssueReason, int CreatedByUserID)
        {
            this.LicenseID = licenseID;
            this.ApplicationID = ApplicationID;
            this.IssueDate = IssueDate;
            this.LicenseClass = LicenseClass;
            this.ExpDate = ExpDate;
            this.DriverID = DriverID;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.Notes = Notes;
            this.IsActive = IsActive;
            this.IssueReason = IssueReason;
            this.LicenseInfo = clsClassLicenseBLL.Find(this.LicenseClass);
            this.DriverInfo = clsDriverBLL.GetDriverByID(this.DriverID);
            this.DetainedInfo = clsDetainedBLL.FindDetainedLicenseByLicenseID(this.LicenseID);
            _Mode = EnMode._Update;
        }

        static public clsLicensesBLL FindLicense(int licenseID)
        {

           int ApplicationID = -1;
           DateTime IssueDate = DateTime.UtcNow;
           int LicenseClass = -1;
           DateTime ExpDate = DateTime.UtcNow;
           int DriverID = -1;
            decimal PaidFees = 0;
           int CreatedByUserID = -1;
           string Notes = "";
           bool IsActive = true;
           byte IssueReason = 0;

            if (clsLicensesDAL.GetLicenseByID(licenseID, ref   ApplicationID, ref   DriverID, ref   LicenseClass, ref   IssueDate,
                                             ref   ExpDate, ref   Notes, ref   PaidFees, ref   IsActive, ref   IssueReason, ref   CreatedByUserID))
            {
                return new clsLicensesBLL(licenseID, ApplicationID, DriverID, LicenseClass, IssueDate,
               ExpDate, Notes, PaidFees, IsActive, (enIssueReason)IssueReason, CreatedByUserID);
            }

            else
                return null;


        }
        static public clsLicensesBLL FindLicenseByAppID(int ApplicationID)
        {

            int licenseID = -1;
            DateTime IssueDate = DateTime.UtcNow;
            int LicenseClass = -1;
            DateTime ExpDate = DateTime.UtcNow;
            int DriverID = -1;
            decimal PaidFees = 0;
            int CreatedByUserID = -1;
            string Notes = "";
            bool IsActive = true;
            byte IssueReason = 1;

            if (clsLicensesDAL.GetLicenseByAppID(ApplicationID, ref licenseID  , ref DriverID, ref LicenseClass, ref IssueDate,
                                             ref ExpDate, ref Notes, ref PaidFees, ref IsActive, ref IssueReason, ref CreatedByUserID))
            {
                return new clsLicensesBLL(licenseID, ApplicationID, DriverID, LicenseClass, IssueDate,
               ExpDate, Notes,PaidFees, IsActive, (enIssueReason)IssueReason, CreatedByUserID);
            }

            else
                return null;


        }

        private bool _AddLicense()
        {
            this.LicenseID = clsLicensesDAL.AddLicense(this.ApplicationID,this.DriverID,this.LicenseClass,this.IssueDate,this.ExpDate,this.Notes,this.PaidFees, this.IsActive
                , (byte)this.IssueReason, this.CreatedByUserID);
            return (this.LicenseID != -1);

        }
        private bool _UpdateLicense()
        {
            return clsLicensesDAL.UpdateLicense(this.LicenseID, this.ApplicationID, this.DriverID, this.LicenseClass, this.IssueDate, this.ExpDate, this.Notes,
                this.PaidFees, this.IsActive, (byte)this.IssueReason, this.CreatedByUserID);

        }

     

       
        public bool Save()
        {

            switch (_Mode)
            {
                case EnMode._AddNew:
                    {
                        if (_AddLicense())
                        {

                            _Mode = EnMode._Update;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                case EnMode._Update:
                    {
                        return _UpdateLicense();


                    }

            }

            return false;

        }
        public static DataTable GetLocalLicenses(int PersonID)
        {
            return clsLicensesDAL.GetAllLocalLicenseByPersonID(PersonID);
        }

        public static bool IsLicenseExistByPersonID(int PersonID, int LicenseClassID)
        {
            return (GetActiveLicenseIDByPersonID(PersonID, LicenseClassID) != -1);
        }

        public static int GetActiveLicenseIDByPersonID(int PersonID, int LicenseClassID)
        {

            return clsLicensesDAL.GetActiveLicenseIDByPersonID(PersonID, LicenseClassID);

        }
        public Boolean IsLicenseExpired()
        {

            return (this.ExpDate < DateTime.Now);

        }

        public bool DeactivateCurrentLicense()
        {
            return (clsLicensesDAL.DeactivateLicense(this.LicenseID));
        }

        public clsLicensesBLL RenewLicense(int createdByUserID, string notes)
        {
            int AppID = -1;
            clsApplicationBLL application = new clsApplicationBLL();
            application.ApplicantPersonID = this.DriverInfo.PersonID;
            application.ApplicationDate = DateTime.Now;
            application.LastStatusDate = DateTime.Now;
            application.ApplicationStatus = clsApplicationBLL.enApplicationStatus.Completed;
            application.ApplicationTypeID = (int)clsApplicationBLL.enApplicationType.RenewDrivingLicense;
            application.createdByUserID = createdByUserID;
            application.PaidFee = clsAppTypesBLL.FindApp(application.ApplicationTypeID)._Fee;

            if (!application.Save())
            {
                return null; 
             }

            clsLicensesBLL NewLicense = new clsLicensesBLL();
            NewLicense.CreatedByUserID = createdByUserID;
            NewLicense.ApplicationID = AppID;
            NewLicense.DriverID = this.DriverID;
            NewLicense.IssueDate = DateTime.Now;
            NewLicense.ExpDate = DateTime.Now.AddYears(this.LicenseInfo.validity);
            NewLicense.LicenseClass = this.LicenseClass;
            NewLicense.IsActive = true;
            NewLicense.IssueReason = clsLicensesBLL.enIssueReason.Renew;
            NewLicense.Notes = notes;

            if (!NewLicense.Save())
            {
                return null;
            }
            DeactivateCurrentLicense();

            return NewLicense;

        }

        public clsLicensesBLL ReplaceLicense(enIssueReason IssueReason ,int createdByUserID)
        {


            clsApplicationBLL application = new clsApplicationBLL();
            application.ApplicantPersonID = this.DriverInfo.PersonID;
            application.ApplicationDate = DateTime.Now;
            application.LastStatusDate = DateTime.Now;
            application.ApplicationStatus = clsApplicationBLL.enApplicationStatus.Completed;
            application.ApplicationTypeID = (IssueReason == enIssueReason.DamagedReplacement) ?
                (int)clsApplicationBLL.enApplicationType.ReplaceDamagedDrivingLicense :
                (int)clsApplicationBLL.enApplicationType.ReplaceLostDrivingLicense;

            application.createdByUserID = createdByUserID;
            application.PaidFee = clsAppTypesBLL.FindApp(application.ApplicationTypeID)._Fee;

            if (!application.Save())
            {
                return null;
            }

            clsLicensesBLL NewLicense = new clsLicensesBLL();
            NewLicense.CreatedByUserID = createdByUserID;
            NewLicense.ApplicationID = application.ApplicationID;
            NewLicense.DriverID = this.DriverID;
            NewLicense.IssueDate = DateTime.Now;
            NewLicense.ExpDate = this.ExpDate;
            NewLicense.LicenseClass = this.LicenseClass;
            NewLicense.IsActive = true;
            NewLicense.IssueReason = IssueReason;
            NewLicense.Notes = this.Notes;
            NewLicense.PaidFees = 0;

            if (!NewLicense.Save())
            {
                return null;
            }
            DeactivateCurrentLicense();

            return NewLicense;

        }


    }
}
