using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Website.Models;

namespace ClassLibrary
{
    public class DummyAdmin
    {
        public List<TestDummyData> myData;
        public DummyAdmin() 
        { 
            myData = new List<TestDummyData>();
            GetDummyData();
        }
        public void GetDummyData() 
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-EMSMO52\\SQLEXPRESS;Initial Catalog=TestSemester2;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * from MOCK_EMPLOYEE_DATA";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                TestDummyData data = new TestDummyData();
                                data.Id = reader.GetInt32(0);
                                data.FirstName = reader.GetString(1);
                                data.LastName = reader.GetString(2);
                                data.Email = reader.GetString(3);
                                data.Gender = reader.GetString(4);
                                data.Avatar = reader.GetString(5);
                                data.StreetName = reader.GetString(6);
                                data.StreetNumber = reader.GetString(7);
                                data.ZipCode = reader.GetString(8);
                                data.City = reader.GetString(9);
                                data.Country = reader.GetString(10);

                                myData.Add(data);
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public TestDummyData GetDummyId(int id)
        {
            return myData[id - 1];
        }
        public List<TestDummyData> GetEmployees()
        {
            return myData; 
        }
    }
}
