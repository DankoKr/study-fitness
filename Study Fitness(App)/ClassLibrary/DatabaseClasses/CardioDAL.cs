using ClassLibrary.ExerciseClasses;
using ClassLibrary.UserClasses;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DatabaseClasses
{
    public class CardioDAL
    {
        MSSQL db = new MSSQL();

        public void LoadCardios(CardioAdministration myManager)
        {//Cardio db not created
            SqlConnection _connection = db.GetSqlConnection();

            try
            {
                string sql = "SELECT  * FROM Cardio ";
                SqlCommand cmd = new SqlCommand(sql, _connection);
                _connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    myManager.AddCardio(Convert.ToString(dr[1]), Convert.ToInt32(dr[2]), Convert.ToString(dr[3]), Convert.ToString(dr[4]));
                }

                dr.Close();
            }
            catch (SqlException sqlEx)
            {

                throw new Exception(sqlEx.Message);
            }
            finally { _connection.Close(); }
        }

        public void AddCardio(Cardio c) { }
        public void DeleteCardio(Cardio c) { }
        public void EditCardio(Cardio c, string difficulty, int calories) { }
    }
}
