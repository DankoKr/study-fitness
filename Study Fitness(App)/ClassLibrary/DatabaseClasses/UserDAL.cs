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
using System.Xml.Linq;

namespace ClassLibrary.DatabaseClasses
{
    public class UserDAL : IUserDAL
    {
        DatabaseRepo db = new DatabaseRepo();
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
            int userId = UserId(u.Username);

            try
            {
                string sql = (
                    $"DELETE Comment\r\nFROM Comment\r\nWHERE user_id = {userId}" +
                    $"UPDATE Schedule SET client_name = NULL WHERE client_name = '{u.FirstName}'" +
                    $"DELETE Schedule\r\nFROM Schedule\r\nWHERE trainer_id = {userId}" +
                    $"DELETE FROM Users\r\nWHERE Username = '{u.Username}';");
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
			DatabaseRepo db = new DatabaseRepo();
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
            DatabaseRepo db = new DatabaseRepo();
            
            using (SqlConnection _newConnection = db.GetSqlConnection())
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
            DatabaseRepo db = new DatabaseRepo();
            SqlConnection _newConnection = db.GetSqlConnection();

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

        public void EditUserFirstName(User u, string newFirstName) 
        {
            using (SqlConnection _connection = db.GetSqlConnection())
            {
                try
                {
                    string sql = $"UPDATE Users\r\nSET FirstName = '{newFirstName}'\r\nWHERE Username = '{u.Username}';";
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

        }

        public void GetTrainerNameByPoints(int points, List<string> trainers) 
        {
            SqlConnection _connection = db.GetSqlConnection();

            try
            {
                string sql = $"SELECT FirstName\r\nFROM Users\r\nWHERE TrainerLevel = {points};";
                SqlCommand cmd = new SqlCommand(sql, _connection);
                _connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    trainers.Add(Convert.ToString(dr[0]));
                }

                dr.Close();
            }
            catch (SqlException sqlEx)
            {

                throw new Exception(sqlEx.Message);
            }
            finally { _connection.Close(); }
        }

        public void SetTrainerLevel(string trainerUsername, int level)
        {
            using (SqlConnection _connection = db.GetSqlConnection())
            {
                try
                {
                    string sql = $"UPDATE Users\r\nSET TrainerLevel = '{level}'\r\nWHERE Username = '{trainerUsername}';";
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
        }

        public int UserId(string username)
        {
            SqlConnection _connection = db.GetSqlConnection();
            int userId = 0;

            try
            {
                string sql = $"SELECT Id\r\nFROM Users\r\nWHERE Username = '{username}'";
                SqlCommand cmd = new SqlCommand(sql, _connection);
                _connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    userId = Convert.ToInt32(Convert.ToString(dr[0]));
                    return userId;
                }

                dr.Close();
            }
            catch (SqlException sqlEx)
            {

                throw new Exception(sqlEx.Message);
            }
            finally { _connection.Close(); }
            return userId;
        }
    }
}
