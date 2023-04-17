using ClassLibrary.UserClasses;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
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
                string sql = "SELECT FirstName, Username, PasswordHash, Role\r\nFROM Users";
                SqlCommand cmd = new SqlCommand(sql, _connection);
                _connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    myManager.AddExistingUser(new User(Convert.ToString(dr[0]), Convert.ToString(dr[1]), Convert.ToString(dr[2]), Convert.ToString(dr[3])));
                }

                dr.Close();
            }
            catch (SqlException sqlEx)
            {

                throw new Exception(sqlEx.Message);
            }
            finally { _connection.Close(); }
        }

        public void DeleteUser(User u) 
        {
            SqlConnection _connection = db.GetSqlConnection();

            try
            {
                string sql = $"DELETE FROM Users\r\nWHERE Username = '{u.Username}';";
                SqlCommand cmd = new SqlCommand(sql, _connection);
                _connection.Open();
                cmd.ExecuteNonQuery();

            }
            catch (SqlException sqlEx)
            {

                throw new Exception(sqlEx.Message);
            }
            finally { _connection.Close(); }
        }

        public void EditUser(User u, string name) 
        {
            SqlConnection _connection = db.GetSqlConnection();

            try
            {
                string sql = $"UPDATE Users\r\nSET Username = '{name}'\r\nWHERE Username = '{u.Username}';";
                SqlCommand cmd = new SqlCommand(sql, _connection);
                _connection.Open();
                cmd.ExecuteNonQuery();

            }
            catch (SqlException sqlEx)
            {

                throw new Exception(sqlEx.Message);
            }
            finally { _connection.Close(); }
        }


        public bool CreateUser(User user) 
        { 
            using (SqlConnection _connection = db.GetSqlConnection()) 
            {
                try
                {
                    _connection.Open();
                    string randomSalt = BCrypt.Net.BCrypt.GenerateSalt();
                    string hashedPassword = BCrypt.Net.BCrypt.HashPassword(user.Password, randomSalt); 
                    user.Password = hashedPassword;
                    string query = $"INSERT INTO Users(FirstName, Username, PasswordHash, Salt, Role) " + $"VALUES('{user.FirstName}', '{user.Username}', '{user.Password}', '{randomSalt}', '{user.UserRole}')";
                    using (SqlCommand command = new SqlCommand(query, _connection)) 
                    { 
                        command.ExecuteNonQuery(); 
                    }
                    return true; 
                } 
                catch (Exception) 
                { return false; }
                finally { _connection.Close(); }

            } 
        }

        public bool CheckLogin(string username, string password)
        {

            string connection = $"Server = mssqlstud.fhict.local; Database = dbi500872; User Id =dbi500872; Password = Danko2003;";
            using (SqlConnection _newConnection = new SqlConnection(connection))
            {
                try
                {
                    string salt = GetSalt(username);
                    string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password, salt);

                    _newConnection.Open();

                    string query = $"SELECT * FROM Users " + $"WHERE Username = '{username}' AND PasswordHash = '{hashedPassword}'";
                    using (SqlCommand command = new SqlCommand(query, _newConnection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read()) { return true; }
                            else { return false; }
                        }
                    }
                }
                catch (Exception)
                { return false; }
                finally { _newConnection.Close(); }
            }
        }


        public string GetSalt(string username)
        {
            using (SqlConnection _connection = db.GetSqlConnection())
            {
                try
                {
                    _connection.Open();
                    SqlCommand cmd = new SqlCommand("SELECT Salt FROM Users WHERE Username = @username", _connection);
                    cmd.Parameters.AddWithValue("@username", username);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        return reader.GetString("Salt");
                    }
                    return null;
                }
                catch (SqlException)
                { return null; }
            }
        }

        public void GetUserByUsername(UserAdministration myManager, string username) 
        {
            string connection = $"Server = mssqlstud.fhict.local; Database = dbi500872; User Id =dbi500872; Password = Danko2003;";
            SqlConnection _newConnection = new SqlConnection(connection);

            try
            {
                string sql = $"SELECT FirstName, Username, PasswordHash, Role\r\nFROM Users\r\nWHERE Username = '{username}'";
                SqlCommand cmd = new SqlCommand(sql, _newConnection);
                _newConnection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    myManager.AddExistingUser(new User(Convert.ToString(dr[0]), Convert.ToString(dr[1]), Convert.ToString(dr[2]), Convert.ToString(dr[3])));
                }

                dr.Close();
            }
            catch (SqlException sqlEx)
            {

                throw new Exception(sqlEx.Message);
            }
            finally { _newConnection.Close(); }
        }

    }
}
