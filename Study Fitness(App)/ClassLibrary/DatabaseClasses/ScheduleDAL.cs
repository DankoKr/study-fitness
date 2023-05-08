using ClassLibrary.ScheduleClasses;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void LoadSchedules(ScheduleAdministration myManager)
        {
            throw new NotImplementedException();
        }

        public void RemoveSchedule(Schedule s)
        {
            throw new NotImplementedException();
        }

        public void UpdateSchedule(Schedule s, string trainerName, string title, int time, string description)
        {
            throw new NotImplementedException();
        }
    }
}
