using ClassLibrary.ExerciseClasses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibrary.DatabaseClasses
{
    public class MSSQL
    {
        private SqlConnection _connection;
        private string conncetion;
        private string server;
        private string database;
        private string user;
        private string password;

        public MSSQL()
        {
            server = "mssqlstud.fhict.local";
            database = "dbi500872";
            user = "dbi500872";
            password = "Danko2003";
            conncetion = $"Server = {server}; Database = {database}; User Id ={user}; Password = {password};";
            _connection = new SqlConnection(conncetion);
        }

        public SqlConnection GetSqlConnection()
        {
            return _connection;
        }
    }
}
