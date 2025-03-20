using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testik
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;

            string connectionString = "Server = U314-S8a\\SQLEXPRESS314S8; Database =тесатик; Trusted_Connection = True; ";

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = $"INSERT INTO Аккаунты (login, password) VALUES ('{login}','{password}')";
            using (SqlCommand command = new SqlCommand(query, connection))
            {

                
              command.ExecuteNonQuery();
                MessageBox.Show("ВЫ ЗАРЕГАЛИСЬ");

            }

        }
    }
}

