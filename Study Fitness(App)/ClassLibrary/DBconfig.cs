using ClassLibrary.ExerciseClasses;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibrary
{
    public class DBconfig
    {
        private SqlConnection _connection;
        private string conncetion;
        private string server;
        private string database;
        private string user;
        private string password;

        public DBconfig()
        {
            this.server = "mssqlstud.fhict.local";
            this.database = "dbi500872";
            this.user = "dbi500872";
            this.password = "Danko2003";
            this.conncetion = $"Server = {server}; Database = {database}; User Id ={user}; Password = {password};";
            _connection = new SqlConnection(conncetion);
        }

        public void LoadExercises(ExerciseAdministration myManager)
        {
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
