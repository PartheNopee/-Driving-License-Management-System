using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsTestTyDAL
    {
         


            public static bool GetTestByID(int ID, ref string AppTitle,ref string Descrption, ref decimal Fee)
            {

                bool isFOUND = false;
                SqlConnection conn = new SqlConnection(clsConnectionString.ConnectionString);

                string query = " SELECT * FROM TestTypes where TestTypeID = @ID; ";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", ID);

            try
            {

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        isFOUND = true;

                        AppTitle = (string)reader["TestTypeTitle"];
                        Descrption = (string)reader["TestTypeDescription"];
                        Fee = (decimal)reader["TestTypeFees"];


                    }
                    else
                    {
                        isFOUND = false;
                    }
 


                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                conn.Close();
            }
                return isFOUND;



            }

            public static DataTable GetAllTestTypes()
            {
                DataTable dt = new DataTable();

                SqlConnection conn = new SqlConnection(clsConnectionString.ConnectionString);

                string query = "select * from TestTypes;";
                SqlCommand cmd = new SqlCommand(query, conn);

                try
                {
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        dt.Load(reader);
                    }

                    reader.Close();


                }
                catch (Exception ex)
                {
                }

                finally
                {
                    conn.Close();
                }
                return dt;



            }

            static public bool updateTestType(int ID, string TestTitle,string Des, decimal Fee)
            {
                int RowAffected = 0;
                SqlConnection conn = new SqlConnection(clsConnectionString.ConnectionString);

                string query = "update TestTypes Set TestTypeTitle = @Apptite , TestTypeFees = @Fee ,TestTypeDescription= @Desc where TestTypeID = @ID;";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Apptite", TestTitle);
                cmd.Parameters.AddWithValue("@Fee", Fee);
                cmd.Parameters.AddWithValue("@Desc",Des);
                cmd.Parameters.AddWithValue("@ID", ID);
               

                try
                {
                    conn.Open();

                    RowAffected = cmd.ExecuteNonQuery();








                }
                catch (Exception ex)
                {
                }


                finally
                {
                    conn.Close();
                }
                return (RowAffected > 0);


            }


        }
    }




