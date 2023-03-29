using ClassLibrary.UserClasses;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DatabaseClasses
{
    public class UserDAL
    {
        DBconfig db = new DBconfig();
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
                    myManager.AddUser(new User(Convert.ToString(dr[1]), Convert.ToString(dr[2]), Convert.ToString(dr[3]), Convert.ToString(dr[4])));
                }

                dr.Close();
            }
            catch (SqlException sqlEx)
            {

                throw new Exception(sqlEx.Message);
            }
            finally { _connection.Close(); }
        }
    }
}
