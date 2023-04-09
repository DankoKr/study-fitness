using ClassLibrary.UserClasses;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DatabaseClasses
{
    public class UserDAL
    {
        MSSQL db = new MSSQL();
        public void LoadUsers(UserAdministration myManager)
        {
            SqlConnection _connection = db.GetSqlConnection();

            try
            {
                string sql = "SELECT  * FROM Account ";
                SqlCommand cmd = new SqlCommand(sql, _connection);
                _connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    myManager.AddUserFromDatabase(new User(Convert.ToString(dr[1]), Convert.ToString(dr[2]), Convert.ToString(dr[3]), Convert.ToString(dr[4])));
                }

                dr.Close();
            }
            catch (SqlException sqlEx)
            {

                throw new Exception(sqlEx.Message);
            }
            finally { _connection.Close(); }
        }

        public void AddUser(User u) 
        {
            SqlConnection _connection = db.GetSqlConnection();
            string passwordToHash = u.Password;
            string hashedPassword = PasswordHash.HashPassword(passwordToHash);

            try
            {
                string query = "INSERT INTO Users (Username, HashedPassword, FirstName, Type) " +
                "VALUES (@Username, @HashedPassword, @FirstName, @Type)";

                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    command.Parameters.AddWithValue("@Username", u.Username);
                    command.Parameters.AddWithValue("@HashedPassword", hashedPassword);
                    command.Parameters.AddWithValue("@FirstName", u.FirstName);
                    command.Parameters.AddWithValue("@Type", u.Type);

                    _connection.Open();
                    command.ExecuteNonQuery();
                }

            }
            catch (SqlException sqlEx)
            {

                throw new Exception(sqlEx.Message);
            }
            finally { _connection.Close(); }
        }
        public void DeleteUser(User u) { }
        public void EditUser(User u, string name, string password) { }
    }
}
