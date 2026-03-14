using System;
 using System.Data;
using DataAccessLayer;

namespace clsBusinessLayerDVLD
{
    public class clsCountryBLL
    {
        public int ID { set; get; }
        public string CountryName { set; get; }

        private clsCountryBLL(int ID, string CountryName)

        {
            this.ID =   ID;
            this.CountryName = CountryName;



        }
        
        public static clsCountryBLL Find(int ID)
        {

            string CountryName = "";


 
            if (clsCountry.GetCountryInfoByID(ID, ref CountryName ))
            
                return   new clsCountryBLL(ID,  CountryName);
             
             else return null;

        }

        public static DataTable GetCountries()
        {

            return clsCountry.GetAllCountries();


        }


    }


}
