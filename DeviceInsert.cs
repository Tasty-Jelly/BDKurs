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
    public partial class DeviceInsert : Form
    {
        public DeviceInsert()
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
            comm.CommandText = "call device_exist1(1, " + repair_id_info.Text + ", '" + comboBoxDeviceStatus.Text + "', '" + comboBoxDeviceNames.Text + "')";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(comm.CommandText, conn);
            ds.Reset(); // очищает таблицу на всякий случай
            da.Fill(ds); // добавляет записи в таблицу
            conn.Close();
            this.Close();
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
