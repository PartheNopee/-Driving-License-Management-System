using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLLPeople;
using DataAccessLayer;

namespace clsBusinessLayerDVLD
{
    public class clsDriverBLL 
    {
        enum EnMode {_AddDriver=0, _UpdateDriver = 1}
        EnMode _ModeDriver = EnMode._AddDriver;

        public clsBLLPeople PersonInfo;
        public int DriverID {  get; set; }
        public int PersonID {  get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedDate { get; set; }

 
        private clsDriverBLL( int driverID, int personID, int createdByUserID, DateTime createdDate)
        {
            DriverID = driverID;
            PersonID = personID;
            CreatedByUserID = createdByUserID;
            CreatedDate = createdDate;
            this.PersonInfo = clsBLLPeople.Find(personID);
            _ModeDriver = EnMode._UpdateDriver;
        }

        public clsDriverBLL()
        {
            this.DriverID = -1;
            this.PersonID = -1;
            this.CreatedByUserID = -1;
            this.CreatedDate = DateTime.UtcNow;

            _ModeDriver = EnMode._AddDriver;



        }

        public static clsDriverBLL GetDriverByID(int driverID)
        {

            int personID =-1, createdByUserID =-1;
            DateTime createdDate = DateTime.UtcNow;

            if (clsDriversDAL.GetDriverByID(driverID,ref personID, ref createdByUserID, ref createdDate))
            {
                return new clsDriverBLL(driverID, personID, createdByUserID, createdDate);
            }
            else 
                return null;



        }
        public static clsDriverBLL GetDriverByPersonID(int personID)
        {

            int driverID = -1, createdByUserID = -1;
            DateTime createdDate = DateTime.UtcNow;

            if (clsDriversDAL.GetDriverByPersonID(personID, ref driverID, ref createdByUserID, ref createdDate))
            {
                return new clsDriverBLL(driverID, personID, createdByUserID, createdDate);
            }
            else
                return null;



        }

        private bool _AddDriver()
        {
            this.DriverID = clsDriversDAL.AddDriver(this.PersonID, this.CreatedByUserID, this.CreatedDate);
            return(this.DriverID !=-1);

        }
        private bool _UpdateDriver()
        {
            return clsDriversDAL.UpdateDriver(this.DriverID, this.PersonID, this.CreatedByUserID, this.CreatedDate);

        }

        public bool SaveDriver()
        {

            switch(_ModeDriver)
            {
                    case EnMode._AddDriver:
                    {
                        if (_AddDriver())
                        {

                            _ModeDriver = EnMode._UpdateDriver;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                   case EnMode._UpdateDriver:
                   {
                        return _UpdateDriver();


                   }

            }
                 
            return false;

        }

        static public DataTable  GetAllDrivers()
        {

            return clsDriversDAL.GetAllDrivers();

        }

    }
}
