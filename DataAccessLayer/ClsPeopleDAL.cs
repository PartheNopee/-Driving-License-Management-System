using System;
using System.Data;
using System.Data.SqlClient;
 

namespace DataAccessLayer
{
    public class ClsPeopleDAL
    {


        public static bool DeletePerson(int ID)
        {

            int RowAffected = 0;


            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);
            string query = "DELETE FROM People where PersonID = @PersonID;";
            SqlCommand command  = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", ID);
            try
            {
                connection.Open();

                 RowAffected = command.ExecuteNonQuery();
                

            }
            catch (Exception ex)
            {

            }
            finally

            { 
                connection.Close(); 
            }

            return (RowAffected > 0 );



        }
        static public bool GetPersonByID(int ID, ref string NationalNo, ref string FirstName,
            ref string SecondName,  ref string ThirdName, ref string LastName , ref DateTime DateOfBirth,
            ref byte Gendor, ref string Address, ref string Phone, ref string Email,ref int country,ref
            string ImagePath)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);
            string query = "SELECT PersonID, NationalNo, FirstName, SecondName, ThirdName, DateOfBirth, LastName, Gendor, Address, Phone, Email, ImagePath, NationalityCountryID " +
               "FROM People where PersonID = @PersonID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    NationalNo = (string)reader["NationalNo"];
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];
                     LastName = (string)reader["LastName"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                     Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];

                    // Use the 'as' keyword or check for DBNull
                    Email = reader["Email"] != DBNull.Value ? (string)reader["Email"] : "";
                    ThirdName = reader["ThirdName"] != DBNull.Value ? (string)reader["ThirdName"] : "";
                    country = (int)reader["NationalityCountryID"];

                    if (reader["ImagePath"] != DBNull.Value )
                    {
                        ImagePath = (string)reader["ImagePath"];


                    }
                    else
                    {
                        ImagePath = "";
                    }

                    Gendor = (byte)reader["Gendor"];


                }
                else
                {
                    IsFound = false;
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

            return IsFound;

        }
        static public bool GetPersonByNationalID(string NationalNo, ref int ID, ref string FirstName,
           ref string SecondName, ref string ThirdName, ref string LastName, ref DateTime DateOfBirth,
           ref byte Gendor, ref string Address, ref string Phone, ref string Email, ref int country, ref
           string ImagePath)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);
            string query = "SELECT * FROM People where NationalNo = @NationalNo;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    ID = (int)reader["PersonID"];
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];
                    ThirdName = (string)reader["ThirdName"];
                    LastName = (string)reader["LastName"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Email = (string)reader["Email"];
                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];

                    country = (int)reader["NationalityCountryID"];

                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)reader["ImagePath"];


                    }
                    else
                    {
                        ImagePath = "";
                    }

                    Gendor = (byte)reader["Gendor"];


                }
                else
                {
                    IsFound = false;
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

            return IsFound;

        }
        public static DataTable GetAllPersons()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "SELECT People.PersonID, People.NationalNo,\r\n              People.FirstName, People.SecondName, People.ThirdName, People.LastName,\r\n\t\t\t  People.DateOfBirth, \r\n\t\t\t\t  CASE\r\n                  WHEN People.Gendor = 0 THEN 'Male'\r\n\r\n                  ELSE 'Female'\r\n\r\n                  END as Gendor,\r\n\t\t\t  People.Address, People.Phone, People.Email, \r\n              People.NationalityCountryID, Countries.CountryName, People.ImagePath\r\n              FROM            People INNER JOIN\r\n                         Countries ON People.NationalityCountryID = Countries.CountryID\r\n                ORDER BY People.FirstName";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {
                    dt.Load(reader);
                }

                reader.Close();


            }

            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }
       

     


        public static int AddPerson(string NationalNo, string FirstName,
            string SecondName, string ThirdName, string LastName, DateTime DateOfBirth,
            byte Gendor, string Address, string Phone, string Email, int NationalityCountryID,
            string ImagePath)
        {
            SqlConnection connection= new SqlConnection( clsConnectionString.ConnectionString );
            int ContactID = -1;

             string query = @"
            INSERT INTO People
               ([NationalNo], [FirstName], [SecondName], [ThirdName], [LastName],
                [DateOfBirth], [Gendor], [Address], [Phone], [Email],
                [NationalityCountryID], [ImagePath])
            VALUES
               (@NationalNo, @FirstName, @SecondName, @ThirdName, @LastName,
                @DateOfBirth, @Gendor, @Address, @Phone, @Email,
                @NationalityCountryID, @ImagePath);

            SELECT SCOPE_IDENTITY();";


            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@NationalNo", NationalNo);
            cmd.Parameters.AddWithValue("@FirstName", FirstName);
            cmd.Parameters.AddWithValue("@SecondName", SecondName);
            cmd.Parameters.AddWithValue("@ThirdName", ThirdName);
            cmd.Parameters.AddWithValue("@LastName", LastName);
            cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            cmd.Parameters.AddWithValue("@Gendor", Gendor);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.Parameters.AddWithValue("@Phone", Phone);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

            if (ImagePath != "")
            
                cmd.Parameters.AddWithValue("@ImagePath", ImagePath);
            
            else
            
                cmd.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);


            try
            {
                connection.Open();

                object result = cmd.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    ContactID = insertedID;
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);

            }

            finally
            {
                connection.Close();
            }


            return ContactID;

        }
        public static bool UpdatePerson(int ID,string NationalNo, string FirstName,
            string SecondName, string ThirdName, string LastName, DateTime DateOfBirth,
            byte Gendor, string Address, string Phone, string Email, int NationalityCountryID,
            string ImagePath)
        {
            int rowAffected= 0; 
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);
            string query = @"
        UPDATE [dbo].[People]
        SET [NationalNo] = @NationalNo,
            [FirstName] = @FirstName,
            [SecondName] = @SecondName,
            [ThirdName] = @ThirdName,
            [LastName] = @LastName,
            [DateOfBirth] = @DateOfBirth,
            [Gendor] = @Gendor,
            [Address] = @Address,
            [Phone] = @Phone,
            [Email] = @Email,
            [NationalityCountryID] = @NationalityCountryID,
            [ImagePath] = @ImagePath
        WHERE [PersonId] = @PersonId";
            
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@PersonId", ID);
            cmd.Parameters.AddWithValue("@NationalNo", NationalNo);
            cmd.Parameters.AddWithValue("@FirstName", FirstName);
            cmd.Parameters.AddWithValue("@SecondName", SecondName);
            cmd.Parameters.AddWithValue("@ThirdName", ThirdName);
            cmd.Parameters.AddWithValue("@LastName", LastName);
            cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            cmd.Parameters.AddWithValue("@Gendor", Gendor);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.Parameters.AddWithValue("@Phone", Phone);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

            if (ImagePath != null)
            {
                cmd.Parameters.AddWithValue("@ImagePath", ImagePath);
            }
            else
            {
                cmd.Parameters.AddWithValue(ImagePath, System.DBNull.Value);    
            }

            try
            {
                connection.Open();
                rowAffected = cmd.ExecuteNonQuery();
              


            }
            catch 
            { 
                
            }
            finally
            {
                connection.Close();
            }
            bool isUpdated = rowAffected > 0;
            return isUpdated;


        }
        



    }

}
