using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DataAccessLayer
{
    public class clsDriversDAL
    {
        public static int AddDriver(int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {
            int DriverID = -1;


            string Query = @"INSERT INTO [dbo].[Drivers]
                              ([PersonID],
                              [CreatedByUserID],
                              [CreatedDate]
                              )
                                VALUES
                                      (@PersonID,
                             @CreatedByUserID, 
                             @CreatedDate
                             )


               SELECT SCOPE_IDENTITY(); ";


            using (SqlConnection Connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                Connection.Open();
                using (SqlCommand cmd = new SqlCommand(Query, Connection))
                {
                    cmd.Parameters.AddWithValue("@PersonID", PersonID);
                    cmd.Parameters.AddWithValue("@CreatedDate", CreatedDate);
                    
                    cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                    

                    try
                    {
                        object result = cmd.ExecuteScalar();


                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            DriverID = insertedID;
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("This is the CATCHED error : " + ex.ToString());
                    }



                }






            }


            return DriverID;
        }


        public static bool UpdateDriver(int DriverID,int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {
            int AffectedRows = -1;


            string Query = @"UPDATE [dbo].[Drivers]
                             SET [PersonID] = @PersonID, 
                                [CreatedByUserID] = @CreatedByUserID, 
                                [CreatedDate] = @CreatedDate,  
                                
  


                            WHERE DriverID = @DriverID;";



            using (SqlConnection Connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                Connection.Open();
                using (SqlCommand cmd = new SqlCommand(Query, Connection))
                {
                     cmd.Parameters.AddWithValue("@DriverID", DriverID);
                    cmd.Parameters.AddWithValue("@PersonID", PersonID);
                    cmd.Parameters.AddWithValue("@CreatedDate", CreatedDate);
                    
                    cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);



                    try
                    {
                        AffectedRows = cmd.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("This is the CATCHED error : " + ex.ToString());
                    }



                }






            }


            return (AffectedRows > 0);
        }

        public static bool GetDriverByID(int DriverID, ref int PersonID, ref int CreatedByUserID, ref DateTime CreatedDate)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsConnectionString.ConnectionString);
            string query = @"Select * from Drivers where DriverID = @DriverID ;";

            SqlCommand cmd = new SqlCommand(query, Connection);

            cmd.Parameters.AddWithValue("@DriverID", DriverID);



            try
            {

                Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    PersonID = (int)reader["PersonID"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
 
                    CreatedDate = (DateTime)reader["CreatedDate"];
                    






                }
                reader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(" the Catched error" + ex.Message);
            }
            finally
            {
                Connection.Close();
            }

            return IsFound;

        }

        public static bool GetDriverByPersonID(int PersonID, ref int DriverID, ref int CreatedByUserID, ref DateTime CreatedDate)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsConnectionString.ConnectionString);
            string query = @"Select * from Drivers where PersonID = @PersonID ;";

            SqlCommand cmd = new SqlCommand(query, Connection);

            cmd.Parameters.AddWithValue("@PersonID", PersonID);



            try
            {

                Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    DriverID = (int)reader["DriverID"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];

                    CreatedDate = (DateTime)reader["CreatedDate"];







                }
                reader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(" the Catched error" + ex.Message);
            }
            finally
            {
                Connection.Close();
            }

            return IsFound;

        }
        static public DataTable GetAllDrivers()
        {
            DataTable Dt = new DataTable();

            string Query = " SELECT \r\n    D.DriverID,\r\n    D.PersonID,\r\n    P.NationalNo,\r\n    P.FirstName + ' ' + P.SecondName + ' ' + P.ThirdName + ' ' + P.LastName AS FullName,\r\n    D.CreatedDate,\r\n    COUNT(L.LicenseID) AS ActiveLicenses\r\nFROM Drivers D\r\nINNER JOIN People P ON D.PersonID = P.PersonID\r\nLEFT JOIN Licenses L \r\n    ON D.DriverID = L.DriverID \r\n    AND L.IsActive = 1\r\n\tGROUP BY\r\n    D.DriverID,\r\n    D.PersonID,\r\n    P.NationalNo,\r\n    P.FirstName,\r\n    P.SecondName,\r\n    P.ThirdName,\r\n    P.LastName,\r\n    D.CreatedDate;";

            using (SqlConnection Connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                Connection.Open();
                using (SqlCommand cmd = new SqlCommand(Query, Connection))
                {
                     


                    try
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)

                        {
                            Dt.Load(reader);
                        }

                        reader.Close();


                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("This is the CATCHED error : " + ex.ToString());
                    }



                }


            }




            return Dt;
        }
    }

}

