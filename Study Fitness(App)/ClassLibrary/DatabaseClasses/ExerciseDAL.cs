using ClassLibrary.ExerciseClasses;
using Study_Fitness_App_;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DatabaseClasses
{
    public class ExerciseDAL
    {
        DBconfig db = new DBconfig();

        public void AddExercise(Exercise ex) 
        {
            SqlConnection _connection = db.GetSqlConnection();
            if (ex is ArmExercise)
            {
                ArmExercise exArm = (ArmExercise)ex;
                string sql = (
             $"INSERT INTO Exercise (Name, Difficulty, Equipment, RepRange, Weight, PictureURL)\r\nVALUES ('{exArm.Name}', '{exArm.Difficulty}', '{exArm.Equipment}', {exArm.RepRange}, {exArm.Weight}, '{exArm.PictureUrl}')" +
             $"INSERT INTO ArmExercise (exercise_id, armElement, nameEx)\r\nVALUES (SCOPE_IDENTITY(), '{exArm.ArmElemet}', '{exArm.Name}');");
                try
                {
                    SqlCommand cmd = new SqlCommand(sql, _connection);
                    _connection.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException sqlEx)
                {
                    throw new Exception( sqlEx.Message );
                }
                finally
                {
                    _connection.Close();
                }
            }
        }

        public void DeleteExercise(Exercise ex) 
        {
            SqlConnection _connection = db.GetSqlConnection();
            if (ex is ArmExercise)
            {
                string sql = (
               $"DELETE FROM ArmExercise WHERE nameEx = '{ex.Name}';\r\nDELETE FROM Exercise WHERE Name = '{ex.Name}';" );
                try
                {
                    SqlCommand cmd = new SqlCommand(sql, _connection);
                    _connection.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException sqlEx)
                {
                    throw new Exception ( sqlEx.Message );
                }
                finally
                {
                    _connection.Close();
                }
            }
        }

        public void EditExercise(Exercise ex, string difficulty, int reps, double weight) 
        {
            SqlConnection _connection = db.GetSqlConnection();
            if (ex is ArmExercise)
            {
                ArmExercise exArm = (ArmExercise)ex;
                string sql = (
               $"UPDATE Exercise\r\nSET RepRange = @reps, Difficulty = @difficulty, Weight = @weight\r\nWHERE Name = '{exArm.Name}';");
                try
                {
                    SqlCommand cmd = new SqlCommand(sql, _connection);
                    cmd.Parameters.AddWithValue("@reps", reps);
                    cmd.Parameters.AddWithValue("@difficulty", difficulty);
                    cmd.Parameters.AddWithValue("@weight", weight);
                    _connection.Open();
                    cmd.ExecuteNonQuery();
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
        }
    }
}
