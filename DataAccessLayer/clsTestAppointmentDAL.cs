using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsTestAppointmentDAL

    {

      

        //lock the test after passing it ...

        public static bool LockTestAppointment(int testAppointmentID)
        {
            int AffectedRows = -1;


            string Query = @"UPDATE TestAppointments SET IsLocked = 1 WHERE TestAppointmentID = @testAppointmentID;";

            using (SqlConnection Connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                Connection.Open();
                using (SqlCommand cmd = new SqlCommand(Query, Connection))
                {
                     cmd.Parameters.AddWithValue("@TestAppointmentID", testAppointmentID);

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



        //retrieve Appointments list of the person with the Local app ID...
        static public DataTable GetAllAppointmentsByAppID(int LocalAppID , int TestTypeID)
        {
            DataTable dt = new DataTable();


            string Query = @"select TestAppointments.TestAppointmentID, TestAppointments.AppointmentDate, TestAppointments.PaidFees,  
                TestAppointments.IsLocked from TestAppointments where LocalDrivingLicenseApplicationID = @LocalAppID and TestTypeID = @TestID;";

            
            using (SqlConnection Connection = new SqlConnection(clsConnectionString.ConnectionString)  )
            {
                SqlCommand cmd = new SqlCommand(Query, Connection);
                cmd.Parameters.AddWithValue("@LocalAppID", LocalAppID);
                cmd.Parameters.AddWithValue("@TestID", TestTypeID);

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

                    Console.WriteLine (ex.ToString());


                }
            }


            return dt;

        }

        //Add Appointment...
        static public int AddTestAppointment(int TestTypeID, int LocalAppID,DateTime AppointmentDate,float PaidFee,
            int createdByUserID,int RetakeTestApplicationID)
        {
            int AppointmentID = -1;                                                                                                                                                                       
            SqlConnection Connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @"INSERT INTO
                            TestAppointments
                           ([TestTypeID]
                           ,[LocalDrivingLicenseApplicationID]
                           ,[AppointmentDate]
                           ,[PaidFees]
                           ,[CreatedByUserID]
                           ,[IsLocked]
                           ,[RetakeTestApplicationID])
                     VALUES  (@TestTypeID, @LocalDrivingLicenseApplicationID, @AppointmentDate, @PaidFees, @CreatedByUserID
                              ,0,@RetakeTestApplicationID );

                         SELECT SCOPE_IDENTITY(); ";

            SqlCommand cmd = new SqlCommand(query, Connection);
            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalAppID);
            cmd.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            cmd.Parameters.AddWithValue("@PaidFees", PaidFee);
            cmd.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);
            if (RetakeTestApplicationID == -1)

                cmd.Parameters.AddWithValue("@RetakeTestApplicationID", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID);

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

        public static bool UpdateAppointment(int testAppointmentID , DateTime appointmentDate)
        {
            int AffectedRows = -1;


            string Query = @"UPDATE TestAppointments SET AppointmentDate = @AppointmentDate WHERE TestAppointmentID = @TestAppointmentID;";

            using (SqlConnection Connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                Connection.Open();
                using (SqlCommand cmd = new SqlCommand(Query, Connection))
                {
                    cmd.Parameters.AddWithValue("@AppointmentDate", appointmentDate);
                    cmd.Parameters.AddWithValue("@TestAppointmentID", testAppointmentID);

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

        public static bool GetTestAppointmentID(int TestAppointmentID, ref int TestTypeID, ref int LocalDrivingLicenseApplicationID, ref DateTime AppointmentDate
            , ref bool IsLocked,
                         ref float paidFees, ref int createdByUserID ,ref int RetakeTestApplicationID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsConnectionString.ConnectionString);
            string query = @"Select * from TestAppointments where TestAppointmentID = @TestAppointmentID ;";

            SqlCommand cmd = new SqlCommand(query, Connection);

            cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);



            try
            {

                Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    LocalDrivingLicenseApplicationID = (int)reader["LocalDrivingLicenseApplicationID"];
                    TestTypeID = (int)reader["TestTypeID"];

                    AppointmentDate = (DateTime)reader["AppointmentDate"];
                     IsLocked = (bool)reader["IsLocked"];

                    createdByUserID = (int)reader["CreatedByUserID"];
                    paidFees = (float)reader["PaidFees"];
                    if (reader["RetakeTestApplicationID"] == DBNull.Value)
                        RetakeTestApplicationID = -1;
                    else
                        RetakeTestApplicationID = (int)reader["RetakeTestApplicationID"];






                }
                reader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine( " the Catched error"+ex.Message);
            }
            finally
            {
                Connection.Close();
            }

            return IsFound;

        }

        public static bool GetTestAppointmentbyLocalAppID(int LocalDrivingLicenseApplicationID  , ref int TestTypeID, ref int TestAppointmentID, ref DateTime AppointmentDate
           , ref bool IsLocked,
                        ref float paidFees, ref int createdByUserID, ref int RetakeTestApplicationID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsConnectionString.ConnectionString);
            string query = @"Select * from TestAppointments where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID ;";

            SqlCommand cmd = new SqlCommand(query, Connection);

            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);



            try
            {

                Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    TestAppointmentID = (int)reader["TestAppointmentID"];
                    TestTypeID = (int)reader["TestTypeID"];

                    AppointmentDate = (DateTime)reader["AppointmentDate"];
                    IsLocked = (bool)reader["IsLocked"];

                    createdByUserID = (int)reader["CreatedByUserID"];
                    paidFees = (float)reader["PaidFees"];
                    if (reader["RetakeTestApplicationID"] == DBNull.Value)
                        RetakeTestApplicationID = -1;
                    else
                        RetakeTestApplicationID = (int)reader["RetakeTestApplicationID"];






                }
                reader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Connection.Close();
            }

            return IsFound;

        }
        public static bool HasUnlockedAppointmet(int LocalID, int TestTypeID)
        {
            bool IsFound = false;


            string Query = @"select Found = 1 from TestAppointments 
                            where LocalDrivingLicenseApplicationID = @LocalID and TestTypeID = @TestTypeID and IsLocked = 0";

            using (SqlConnection Connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                Connection.Open();
                using (SqlCommand cmd = new SqlCommand(Query, Connection))
                {
                    cmd.Parameters.AddWithValue("@LocalID", LocalID);
                    cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);

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
        public static bool HasUnlockedAppointmet( int TestAppointmentID)
        {
            bool IsFound = false;


            string Query = @"select Found = 1 from TestAppointments 
                            where   TestAppointmentID = @TestAppointmentID and IsLocked = 0;";

            using (SqlConnection Connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                Connection.Open();
                using (SqlCommand cmd = new SqlCommand(Query, Connection))
                {
                     cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

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

        public static bool HasPassedTest(int LocalAppId , int TestTypeID)
        {
            bool IsFound = false;


            string Query = @"SELECT found =1
                        FROM      
                          LocalDrivingLicenseApplications INNER JOIN
                         TestAppointments ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID INNER JOIN
                         TestTypes ON TestAppointments.TestTypeID = TestTypes.TestTypeID INNER JOIN
                         Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                         where LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalAppId and  TestAppointments.TestTypeID = @TestTypeID and Tests.TestResult =1
                         order by TestAppointments.TestAppointmentID desc ;";


            using (SqlConnection Connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                Connection.Open();
                using (SqlCommand cmd = new SqlCommand(Query, Connection))
                {
                    cmd.Parameters.AddWithValue("@LocalAppId", LocalAppId);
                    cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);

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


        static public int GetFailedTestsCount( int LocalAppID , int TestTypeID)
        {
            int FailedTestsCount = -1;
            string query = @"SELECT COUNT(*) 
                                FROM TestAppointments inner join Tests on TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                                WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID
                                AND TestTypeID = @TestTypeID
                                AND TestResult = 0 ";

            using (SqlConnection Connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                

                SqlCommand cmd = new SqlCommand(query, Connection);
                cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);
                cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalAppID);

                try
                {
                    Connection.Open();
                    //object result = cmd.ExecuteScalar();
                    FailedTestsCount = (int)cmd.ExecuteScalar();

                    //if (result != null && int.TryParse(result.ToString(), out int CountResult))
                    //{
                    //    FailedTestsCount = CountResult;
                    //}




                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());

                }

            }


            return FailedTestsCount;
        }
    }


}
