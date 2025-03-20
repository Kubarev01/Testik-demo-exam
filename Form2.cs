using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Testik
{
    public partial class Form2 : Form
    {
        private string connectionString = "Server=U314-S8a\\SQLEXPRESS314S8;Database=тесатик;Trusted_Connection=True;";
        private SqlDataAdapter adapter;
        private DataTable table;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                // Создаем подключение и адаптер
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Инициализация адаптера с запросом и подключением
                    adapter = new SqlDataAdapter("SELECT * FROM Заявки", connection);
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);

                    // Заполнение таблицы данных
                    table = new DataTable();
                    adapter.Fill(table);

                    // Привязка данных к DataGridView
                    dataGridView1.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки данных: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Сохранение изменений
                if (table != null)
                {
                    // Создаем новое подключение для сохранения
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        adapter.SelectCommand.Connection = connection; // Привязка команды к подключению
                        adapter.Update(table);
                        MessageBox.Show("Изменения успешно сохранены.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения: " + ex.Message);
            }
        }
    }
}


