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
    public class DatabaseRepo
    {       
        private SqlConnection _connection;

        public DatabaseRepo()
        {
            string connection = $"Server = mssqlstud.fhict.local; Database = dbi500872; User Id = dbi500872; Password = Danko2003;";
            this._connection = new SqlConnection(connection);
        }

        public SqlConnection GetSqlConnection()
        {
            return this._connection;
        }

    }
}


