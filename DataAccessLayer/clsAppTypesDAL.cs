using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsAppTypesDAL
    {


        public static bool GetAppByID(int ApplicationTypeID, ref string ApplicationTypeTitle, ref float ApplicationFees)
        {

            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "SELECT * FROM ApplicationTypes WHERE ApplicationTypeID = @ApplicationTypeID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found
                    isFound = true;

                    ApplicationTypeTitle = (string)reader["ApplicationTypeTitle"];
                    ApplicationFees = Convert.ToSingle(reader["ApplicationFees"]);





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
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static DataTable GetAllApps()
        {
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "select * from ApplicationTypes;" ;
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
            catch (Exception ex)
            {
            }

            finally
            {
                conn.Close();
            }
            return dt;



        }

        static public bool updateAppType(int ID, string AppTitle, float Fee)
        {
            int RowAffected =  0;
            SqlConnection conn = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "update ApplicationTypes Set ApplicationTypeTitle = @Apptite , ApplicationFees = @Fee where ApplicationTypeID = @ID;";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@Apptite",AppTitle);
            cmd.Parameters.AddWithValue("@Fee", Fee);
            cmd.Parameters.AddWithValue("@ID", ID);


            try
            {
                conn.Open();

                RowAffected = cmd.ExecuteNonQuery();








            }
            catch (Exception ex) {
            }

            
            finally
            {
                conn.Close();
            }
           return (RowAffected > 0);

             
        }


    }
}
