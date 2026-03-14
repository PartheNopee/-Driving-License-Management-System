using BLLPeople;
using DataAccessLayer;
using System;
using System.Data;


namespace clsBusinessLayerDVLD
{
    public class clsUserBLL
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int UserID {  get; set; }
        public string UserName { get; set; }
        public int PersonID { get; set; }
        public string Password { get; set; }

        public bool IsActive { get; set; }

        //public static clsUserBLL UserCred { get; set; }

        public static clsUserBLL getUserbyUsername (string UserName)
        {
            int PersonID = -1, UserID = -1;
            string Password = "";
            bool IsActive = false;

            if (clsUsersDAL.getuserByName(UserName, ref UserID, ref PersonID, ref Password, ref IsActive))
            {
                return new clsUserBLL(UserID, PersonID, UserName, Password, IsActive);


            }
            else  return null;
            


        }

        public static bool IsExist(string UserName)
        {

            return clsUsersDAL.IsUserExist(UserName);

        }
        public static clsUserBLL Find(int ID)
        {
            int PersonID = -1;
            string Password = "", UserName = "";
            bool IsActive = false;

            if (clsUsersDAL.GetUserByID(ID, ref UserName, ref PersonID, ref Password, ref IsActive))
            {
                return new clsUserBLL(ID, PersonID, UserName, Password, IsActive);

            }
            else return null;



        }

        public clsUserBLL()
        {
            this.UserID = -1;
            this.PersonID = -1;
            this.UserName = "";
            this.Password = "";
            this.IsActive = false;

            Mode = enMode.AddNew;



        }

        public static bool DeleteUser(int _User)
        {

            return clsUsersDAL.DeleteUser(_User);

            
        }
        public static bool Login(string username, string password)
        {

            return clsUsersDAL.LoginUser(username, password);


        }

        private clsUserBLL( int userID, int personID, string userName,  string password, bool isActive)
        {
            UserID = userID;
            UserName = userName;
            PersonID = personID;
            Password = password;
            IsActive = isActive;
            Mode = enMode.Update;

        }

        private bool _AddNewUser()
        {
            this.UserID = clsUsersDAL.AddUser(PersonID, UserName, Password,IsActive);

            return (this.UserID != -1);

        }

        public  bool _UpdateUser( )
        {


            return (clsUsersDAL.UpdateUser(this.UserID, this.PersonID, this.UserName, this.Password, this.IsActive));
            
 
            
             

        }

        public bool _Save()
        {
            switch(Mode)
            { 
            case enMode.AddNew:
                if (_AddNewUser())
                {

                    Mode = enMode.Update;
                    return true;
                }
                else
                {
                    return false;
                }

            case enMode.Update:

                return _UpdateUser();

            }
            return false;
        }

        public static bool IsUserRelated(int personID)
        {
            return clsUsersDAL.IsPersonRelated(personID);
        }
         
        public static DataTable GetAllUser()
        {

            return clsUsersDAL.GetUsers();


        }



    }
}
