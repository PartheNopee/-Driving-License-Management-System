using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;

namespace clsBusinessLayerDVLD
{
    public class clsClassLicenseBLL
    {


         public int LicenseClassID { get; set; }
        public string LicenseName { get; set; }
        public string LicenseDescription { get; set; }
        public byte MinimumAge {  get; set; }
        public byte validity { get; set; }
        public decimal LicenceFee {  get; set; }

        
        public clsClassLicenseBLL( )
        {
            this.LicenseClassID = -1;
            this.LicenseName = "";
            this.MinimumAge = 0;
            this.validity = 0;
            this.LicenseDescription = "";
            this.LicenceFee = 0;


        }
        private clsClassLicenseBLL(int licenseClassID, string licenseName, string licenseDescription, byte minimumAge, byte Validity, decimal licenceFee)
        {
            this.LicenseClassID = licenseClassID;
            this.LicenseName = licenseName;
            this.MinimumAge = minimumAge;   
            this.validity = Validity;
            this.LicenseDescription = licenseDescription;
            this.LicenceFee = licenceFee;

        }

        static public DataTable GetAllClasses()
        {

           return clsClassLicenseDAL.GetAllClasses();
           

        }

        static public clsClassLicenseBLL Find(int ID)
        {
            string licenseName = "";
            string licenseDescrition = "";
            byte minimumAge = 0;
            byte Validity = 0;
            decimal licenseFee = 0;

            if (clsClassLicenseDAL.GetLicenseClassByID(ID, ref licenseName, ref licenseDescrition, ref minimumAge, ref Validity, ref licenseFee))
            {
                return new clsClassLicenseBLL(ID, licenseName, licenseDescrition, minimumAge, Validity, licenseFee);

            }
            else
                return null;


        }


    }
}
