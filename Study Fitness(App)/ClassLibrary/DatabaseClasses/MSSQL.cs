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
    public class MSSQL : IDBconfig
    {
        private SqlConnection _connection;
        private string connection;
        private string server;
        private string database;
        private string user;
        private string password;

        public MSSQL()
        {
            CreateConnection();
            _connection = new SqlConnection(connection);
        }

        public SqlConnection GetSqlConnection()
        {
            return _connection;
        }

        public void CreateConnection() 
        {
            server = "mssqlstud.fhict.local";
            database = "dbi500872";
            user = "dbi500872";
            password = "Danko2003";
            connection = $"Server = {server}; Database = {database}; User Id ={user}; Password = {password};";
        }

    }
}


