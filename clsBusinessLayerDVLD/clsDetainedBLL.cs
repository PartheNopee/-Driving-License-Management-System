using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace clsBusinessLayerDVLD
{
    public  class clsDetainedBLL
    {
        enum EnMode { _AddNew = 0, _Update = 1 }
        EnMode _Mode = EnMode._AddNew;


        public int LicenseID { get; set; }


        public int  DetainID { get; set; }

        public DateTime DetainDate { get; set; }
        public DateTime ReleaseDate { get; set; }

         public int ReleasedByUserID { get; set; }
        public float FineFees { get; set; }
        public bool IsReleased { get; set; }
        public int ReleaseApplicationID { get; set; }
        public int CreatedByUserID { get; set; }


        public clsDetainedBLL()
        {
            this.DetainID = -1;
            this.LicenseID = -1;
            this.DetainDate = DateTime.Now;
            this.FineFees = 0;
            this.ReleaseDate = DateTime.Now;
            this.ReleaseApplicationID = -1;
            this.CreatedByUserID = -1;
            this.ReleasedByUserID = -1;
            this.IsReleased = false;

            _Mode = EnMode._AddNew;



        }


        private clsDetainedBLL(int DetainID, int LicenseID, DateTime DetainDate,
           float FineFees, int CreatedByUserID,bool IsReleased, DateTime ReleaseDate
           , int ReleasedByUserID, int ReleaseApplicationID)
        {
            this.DetainID = DetainID;
            this.LicenseID = LicenseID;
            this.DetainDate = DetainDate;
            this.FineFees = FineFees;
            this.ReleaseDate = ReleaseDate;
            this.ReleaseApplicationID = ReleaseApplicationID;
            this.CreatedByUserID = CreatedByUserID;
            this.ReleasedByUserID = ReleasedByUserID;
            this.IsReleased = IsReleased;
             _Mode = EnMode._Update;



        }

       static public clsDetainedBLL FindDetainedLicenseByDetainID(int DetainID)

        {
            int LicenseID = -1;
            DateTime DetainDate = DateTime.Now;
           float FineFees = 0;
            int CreatedByUserID = -1;
            bool IsReleased = false;
            DateTime ReleaseDate = DateTime.Now;
            int ReleasedByUserID = -1;
            int ReleaseApplicationID = -1;

            if (clsDetainedDAL.GetDetainedLicenseByID(DetainID, ref LicenseID, ref DetainDate, ref FineFees, ref CreatedByUserID,ref IsReleased, ref ReleaseDate,
                ref ReleaseApplicationID,ref ReleasedByUserID))
            {
                return new clsDetainedBLL(DetainID,   LicenseID,   DetainDate,   FineFees,   CreatedByUserID, IsReleased, ReleaseDate,
                ReleaseApplicationID,   ReleasedByUserID);
            }

            else 
                return null;

        }
        static public clsDetainedBLL FindDetainedLicenseByLicenseID(int LicenseID )

        {
            int DetainID = -1;
            DateTime DetainDate = DateTime.Now;
            float FineFees = 0;
            int CreatedByUserID = -1;
            bool IsReleased = false;
            DateTime ReleaseDate = DateTime.Now;
            int ReleasedByUserID = -1;
            int ReleaseApplicationID = -1;

            if (clsDetainedDAL.GetDetainedLicenseByLicenseID(LicenseID,ref DetainID,  ref DetainDate, ref FineFees, ref CreatedByUserID, ref IsReleased, ref ReleaseDate,
                ref ReleaseApplicationID, ref ReleasedByUserID))
            {
                return new clsDetainedBLL(DetainID, LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate,
                ReleaseApplicationID, ReleasedByUserID);
            }

            else
                return null;

        }
        private bool _AddDetain()
        {
            this.DetainID = clsDetainedDAL.AddDetainedLicense(this.LicenseID, this.DetainDate, this.FineFees, this.CreatedByUserID) ;
            return (this.DetainID != -1);

        }
        private bool _UpdateDetain()
        {
            return clsDetainedDAL.UpdateDetainLicense(this.DetainID, this.LicenseID, this.DetainDate, this.FineFees, this.CreatedByUserID, 
                this.IsReleased, this.ReleaseDate, this.ReleasedByUserID, this.ReleaseApplicationID);


        }

        public bool Save()
        {
            switch(_Mode)
            {

                case EnMode._AddNew:
                    if (_AddDetain())
                    {
                        _Mode = EnMode._Update;
                        return true;
                    }
                    else
                        return false;
                    

                case EnMode._Update:
                    return _UpdateDetain();



            }

            return false;
        }
        static public bool IsDetained(int LicenseID)
        {
            return clsDetainedDAL.IsLicenseDetained(LicenseID);


        }
        
        public bool ReleaseDetainedLicense(int ReleasedByUserID, int ReleaseApplicationID)
        {
            return clsDetainedDAL.ReleaseDetainedLicense(this.DetainID,
                   ReleasedByUserID, ReleaseApplicationID);
        }
        static public DataTable GetAllDetainedLicenses()
        {
            return clsDetainedDAL. GetAllDetainedLicense();
        }

    }
}
