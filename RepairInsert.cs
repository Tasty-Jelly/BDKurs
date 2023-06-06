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
    public partial class RepairInsert : Form
    {
        public RepairInsert()
        {
            InitializeComponent();
        }

        private void RepairInsert_Load(object sender, EventArgs e)
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
            comm.CommandText = 
                "insert into repair(repair_id, service_id, repair_price, repair_date) values (default, (Select service_id from service where service_description = '"+ comboBoxServiceNames.Text + "'), " + repair_price_info.Text + ", '" + dateTimePicker1.Value + "')";

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(comm.CommandText, conn);
            ds.Reset(); // очищает таблицу на всякий случай
            da.Fill(ds); // добавляет записи в таблицу
            conn.Close();
            this.Close();
        }

        public List<string> GetServiceNamesFromDatabase()
        {
            string connectionString = "Server=localhost;Port=5432;Database=LR3.1;User id =postgres;Password=123456;";
            string query = "SELECT service_description FROM service";

            List<string> serviceNames = new List<string>();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string serviceName = reader.GetString(0);
                            serviceNames.Add(serviceName);
                        }
                    }
                }
            }

            return serviceNames;
        }
        private void comboBoxServiceNames_Click(object sender, EventArgs e)
        {
            List<string> serviceNames = GetServiceNamesFromDatabase();

            // Очистка списка перед добавлением новых значений
            comboBoxServiceNames.Items.Clear();

            // Добавление значений в ListBox
            foreach (string serviceName in serviceNames)
            {
                comboBoxServiceNames.Items.Add(serviceName);
            }
            //FillListBoxWorkerNames();
        }

    }
}
