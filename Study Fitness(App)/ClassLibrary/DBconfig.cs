using ClassLibrary.ExerciseClasses;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
//using Website.Models;

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
                string sql1 = "SELECT * FROM Exercise;";
                string sql2 = "SELECT * FROM BackExercise;";
                //string sql3 = "SELECT * FROM Omnivore;";
                SqlCommand cmd1 = new SqlCommand(sql1, _connection);
                SqlCommand cmd2 = new SqlCommand(sql2, _connection);
                //SqlCommand cmd3 = new SqlCommand(sql3, _connection);
                _connection.Open();
                SqlDataReader dr1 = cmd1.ExecuteReader();

                while (dr1.Read())
                {//ChestExercise(                                      nameEx,               difficulty,                equipment,                     numReps,                weight,              specialty,         picture)
                    myManager.AddExercise(new ChestExercise(Convert.ToString(dr1[1]), Convert.ToString(dr1[2]), Convert.ToString(dr1[3]), Convert.ToInt32(dr1[4]), Convert.ToDouble(dr1[5]), "specialty", Convert.ToString(dr1[6])));
                }

                dr1.Close();
                //dr1 = cmd2.ExecuteReader();

                //while (dr1.Read())
                //{
                //    myManager.AddExercise(new BackExercise(Convert.ToString(dr1[1]), Convert.ToString(dr1[2]), Convert.ToString(dr1[3]), Convert.ToInt32(dr1[4]), Convert.ToDouble(dr1[5]), "specialty", Convert.ToString(dr1[6])));
                //}

                //dr1.Close();

            }
            catch (Exception EX)
            {

            }
            finally
            {
                _connection.Close();
            }
        }

    }
}
