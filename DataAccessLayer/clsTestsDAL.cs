using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsTestsDAL
    {


        public static bool GetTakeTestByID(int ID, ref int TestAppointmentID, ref bool TestResult, ref string Notes, ref int CreatedByUser)
        {

            bool isFOUND = false;
            SqlConnection conn = new SqlConnection(clsConnectionString.ConnectionString);

            string query = " SELECT * FROM Tests where TestID = @ID; ";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@TestID", ID);

            try
            {

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        isFOUND = true;

                        TestAppointmentID = (int)reader["TestAppointmentID"];
                        TestResult = (bool)reader["TestResult"];
                        Notes = reader["Notes"] != DBNull.Value
                         ? (string)reader["Notes"] : null;

                        CreatedByUser = (int)reader["CreatedByUserID"];


                    }
                    else
                    {
                        isFOUND = false;
                    }



                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());   
            }
            finally
            {
                conn.Close();
            }
            return isFOUND;



        }

        static public int AddTest(int TestAppointmentID,   bool TestResult,   string Notes,   int CreatedByUser)
        {
            int AppointmentID = -1;
            SqlConnection Connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @"INSERT INTO [dbo].[Tests]
           ([TestAppointmentID]
           ,[TestResult]
           ,[Notes]
           ,[CreatedByUserID])
             VALUES (@TestAppointmentID, @TestResult, @Notes,  @CreatedByUser);

                         SELECT SCOPE_IDENTITY();  ";

            SqlCommand cmd = new SqlCommand(query, Connection);
            cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            cmd.Parameters.AddWithValue("@TestResult", TestResult);
            cmd.Parameters.AddWithValue("@CreatedByUser", CreatedByUser);
             if (Notes != null)

                cmd.Parameters.AddWithValue("@Notes", Notes);

            else

                cmd.Parameters.AddWithValue("@Notes", System.DBNull.Value);
            try
            {
                Connection.Open();
                object result = cmd.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    AppointmentID = insertedID;
                }




            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }
            finally
            {
                Connection.Close();
            }
         



            return AppointmentID;
        }


        public static bool GetLastTestByPersonAndTestTypeAndLicenseClass
           (int PersonID, int LicenseClassID, int TestTypeID, ref int TestID,
             ref int TestAppointmentID, ref bool TestResult,
             ref string Notes, ref int CreatedByUserID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @"SELECT  top 1 Tests.TestID, 
                Tests.TestAppointmentID, Tests.TestResult, 
			    Tests.Notes, Tests.CreatedByUserID, Applications.ApplicantPersonID
                FROM            LocalDrivingLicenseApplications INNER JOIN
                                         Tests INNER JOIN
                                         TestAppointments ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID INNER JOIN
                                         Applications ON LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID
                WHERE        (Applications.ApplicantPersonID = @PersonID) 
                        AND (LocalDrivingLicenseApplications.LicenseClassID = @LicenseClassID)
                        AND ( TestAppointments.TestTypeID=@TestTypeID)
                ORDER BY Tests.TestAppointmentID DESC";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found
                    isFound = true;
                    TestID = (int)reader["TestID"];
                    TestAppointmentID = (int)reader["TestAppointmentID"];
                    TestResult = (bool)reader["TestResult"];
                    if (reader["Notes"] == DBNull.Value)

                        Notes = "";
                    else
                        Notes = (string)reader["Notes"];

                    CreatedByUserID = (int)reader["CreatedByUserID"];

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

        










    }
}
