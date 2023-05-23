using ClassLibrary.CardioClasses;
using ClassLibrary.CommentClasses;
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

        public void LoadSchedules(ScheduleAdministration myManager, int pageNumber, int pageSize, bool hasMoreRows)
        {
            SqlConnection _connection = db.GetSqlConnection();

            try
            {
                string sql = "SELECT * " +
                             "FROM Schedule " +
                             "ORDER BY title " +
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
                        if (dr[5] != null)
                        {
                            myManager.AddExistingSchedule(new Schedule(Convert.ToString(dr[1]), Convert.ToDateTime(dr[3]).Date, Convert.ToString(dr[2]), Convert.ToInt32(dr[4]), Convert.ToString(dr[5])));
                        }
                        else
                        {
                            myManager.AddExistingSchedule(new Schedule(Convert.ToString(dr[1]), Convert.ToDateTime(dr[3]).Date, Convert.ToString(dr[2]), Convert.ToInt32(dr[4])));
                        }
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
        public Dictionary<string, int> GetTrainersBookings()
        {
            SqlConnection _connection = db.GetSqlConnection();
            Dictionary<string, int> trainersBookings = new Dictionary<string, int>();

            try
            {
                string sql = $"SELECT u.FirstName, COUNT(*) AS schedule_count\r\nFROM Schedule s\r\nJOIN Users u ON s.trainer_id = u.Id\r\nWHERE s.client_name IS NOT NULL\r\nGROUP BY s.trainer_id, u.FirstName;";
                SqlCommand cmd = new SqlCommand(sql, _connection);
                _connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string trainerName = dr.GetString(0);
                    int scheduleCount = dr.GetInt32(1);
                    trainersBookings[trainerName] = scheduleCount;
                }
                dr.Close();
                return trainersBookings;
            }
            catch (SqlException sqlEx)
            {
                throw new Exception(sqlEx.Message);
            }
            finally { _connection.Close(); }
        }
        public int NumBookedSchedulesPerTrainerLevel(int level)
        {
            SqlConnection _connection = db.GetSqlConnection();
            int bookings = 0;

            try
            {
                string sql = $"SELECT U.TrainerLevel, COUNT(*) AS schedule_count\r\nFROM Schedule S\r\nJOIN Users U ON S.trainer_id = U.Id\r\nWHERE S.client_name IS NOT NULL AND U.TrainerLevel = {level}\r\nGROUP BY U.TrainerLevel\r\nORDER BY schedule_count DESC;";
                SqlCommand cmd = new SqlCommand(sql, _connection);
                _connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    bookings = Convert.ToInt32(dr[1]);
                    return bookings;
                }
                dr.Close();
                return bookings;
            }
            catch (SqlException sqlEx)
            {

                throw new Exception(sqlEx.Message);
            }
            finally { _connection.Close(); }
        }
    }
}
