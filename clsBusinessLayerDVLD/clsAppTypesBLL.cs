using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace clsBusinessLayerDVLD
{
    public class clsAppTypesBLL
    {
        public int _ID {  get; set; }
        public string _Title { get; set; }
        public float _Fee { get; set; }

        private clsAppTypesBLL(int ID , string Title , float Fee)
        {

             this._ID = ID ;
             this._Title = Title ;
             this._Fee = Fee ;
        
         
        
        
        }
            
         static public clsAppTypesBLL FindApp(int ID)
        {
            string AppTitl = "";
            float AppFee = 0;

            if (clsAppTypesDAL.GetAppByID(ID, ref AppTitl, ref AppFee))
            {
                return new clsAppTypesBLL(ID,  AppTitl, AppFee);
            }

            else return null;


        }
            
          public bool updateApp()
        {

            return clsAppTypesDAL.updateAppType(this._ID, this._Title,this._Fee);
            

        }
            
            



        public static DataTable getAllApp()
        {
            return clsAppTypesDAL.GetAllApps();
        }




    }
}
