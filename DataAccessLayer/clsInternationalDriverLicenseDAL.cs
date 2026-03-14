using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsInternationalDriverLicensesAppDAL
    {
        public static bool DeleteInternationalDriverApplication(int InternationalLicenseID)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @"Delete InternationalLicenses  where InternationalLicenseID = @InternationalLicenseID";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);


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
        public static bool GetInternationalLicenseByLocalLicenseID(int IssuedUsingLocalLicenseID, ref int InternationalLicenseID, ref int ApplicationID, ref int DriverID,
           ref DateTime IssueDate, ref DateTime ExpirationDate, ref bool IsActive,
           ref int CreatedByUserID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsConnectionString.ConnectionString);
            string query = @" select * from InternationalLicenses where IssuedUsingLocalLicenseID = @IssuedUsingLocalLicenseID ;";

            SqlCommand cmd = new SqlCommand(query, Connection);

            cmd.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);



            try
            {

                Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    ApplicationID = (int)reader["ApplicationID"];
                    DriverID = (int)reader["DriverID"];
                    InternationalLicenseID = (int)reader["InternationalLicenseID"];

                    IssueDate = (DateTime)reader["IssueDate"];
                    ExpirationDate = (DateTime)reader["ExpirationDate"];

                    IsActive = (bool)reader["IsActive"];

                    CreatedByUserID = (int)reader["CreatedByUserID"];


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
        public static bool GetInternationalLicenseByID(int InternationalLicenseID,ref int ApplicationID, ref int DriverID,
           ref int IssuedUsingLocalLicenseID, ref DateTime IssueDate,ref  DateTime ExpirationDate,ref bool IsActive,
           ref int CreatedByUserID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsConnectionString.ConnectionString);
            string query = @" select * from InternationalLicenses where InternationalLicenseID = @InternationalLicenseID ;";

            SqlCommand cmd = new SqlCommand(query, Connection);

            cmd.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);



            try
            {

                Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    ApplicationID = (int)reader["ApplicationID"];
                    DriverID = (int)reader["DriverID"];
                    IssuedUsingLocalLicenseID = (int)reader["IssuedUsingLocalLicenseID"];

                    IssueDate = (DateTime)reader["IssueDate"];
                    ExpirationDate = (DateTime)reader["ExpirationDate"];

                    IsActive = (bool)reader["IsActive"];

                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    

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
        static public bool UpdateInternationalLicense(int InternationalLicenseID, int ApplicationID, int DriverID, 
            int LocalLicenseID, DateTime IssueDate, DateTime ExpirationDate, bool IsActive,
            int CreatedByUserID)
        {
            int rowsAffected = 0;



            string query = @"Update  InternationalLicenses  
                            set ApplicationID = @ApplicationID,
                                DriverID = @DriverID,
								IssuedUsingLocalLicenseID =@IssuedUsingLocalLicenseID ,
								IssueDate =@IssueDate  ,
								ExpirationDate =@ExpirationDate ,
								IsActive =@IsActive ,
								CreatedByUserID=@CreatedByUserID 
		   where InternationalLicenseID = @InternationalLicenseID";




            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);



            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", LocalLicenseID);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);

            try
            {

                connection.Open();

                rowsAffected = command.ExecuteNonQuery();


            }


            catch (Exception)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return false;
            }



            return (rowsAffected > 0);




        }

        static public int AddinternationalLicense(int ApplicationID,int DriverID, int LocalLicenseID, DateTime IssueDate, DateTime ExpirationDate,
            int CreatedByUserID)
        {
            int InternationalLicenseID = -1;
            // Define the query with parameterized values
            string query = @" UPDATE InternationalLicenses
                              SET IsActive = 0
                                where DriverID = @DriverID;

                            INSERT INTO InternationalLicenses
                               (ApplicationID,
                    			DriverID,IssuedUsingLocalLicenseID,IssueDate,ExpirationDate,InternationalLicenses,CreatedByUserID)
                         VALUES
                               (@ApplicationID, @DriverID, @IssuedUsingLocalLicenseID,@IssueDate,@ExpirationDate,1,@CreatedByUserID);
                    
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
                    cmd.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", LocalLicenseID);
                    cmd.Parameters.AddWithValue("@DriverID", DriverID);
                    cmd.Parameters.AddWithValue("@IssueDate", IssueDate);
                    cmd.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
                    cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                    try
                    {
                        // Execute the query and get the ApplicationID (SCOPE_IDENTITY() returns the last inserted identity value)
                        object result = cmd.ExecuteScalar();

                        // If result is not null, return the ApplicationID (converted to int)
                        if (result != null)
                        {
                            InternationalLicenseID = Convert.ToInt32(result);

                        }
                        
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    }
                }
            }
            return InternationalLicenseID;
        }

        static public DataTable GetAllInternationalApplications()
        {
            DataTable dt = new DataTable();

            string query = "select * from InternationalLicenses";

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
                    catch (Exception)
                    {

                    }

                }



            }


            return dt;
        }

        static public DataTable GetAllInternationalLicensesByPersonID(int PersonID)
        {
            DataTable dt = new DataTable();

            string query = "SELECT InternationalLicenses.* FROM InternationalLicenses INNER JOIN Applications ON InternationalLicenses.ApplicationID" +
                " = Applications.ApplicationID where ApplicantPersonID = @ApplicantPersonID";

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ApplicantPersonID",PersonID);
                    try
                    {

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            dt.Load(reader);
                        }



                    }
                    catch (Exception)
                    {

                    }

                }



            }


            return dt;
        }

        public static int GetActiveInternationalLicenseIDByDriverID(int DriverID)
        {
            int LicenseID = -1;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @"SELECT Top 1 InternationalLicenseID
                            FROM InternationalLicenses 
                            where DriverID=@DriverID and GetDate() between IssueDate and ExpirationDate 
                            order by ExpirationDate Desc;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DriverID", DriverID);

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
