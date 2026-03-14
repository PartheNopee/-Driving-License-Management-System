using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsLicensesDAL
    {

        
        public static int AddLicense( int ApplicationID ,int DriverID, 
            int LicenseClass, DateTime IssueDate, DateTime ExpDate,
            string Notes, decimal PaidFees, bool IsActive
            ,byte IssueReason, int CreatedByUserID)
        {
            int LicenseID = -1;


            string Query = @"INSERT INTO [dbo].[Licenses]
                              ([ApplicationID]
                              ,[DriverID]
                              ,[LicenseClass]
                              ,[IssueDate]
                              ,[ExpirationDate]
                              ,[Notes]
                              ,[PaidFees]
                              ,[IsActive]
                              ,[IssueReason]
                              ,[CreatedByUserID])
                                VALUES
                                      (@ApplicationID,
                             @DriverID, 
                             @LicenseClass, 
                             @IssueDate,  
                             @ExpirationDate ,
                             @Notes, 
                             @PaidFees,  
                             @IsActive,  
                             @IssueReason,  
                             @CreatedByUserID )


               SELECT SCOPE_IDENTITY(); ";


            using (SqlConnection Connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                Connection.Open();
                using (SqlCommand cmd = new SqlCommand(Query, Connection))
                {
                     cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                    cmd.Parameters.AddWithValue("@DriverID", DriverID);
                    cmd.Parameters.AddWithValue("@LicenseClass", LicenseClass);
                    cmd.Parameters.AddWithValue("@IssueDate", IssueDate);
                    cmd.Parameters.AddWithValue("@ExpirationDate", ExpDate);
                     cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
                    cmd.Parameters.AddWithValue("@IsActive", IsActive);
                    cmd.Parameters.AddWithValue("@IssueReason", IssueReason);
                    cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                    if (Notes != null)

                        cmd.Parameters.AddWithValue("@Notes", Notes);

                    else

                        cmd.Parameters.AddWithValue("@Notes", System.DBNull.Value);


                    try
                    {
                        object result = cmd.ExecuteScalar();


                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            LicenseID = insertedID;
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("This is the CATCHED error : " + ex.ToString());
                    }



                }






            }


            return LicenseID;
        }

        public static bool UpdateLicense(int LicenseID, int ApplicationID, int DriverID, int LicenseClass, DateTime IssueDate, 
            DateTime ExpDate, string Notes, decimal PaidFees, bool IsActive
           , byte IssueReason, int CreatedByUserID)
        {
            int AffectedRows = -1;


            string Query = @"UPDATE [dbo].[Licenses]
                             SET [ApplicationID] = @ApplicationID, 
                                [DriverID] = @DriverID, 
                                [LicenseClass] = @LicenseClass,  
                                [IssueDate] = @IssueDate,  
                                [ExpirationDate] = @ExpirationDate, 
                                [Notes] = @Notes,  
                                [PaidFees] = @PaidFees,  
                                [IsActive] = @IsActive, 
                                [IssueReason] = @IssueReason,  
                                [CreatedByUserID] = @CreatedByUserID,  
  


                            WHERE LicenseID = @LicenseID;";

            using (SqlConnection Connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                Connection.Open();
                using (SqlCommand cmd = new SqlCommand(Query, Connection))
                {
                    cmd.Parameters.AddWithValue("@LicenseID", LicenseID);

                    cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                    cmd.Parameters.AddWithValue("@DriverID", DriverID);
                    cmd.Parameters.AddWithValue("@LicenseClass", LicenseClass);
                    cmd.Parameters.AddWithValue("@IssueDate", IssueDate);
                    cmd.Parameters.AddWithValue("@ExpirationDate", ExpDate);
                    cmd.Parameters.AddWithValue("@Notes", Notes);
                    cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
                    cmd.Parameters.AddWithValue("@IsActive", IsActive);
                    cmd.Parameters.AddWithValue("@IssueReason", IssueReason);
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

        public static bool GetLicenseByID(int LicenseID, ref int ApplicationID, ref int DriverID, ref int LicenseClass, ref DateTime IssueDate,
           ref DateTime ExpDate, ref string Notes, ref decimal PaidFees, ref bool IsActive
           , ref byte IssueReason, ref int CreatedByUserID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsConnectionString.ConnectionString);
            string query = @"Select * from Licenses where LicenseID = @LicenseID ;";

            SqlCommand cmd = new SqlCommand(query, Connection);

            cmd.Parameters.AddWithValue("@LicenseID", LicenseID);



            try
            {

                Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    ApplicationID = (int)reader["ApplicationID"];
                    DriverID = (int)reader["DriverID"];
                    LicenseClass = (int)reader["LicenseClass"];

                    IssueDate = (DateTime)reader["IssueDate"];
                    ExpDate = (DateTime)reader["ExpirationDate"];

                    IsActive = (bool)reader["IsActive"];
                    IssueReason = (byte)reader["IssueReason"];

                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    PaidFees = (decimal)reader["PaidFees"];
                    Notes = reader["Notes"] != DBNull.Value
                     ? (string)reader["Notes"]  // Casting to nullable int
                     : null;






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
        public static bool GetLicenseByAppID(int ApplicationID  , ref int LicenseID, ref int DriverID, ref int LicenseClass, ref DateTime IssueDate,
          ref DateTime ExpDate, ref string Notes, ref decimal PaidFees, ref bool IsActive
          , ref byte IssueReason, ref int CreatedByUserID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsConnectionString.ConnectionString);
            string query = @"Select * from Licenses where ApplicationID = @ApplicationID ;";

            SqlCommand cmd = new SqlCommand(query, Connection);

            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);



            try
            {

                Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    LicenseID = (int)reader["LicenseID"];
                    DriverID = (int)reader["DriverID"];
                    LicenseClass = (int)reader["LicenseClass"];

                    IssueDate = (DateTime)reader["IssueDate"];
                    ExpDate = (DateTime)reader["ExpirationDate"];

                    IsActive = (bool)reader["IsActive"];
                    IssueReason = (byte)reader["IssueReason"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    PaidFees = (decimal)reader["PaidFees"];
                   
                    if (reader["Notes"] != DBNull.Value)
                    {
                        Notes = (string)reader["Notes"];


                    }
                    else
                    {
                        Notes = "";
                    }

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

        static public DataTable GetAllLocalLicenseByPersonID(int PersonID)
        {
            DataTable dt = new DataTable();


            string Query = @"SELECT  Licenses.LicenseID, Licenses.ApplicationID, LicenseClasses.ClassName, Licenses.ExpirationDate, Licenses.IsActive
                            FROM      Licenses INNER JOIN
                             LicenseClasses ON Licenses.LicenseClass = LicenseClasses.LicenseClassID INNER JOIN
                             Applications ON Licenses.ApplicationID = Applications.ApplicationID
                             where ApplicantPersonID = @PersonID ";


            using (SqlConnection Connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(Query, Connection);
                cmd.Parameters.AddWithValue("@PersonID", PersonID);
 
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

        public static bool DeactivateLicense(int LicenseID)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @"UPDATE Licenses
                           SET 
                              IsActive = 0
                             
                         WHERE LicenseID=@LicenseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);


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

    }
}


