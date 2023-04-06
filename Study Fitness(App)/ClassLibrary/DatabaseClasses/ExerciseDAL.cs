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
                string sql = ($"INSERT INTO Exercise (Name, Difficulty, Equipment, RepRange, Weight, PictureURL, Type)\r\nVALUES ('{exArm.Name}', '{exArm.Difficulty}', '{exArm.Equipment}', {exArm.RepRange}, {exArm.Weight}, '{exArm.PictureUrl}', 'ArmExercise');\r\n\r\nINSERT INTO ArmExercise (exercise_id, armElement)\r\nVALUES (SCOPE_IDENTITY(), '{exArm.ArmElemet}');");
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

            else if(ex is BackExercise)
            {
                BackExercise exBack = (BackExercise)ex;
                string sql = ($"INSERT INTO Exercise (Name, Difficulty, Equipment, RepRange, Weight, PictureURL, Type)\r\nVALUES ('{exBack.Name}', '{exBack.Difficulty}', '{exBack.Equipment}', {exBack.RepRange}, {exBack.Weight}, '{exBack.PictureUrl}', 'BackExercise');\r\n\r\nINSERT INTO BackExercise (exercise_id, backElement)\r\nVALUES (SCOPE_IDENTITY(), '{exBack.BackElemet}');");
                try
                {
                    SqlCommand cmd = new SqlCommand(sql, _connection);
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

            else if (ex is ChestExercise)
            {
                ChestExercise exChest = (ChestExercise)ex;
                string sql = ($"INSERT INTO Exercise (Name, Difficulty, Equipment, RepRange, Weight, PictureURL, Type)\r\nVALUES ('{exChest.Name}', '{exChest.Difficulty}', '{exChest.Equipment}', {exChest.RepRange}, {exChest.Weight}, '{exChest.PictureUrl}', 'ChestExercise');\r\n\r\nINSERT INTO BackExercise (exercise_id, backElement)\r\nVALUES (SCOPE_IDENTITY(), '{exChest.ChestElemet}');");
                try
                {
                    SqlCommand cmd = new SqlCommand(sql, _connection);
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

            else if (ex is LegsExercise)
            {
                LegsExercise exLegs = (LegsExercise)ex;
                string sql = ($"INSERT INTO Exercise (Name, Difficulty, Equipment, RepRange, Weight, PictureURL, Type)\r\nVALUES ('{exLegs.Name}', '{exLegs.Difficulty}', '{exLegs.Equipment}', {exLegs.RepRange}, {exLegs.Weight}, '{exLegs.PictureUrl}', 'LegsExercise');\r\n\r\nINSERT INTO BackExercise (exercise_id, backElement)\r\nVALUES (SCOPE_IDENTITY(), '{exLegs.Legs}');");
                try
                {
                    SqlCommand cmd = new SqlCommand(sql, _connection);
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

            else if (ex is ShoulderExercise)
            {
                ShoulderExercise exShoulder = (ShoulderExercise)ex;
                string sql = ($"INSERT INTO Exercise (Name, Difficulty, Equipment, RepRange, Weight, PictureURL, Type)\r\nVALUES ('{exShoulder.Name}', '{exShoulder.Difficulty}', '{exShoulder.Equipment}', {exShoulder.RepRange}, {exShoulder.Weight}, '{exShoulder.PictureUrl}', 'ShoulderExercise');\r\n\r\nINSERT INTO BackExercise (exercise_id, backElement)\r\nVALUES (SCOPE_IDENTITY(), '{exShoulder.ShoulderHead}');");
                try
                {
                    SqlCommand cmd = new SqlCommand(sql, _connection);
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

            else if (ex is NeckExercise)
            {
                NeckExercise exNeck = (NeckExercise)ex;
                string sql = ($"INSERT INTO Exercise (Name, Difficulty, Equipment, RepRange, Weight, PictureURL, Type)\r\nVALUES ('{exNeck.Name}', '{exNeck.Difficulty}', '{exNeck.Equipment}', {exNeck.RepRange}, {exNeck.Weight}, '{exNeck.PictureUrl}', 'NeckExercise');");
                try
                {
                    SqlCommand cmd = new SqlCommand(sql, _connection);
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

            else if (ex is CoreExercise)
            {
                CoreExercise exCore = (CoreExercise)ex;
                string sql = ($"INSERT INTO Exercise (Name, Difficulty, Equipment, RepRange, Weight, PictureURL, Type)\r\nVALUES ('{exCore.Name}', '{exCore.Difficulty}', '{exCore.Equipment}', {exCore.RepRange}, {exCore.Weight}, '{exCore.PictureUrl}', 'CoreExercise');");
                try
                {
                    SqlCommand cmd = new SqlCommand(sql, _connection);
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

        public void DeleteExercise(Exercise ex) 
        {//Needs to change
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

            else if (ex is BackExercise)
            {
                BackExercise exBack = (BackExercise)ex;
                string sql = (
               $"UPDATE Exercise\r\nSET RepRange = @reps, Difficulty = @difficulty, Weight = @weight\r\nWHERE Name = '{exBack.Name}';");
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

            else if (ex is ChestExercise)
            {
                ChestExercise exChest = (ChestExercise)ex;
                string sql = (
               $"UPDATE Exercise\r\nSET RepRange = @reps, Difficulty = @difficulty, Weight = @weight\r\nWHERE Name = '{exChest.Name}';");
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

            else if (ex is CoreExercise)
            {
                CoreExercise exCore = (CoreExercise)ex;
                string sql = (
               $"UPDATE Exercise\r\nSET RepRange = @reps, Difficulty = @difficulty, Weight = @weight\r\nWHERE Name = '{exCore.Name}';");
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

            else if (ex is LegsExercise)
            {
                LegsExercise exLegs = (LegsExercise)ex;
                string sql = (
               $"UPDATE Exercise\r\nSET RepRange = @reps, Difficulty = @difficulty, Weight = @weight\r\nWHERE Name = '{exLegs.Name}';");
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

            else if (ex is NeckExercise)
            {
                NeckExercise exNeck = (NeckExercise)ex;
                string sql = (
               $"UPDATE Exercise\r\nSET RepRange = @reps, Difficulty = @difficulty, Weight = @weight\r\nWHERE Name = '{exNeck.Name}';");
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

            else if (ex is ShoulderExercise)
            {
                ShoulderExercise exShoulder = (ShoulderExercise)ex;
                string sql = (
               $"UPDATE Exercise\r\nSET RepRange = @reps, Difficulty = @difficulty, Weight = @weight\r\nWHERE Name = '{exShoulder.Name}';");
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
                string sql6 = "SELECT Name, Difficulty, Equipment, RepRange, Weight, PictureURL\r\nFROM Exercise\r\nWHERE Type = 'NeckExercise'";
                string sql7 = "SELECT Name, Difficulty, Equipment, RepRange, Weight, PictureURL\r\nFROM Exercise\r\nWHERE Type = 'CoreExercise'";

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
                    myManager.AddFromDatabase(new ChestExercise(Convert.ToString(dr1[0]), Convert.ToString(dr1[1]), Convert.ToString(dr1[2]), Convert.ToInt32(dr1[3]), Convert.ToDouble(dr1[4]), Convert.ToString(dr1[6]), Convert.ToString(dr1[5])));
                }

                dr1.Close();
                dr1 = cmd2.ExecuteReader();

                while (dr1.Read())
                {
                    myManager.AddFromDatabase(new ArmExercise(Convert.ToString(dr1[0]), Convert.ToString(dr1[1]), Convert.ToString(dr1[2]), Convert.ToInt32(dr1[3]), Convert.ToDouble(dr1[4]), Convert.ToString(dr1[6]), Convert.ToString(dr1[5])));
                }

                dr1.Close();
                dr1 = cmd3.ExecuteReader();

                while (dr1.Read())
                {
                    myManager.AddFromDatabase(new ShoulderExercise(Convert.ToString(dr1[0]), Convert.ToString(dr1[1]), Convert.ToString(dr1[2]), Convert.ToInt32(dr1[3]), Convert.ToDouble(dr1[4]), Convert.ToString(dr1[6]), Convert.ToString(dr1[5])));
                }

                dr1.Close();
                dr1 = cmd4.ExecuteReader();

                while (dr1.Read())
                {
                    myManager.AddFromDatabase(new LegsExercise(Convert.ToString(dr1[0]), Convert.ToString(dr1[1]), Convert.ToString(dr1[2]), Convert.ToInt32(dr1[3]), Convert.ToDouble(dr1[4]), Convert.ToString(dr1[6]), Convert.ToString(dr1[5])));
                }

                dr1.Close();
                dr1 = cmd5.ExecuteReader();

                while (dr1.Read())
                {
                    myManager.AddFromDatabase(new BackExercise(Convert.ToString(dr1[0]), Convert.ToString(dr1[1]), Convert.ToString(dr1[2]), Convert.ToInt32(dr1[3]), Convert.ToDouble(dr1[4]), Convert.ToString(dr1[6]), Convert.ToString(dr1[5])));
                }

                dr1.Close();
                dr1 = cmd6.ExecuteReader();

                while (dr1.Read())
                {
                    myManager.AddFromDatabase(new NeckExercise(Convert.ToString(dr1[0]), Convert.ToString(dr1[1]), Convert.ToString(dr1[2]), Convert.ToInt32(dr1[3]), Convert.ToDouble(dr1[4]), Convert.ToString(dr1[5])));
                }

                dr1.Close();
                dr1 = cmd7.ExecuteReader();

                while (dr1.Read())
                {
                    myManager.AddFromDatabase(new CoreExercise(Convert.ToString(dr1[0]), Convert.ToString(dr1[1]), Convert.ToString(dr1[2]), Convert.ToInt32(dr1[3]), Convert.ToDouble(dr1[4]), Convert.ToString(dr1[5])));
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
