using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
using static clsBusinessLayerDVLD.clsLicensesBLL;

namespace clsBusinessLayerDVLD
{
    public class clsIntenationalLicenseBLL:clsApplicationBLL
    {
        enum EnMode { _AddNew = 0, _Update = 1 }
        EnMode _enMode = EnMode._AddNew;

        public int InternationalLicenseID { get; set; }

        public clsApplicationBLL Application { get; set; }
        public int LocalLicenseIDIssues { get; set; }

        public DateTime IssueDate { get; set; }
        public DateTime ExpDate { get; set; }

        public clsDriverBLL DriverInfo { get; set; }
        public int DriverID { get; set; }
        public bool IsActive { get; set; }

        public clsIntenationalLicenseBLL()
        {
            this.InternationalLicenseID = -1;
            this.IssueDate = DateTime.UtcNow;
            this.LocalLicenseIDIssues = -1;
            this.DriverID = -1;
            this.IsActive = true;
            this.ExpDate = DateTime.UtcNow;
            this.Application = new clsApplicationBLL();

            _enMode = EnMode._AddNew;

        }

        private clsIntenationalLicenseBLL(int InternationalLicenseID, int ApplicationID, int DriverID,
            int LocalLicenseIDIssues, DateTime IssueDate, DateTime ExpirationDate, bool IsActive,
            int CreatedByUserID , int ApplicantPersonID,
            DateTime ApplicationDate, int ApplicationTypeID,
             enApplicationStatus ApplicationStatus, DateTime LastStatusDate,
             float PaidFees)
        {
            this.InternationalLicenseID = InternationalLicenseID;
            this.IssueDate = IssueDate;
            this.LocalLicenseIDIssues = LocalLicenseIDIssues;
            this.DriverID = DriverID;
            this.IsActive = IsActive;
            this.ExpDate = ExpirationDate;

            //Composition..
            this.DriverInfo = clsDriverBLL.GetDriverByID(this.DriverID);

            base.ApplicationID = ApplicationID;
            base.ApplicantPersonID = ApplicantPersonID;
            base.ApplicationDate = ApplicationDate;
            base.ApplicationTypeID = (int)ApplicationTypeID;
            base.ApplicationStatus = ApplicationStatus;
            base.LastStatusDate = LastStatusDate;
            base.PaidFee = PaidFees;
            base.createdByUserID = CreatedByUserID;
            _enMode = EnMode._Update;

        }

        private bool _AddInternationalLcense()
        {
            this.InternationalLicenseID = clsInternationalDriverLicensesAppDAL.AddinternationalLicense(this.ApplicationID, this.DriverID, this.LocalLicenseIDIssues
                , this.IssueDate, this.ExpDate, this.Application.createdByUserID);

            return (this.InternationalLicenseID != -1);

        }
        private bool _UpdateInternationalLicense()
        {
            return clsInternationalDriverLicensesAppDAL.UpdateInternationalLicense(this.InternationalLicenseID, this.ApplicationID, this.DriverID, this.LocalLicenseIDIssues
                , this.IssueDate, this.ExpDate,this.IsActive, this.Application.createdByUserID);
        }

        private bool _PrepareApplicationForLicense()
        {


            Application.ApplicationTypeID = (int)clsApplicationBLL.enApplicationType.NewInternationalLicense;
            Application.ApplicationDate = DateTime.Now;

            Application.PaidFee = clsAppTypesBLL.FindApp(Application.ApplicationTypeID)._Fee;
            Application.ApplicationStatus = enApplicationStatus.Completed;
            Application.LastStatusDate = DateTime.Now;

            Application.Mode = (clsApplicationBLL.EnMode)Mode;
            if (Application.Save())
            {
                this.ApplicationID = Application.ApplicationID;
                MessageBox.Show("it worked bitch ass retard");
                return true;    
            }
            
         
            return false ;

        }

        public override bool Save()
        {
            if (!_PrepareApplicationForLicense())
                return false;

            switch (_enMode)
            {
                case EnMode._AddNew:
                    if (_AddInternationalLcense())
                    {
                        _enMode = EnMode._Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case EnMode._Update:
                    return _UpdateInternationalLicense();




            }
            return false;

        }
        static public clsIntenationalLicenseBLL Find(int InternationalLicenseID)
        {


            int ApplicationID = -1;
            int DriverID = -1;
            int IssuedUsingLocalLicenseID = -1;
            DateTime IssueDate = DateTime.MinValue;
            DateTime ExpirationDate = DateTime.MinValue;
            bool IsActive = true;
            int CreatedByUserID = -1;

            bool isFound = clsInternationalDriverLicensesAppDAL.GetInternationalLicenseByID( InternationalLicenseID,
                ref  ApplicationID, ref   DriverID,
                 ref   IssuedUsingLocalLicenseID, ref   IssueDate, ref   ExpirationDate, ref   IsActive,
                     ref   CreatedByUserID);

            if (isFound)
            {

                clsApplicationBLL Application = clsApplicationBLL.FindApp(ApplicationID);

                return new clsIntenationalLicenseBLL(
                   InternationalLicenseID, Application.ApplicationID,DriverID,IssuedUsingLocalLicenseID,IssueDate,ExpirationDate,IsActive,CreatedByUserID,
                   Application.ApplicantPersonID,
                                    Application.ApplicationDate, Application.ApplicationTypeID,
                                   (enApplicationStatus)Application.ApplicationStatus, Application.LastStatusDate,
                                    Application.PaidFee);


            }
            return null;


        }

        static public int GetActiveInternationalLicenseIDByDriverID( int driverID )
        {

            return clsInternationalDriverLicensesAppDAL.GetActiveInternationalLicenseIDByDriverID(driverID);

        }
        static public DataTable GetAllInternationalLicenseApplications()
        {

            return clsInternationalDriverLicensesAppDAL.GetAllInternationalApplications();


        }
        static public DataTable GetAllinternationlLicenseWithPersonID( int personID )
        {
            return clsInternationalDriverLicensesAppDAL.GetAllInternationalLicensesByPersonID(personID);

        }

    }
}
