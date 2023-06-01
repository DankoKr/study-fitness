using ClassLibrary.CommentClasses;
using ClassLibrary.ExerciseClasses;
using ClassLibrary.UserClasses;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibrary.DatabaseClasses
{
    public class CommentDAL : ICommentDAL
    {
        DatabaseRepo db = new DatabaseRepo();
        public void LoadComments(CommentAdministration myManager, int pageNumber, int pageSize, bool hasMoreRows) 
        {
            SqlConnection _connection = db.GetSqlConnection();

            try
            {
                string sql = "SELECT name, description, rating " +
                             "FROM Comment " +
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
                        myManager.AddExistingComment(new Comment(Convert.ToString(dr[0]), Convert.ToString(dr[1]), Convert.ToInt32(dr[2]))); 
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
        public void AddCommentExercise(Comment c, int userId, int exId) 
        {
            SqlConnection _connection = db.GetSqlConnection();

            try
            {
                string sql = $"INSERT INTO Comment (name, description, rating, user_id, exercise_id)\r\nVALUES ('{c.Title}', '{c.Description}','{c.Rating}', {userId}, {exId});";
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
        public void DeleteComment(Comment c) 
        {
            SqlConnection _connection = db.GetSqlConnection();

            try
            {
                string sql = $"DELETE FROM Comment\r\nWHERE name = '{c.Title}';";
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
        public void EditComment(Comment c, string description, int rating) 
        {
            SqlConnection _connection = db.GetSqlConnection();

            try
            {
                string sql = $"UPDATE Comment\r\nSET description = '{description}', rating = {rating}\r\nWHERE name = '{c.Title}';";
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
        public int GetExerciseId(string nameEx, int exId) 
        {
            SqlConnection _connection = db.GetSqlConnection();

            try
            {
                string sql = $"SELECT exercise_id\r\nFROM Exercise\r\nWHERE Name = '{nameEx}'";
                SqlCommand cmd = new SqlCommand(sql, _connection);
                _connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    exId = Convert.ToInt32(Convert.ToString(dr[0]));
                    return exId;
                }

                dr.Close();
            }
            catch (SqlException sqlEx)
            {

                throw new Exception(sqlEx.Message);
            }
            finally { _connection.Close(); }
            return exId;
        }
        public int GetUserId(string username, int userId)
        {
            SqlConnection _connection = db.GetSqlConnection();

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
        public int GetCardioId(string nameCardio, int cId)
        {
            SqlConnection _connection = db.GetSqlConnection();

            try
            {
                string sql = $"SELECT cardio_id\r\nFROM Cardio\r\nWHERE name = '{nameCardio}'";
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
        public void AddCommentCardio(Comment c, int userId, int cId)
        {
            SqlConnection _connection = db.GetSqlConnection();

            try
            {
                string sql = $"INSERT INTO Comment (name, description, rating, user_id, cardio_id)\r\nVALUES ('{c.Title}', '{c.Description}','{c.Rating}', {userId}, {cId});";
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
        public void GetExerciseComments(int exercise_id, CommentAdministration myManager, int pageNumber, int pageSize, bool hasMoreRows)
        {
            SqlConnection _connection = db.GetSqlConnection();

            try
            {
                string sql = $"SELECT name, description, rating FROM Comment WHERE exercise_id = {exercise_id} ORDER BY name OFFSET @offset ROWS FETCH NEXT @fetch ROWS ONLY";
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
                        myManager.AddExistingComment(new Comment(Convert.ToString(dr[0]), Convert.ToString(dr[1]), Convert.ToInt32(dr[2])));
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
        public void GetUserComments(int user_id, CommentAdministration myManager, int pageNumber, int pageSize, bool hasMoreRows)
        {
            SqlConnection _connection = db.GetSqlConnection();

            try
            {
                string sql = $"SELECT name, description, rating FROM Comment WHERE user_id = {user_id} ORDER BY name OFFSET @offset ROWS FETCH NEXT @fetch ROWS ONLY";
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
                        myManager.AddExistingComment(new Comment(Convert.ToString(dr[0]), Convert.ToString(dr[1]), Convert.ToInt32(dr[2])));
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
        public Comment GetComment(string title, Comment c) 
        {
            SqlConnection _connection = db.GetSqlConnection();

            try
            {
                string sql = $"SELECT  name, description, rating FROM Comment WHERE name = '{title}'";
                SqlCommand cmd = new SqlCommand(sql, _connection);
                _connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    c = new Comment(Convert.ToString(dr[0]), Convert.ToString(dr[1]), Convert.ToInt32(dr[2]));
                    return c;
                }

                dr.Close();
            }
            catch (SqlException sqlEx)
            {

                throw new Exception(sqlEx.Message);
            }
            finally { _connection.Close(); }
            return c;
        }
        public int GetCommentsByRating(int rating) 
        {
            SqlConnection _connection = db.GetSqlConnection();
            int numComments = 0;

            try
            {
                string sql = $"SELECT COUNT(*) FROM Comment WHERE rating = {rating}";
                SqlCommand cmd = new SqlCommand(sql, _connection);
                _connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    numComments = Convert.ToInt32(dr[0]);
                    return numComments;
                }

                dr.Close();
            }
            catch (SqlException sqlEx)
            {

                throw new Exception(sqlEx.Message);
            }
            finally { _connection.Close(); }
            return numComments;
        }
        public bool IsUnique(string name)
        {
            SqlConnection _connection = db.GetSqlConnection();
            bool isUnique = true;

            try
            {
                string sql = $"SELECT name FROM Comment WHERE name = '{name}'";
                SqlCommand cmd = new SqlCommand(sql, _connection);
                _connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    return isUnique = false;
                }

                dr.Close();
            }
            catch (SqlException sqlEx)
            {

                throw new Exception(sqlEx.Message);
            }
            finally { _connection.Close(); }
            return isUnique;
        }
    }
}
