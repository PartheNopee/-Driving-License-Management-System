using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsApplicationDAL
    {

        public static bool GetApplicationByID(int ApplicationID, ref int applicantPersonID, ref DateTime applicationDate, ref
            int applicationTypeID, ref byte applicationStatus,
                         ref DateTime lastStatusDate, ref decimal paidFees, ref int createdByUserID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsConnectionString.ConnectionString);
            string query = @"Select * from Applications where ApplicationID = @ApplicationID ;";

            SqlCommand cmd = new SqlCommand(query, Connection);

            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);



            try
            {

                Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    applicantPersonID = (int)reader["ApplicantPersonID"];

                    applicationDate = (DateTime)reader["ApplicationDate"];
                    applicationTypeID = (int)reader["ApplicationTypeID"];
                    applicationStatus = (byte)reader["ApplicationStatus"];
                    lastStatusDate = (DateTime)reader["LastStatusDate"];
                    
                    createdByUserID = (int)reader["CreatedByUserID"];
                    paidFees = (decimal)reader["PaidFees"];




                }
                else 
                    IsFound = false;
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
        public static bool DeleteApplication(int applicationID)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @"Delete Applications 
                                where ApplicationID = @ApplicationID";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@ApplicationID", applicationID);


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

        static public bool UpdateApplication(int ApplicationID, int applicantPersonID, DateTime applicationDate,
            int applicationTypeID, byte applicationStatus,
                             DateTime lastStatusDate, float paidFees, int createdByUserID)
        {
            int rowsAffected = 0;



            string query = @"Update  Applications  
                            set ApplicantPersonID = @applicantPersonID,
                                ApplicationDate = @applicationDate,
                                ApplicationTypeID = @applicationTypeID,
                                ApplicationStatus = @applicationStatus,
                                LastStatusDate= @lastStatusDate,
                                PaidFees = paidFees,
                                CreatedByUserID = @createdByUserID
                                where ApplicationID = @ApplicationID";




            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);



            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicantPersonID", applicantPersonID);
            command.Parameters.AddWithValue("@ApplicationDate", applicationDate);
            command.Parameters.AddWithValue("@ApplicationTypeID", applicationTypeID);
            command.Parameters.AddWithValue("@ApplicationStatus", applicationStatus);
            command.Parameters.AddWithValue("@LastStatusDate", lastStatusDate);
            command.Parameters.AddWithValue("@PaidFees", paidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

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



            return (rowsAffected > 0);




        }

        static public int AddApplication(int applicantPersonID, DateTime applicationDate, int applicationTypeID, byte applicationStatus,
                             DateTime lastStatusDate, float paidFees, int createdByUserID)
        {
            int ID = -1;

            // Define the query with parameterized values
            string query = @"
            INSERT INTO [dbo].[Applications]
                       ([ApplicantPersonID]
                       ,[ApplicationDate]
                       ,[ApplicationTypeID]
                       ,[ApplicationStatus]
                       ,[LastStatusDate]
                       ,[PaidFees]
                       ,[CreatedByUserID])
                 VALUES
                       (@ApplicantPersonID, @ApplicationDate, @ApplicationTypeID, @ApplicationStatus, 
                        @LastStatusDate, @PaidFees, @CreatedByUserID);
            
            SELECT SCOPE_IDENTITY();";

            // Initialize the connection and command
            using (SqlConnection conn = new SqlConnection(clsConnectionString.ConnectionString))
            {
                conn.Open();

                // Initialize the command object with the query and connection
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Add parameters to the command
                    cmd.Parameters.AddWithValue("@ApplicantPersonID", applicantPersonID);
                    cmd.Parameters.AddWithValue("@ApplicationDate", applicationDate);
                    cmd.Parameters.AddWithValue("@ApplicationTypeID", applicationTypeID);
                    cmd.Parameters.AddWithValue("@ApplicationStatus", applicationStatus);
                    cmd.Parameters.AddWithValue("@LastStatusDate", lastStatusDate);
                    cmd.Parameters.AddWithValue("@PaidFees", paidFees);
                    cmd.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);
                    try
                    {
                        // Execute the query and get the ApplicationID (SCOPE_IDENTITY() returns the last inserted identity value)
                        object result = cmd.ExecuteScalar();

                        // If result is not null, return the ApplicationID (converted to int)
                        if (result != null)
                        {
                            ID= Convert.ToInt32(result);
                        }
                        else
                        {
                            throw new Exception("Error: Unable to retrieve the Application ID.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }

                }
            }
            return ID;
        }



        static public DataTable GetAllApps()
        {
            DataTable vw = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "   SELECT * from LocalDrivingLicenseApplications_View; ";

            SqlCommand cmd = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    vw.Load(reader);
                }
                reader.Close();

            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }


            return vw;
        }

        public static bool HasApplied(int ApplicantPerson, int LicenseClassID)
        {
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);
            string Query = " SELECT found=1 FROM LocalDrivingLicenseApplications as lc INNER JOIN " +
                "Applications as a ON lc.ApplicationID = a.ApplicationID WHERE a.ApplicantPersonID = @ApplicantPerson " +
                "AND lc.LicenseClassID = @LicenseClassID AND a.ApplicationStatus IN (1, 3)";

            bool IsFound = false;
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@ApplicantPerson", ApplicantPerson);
            cmd.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                IsFound = reader.HasRows;
                reader.Close();



            }
            catch (Exception ex)
            {


            }

            finally
            {
                connection.Close();
            }

            return IsFound;



        }
        public static bool UpdateStatus(int ApplicationID, short NewStatus)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @"Update  Applications  
                            set 
                                ApplicationStatus = @NewStatus, 
                                LastStatusDate = @LastStatusDate
                            where ApplicationID=@ApplicationID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@NewStatus", NewStatus);
            command.Parameters.AddWithValue("LastStatusDate", DateTime.Now);


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

        public static bool IsAppActive(int PersonID, int AppTypeID)
        {
            return (GetActiveApplicationID(PersonID, AppTypeID) != -1);
        }
        public static int GetActiveApplicationID(int PersonID, int ApplicationTypeID)
        {
            int ActiveApplicationID = -1;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "SELECT ActiveApplicationID = ApplicationID FROM Applications" +
                " WHERE ApplicantPersonID = @ApplicantPersonID and ApplicationTypeID=@ApplicationTypeID and ApplicationStatus=1";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicantPersonID", PersonID);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int AppID))
                {
                    ActiveApplicationID = AppID;
                }
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return ActiveApplicationID;
            }
            finally
            {
                connection.Close();
            }

            return ActiveApplicationID;
        }
        public static int GetActiveApplicationIDForLicenseClass(int PersonID, int ApplicationTypeID, int LicenseClassID)
        {
            int ActiveApplicationID = -1;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @"SELECT ActiveApplicationID=Applications.ApplicationID  
                            From
                            Applications INNER JOIN
                            LocalDrivingLicenseApplications ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID
                            WHERE ApplicantPersonID = @ApplicantPersonID 
                            and ApplicationTypeID=@ApplicationTypeID 
							and LocalDrivingLicenseApplications.LicenseClassID = @LicenseClassID
                            and ApplicationStatus=1";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicantPersonID", PersonID);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int AppID))
                {
                    ActiveApplicationID = AppID;
                }
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return ActiveApplicationID;
            }
            finally
            {
                connection.Close();
            }

            return ActiveApplicationID;
        }

    }

}
