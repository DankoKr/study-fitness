using ClassLibrary.ExerciseClasses;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DatabaseClasses
{
    public class ExerciseDAL : IExerciseDAL
    {
        DatabaseRepo db = new DatabaseRepo();

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
                string sql = ($"INSERT INTO Exercise (Name, Difficulty, Equipment, RepRange, Weight, PictureURL, Type)\r\nVALUES ('{exLegs.Name}', '{exLegs.Difficulty}', '{exLegs.Equipment}', {exLegs.RepRange}, {exLegs.Weight}, '{exLegs.PictureUrl}', 'LegsExercise');\r\n\r\nINSERT INTO LegsExercise (exercise_id, legs)\r\nVALUES (SCOPE_IDENTITY(), '{exLegs.Legs}');");
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
                string sql = ($"INSERT INTO Exercise (Name, Difficulty, Equipment, RepRange, Weight, PictureURL, Type)\r\nVALUES ('{exShoulder.Name}', '{exShoulder.Difficulty}', '{exShoulder.Equipment}', {exShoulder.RepRange}, {exShoulder.Weight}, '{exShoulder.PictureUrl}', 'ShoulderExercise');\r\n\r\nINSERT INTO ShoulderExercise (exercise_id, shoulderHead)\r\nVALUES (SCOPE_IDENTITY(), '{exShoulder.ShoulderHead}');");
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
        {
            SqlConnection _connection = db.GetSqlConnection();
            if (ex is ArmExercise)
            {
				ArmExercise exArm = (ArmExercise)ex;
                int exId = ExerciseId(exArm.Name);
                string sql = (
                $"DELETE Comment\r\nFROM Comment\r\nWHERE exercise_id = {exId}" +
               $"DELETE FROM ArmExercise\r\nWHERE exercise_id IN (\r\n    SELECT exercise_id\r\n    FROM Exercise\r\n    WHERE Name = '{exArm.Name}'\r\n);\r\n\r\nDELETE FROM Exercise\r\nWHERE Name = '{exArm.Name}';" );
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

			else if (ex is BackExercise)
			{
				BackExercise exBack = (BackExercise)ex;
                int exId = ExerciseId(exBack.Name);
                string sql = (
                $"DELETE Comment\r\nFROM Comment\r\nWHERE exercise_id = {exId}" +
               $"DELETE FROM BackExercise\r\nWHERE exercise_id IN (\r\n    SELECT exercise_id\r\n    FROM Exercise\r\n    WHERE Name = '{exBack.Name}'\r\n);\r\n\r\nDELETE FROM Exercise\r\nWHERE Name = '{exBack.Name}';");
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
                int exId = ExerciseId(exChest.Name);
                string sql = (
                $"DELETE Comment\r\nFROM Comment\r\nWHERE exercise_id = {exId}" +
               $"DELETE FROM ChestExercise\r\nWHERE exercise_id IN (\r\n    SELECT exercise_id\r\n    FROM Exercise\r\n    WHERE Name = '{exChest.Name}'\r\n);\r\n\r\nDELETE FROM Exercise\r\nWHERE Name = '{exChest.Name}';");
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
                int exId = ExerciseId(exLegs.Name);
                string sql = (
                $"DELETE Comment\r\nFROM Comment\r\nWHERE exercise_id = {exId}" +
               $"DELETE FROM LegsExercise\r\nWHERE exercise_id IN (\r\n    SELECT exercise_id\r\n    FROM Exercise\r\n    WHERE Name = '{exLegs.Name}'\r\n);\r\n\r\nDELETE FROM Exercise\r\nWHERE Name = '{exLegs.Name}';");
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
                int exId = ExerciseId(exShoulder.Name);
                string sql = (
                $"DELETE Comment\r\nFROM Comment\r\nWHERE exercise_id = {exId}" +
               $"DELETE FROM ShoulderExercise\r\nWHERE exercise_id IN (\r\n    SELECT exercise_id\r\n    FROM Exercise\r\n    WHERE Name = '{exShoulder.Name}'\r\n);\r\n\r\nDELETE FROM Exercise\r\nWHERE Name = '{exShoulder.Name}';");
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
                int exId = ExerciseId(exNeck.Name);
                string sql = (
                $"DELETE Comment\r\nFROM Comment\r\nWHERE exercise_id = {exId}" +
               $"DELETE Exercise\r\nFROM Exercise\r\nWHERE Name = '{exNeck.Name}';");
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
                int exId = ExerciseId(exCore.Name);
				string sql = (
                $"DELETE Comment\r\nFROM Comment\r\nWHERE exercise_id = {exId}" +
			    $"DELETE Exercise\r\nFROM Exercise\r\nWHERE Name = '{exCore.Name}';");
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

        public int ExerciseId(string name)
        {
            SqlConnection _connection = db.GetSqlConnection();
            int exId = 0;

            try
            {
                string sql = $"SELECT exercise_id\r\nFROM Exercise\r\nWHERE Name = '{name}'";
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

        public bool isUnique(string name)
        {
            SqlConnection _connection = db.GetSqlConnection();
            bool isUnique = true;

            try
            {
                string sql = $"SELECT Name FROM Exercise WHERE Name = '{name}'";
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

        public void LoadExercises(ExerciseAdministration myManager, int pageNumber, int pageSize, bool hasMoreRows)
        {
            SqlConnection _connection = db.GetSqlConnection();
            try
            {
                string sql = @"
            SELECT Name, Difficulty, Equipment, RepRange, Weight, PictureURL, SpecialElement, ExerciseType
            FROM (
                SELECT e.Name, e.Difficulty, e.Equipment, e.RepRange, e.Weight, e.PictureURL, ch.chestElement as SpecialElement, 'ChestExercise' as ExerciseType
                FROM Exercise e
                JOIN ChestExercise ch on e.exercise_id = ch.exercise_id

                UNION ALL

                SELECT e.Name, e.Difficulty, e.Equipment, e.RepRange, e.Weight, e.PictureURL, arm.armElement, 'ArmExercise'
                FROM Exercise e
                JOIN ArmExercise arm on e.exercise_id = arm.exercise_id

                UNION ALL

                SELECT e.Name, e.Difficulty, e.Equipment, e.RepRange, e.Weight, e.PictureURL, sh.shoulderHead, 'ShoulderExercise'
                FROM Exercise e
                JOIN ShoulderExercise sh on e.exercise_id = sh.exercise_id

                UNION ALL

                SELECT e.Name, e.Difficulty, e.Equipment, e.RepRange, e.Weight, e.PictureURL, l.legs, 'LegsExercise'
                FROM Exercise e
                JOIN LegsExercise l on e.exercise_id = l.exercise_id

                UNION ALL

                SELECT e.Name, e.Difficulty, e.Equipment, e.RepRange, e.Weight, e.PictureURL, b.backElement, 'BackExercise'
                FROM Exercise e
                JOIN BackExercise b on e.exercise_id = b.exercise_id

                UNION ALL

                SELECT Name, Difficulty, Equipment, RepRange, Weight, PictureURL, NULL, 'NeckExercise'
                FROM Exercise
                WHERE Type = 'NeckExercise'

                UNION ALL

                SELECT Name, Difficulty, Equipment, RepRange, Weight, PictureURL, NULL, 'CoreExercise'
                FROM Exercise
                WHERE Type = 'CoreExercise'
            ) AS AllExercises
            ORDER BY Name
            OFFSET @offset ROWS FETCH NEXT @pageSize ROWS ONLY;
        ";

                int offset = (pageNumber - 1) * pageSize;

                using (SqlCommand cmd = new SqlCommand(sql, _connection))
                {
                    cmd.Parameters.AddWithValue("@offset", offset);
                    cmd.Parameters.AddWithValue("@pageSize", pageSize);

                    _connection.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            string name = Convert.ToString(dr[0]);
                            string difficulty = Convert.ToString(dr[1]);
                            string equipment = Convert.ToString(dr[2]);
                            int numReps = Convert.ToInt32(dr[3]);
                            double weight = Convert.ToDouble(dr[4]);
                            string picture = Convert.ToString(dr[5]);
                            string specialElement = Convert.ToString(dr[6]);
                            string exerciseType = Convert.ToString(dr[7]);

                            switch (exerciseType)
                            {
                                case "ChestExercise":
                                    myManager.AddExistingEx(new ChestExercise(name, difficulty, equipment, numReps, weight, specialElement, picture));
                                    break;
                                case "ArmExercise":
                                    myManager.AddExistingEx(new ArmExercise(name, difficulty, equipment, numReps, weight, specialElement, picture));
                                    break;
                                case "ShoulderExercise":
                                    myManager.AddExistingEx(new ShoulderExercise(name, difficulty, equipment, numReps, weight, specialElement, picture));
                                    break;
                                case "LegsExercise":
                                    myManager.AddExistingEx(new LegsExercise(name, difficulty, equipment, numReps, weight, specialElement, picture));
                                    break;
                                case "BackExercise":
                                    myManager.AddExistingEx(new BackExercise(name, difficulty, equipment, numReps, weight, specialElement, picture));
                                    break;
                                case "NeckExercise":
                                    myManager.AddExistingEx(new NeckExercise(name, difficulty, equipment, numReps, weight, picture));
                                    break;
                                case "CoreExercise":
                                    myManager.AddExistingEx(new CoreExercise(name, difficulty, equipment, numReps, weight, picture));
                                    break;
                            }
                        }
                    }
                }
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
