using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;

namespace DataAccessLayer
{
    public class clsUsersDAL
    {
        public static bool getuserByName(string username, ref int UserID,ref int PersonID,ref string Password, ref bool IsActive)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsConnectionString.ConnectionString);
            string query = @"Select * from Users where UserName = @UserName ;";

            SqlCommand cmd = new SqlCommand(query, Connection);

            cmd.Parameters.AddWithValue("@UserName", username);



            try
            {

                Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    UserID = (int)reader["UserID"];

                    PersonID = (int)reader["PersonID"];
                    Password = (string)reader["Password"];
                    IsActive = (bool)reader["IsActive"];
                  

 

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

        public static bool GetUserByID(int UserID, ref string username, ref int PersonID, ref string Password, ref bool IsActive)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsConnectionString.ConnectionString);
            string query = @"Select * from Users where UserID = @UserID ;";

            SqlCommand cmd = new SqlCommand(query, Connection);

            cmd.Parameters.AddWithValue("@UserID", UserID);



            try
            {

                Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    username = (string)reader["UserName"];

                    PersonID = (int)reader["PersonID"];
                    Password = (string)reader["Password"];
                    IsActive = (bool)reader["IsActive"];




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

        //useless..
        public static bool LoginUser (string username, string password)
        {
            bool IsLogged = false;

            SqlConnection Connection = new SqlConnection(clsConnectionString.ConnectionString); 
            string query = @"Select * from Users where UserName = @UserName and Password = @Password;";

            SqlCommand cmd = new SqlCommand(query, Connection);

            cmd.Parameters.AddWithValue("@UserName", username);
            cmd.Parameters.AddWithValue ("@Password", password);



            try
            {

                Connection.Open();


                SqlDataReader reader = cmd.ExecuteReader();

                IsLogged = reader.HasRows;
                reader.Close();



            }
            catch (Exception ex)
            {
            }
            finally
            {
                Connection.Close();
            }

             return IsLogged;

        }
        public static int AddUser(int PersonID, string UserName, string Password,bool IsActive)
        {

            SqlConnection Conn = new SqlConnection(clsConnectionString.ConnectionString);

            int UserId = -1;
            string Query = @"
            INSERT INTO Users
               ([PersonID], [UserName], [Password], [IsActive]  )
            VALUES
               (@PersonID, @UserName, @Password, @IsActive);

            SELECT SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(Query, Conn);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("@IsActive", IsActive);

            try
            {
                Conn.Open();
                object result = cmd.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    UserId = insertedID;
                }

 

            }
            catch (Exception ex)
            {


            }

            finally
            {

                Conn.Close();
            }

             
            return UserId;
        }
        public static bool DeleteUser(int UserID)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @"Delete Users 
                                where UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            
            command.Parameters.AddWithValue("@UserID", UserID);


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
        public static bool UpdateUser(int UserID, int PersonID, string UserName,
              string Password, bool IsActive)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @"Update  Users  
                            set PersonID = @PersonID,
                                UserName = @UserName,
                                Password = @Password,
                                IsActive = @IsActive
                                where UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@UserID", UserID);


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


        public static bool IsPersonRelated(int PersonID)
        {
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);
            string Query = " SELECT found = 1 from Users where PersonID = @PersonID;";

            bool IsFound = false;
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);


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
        public static bool IsUserExist(string UserName)
        {
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);
            string Query = " SELECT found = 1 from Users where UserName = @UserName;";

            bool IsFound = false;
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@UserName", UserName);


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
        public static DataTable GetUsers()
        {
            DataTable Dt = new DataTable();

            Dt.Columns.Add("UserID" ,typeof(int));
            Dt.Columns.Add("PersonID", typeof(int));
            Dt.Columns.Add("FullName", typeof(string));
            Dt.Columns.Add("Username", typeof(string));
            Dt.Columns.Add("IsActive", typeof(bool));
             
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "SELECT Users.UserID, Users.PersonID, People.FirstName, People.SecondName, People.ThirdName, People.LastName, Users.UserName, Users.IsActive FROM Users INNER JOIN  People ON Users.PersonID = People.PersonID;";

            SqlCommand cmd = new SqlCommand(query, connection);



            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {


                    while (reader.Read())
                    {
                        string fullName = $"{reader["FirstName"]} {reader["SecondName"]} {reader["ThirdName"]} {reader["LastName"]} ";
                        Dt.Rows.Add(

                            reader["UserID"],
                            reader["PersonID"],
                            fullName,
                            reader["UserName"],
                            reader["IsActive"]

                            );



                    }
                }


                reader.Close();


            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();


            }



            return Dt;
        }


    }
}
