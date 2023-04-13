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
                string sql = "SELECT  * FROM Account ";
                SqlCommand cmd = new SqlCommand(sql, _connection);
                _connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    myManager.AddExistingUser(new User(Convert.ToString(dr[1]), Convert.ToString(dr[2]), Convert.ToString(dr[3]), Convert.ToString(dr[4])));
                }

                dr.Close();
            }
            catch (SqlException sqlEx)
            {

                throw new Exception(sqlEx.Message);
            }
            finally { _connection.Close(); }
        }

        public void DeleteUser(User u) { }
        public void EditUser(User u, string name, string password) { }
        //-----------------------
        public void CreateUser(User user) 
        {
            SqlConnection _connection = db.GetSqlConnection();
            try
            {
                _connection.Open();
                string query = "INSERT INTO [User](FirstName, Username, PasswordHash, PasswordSalt, Role) " +
               "VALUES(@FirstName, @Username, CONVERT(varbinary, @PasswordHash), CONVERT(varbinary, @PasswordSalt), @Role)";

                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    command.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = user.FirstName;
                    command.Parameters.Add("@Username", SqlDbType.NVarChar).Value = user.Username;
                    command.Parameters.Add("@Role", SqlDbType.NVarChar).Value = user.UserRole;
                    command.Parameters.Add("@PasswordHash", SqlDbType.VarBinary, 20).Value = Convert.FromBase64String(user.PasswordHash);
                    command.Parameters.Add("@PasswordSalt", SqlDbType.VarBinary, 16).Value = Convert.FromBase64String(user.PasswordSalt);

                    command.ExecuteNonQuery();
                }


            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally { _connection.Close(); }

        }
    }
}
