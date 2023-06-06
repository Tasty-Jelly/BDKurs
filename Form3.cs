using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IDZ_BD
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
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
            comm.CommandText = "insert into \"order\" " +
                "values (default, (select client_id from client where client_name = '"+ comboBoxClientNames.Text+"')," +
                "(select detail_id from \"detail\" where detail_description = '"+ comboBoxDetailNames.Text+"')," +
                "(select device_id from device where device_name = '"+ comboBoxDeviceNames.Text +"')," +
                "(select worker_id from worker where worker_name = '"+ comboBoxWorkerNames.Text +"')," +
                " '"+ order_references_info.Text +"', "+ sell_price_info.Text + ", "+ buy_price_info.Text +", '" + dateTimePicker1.Value + "', \'"+ dateTimePicker2.Value + "\', '"+ comboBoxStatus.Text +"')";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(comm.CommandText, conn);
            ds.Reset(); // очищает таблицу на всякий случай
            da.Fill(ds); // добавляет записи в таблицу
            conn.Close();
            this.Close();
        }


        private void comboBoxDeviceNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet(); // определяешь кеш в памяти
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=LR3.1;User id =postgres;Password=123456;");
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;

            conn.Open();
            string query = comm.CommandText = "SELECT repair.repair_price AS order_price FROM repair JOIN device ON repair.repair_id = device.repair_id WHERE device.device_name = '" + comboBoxDeviceNames.Text + "'";
            using (NpgsqlCommand command = new NpgsqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@deviceName", comboBoxDeviceNames.Text);

                object result = command.ExecuteScalar();
                if (result != null)
                {
                    decimal orderPrice = Convert.ToDecimal(result);
                    buy_price_info.Text = orderPrice.ToString();
                }
            }
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

        public List<string> GetClientNamesFromDatabase()
        {
            string connectionString = "Server=localhost;Port=5432;Database=LR3.1;User id =postgres;Password=123456;";
            string query = "SELECT client_name FROM client";

            List<string> clientNames = new List<string>();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string clientName = reader.GetString(0);
                            clientNames.Add(clientName);
                        }
                    }
                }
            }

            return clientNames;
        }
        private void comboBoxClientNames_Click(object sender, EventArgs e)
        {
            List<string> clientNames = GetClientNamesFromDatabase();

            // Очистка списка перед добавлением новых значений
            comboBoxClientNames.Items.Clear();

            // Добавление значений в ListBox
            foreach (string clientName in clientNames)
            {
                comboBoxClientNames.Items.Add(clientName);
            }
            //FillListBoxWorkerNames();
        }

        public List<string> GetDetailNamesFromDatabase()
        {
            string connectionString = "Server=localhost;Port=5432;Database=LR3.1;User id =postgres;Password=123456;";
            string query = "SELECT detail_description FROM detail";

            List<string> detailNames = new List<string>();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string detailName = reader.GetString(0);
                            detailNames.Add(detailName);
                        }
                    }
                }
            }

            return detailNames;
        }
        private void comboBoxDetailNames_Click(object sender, EventArgs e)
        {
            List<string> detailNames = GetDetailNamesFromDatabase();

            // Очистка списка перед добавлением новых значений
            comboBoxDetailNames.Items.Clear();

            // Добавление значений в ListBox
            foreach (string detailName in detailNames)
            {
                comboBoxDetailNames.Items.Add(detailName);
            }
            //FillListBoxWorkerNames();
        }

        public List<string> GetDeviceNamesFromDatabase()
        {
            string connectionString = "Server=localhost;Port=5432;Database=LR3.1;User id =postgres;Password=123456;";
            string query = "SELECT device_name FROM device";

            List<string> deviceNames = new List<string>();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string deviceName = reader.GetString(0);
                            deviceNames.Add(deviceName);
                        }
                    }
                }
            }

            return deviceNames;
        }
        private void comboBoxDeviceNames_Click(object sender, EventArgs e)
        {
            List<string> deviceNames = GetDeviceNamesFromDatabase();

            // Очистка списка перед добавлением новых значений
            comboBoxDeviceNames.Items.Clear();

            // Добавление значений в ListBox
            foreach (string deviceName in deviceNames)
            {
                comboBoxDeviceNames.Items.Add(deviceName);
            }
            //FillListBoxWorkerNames();
        }

    }
}
