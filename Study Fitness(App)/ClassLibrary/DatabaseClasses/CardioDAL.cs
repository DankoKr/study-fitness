using ClassLibrary.CardioClasses;
using ClassLibrary.CommentClasses;
using ClassLibrary.UserClasses;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DatabaseClasses
{
    public class CardioDAL : ICardioDAL
    {
        DatabaseRepo db = new DatabaseRepo();

        public void LoadCardios(CardioAdministration myManager, int pageNumber, int pageSize, bool hasMoreRows)
        {
            SqlConnection _connection = db.GetSqlConnection();

            try
            {
                string sql = "SELECT * " +
                             "FROM Cardio " +
                             "ORDER BY name " +
                             "OFFSET @offset ROWS FETCH NEXT @fetch ROWS ONLY;";

                SqlCommand cmd = new SqlCommand(sql, _connection);

                cmd.Parameters.AddWithValue("@offset", (pageNumber - 1) * pageSize);
                cmd.Parameters.AddWithValue("@fetch", pageSize);

                _connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                int rowCount = 0;

                while (dr.Read())
                {
                    rowCount++;
                    if (rowCount <= pageSize)
                    {
                        myManager.AddExistingCardio(new Cardio(Convert.ToString(dr[1]), Convert.ToInt32(dr[2]), Convert.ToString(dr[3]), Convert.ToString(dr[4])));
                    }
                }

                hasMoreRows = rowCount > pageSize;
                dr.Close();

            }
            catch (SqlException sqlEx)
            {
                throw new Exception(sqlEx.Message);
            }
            finally
            {
                _connection.Close();
            }
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
            int cId = CardioId(c.Name);

			try
			{
				string sql = (
                    $"DELETE Comment\r\nFROM Comment\r\nWHERE cardio_id = {cId}" +
                    $"DELETE FROM Cardio\r\nWHERE name = '{c.Name}';");
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

        public int CardioId(string name)
        {
            SqlConnection _connection = db.GetSqlConnection();
            int cId = 0;

            try
            {
                string sql = $"SELECT cardio_id\r\nFROM Cardio\r\nWHERE name = '{name}'";
                SqlCommand cmd = new SqlCommand(sql, _connection);
                _connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    cId = Convert.ToInt32(Convert.ToString(dr[0]));
                    return cId;
                }

                dr.Close();
            }
            catch (SqlException sqlEx)
            {

                throw new Exception(sqlEx.Message);
            }
            finally { _connection.Close(); }
            return cId;
        }
    }
}
