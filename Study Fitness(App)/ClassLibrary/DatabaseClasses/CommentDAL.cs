using ClassLibrary.CommentClasses;
using ClassLibrary.ExerciseClasses;
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
        MSSQL db = new MSSQL();
        public void LoadComments(CommentAdministration myManager) 
        {
            SqlConnection _connection = db.GetSqlConnection();

            try
            {
                string sql = "SELECT  name, description, rating FROM Comment ";
                SqlCommand cmd = new SqlCommand(sql, _connection);
                _connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    myManager.AddExistingComment(new Comment(Convert.ToString(dr[0]), Convert.ToString(dr[1]), Convert.ToInt32(dr[2])));
                }

                dr.Close();
            }
            catch (SqlException sqlEx)
            {

                throw new Exception(sqlEx.Message);
            }
            finally { _connection.Close(); }
        }
        public void AddComment(Comment c, int userId) 
        {//Not fully implemented
            SqlConnection _connection = db.GetSqlConnection();

            try
            {
                string sql = $"INSERT INTO Comment (name, description, rating, user_id)\r\nVALUES ('{c.Title}', {c.Description},'{c.Rating}');";
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
        public void EditComment(Comment c, string title, string description, int rating) 
        {
            SqlConnection _connection = db.GetSqlConnection();

            try
            {
                string sql = $"UPDATE Comment\r\nSET name = '{title}', descrition = '{description}', rating = {rating}\r\nWHERE name = '{c.Title}';";
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
