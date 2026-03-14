using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;


namespace clsBusinessLayerDVLD
{
    public class clstestTypesBLL
    {
         public string TestTitle {  get; set; }
        public string TestDescription { get; set; }
        public decimal FeesTest {  get; set; }

        public enum enTestType { visionTest = 1 , writtenTest =2, StreetTest = 3};

        public  enTestType ID { get; set; }

        private clstestTypesBLL(clstestTypesBLL.enTestType ID , string Title,string Desc,decimal Fee)
        {
            this.ID = ID;
            this.TestTitle = Title;
            this.TestDescription = Desc;
            this.FeesTest = Fee;

         
        }

        public bool UpdateTest()
        {
            return clsTestTyDAL.updateTestType((int)this.ID,this.TestTitle,this.TestDescription,this.FeesTest);

        }

        static public clstestTypesBLL FindTest( clstestTypesBLL.enTestType ID)
        {
            string Title = "", Desc="";
            decimal Fee = 0;

            if (clsTestTyDAL.GetTestByID((int)ID, ref Title ,ref Desc,ref Fee ))
            {
               return new clstestTypesBLL(ID, Title, Desc, Fee);   


            }
            else return null;

        }

        static public DataTable GetAllTest()
        {
            return clsTestTyDAL.GetAllTestTypes();
        }



    }
}
