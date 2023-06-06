﻿using Npgsql;
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
    public partial class UpdateOrder : Form
    {
        public UpdateOrder()
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
            comm.CommandText = "update \"order\" set detail_id = (select detail_id from detail where detail_description = '" + comboBoxDetailNames.Text + "'), order_references = '"+ order_references_info.Text + "', order_sell_price = " + sell_price_info.Text + ", order_buy_price = " + buy_price_info.Text + ", order_date_issue = '" + dateTimePicker2.Value + "', order_status  = '" + comboBoxStatus.Text + "' where order_id = '" + comboBoxIdOrder.Text + "'";

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(comm.CommandText, conn);
            ds.Reset(); // очищает таблицу на всякий случай
            da.Fill(ds); // добавляет записи в таблицу
            conn.Close();
            this.Close();
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


        public List<string> GetIdOrdersFromDatabase()
        {
            string connectionString = "Server=localhost;Port=5432;Database=LR3.1;User id =postgres;Password=123456;";
            string query = "SELECT order_id FROM \"order\"";

            List<string> IdOrder = new List<string>();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int Id_Order = reader.GetInt32(0);
                            string orderIdString = Id_Order.ToString();
                            IdOrder.Add(orderIdString);
                        }
                    }
                }
            }

            return IdOrder;
        }
        private void comboBoxIdOrder_Click(object sender, EventArgs e)
        {
            List<string> IdOrder = GetIdOrdersFromDatabase();

            // Очистка списка перед добавлением новых значений
            comboBoxIdOrder.Items.Clear();

            // Добавление значений в ListBox
            foreach (string Id_Order in IdOrder)
            {
                comboBoxIdOrder.Items.Add(Id_Order);
            }
            //FillListBoxWorkerNames();
        }

    }
}
