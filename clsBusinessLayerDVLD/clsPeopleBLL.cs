using DataAccessLayer;
using System;
using System.Data;

namespace BLLPeople
{
    public class clsBLLPeople
    {
        private enum enMode
        {
            _Add = 0, _Update = 1
        }
        enMode Mode = enMode._Add;

        public int ID { get; set;}
        public string NationalID { get; set; }

        public string Name { get; set; }
        public string firstName { get; set;}

        public string SecName { get; set; }
        public string ThirdName { get; set; }
        public string lastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public byte Gendor {  get; set; }
        public string Address { get; set; }
        public DateTime DOB { get; set; }
        public int Country { get; set; }
        public string FullName
        {
            get { return firstName + " " + SecName + " " + ThirdName + " " + lastName; }

        }
        public string ImagePath { get; set; }

       
        private clsBLLPeople(int ID,string NationalNo, string FirstName,
            string SecondName, string ThirdName, string LastName, DateTime DateOfBirth,
            byte Gendor, string Address, string Phone, string Email, int Country,
            string ImagePath)
        {
            this.ID = ID;
            this.NationalID = NationalNo;
            this.firstName = FirstName;
            this.SecName = SecondName; 
            this.ThirdName = ThirdName;
            this.lastName = LastName;
            this.Phone = Phone;
            this.Email = Email;
            this.Gendor = Gendor;
            this.Address = Address;
            this.DOB = DateOfBirth;
            this.Country = Country;
            this.ImagePath = ImagePath;

            Mode = enMode._Update;

             

        }
        public clsBLLPeople() 
        {
            this.ID = -1;
            this.NationalID = "";
            this.firstName = "";
            this.SecName = string.Empty;
            this.ThirdName = string.Empty;
            this.lastName = "";
            this.Phone = string.Empty;
            this.Email = string.Empty;
            this.Gendor = 0;
            this.Address = string.Empty;
            this.DOB = DateTime.MinValue;
            this.Country = 0;
            this.ImagePath = string.Empty;

            Mode = enMode._Add;



        }

        private bool _AddPerson()
        {
            this.ID = ClsPeopleDAL.AddPerson(this.NationalID, this.firstName, this.SecName, this.ThirdName, this.lastName, this.DOB, this.Gendor, this.Address,
                this.Phone, this.Email, this.Country, this.ImagePath);

                return (this.ID != -1);
        }

        private bool _UpdatePerson()
        {
            return  ClsPeopleDAL.UpdatePerson(this.ID, this.NationalID, this.firstName, this.SecName, this.ThirdName, this.lastName, this.DOB, this.Gendor, this.Address,
                this.Phone, this.Email, this.Country, this.ImagePath);


        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode._Add:
                    if (_AddPerson())
                    {

                        Mode = enMode._Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode._Update:

                    return _UpdatePerson();

            }

            return false;
        }

        public  static clsBLLPeople Find(int ID)
        {
            string NationalNo = "", FirstName = "",
             SecondName = "", ThirdName = "", LastName = "", Address = "" , Phone = "",Email = "";
            DateTime DateOfBirth = DateTime.MinValue;
            byte Gendor = 0;
            int country = 0; 
            string ImagePath = " ";


            if (ClsPeopleDAL.GetPersonByID(ID,ref NationalNo,  ref FirstName,
            ref   SecondName,  ref ThirdName, ref   LastName, ref   DateOfBirth,
            ref   Gendor, ref   Address, ref   Phone, ref Email, ref    country,
              ref ImagePath))
            
                return new clsBLLPeople(ID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor,
                    Address, Phone, Email, country, ImagePath);


            else return null;


        }

        public static clsBLLPeople Find(string NationalNo)
        {
            int ID = -1;
                string FirstName = "",
             SecondName = "", ThirdName = "", LastName = "", Address = "", Phone = "", Email = "";
            DateTime DateOfBirth = DateTime.MinValue;
            byte Gendor = 0;
            int country = 0;
            string ImagePath = " ";


            if (ClsPeopleDAL.GetPersonByNationalID(NationalNo, ref ID, ref FirstName,
            ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth,
            ref Gendor, ref Address, ref Phone, ref Email, ref country,
              ref ImagePath))

                return new clsBLLPeople(ID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor,
                    Address, Phone, Email, country, ImagePath);


            else return null;


        }


        static public DataTable GetAllPeople()
        {
            return ClsPeopleDAL.GetAllPersons();
        }

       static public bool DeletePersonbyID(int ID)
        {
            return ClsPeopleDAL.DeletePerson(ID);

        }

        


    }
}
