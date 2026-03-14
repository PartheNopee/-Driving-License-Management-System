using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsClassLicenseDAL
    {
        static public DataTable GetAllClasses()
        {
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "SELECT * from LicenseClasses;";

            SqlCommand cmd = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);

                }
                reader.Close();




            }
            catch
            {



            }
            finally
            {


                conn.Close();
            }
            return dt;

        }
        public static bool GetLicenseClassByID(int ID, ref string ClassName, ref string ClassDescription, ref byte MinimumAllowedAge, ref byte DefaultValidityLength , ref decimal ClassFees)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @"SELECT [ClassName]  ,[ClassDescription] ,[MinimumAllowedAge] ,[DefaultValidityLength] ,[ClassFees]
                            FROM LicenseClasses  where LicenseClassID = @LicenseClassID ;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseClassID", ID);
            // convert fee single
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found
                    isFound = true;

                    ClassName = (string)reader["ClassName"];
                    ClassDescription = (string)reader["ClassDescription"];
                    MinimumAllowedAge = (byte)reader["MinimumAllowedAge"];
                    DefaultValidityLength = (byte)reader["DefaultValidityLength"];
                   ClassFees = (decimal)reader["ClassFees"];
 


                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();


            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }



    }
}
