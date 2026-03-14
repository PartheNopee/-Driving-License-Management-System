using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsDetainedDAL
    {
        static public DataTable GetAllDetainedLicense()
        {
            DataTable dt = new DataTable();


            string Query = @"select * from DetainedLicenses_View order by IsReleased, DetainID ";


            using (SqlConnection Connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(Query, Connection);

                Connection.Open();
                try
                {

                    SqlDataReader Reader = cmd.ExecuteReader();

                    if (Reader.HasRows)
                    {
                        dt.Load(Reader);
                    }

                    Reader.Close();

                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.ToString());


                }
            }


            return dt;

        }
        public static int AddDetainedLicense(int LicenseID, DateTime DetainDate ,
           float FineFees , int CreatedByUserID)
        {
            int DetainedLicenceID = -1;


            string Query = @"INSERT INTO [dbo].[DetainedLicenses]
                              ([LicenseID]
                              ,[DetainDate]
                              ,[FineFees]
                              ,[CreatedByUserID]
                              ,[IsReleased]
                              ,[ReleaseDate]
                              ,[ReleasedByUserID]
                              ,[ReleaseApplicationID])
                                VALUES
                                      (@LicenseID,
                           
                             @DetainDate, 
                             @FineFees,  
                             @CreatedByUserID ,
                             0, 
                             null,  
                             null,  
                             null)

               SELECT SCOPE_IDENTITY(); ";


            using (SqlConnection Connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                Connection.Open();
                using (SqlCommand cmd = new SqlCommand(Query, Connection))
                {
                    cmd.Parameters.AddWithValue("@LicenseID", LicenseID);
                    cmd.Parameters.AddWithValue("@DetainDate", DetainDate);
                    cmd.Parameters.AddWithValue("@FineFees", FineFees);
                    cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                    


                    try
                    {
                        object result = cmd.ExecuteScalar();


                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            DetainedLicenceID = insertedID;
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("This is the CATCHED error : " + ex.ToString());
                    }



                }






            }


            return DetainedLicenceID;
        }

        public static bool UpdateDetainLicense(int DetainID, int LicenseID, DateTime DetainDate,
           float FineFees, int CreatedByUserID,bool IsReleased, DateTime ReleaseDate
           , int ReleasedByUserID, int ReleaseApplicationID)
        {
            int AffectedRows = 0;


            string Query = @"UPDATE [dbo].[DetainedLicenses]
                             SET [LicenseID] = @LicenseID, 
                               
                                [DetainDate] = @DetainDate,  
                                [FineFees] = @FineFees,  
                                [CreatedByUserID] = @CreatedByUserID, 
                                [IsReleased] = @IsReleased,  
                                [ReleaseDate] = @ReleaseDate,  
                                [ReleasedByUserID] = @ReleasedByUserID, 
                                [ReleaseApplicationID] = @ReleaseApplicationID,  
  


                            WHERE DetainID = @DetainID;";

            using (SqlConnection Connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(Query, Connection))
                {
                    Connection.Open();

                    cmd.Parameters.AddWithValue("@DetainID", DetainID);

                    cmd.Parameters.AddWithValue("@LicenseID", LicenseID);
                    cmd.Parameters.AddWithValue("@DetainDate", DetainDate);
                    cmd.Parameters.AddWithValue("@FineFees",  (decimal)FineFees);
                    cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                    cmd.Parameters.AddWithValue("@IsReleased", IsReleased);
                    cmd.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
                    cmd.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
                    cmd.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);



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


        //in the bll the first 5 fields will be filled from the obj the other 3 after creating the application
        public static bool ReleaseDetainedLicense(int DetainID, int ReleasedByUserID, int ReleaseApplicationID)
        {
            int AffectedRows = 0;

            // We set IsReleased to 1 and use the current system time for ReleaseDate
            string Query = @"UPDATE dbo.DetainedLicenses
                              SET IsReleased = 1, 
                              ReleaseDate = @ReleaseDate, 
                              ReleaseApplicationID = @ReleaseApplicationID   
                              WHERE DetainID=@DetainID;";

            using (SqlConnection Connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(Query, Connection))
                {
                    // Explicitly defining types is best practice here
                    cmd.Parameters.AddWithValue("@DetainID", DetainID);
                    cmd.Parameters.AddWithValue("@ReleaseDate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
                    cmd.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);

                    try
                    {
                        Connection.Open();
                        AffectedRows = cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        // Log the error (consider using a logging framework instead of Console)
                        Console.WriteLine("Database Error: " + ex.Message);
                    }
                }
            }

            return (AffectedRows > 0);
        }




        public static bool GetDetainedLicenseByID(int DetainID, ref int  LicenseID, ref DateTime DetainDate,
          ref float FineFees, ref int CreatedByUserID, ref bool IsReleased, ref DateTime ReleaseDate
          , ref int ReleasedByUserID, ref int ReleaseApplicationID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsConnectionString.ConnectionString);
            string query = @"Select * from DetainedLicenses where DetainID = @DetainID ;";

            SqlCommand cmd = new SqlCommand(query, Connection);

            cmd.Parameters.AddWithValue("@DetainID", DetainID);



            try
            {

                Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    LicenseID = (int)reader["ApplicationID"];
                    DetainDate = (DateTime)reader["DetainDate"];
                    FineFees = (float)reader["FineFees"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    ReleaseDate = (DateTime)reader["ReleaseDate"];

                    IsReleased = (bool)reader["IsReleased"];
                    ReleaseApplicationID = (int)reader["IssueReason"];

                    ReleasedByUserID = (int)reader["ReleasedByUserID"];
                   






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
        public static bool IsLicenseDetained(int LicenseID)
        {
            bool IsFound = false;


            string Query = @"select * from DetainedLicenses where LicenseID = @LicenseID and IsReleased = 0;";

            using (SqlConnection Connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                Connection.Open();
                using (SqlCommand cmd = new SqlCommand(Query, Connection))
                {
                    cmd.Parameters.AddWithValue("@LicenseID", LicenseID);

                    try
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        IsFound = reader.HasRows;

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("This is the CATCHED error : " + ex.ToString());
                    }



                }


            }

            return IsFound;
        }
        public static bool GetDetainedLicenseByLicenseID(int LicenseID,ref int   DetainID, ref DateTime DetainDate,
          ref float FineFees, ref int CreatedByUserID, ref bool IsReleased, ref DateTime ReleaseDate
          , ref int ReleasedByUserID, ref int ReleaseApplicationID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsConnectionString.ConnectionString);
            string query = @"Select * from DetainedLicenses where LicenseID = @LicenseID ;";

            SqlCommand cmd = new SqlCommand(query, Connection);

            cmd.Parameters.AddWithValue("@LicenseID", LicenseID);



            try
            {

                Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    DetainID = (int)reader["DetainID"];

                    DetainDate = (DateTime)reader["DetainDate"];
                    FineFees = (float)(decimal)reader["FineFees"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    IsReleased = false;

                  







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
    }
}
