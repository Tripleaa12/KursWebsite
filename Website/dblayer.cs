using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace Website
{
    public class dblayer
    {
        public void InsertPerson(string username, string email, string password)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Meld"].ConnectionString;
            SqlParameter param;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Person (Username,Email,Password) VALUES (@Username,@Email,@Password)", conn);
                cmd.CommandType = CommandType.Text;

                param = new SqlParameter("@Username", SqlDbType.NVarChar);
                param.Value = username;//(object)wpd.Temp ?? DBNull.Value;//wpd.Temp;
                cmd.Parameters.Add(param);

                param = new SqlParameter("@Email", SqlDbType.NVarChar);
                param.Value = email;//(object)wpd.Temp ?? DBNull.Value;//wpd.Temp;
                cmd.Parameters.Add(param);

                param = new SqlParameter("@Password", SqlDbType.NVarChar);
                param.Value = password;//(object)wpd.Temp ?? DBNull.Value;//wpd.Temp;
                cmd.Parameters.Add(param);

                

                cmd.ExecuteNonQuery();
                conn.Close();
            }

            

            }
        public bool SelectPerson(String username, string password)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Meld"].ConnectionString;
             SqlParameter param;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Person WHERE Username = @Username AND Password = @Password", conn);
                cmd.CommandType = CommandType.Text;

                param = new SqlParameter("@Username", SqlDbType.NVarChar);
                param.Value = username;//(object)wpd.Temp ?? DBNull.Value;//wpd.Temp;
                cmd.Parameters.Add(param);

                param = new SqlParameter("@Password", SqlDbType.NVarChar);
                param.Value = password;//(object)wpd.Temp ?? DBNull.Value;//wpd.Temp;
                cmd.Parameters.Add(param);

                var reader = cmd.ExecuteReader();
                bool hasRows = reader.HasRows;
                conn.Close();

                return hasRows;
            }

        }
        public void InsertValuesToDB(string Username, string q1, string a1, string q2, string a2, string q3, string a3)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Meld"].ConnectionString;
            SqlParameter param;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into Quiz values(@un,@q1,@a1,@q2,@a2,@q3,@a3)", conn);
                cmd.CommandType = CommandType.Text;

                param = new SqlParameter("@un", SqlDbType.NVarChar);
                param.Value = Username;//(object)wpd.Temp ?? DBNull.Value;//wpd.Temp;
                cmd.Parameters.Add(param);

                param = new SqlParameter("@q1", SqlDbType.NVarChar);
                param.Value = q1;//(object)wpd.Temp ?? DBNull.Value;//wpd.Temp;
                cmd.Parameters.Add(param);

                param = new SqlParameter("@a1", SqlDbType.NVarChar);
                param.Value = a1;//(object)wpd.Temp ?? DBNull.Value;//wpd.Temp;
                cmd.Parameters.Add(param);

                param = new SqlParameter("@q2", SqlDbType.NVarChar);
                param.Value = q2;//(object)wpd.Temp ?? DBNull.Value;//wpd.Temp;
                cmd.Parameters.Add(param);

                param = new SqlParameter("@a2", SqlDbType.NVarChar);
                param.Value = a2;
                cmd.Parameters.Add(param);

                param = new SqlParameter("@q3", SqlDbType.NVarChar);
                param.Value = q3;
                cmd.Parameters.Add(param);

                param = new SqlParameter("@a3", SqlDbType.NVarChar);
                param.Value = a3;
                cmd.Parameters.Add(param);


                int rows = cmd.ExecuteNonQuery();
                conn.Close();
            }

           
        }
        public static bool IsvalidEmail(string textboxEmail)
        {
            try 
            { 
            MailAddress mail = new MailAddress(textboxEmail);
                return true;
            } 
            catch(Exception e)
            {
                return false;
            }

        }

        public bool ValidData(string username, string email, string connectionString)
        {
            var c = new SqlConnection(connectionString);
            var cmdUsername = new SqlCommand("SELECT COUNT(*) FROM Person WHERE UserName = @userName OR email = @email;", c);
            cmdUsername.Parameters.AddWithValue("userName", username);
            cmdUsername.CommandType = System.Data.CommandType.Text;
            cmdUsername.Parameters.AddWithValue("email", email);

            c.Open();
            try
            {
                return (int)cmdUsername.ExecuteScalar() > 0;
            }
            catch (Exception ex)
            {
                //log exception

                return false;
            }
            finally
            {
                c.Close();
            }
        }
    }
   
    }