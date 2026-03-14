using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DataAccessLayer
{
    public class clsLocaldriverlicenseDAL
    {
        public static bool DoesAttendTestType(int LocalDrivingLicenseApplicationID, int TestTypeID)

        {


            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @" SELECT top 1 Found=1
                            FROM LocalDrivingLicenseApplications INNER JOIN
              TestAppointments ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID
              INNER JOIN
              Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                            WHERE
                            (LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID) 
                            AND(TestAppointments.TestTypeID = @TestTypeID)
                            ORDER BY TestAppointments.TestAppointmentID desc";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    IsFound = true;
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }

            finally
            {
                connection.Close();
            }

            return IsFound;

        }

        public static bool GetLocalDriverlicenceAppByID(int LocalDrivingLicenseApplicationID, ref int ApplicationID,  ref
           int LicenseClassID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsConnectionString.ConnectionString);
            string query = @"Select * from LocalDrivingLicenseApplications where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID ;";

            SqlCommand cmd = new SqlCommand(query, Connection);

            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);



            try
            {

                Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    ApplicationID = (int)reader["ApplicationID"];
                    LicenseClassID = (int)reader["LicenseClassID"];
                 




                }
                reader.Close();

            }
            catch (Exception ex)
            {
            }
            finally
            {
                Connection.Close();
            }

            return IsFound;

        }
        public static bool DoesPassTestType(int LocalDrivingLicenseApplicationID, int TestTypeID)

        {


            bool Result = false;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @" SELECT top 1 TestResult
                            FROM LocalDrivingLicenseApplications INNER JOIN
                                 TestAppointments ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID INNER JOIN
                                 Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                            WHERE
                            (LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID) 
                            AND(TestAppointments.TestTypeID = @TestTypeID)
                            ORDER BY TestAppointments.TestAppointmentID desc";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && bool.TryParse(result.ToString(), out bool returnedResult))
                {
                    Result = returnedResult;
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }

            finally
            {
                connection.Close();
            }

            return Result;

        }
        public static bool GetLocalDrivingLicenseApplicationInfoByApplicationID(int ApplicationID, ref int   LocalDrivingLicenseApplicationID, ref
           int LicenseClassID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsConnectionString.ConnectionString);
            string query = @"Select * from LocalDrivingLicenseApplications where ApplicationID = @ApplicationID ;";

            SqlCommand cmd = new SqlCommand(query, Connection);

            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);



            try
            {

                Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    ApplicationID = (int)reader["LocalDrivingLicenseApplicationID"];
                    LicenseClassID = (int)reader["LicenseClassID"];





                }
                reader.Close();

            }
            catch (Exception ex)
            {
            }
            finally
            {
                Connection.Close();
            }

            return IsFound;

        }

        public static bool DeleteLocalDriverApplication(int LocalDrivingLicenseApplicationID)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @"Delete LocalDrivingLicenseApplications 
                                where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);


            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return false;
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

        static public bool UpdateLocalApplication(int LocalDrivingLicenseApplicationID,  int ApplicationID, 
           int LicenseClassID)
        {
            int rowsAffected = 0;



            string query = @"Update  LocalDrivingLicenseApplications  
                            set ApplicationID = @ApplicationID,
                                LicenseClassID = @LicenseClassID,
                                
                                where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";




            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);



            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicantPersonID", ApplicationID);
            command.Parameters.AddWithValue("@ApplicationDate", LicenseClassID);
           
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

            try
            {

                connection.Open();

                rowsAffected = command.ExecuteNonQuery();


            }


            catch (Exception )
            {
                //Console.WriteLine("Error: " + ex.Message);
                return false;
            }



            return (rowsAffected > 0);




        }

        static public int AddLocalLDApplication(int ApplicationID, int LicenseClassID)
        {
            int LocalID = -1;
            // Define the query with parameterized values
            string query = @"
            INSERT INTO [dbo].[LocalDrivingLicenseApplications]
                       ([ApplicationID]
                       ,[LicenseClassID])
                       
                 VALUES
                       (@ApplicationID, @LicenseClassID);
            
            SELECT SCOPE_IDENTITY();";

            // Initialize the connection and command
            using (SqlConnection conn = new SqlConnection(clsConnectionString.ConnectionString))
            {
                conn.Open();

                // Initialize the command object with the query and connection
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Add parameters to the command
                    cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                    cmd.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
                    try
                    {
                        // Execute the query and get the ApplicationID (SCOPE_IDENTITY() returns the last inserted identity value)
                        object result = cmd.ExecuteScalar();

                        // If result is not null, return the ApplicationID (converted to int)
                        if (result != null)
                        {
                            LocalID= Convert.ToInt32(result);

                        }
                        else
                        {
                            throw new Exception("Error: Unable to retrieve the Application ID.");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    }
                }
            }
            return LocalID;
        }

        static public DataTable GetAllLocalLDApps()
        {
            DataTable dt = new DataTable();

            string query = "SELECT * FROM LocalDrivingLicenseApplications";

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    
                    try
                    {

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            dt.Load(reader);
                        }



                    }
                    catch(Exception)
                    {

                    }

                }



            }


                return dt;
        }

        public static int GetActiveLicenseIDByPersonID(int PersonID, int LicenseClassID)
        {
            int LicenseID = -1;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @"SELECT        Licenses.LicenseID
                            FROM Licenses INNER JOIN
                                                     Drivers ON Licenses.DriverID = Drivers.DriverID
                            WHERE  
                             
                             Licenses.LicenseClass = @LicenseClass 
                              AND Drivers.PersonID = @PersonID
                              And IsActive=1;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@LicenseClass", LicenseClassID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    LicenseID = insertedID;
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }

            finally
            {
                connection.Close();
            }


            return LicenseID;
        }

    }
}
