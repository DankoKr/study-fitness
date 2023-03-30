using ClassLibrary.ExerciseClasses;
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
        MSSQL db = new MSSQL();

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

        public void LoadExercises(ExerciseAdministration myManager)
        {
            SqlConnection _connection = db.GetSqlConnection();
            try
            {
                string sql1 = "SELECT  e.Name, e.Difficulty, e.Equipment, e.RepRange, e.Weight, e.PictureURL, ch.chestElement \r\nFROM Exercise e\r\nJOIN ChestExercise ch\r\non e.exercise_id = ch.exercise_id";
                string sql2 = "SELECT  e.Name, e.Difficulty, e.Equipment, e.RepRange, e.Weight, e.PictureURL, arm.armElement \r\nFROM Exercise e\r\nJOIN ArmExercise arm\r\non e.exercise_id = arm.exercise_id";
                string sql3 = "SELECT  e.Name, e.Difficulty, e.Equipment, e.RepRange, e.Weight, e.PictureURL, sh.shoulderHead \r\nFROM Exercise e\r\nJOIN ShoulderExercise sh\r\non e.exercise_id = sh.exercise_id";
                string sql4 = "SELECT  e.Name, e.Difficulty, e.Equipment, e.RepRange, e.Weight, e.PictureURL, l.legs\r\nFROM Exercise e\r\nJOIN LegsExercise l\r\non e.exercise_id = l.exercise_id";
                string sql5 = "SELECT  e.Name, e.Difficulty, e.Equipment, e.RepRange, e.Weight, e.PictureURL, b.backElement\r\nFROM Exercise e\r\nJOIN BackExercise b\r\non e.exercise_id = b.exercise_id";
                string sql6 = "SELECT  e.Name, e.Difficulty, e.Equipment, e.RepRange, e.Weight, e.PictureURL\r\nFROM Exercise e\r\nJOIN CoreExercise co\r\non e.exercise_id = co.exercise_id";
                string sql7 = "SELECT  e.Name, e.Difficulty, e.Equipment, e.RepRange, e.Weight, e.PictureURL\r\nFROM Exercise e\r\nJOIN NeckExercise n\r\non e.exercise_id = n.exercise_id";
                SqlCommand cmd1 = new SqlCommand(sql1, _connection);
                SqlCommand cmd2 = new SqlCommand(sql2, _connection);
                SqlCommand cmd3 = new SqlCommand(sql3, _connection);
                SqlCommand cmd4 = new SqlCommand(sql4, _connection);
                SqlCommand cmd5 = new SqlCommand(sql5, _connection);
                SqlCommand cmd6 = new SqlCommand(sql6, _connection);
                SqlCommand cmd7 = new SqlCommand(sql7, _connection);
                _connection.Open();
                SqlDataReader dr1 = cmd1.ExecuteReader();

                while (dr1.Read())
                {//                                            nameEx,               difficulty,                equipment,                     numReps,                weight,                         specialty,                   picture
                    myManager.AddExercise(new ChestExercise(Convert.ToString(dr1[0]), Convert.ToString(dr1[1]), Convert.ToString(dr1[2]), Convert.ToInt32(dr1[3]), Convert.ToDouble(dr1[4]), Convert.ToString(dr1[6]), Convert.ToString(dr1[5])));
                }

                dr1.Close();
                dr1 = cmd2.ExecuteReader();

                while (dr1.Read())
                {
                    myManager.AddExercise(new ArmExercise(Convert.ToString(dr1[0]), Convert.ToString(dr1[1]), Convert.ToString(dr1[2]), Convert.ToInt32(dr1[3]), Convert.ToDouble(dr1[4]), Convert.ToString(dr1[6]), Convert.ToString(dr1[5])));
                }

                dr1.Close();
                dr1 = cmd3.ExecuteReader();

                while (dr1.Read())
                {
                    myManager.AddExercise(new ShoulderExercise(Convert.ToString(dr1[0]), Convert.ToString(dr1[1]), Convert.ToString(dr1[2]), Convert.ToInt32(dr1[3]), Convert.ToDouble(dr1[4]), Convert.ToString(dr1[6]), Convert.ToString(dr1[5])));
                }

                dr1.Close();
                dr1 = cmd4.ExecuteReader();

                while (dr1.Read())
                {
                    myManager.AddExercise(new LegsExercise(Convert.ToString(dr1[0]), Convert.ToString(dr1[1]), Convert.ToString(dr1[2]), Convert.ToInt32(dr1[3]), Convert.ToDouble(dr1[4]), Convert.ToString(dr1[6]), Convert.ToString(dr1[5])));
                }

                dr1.Close();
                dr1 = cmd5.ExecuteReader();

                while (dr1.Read())
                {
                    myManager.AddExercise(new BackExercise(Convert.ToString(dr1[0]), Convert.ToString(dr1[1]), Convert.ToString(dr1[2]), Convert.ToInt32(dr1[3]), Convert.ToDouble(dr1[4]), Convert.ToString(dr1[6]), Convert.ToString(dr1[5])));
                }

                dr1.Close();
                dr1 = cmd6.ExecuteReader();

                while (dr1.Read())
                {
                    myManager.AddExercise(new CoreExercise(Convert.ToString(dr1[0]), Convert.ToString(dr1[1]), Convert.ToString(dr1[2]), Convert.ToInt32(dr1[3]), Convert.ToDouble(dr1[4]), Convert.ToString(dr1[5])));
                }

                dr1.Close();
                dr1 = cmd7.ExecuteReader();

                while (dr1.Read())
                {
                    myManager.AddExercise(new NeckExercise(Convert.ToString(dr1[0]), Convert.ToString(dr1[1]), Convert.ToString(dr1[2]), Convert.ToInt32(dr1[3]), Convert.ToDouble(dr1[4]), Convert.ToString(dr1[5])));
                }

                dr1.Close();

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
