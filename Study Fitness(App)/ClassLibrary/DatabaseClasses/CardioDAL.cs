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
        {
            SqlConnection _connection = db.GetSqlConnection();

            try
            {
                string sql = "SELECT  * FROM Cardio ";
                SqlCommand cmd = new SqlCommand(sql, _connection);
                _connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    myManager.AddExistingCardio(new Cardio(Convert.ToString(dr[1]), Convert.ToInt32(dr[2]), Convert.ToString(dr[3]), Convert.ToString(dr[4])));
                }

                dr.Close();
            }
            catch (SqlException sqlEx)
            {

                throw new Exception(sqlEx.Message);
            }
            finally { _connection.Close(); }
        }

        public void AddCardio(Cardio c) 
        {
			SqlConnection _connection = db.GetSqlConnection();

			try
			{
				string sql = $"INSERT INTO Cardio (name, calories, difficulty, pictureURL)\r\nVALUES ('{c.Name}', {c.Calories},'{c.Difficulty}', '{c.PictureURL}');";
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
        public void DeleteCardio(Cardio c) 
        {
			SqlConnection _connection = db.GetSqlConnection();

			try
			{
				string sql = $"DELETE FROM Cardio\r\nWHERE name = '{c.Name}';";
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
        public void EditCardio(Cardio c, string name, string difficulty, int calories, string picture) 
        {
			SqlConnection _connection = db.GetSqlConnection();

			try
			{
				string sql = $"UPDATE Cardio\r\nSET name = '{name}', difficulty = '{difficulty}', calories = {calories}, pictureURL = '{picture}'\r\nWHERE name = '{c.Name}';";
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
}
