using ClassLibrary.CardioClasses;
using ClassLibrary.ScheduleClasses;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibrary.DatabaseClasses
{
    public class ScheduleDAL : IScheduleDAL
    {
        DatabaseRepo db = new DatabaseRepo();
        public void AddSchedule(Schedule s)
        {
            SqlConnection _connection = db.GetSqlConnection();

            try
            {
                string sql = $"INSERT INTO Schedule (title, description, date, trainer_id)"
                    + "VALUES (@title, @description, @date , @trainer_id)";
                SqlCommand cmd = new SqlCommand(sql, _connection);
                _connection.Open();
                cmd.Parameters.AddWithValue("@title", s.Title);
                cmd.Parameters.AddWithValue("@description", s.Description);
                cmd.Parameters.AddWithValue("@date", s.Date.Date);
                cmd.Parameters.AddWithValue("@trainer_id", s.TrainerId);
                cmd.ExecuteNonQuery();

            }
            catch (SqlException sqlEx)
            {

                throw new Exception(sqlEx.Message);
            }
            finally { _connection.Close(); }
        }

        public void AssignSchedule(Schedule s, string name)
        {
            SqlConnection _connection = db.GetSqlConnection();

            try
            {
                string sql = $"UPDATE Schedule SET client_name = @client_name WHERE title = '{s.Title}'";

                SqlCommand cmd = new SqlCommand(sql, _connection);
                _connection.Open();
                cmd.Parameters.AddWithValue("@client_name", name);
                cmd.ExecuteNonQuery();

            }
            catch (SqlException sqlEx)
            {

                throw new Exception(sqlEx.Message);
            }
            finally { _connection.Close(); }
        }

        public void GetTrainersId(List<int> ids)
        {
            SqlConnection _connection = db.GetSqlConnection();

            try
            {
                string sql = "SELECT  Id FROM Users WHERE Role = 'Trainer'";
                SqlCommand cmd = new SqlCommand(sql, _connection);
                _connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ids.Add(Convert.ToInt32(dr[0]));                   
                }

                dr.Close();
            }
            catch (SqlException sqlEx)
            {

                throw new Exception(sqlEx.Message);
            }
            finally { _connection.Close(); }
        }

        public void LoadSchedules(ScheduleAdministration myManager)
        {
            SqlConnection _connection = db.GetSqlConnection();

            try
            {
                string sql = "SELECT  * FROM Schedule ";
                SqlCommand cmd = new SqlCommand(sql, _connection);
                _connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr[5] != null)
                    {
                        myManager.AddExistingSchedule(new Schedule(Convert.ToString(dr[1]), Convert.ToDateTime(dr[3]).Date, Convert.ToString(dr[2]), Convert.ToInt32(dr[4]), Convert.ToString(dr[5])));
                    }
                    else
                    {
                        myManager.AddExistingSchedule(new Schedule(Convert.ToString(dr[1]), Convert.ToDateTime(dr[3]).Date, Convert.ToString(dr[2]), Convert.ToInt32(dr[4])));
                    }
                }

                dr.Close();
            }
            catch (SqlException sqlEx)
            {

                throw new Exception(sqlEx.Message);
            }
            finally { _connection.Close(); }
        }

        public void LoadSchedulesTrainerLevel(int level, ScheduleAdministration myManager)
        {
            SqlConnection _connection = db.GetSqlConnection();

            try
            {
                string sql = $"SELECT s.title, s.description, s.date, s.trainer_id, s.client_name, u.Trainerlevel \r\nFROM Schedule s\r\nJOIN Users u\r\nON s.trainer_id = u.Id\r\nWHERE u.TrainerLevel = {level}";
                SqlCommand cmd = new SqlCommand(sql, _connection);
                _connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr[4] != null)
                    {
                        myManager.AddExistingSchedule(new Schedule(Convert.ToString(dr[0]), Convert.ToDateTime(dr[2]).Date, Convert.ToString(dr[1]), Convert.ToInt32(dr[3]), Convert.ToString(dr[4])));
                    }
                    else
                    {
                        myManager.AddExistingSchedule(new Schedule(Convert.ToString(dr[0]), Convert.ToDateTime(dr[2]).Date, Convert.ToString(dr[1]), Convert.ToInt32(dr[3])));
                    }
                }

                dr.Close();
            }
            catch (SqlException sqlEx)
            {

                throw new Exception(sqlEx.Message);
            }
            finally { _connection.Close(); }
        }

        public void LoadTrainerSchedules(int trainer_id, List<Schedule> schedules)
        {
            SqlConnection _connection = db.GetSqlConnection();

            try
            {
                string sql = $"SELECT s.title, s.description, s.date, s.trainer_id, s.client_name, u.Trainerlevel \r\nFROM Schedule s\r\nJOIN Users u\r\nON s.trainer_id = u.Id\r\nWHERE u.Id = {trainer_id}";
                SqlCommand cmd = new SqlCommand(sql, _connection);
                _connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr[4] != null)
                    {
                        schedules.Add(new Schedule(Convert.ToString(dr[0]), Convert.ToDateTime(dr[2]).Date, Convert.ToString(dr[1]), Convert.ToInt32(dr[3]), Convert.ToString(dr[4])));
                    }
                    else
                    {
                        schedules.Add(new Schedule(Convert.ToString(dr[0]), Convert.ToDateTime(dr[2]).Date, Convert.ToString(dr[1]), Convert.ToInt32(dr[3])));
                    }
                }

                dr.Close();
            }
            catch (SqlException sqlEx)
            {

                throw new Exception(sqlEx.Message);
            }
            finally { _connection.Close(); }
        }

        public void RemoveSchedule(Schedule s)
        {
            SqlConnection _connection = db.GetSqlConnection();

            try
            {
                string sql = $"DELETE FROM Schedule\r\nWHERE title = '{s.Title}';";
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

        public void UpdateSchedule(Schedule s, int trainerId, string title, DateTime time, string description)
        {
            SqlConnection _connection = db.GetSqlConnection();

            try
            {
                string sql = "UPDATE Schedule SET title = @title, description = @description, date = @date, trainer_id = @trainer_id WHERE title = @titleSchedule";
                SqlCommand cmd = new SqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@date", time.Date);
                cmd.Parameters.AddWithValue("@trainer_id", trainerId);
                cmd.Parameters.AddWithValue("@titleSchedule", s.Title);
                _connection.Open();
                cmd.ExecuteNonQuery();

            }
            catch (SqlException sqlEx)
            {

                throw new Exception(sqlEx.Message);
            }
            finally { _connection.Close(); }
        }
        public void UnAssignSchedule(Schedule s)
        {
            SqlConnection _connection = db.GetSqlConnection();

            try
            {
                string sql = $"UPDATE Schedule SET client_name = NULL WHERE title = '{s.Title}'";

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

        public void LoadUserBookings(ScheduleAdministration myManager, string username)
        {
            SqlConnection _connection = db.GetSqlConnection();

            try
            {
                string sql = $"SELECT * \r\nFROM Schedule\r\nWHERE client_name = '{username}'";
                SqlCommand cmd = new SqlCommand(sql, _connection);
                _connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr[5] != null)
                    {
                        myManager.AddExistingSchedule(new Schedule(Convert.ToString(dr[1]), Convert.ToDateTime(dr[3]).Date, Convert.ToString(dr[2]), Convert.ToInt32(dr[4]), Convert.ToString(dr[5])));
                    }
                }

                dr.Close();
            }
            catch (SqlException sqlEx)
            {

                throw new Exception(sqlEx.Message);
            }
            finally { _connection.Close(); }
        }

        public int GetTotalUserBookings(string name)
        {
            SqlConnection _connection = db.GetSqlConnection();
            int counter = 0;

            try
            {
                string sql = $"SELECT COUNT(*) \r\nFROM Schedule s\r\nJOIN Users u ON u.Id = s.trainer_id\r\nWHERE client_name = '{name}';";
                SqlCommand cmd = new SqlCommand(sql, _connection);
                _connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    counter = Convert.ToInt32(dr[0]);
                    return counter;
                }
                dr.Close();
                return counter;
            }
            catch (SqlException sqlEx)
            {

                throw new Exception(sqlEx.Message);
            }
            finally { _connection.Close(); }
        }
        public bool IsDublicatedScheduleTime(DateTime date, string username) 
        {
            SqlConnection _connection = db.GetSqlConnection();

            try
            {
                string sql = $"SELECT COUNT(*) FROM Schedule WHERE [date] = @date AND client_name = @username";
                SqlCommand cmd = new SqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@date", date.Date);
                cmd.Parameters.AddWithValue("@username", username);
                _connection.Open();
                int count = (int)cmd.ExecuteScalar();
                _connection.Close();

                if (count != 0)
                {
                    return true;
                }
                return false;


            }
            catch (SqlException sqlEx)
            {

                throw new Exception(sqlEx.Message);
            }
            finally { _connection.Close(); }
        }
        public string MostBookedTrainer() 
        {
            SqlConnection _connection = db.GetSqlConnection();
            string trainerName = "";

            try
            {
                string sql = $"SELECT TOP 1 u.FirstName, COUNT(*) AS schedule_count\r\nFROM Schedule s\r\nJOIN Users u ON s.trainer_id = u.Id\r\nWHERE s.client_name IS NOT NULL\r\nGROUP BY s.trainer_id, u.FirstName\r\nORDER BY schedule_count DESC;";
                SqlCommand cmd = new SqlCommand(sql, _connection);
                _connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    trainerName = Convert.ToString(dr[0]);
                    trainerName += " - ";
                    trainerName += Convert.ToString(dr[1]);
                    return trainerName;
                }
                dr.Close();
                return trainerName;
            }
            catch (SqlException sqlEx)
            {

                throw new Exception(sqlEx.Message);
            }
            finally { _connection.Close(); }
        }
    }
}
