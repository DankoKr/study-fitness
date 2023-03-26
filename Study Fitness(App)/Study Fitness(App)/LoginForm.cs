using ClassLibrary.DatabaseClasses;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Study_Fitness_App_
{
    public partial class LoginForm : Form
    {
        DBconfig db = new DBconfig();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection _connection = db.GetSqlConnection();
            try
            {               
                string sql = "SELECT * FROM Account WHERE username = @username AND password = @password";
                SqlCommand command = new SqlCommand(sql, _connection);

                command.Parameters.AddWithValue("@username", txbEmail.Text);
                command.Parameters.AddWithValue("@password", txbPassword.Text);
                _connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    AppForm fr = new AppForm();
                    fr.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid credentials!","ERROR");
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show("An error occurred while logging in: " + ex.Message);
            }
            finally { _connection.Close(); }
        }
    }
}
