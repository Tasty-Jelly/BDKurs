using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDZ_BD
{
    public partial class WorkerInsert : Form
    {
        public WorkerInsert()
        {
            InitializeComponent();
        }
        
        private void WorkerInsert_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.CenterParent;
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void accept_button_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet(); // определяешь кеш в памяти
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=LR3.1;User id =postgres;Password=123456;");
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "CALL UpdateOrInsertWorker('"+ comboBoxWorkerNames.Text + "', "+ worker_phone_info.Text + ", '"+ comboBoxWorkerPosts.Text+ "')";

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(comm.CommandText, conn);
            ds.Reset(); // очищает таблицу на всякий случай
            da.Fill(ds); // добавляет записи в таблицу
            conn.Close();
            this.Close();

        }

        public List<string> GetWorkerNamesFromDatabase()
        {
            string connectionString = "Server=localhost;Port=5432;Database=LR3.1;User id =postgres;Password=123456;";
            string query = "SELECT worker_name FROM worker";

            List<string> workerNames = new List<string>();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string workerName = reader.GetString(0);
                            workerNames.Add(workerName);
                        }
                    }
                }
            }

            return workerNames;
        }

        private void comboBoxWorkerNames_Click(object sender, EventArgs e)
        {
            List<string> workerNames = GetWorkerNamesFromDatabase();

            // Очистка списка перед добавлением новых значений
            comboBoxWorkerNames.Items.Clear();

            // Добавление значений в ListBox
            foreach (string workerName in workerNames)
            {
                comboBoxWorkerNames.Items.Add(workerName);
            }
            //FillListBoxWorkerNames();
        }

    }
}
