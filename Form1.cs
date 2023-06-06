using Npgsql;
using NpgsqlTypes;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using OfficeOpenXml;
using OfficeOpenXml.Table;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Text;

namespace IDZ_BD
{
    public partial class Form1 : Form
    {
        public static Control form1;
        public Form1()
        {
            InitializeComponent();
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            this.FormClosing += Form1_FormClosing;

            customizeDesign();
            hideSubmenu();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #region Меню //Включение, отключение и скрытие Sub-меню кнопок
        private void customizeDesign()
        {
            client_menu.Visible = false;
            detail_menu.Visible = false;
            device_menu.Visible = false;
            order_menu.Visible = false;
            service_menu.Visible = false;
            worker_menu.Visible = false;
            repair_menu.Visible = false;

        } //Отключаем видимость меню

        private void hideSubmenu()
        {
            if (client_menu.Visible == true) client_menu.Visible = false;
            if (detail_menu.Visible == true) detail_menu.Visible = false;
            if (device_menu.Visible == true) device_menu.Visible = false;
            if (order_menu.Visible ==true) order_menu.Visible = false;
            if (repair_menu.Visible == true) repair_menu.Visible = false;
            if (service_menu.Visible == true) service_menu.Visible = false;
            if (worker_menu.Visible == true) worker_menu.Visible = false;
        }//Скрываем меню

        private void showSubmenu(Panel panel)
        {
            if (panel.Visible == false)
            {
                hideSubmenu();
                panel.Visible = true;
            }
            else panel.Visible = false;
        }//Включаем показ меню при нажатии
        #endregion

        #region Client //Функции кнопки Клиент ГОТОВ
        private void client_button_Click(object sender, EventArgs e)
        {
            showSubmenu(client_menu);
        }

        private void select_client_button_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=LR3.1;User id=postgres;Password=123456;");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select client_name as \"ФИО клиента\", client_phone as \"Номер телефона\" from client";
            NpgsqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                System.Data.DataTable dt = new System.Data.DataTable();
                dt.Load(dr);
                dgv.DataSource = dt;
            }
            comm.Dispose();
            conn.Close();

            hideSubmenu();
        }

        private void insert_client_button_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            System.Data.DataTable dt = new System.Data.DataTable();

            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=LR3.1;User id=postgres;Password=123456;");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();

            client_insert_form f2 = new client_insert_form();
            form1 = this;
            f2.ShowDialog();

            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select client_name as \"ФИО клиента\", client_phone as \"Номер телефона\" from client";
            NpgsqlDataReader dr = comm.ExecuteReader();

            if (dr.HasRows)
            {
                dt.Load(dr);
                dgv.DataSource = dt;
            }
            conn.Close();
            hideSubmenu();
        }

        private void delete_client_button_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=LR3.1;User id=postgres;Password=123456;");
            DataSet ds = new DataSet(); // определяешь кеш в памяти
            System.Data.DataTable dt = new System.Data.DataTable();

            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();

            try
            {
                foreach (DataGridViewRow row in dgv.SelectedRows)
                {
                    string client_name = row.Cells[0].Value.ToString();
                    string client_phone = row.Cells[1].Value.ToString();

                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = "DELETE FROM client WHERE client_name = '" + client_name + "'";
                    comm.ExecuteNonQuery();

                    MessageBox.Show("Запись успешно удалена.");
                }

                comm.CommandText = "SELECT client_name AS \"ФИО клиента\", client_phone AS \"Номер телефона\" FROM client";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(comm.CommandText, conn);
                ds.Reset(); // очищает таблицу на всякий случай
                da.Fill(ds); // добавляет записи в таблицу

                if (ds.Tables.Count > 0)
                {
                    dt = ds.Tables[0];
                    dgv.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                // Проверяем тип исключения, чтобы определить, что произошла ошибка связанная с использованием записи в других таблицах
                if (ex is NpgsqlException npgEx && npgEx.ErrorCode == 23503) // Код ошибки 23503 соответствует ограничению внешнего ключа
                {
                    // Ошибка связана с использованием записи в других таблицах
                    MessageBox.Show("Невозможно удалить запись, так как она используется в других таблицах.");
                }
                else
                {
                    // Ошибка не связана с использованием записи в других таблицах
                    MessageBox.Show("Невозможно удалить запись, так как она используется в других таблицах.");
                }
            }

            conn.Close();

            hideSubmenu();

        }

        #endregion Client

        #region Detail //Функции кнопки Деталь ГОТОВ
        private void detail_button_Click(object sender, EventArgs e)
        {
            showSubmenu(detail_menu);
        }

        private void select_detail_button_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=LR3.1;User id=postgres;Password=123456;");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select detail_name as \"Наименование\", detail_description as \"Описание\", detail_amount as \"Доступное количество\", detail_price as \"Цена\" from detail";
            NpgsqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                System.Data.DataTable dt = new System.Data.DataTable();
                dt.Load(dr);
                dgv.DataSource = dt;
            }
            comm.Dispose();
            conn.Close();

            hideSubmenu();
        }

        private void insert_detail_button_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            System.Data.DataTable dt = new System.Data.DataTable();

            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=LR3.1;User id=postgres;Password=123456;");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();

            DetailInsert f = new DetailInsert();
            form1 = this;
            f.ShowDialog();

            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select detail_name as \"Наименование\", detail_description as \"Описание\", detail_amount as \"Доступное количество\", detail_price as \"Цена\" from detail";
            NpgsqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                dt.Load(dr);
                dgv.DataSource = dt;
            }
            comm.Dispose();
            conn.Close();

            hideSubmenu();
        }

        private void delete_detail_button_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=LR3.1;User id=postgres;Password=123456;");
            DataSet ds = new DataSet(); // определяешь кеш в памяти
            System.Data.DataTable dt = new System.Data.DataTable();

            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            foreach (DataGridViewRow row in dgv.SelectedRows)
            {
                comm.Connection = conn;

                string detail_name = row.Cells[0].Value.ToString();
                string detail_description = row.Cells[1].Value.ToString();

                comm.CommandType = CommandType.Text;
                comm.CommandText = "DELETE FROM detail WHERE detail_description = '" + detail_description + "'";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(comm.CommandText, conn);
                ds.Reset(); // очищает таблицу на всякий случай
                da.Fill(ds); // добавляет записи в таблицу

                comm.CommandText = "select detail_name as \"Наименование\", detail_description as \"Описание\", detail_amount as \"Доступное количество\", detail_price as \"Цена\" from detail";
                NpgsqlDataReader dr = comm.ExecuteReader();

                if (dr.HasRows)
                {
                    dt.Load(dr);
                    dgv.DataSource = dt;
                }

                conn.Close();

                hideSubmenu();
            }
        }
        #endregion Detail

        #region Device //Функции кнопки Девайс ГОТОВ
        private void device_button_Click(object sender, EventArgs e)
        {
            showSubmenu(device_menu);
        }

        private void select_device_button_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=LR3.1;User id=postgres;Password=123456;");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "SELECT D.device_name as \"Название устройства\", S.service_description as \"Наименование услуги\", R.repair_date as \"Дата оказания услуги\", D.device_status as \"Статус работы\", R.repair_price as \"Стоимость работы\"\r\nFROM repair R\r\nJOIN device D ON R.repair_id = D.repair_id\r\nJOIN service S ON R.service_id = S.service_id";
            NpgsqlDataReader dr = comm.ExecuteReader();
            
            if (dr.HasRows)
            {
                System.Data.DataTable dt = new System.Data.DataTable();
                dt.Load(dr);
                dgv.DataSource = dt;
            }
            comm.Dispose();
            conn.Close();

            hideSubmenu();
        }

        private void insert_device_button_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            System.Data.DataTable dt = new System.Data.DataTable();

            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=LR3.1;User id=postgres;Password=123456;");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            
            DeviceInsert f = new DeviceInsert();
            form1 = this;
            f.ShowDialog();

            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "SELECT D.device_name as \"Название устройства\", S.service_description as \"Наименование услуги\", R.repair_date as \"Дата оказания услуги\", D.device_status as \"Статус работы\", R.repair_price as \"Стоимость работы\"\r\nFROM repair R\r\nJOIN device D ON R.repair_id = D.repair_id\r\nJOIN service S ON R.service_id = S.service_id";
            NpgsqlDataReader dr = comm.ExecuteReader();
            
            if (dr.HasRows)
            {
                dt.Load(dr);
                dgv.DataSource = dt;
            }
            comm.Dispose();
            conn.Close();
            
            hideSubmenu();
        }

        private void update_device_button_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            System.Data.DataTable dt = new System.Data.DataTable();

            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=LR3.1;User id=postgres;Password=123456;");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();

            DeviceInsert f = new DeviceInsert();
            form1 = this;
            f.ShowDialog();

            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "SELECT D.device_name as \"Название устройства\", S.service_description as \"Наименование услуги\", R.repair_date as \"Дата оказания услуги\", D.device_status as \"Статус работы\", R.repair_price as \"Стоимость работы\"\r\nFROM repair R\r\nJOIN device D ON R.repair_id = D.repair_id\r\nJOIN service S ON R.service_id = S.service_id";
            NpgsqlDataReader dr = comm.ExecuteReader();

            if (dr.HasRows)
            {
                dt.Load(dr);
                dgv.DataSource = dt;
            }
            comm.Dispose();
            conn.Close();

            hideSubmenu();
        }
        #endregion Device

        #region Order //Функции кнопки Заказ
        private void order_button_Click(object sender, EventArgs e)
        {
            showSubmenu(order_menu);
        }


        private void select_order_button_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=LR3.1;User id=postgres;Password=123456;");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select order_id as \"ID заказа\", C.client_name as \"ФИО клиента\", W.worker_name as \"ФИО сотрудника\", D.detail_description as \"Наименование детали\", DV.device_name as \"Модель устройства\", order_references as \"Примечания к заказу\", order_buy_price as \"Покупная цена\", order_sell_price as \"Продажная цена\", order_date_receipt as \"Дата принятия\", order_date_issue as \"Дата выдачи\", order_status as \"Статус заказа\"" +
                               "from \"order\" O, client C, device DV, detail D, worker W " +
                               "where O.client_id = C.client_id and O.detail_id = D.detail_id and O.device_id = DV.device_id and O.worker_id = W.worker_id";
            NpgsqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                System.Data.DataTable dt = new System.Data.DataTable();
                dt.Load(dr);
                dgv.DataSource = dt;
            }
            comm.Dispose();
            conn.Close();

            hideSubmenu();
        }

        private void insert_order_button_Click(object sender, EventArgs e)
        {

            DataSet ds = new DataSet();
            System.Data.DataTable dt = new System.Data.DataTable();

            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=LR3.1;User id=postgres;Password=123456;");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();

            Form3 f = new Form3();
            form1 = this;
            f.ShowDialog();

            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select order_id as \"ID заказа\", C.client_name as \"ФИО клиента\", W.worker_name as \"ФИО сотрудника\", D.detail_description as \"Наименование детали\", DV.device_name as \"Модель устройства\", order_references as \"Примечания к заказу\", order_buy_price as \"Покупная цена\", order_sell_price as \"Продажная цена\", order_date_receipt as \"Дата принятия\", order_date_issue as \"Дата выдачи\", order_status as \"Статус заказа\"" +
                                "from \"order\" O, client C, device DV, detail D, worker W " +
                                "where O.client_id = C.client_id and O.detail_id = D.detail_id and O.device_id = DV.device_id and O.worker_id = W.worker_id";
            NpgsqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                dt.Load(dr);
                dgv.DataSource = dt;
            }
            comm.Dispose();
            conn.Close();

            hideSubmenu();
        }

        private void update_order_button_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            System.Data.DataTable dt = new System.Data.DataTable();

            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=LR3.1;User id=postgres;Password=123456;");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();

            UpdateOrder f = new UpdateOrder();
            form1 = this;
            f.ShowDialog();

            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select order_id as \"ID заказа\", C.client_name as \"ФИО клиента\", W.worker_name as \"ФИО сотрудника\", D.detail_description as \"Наименование детали\", DV.device_name as \"Модель устройства\", order_references as \"Примечания к заказу\", order_buy_price as \"Покупная цена\", order_sell_price as \"Продажная цена\", order_date_receipt as \"Дата принятия\", order_date_issue as \"Дата выдачи\", order_status as \"Статус заказа\"" +
                                "from \"order\" O, client C, device DV, detail D, worker W " +
                                "where O.client_id = C.client_id and O.detail_id = D.detail_id and O.device_id = DV.device_id and O.worker_id = W.worker_id";
            NpgsqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                dt.Load(dr);
                dgv.DataSource = dt;
            }
            comm.Dispose();
            conn.Close();

            hideSubmenu();
        }

        #endregion Order

        #region Repair //Функции кнопки Ремонт ГОТОВ
        private void repair_button_Click(object sender, EventArgs e)
        {
            showSubmenu(repair_menu);
        }


        private void select_repair_button_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=LR3.1;User id=postgres;Password=123456;");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select repair_id as \"ID ремонта\",S.service_description as \"Наименование услуги\", repair_date as \"Дата оказания ремонта\", repair_price as \"Цена ремонта\" from repair R, service S where R.service_id = S.service_id";
            NpgsqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                System.Data.DataTable dt = new System.Data.DataTable();
                dt.Load(dr);
                dgv.DataSource = dt;
            }
            comm.Dispose();
            conn.Close();

            hideSubmenu();
        }

        private void insert_repair_button_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            System.Data.DataTable dt = new System.Data.DataTable();

            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=LR3.1;User id=postgres;Password=123456;");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();

            RepairInsert f = new RepairInsert();
            form1 = this;
            f.ShowDialog();

            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select repair_id as \"ID ремонта\", S.service_description as \"Наименование услуги\", repair_date as \"Дата оказания ремонта\", repair_price as \"Цена ремонта\" from repair R, service S where R.service_id = S.service_id";
            NpgsqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                dt.Load(dr);
                dgv.DataSource = dt;
            }
            comm.Dispose();
            conn.Close();


            hideSubmenu();
        }

        #endregion

        #region Service //Функции кнопки Услуги ГОТОВ

        private void service_button_Click(object sender, EventArgs e)
        {
            showSubmenu(service_menu);
        }

        private void select_service_button_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=LR3.1;User id=postgres;Password=123456;");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select service_name as \"Наименование услуги\", service_type as \"Тип детали\", service_description as \"Описание\" from service";
            NpgsqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                System.Data.DataTable dt = new System.Data.DataTable();
                dt.Load(dr);
                dgv.DataSource = dt;
            }
            comm.Dispose();
            conn.Close();

            hideSubmenu();
        }

        private void insert_service_button_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            System.Data.DataTable dt = new System.Data.DataTable();

            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=LR3.1;User id=postgres;Password=123456;");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();

            ServiceInsert f = new ServiceInsert();
            form1 = this;
            f.ShowDialog();

            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select service_name as \"Наименование услуги\", service_type as \"Тип детали\", service_description as \"Описание\" from service";
            NpgsqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                dt.Load(dr);
                dgv.DataSource = dt;
            }
            comm.Dispose();
            conn.Close();

            hideSubmenu();
        }

        private void delete_service_button_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Port=5432;Database=LR3.1;User id=postgres;Password=123456;";

            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();

                    foreach (DataGridViewRow row in dgv.SelectedRows)
                    {
                        string service_description = row.Cells[2].Value.ToString();

                        using (NpgsqlCommand comm = new NpgsqlCommand())
                        {
                            comm.Connection = conn;
                            comm.CommandType = CommandType.Text;
                            comm.CommandText = "DELETE FROM service WHERE service_description = @description";
                            comm.Parameters.AddWithValue("@description", service_description);
                            comm.ExecuteNonQuery();
                        }
                    }

                    using (NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT service_name AS \"Наименование услуги\", service_type AS \"Тип детали\", service_description AS \"Описание\" FROM service", conn))
                    {
                        DataSet ds = new DataSet();
                        da.Fill(ds);

                        if (ds.Tables.Count > 0)
                        {
                            DataTable dt = ds.Tables[0];
                            dgv.DataSource = dt;
                        }
                    }
                }

                MessageBox.Show("Запись(и) успешно удалена(ы).");
            }
            catch (NpgsqlException ex)
            {
                if (ex is NpgsqlException npgEx && npgEx.ErrorCode == 23503) // Код ошибки 23503 соответствует ограничению внешнего ключа
                {
                    // Ошибка связана с использованием записи в других таблицах
                    MessageBox.Show("Невозможно удалить запись, так как она используется в других таблицах.");
                }
                else
                {
                    // Ошибка не связана с использованием записи в других таблицах
                    MessageBox.Show("Невозможно удалить запись, так как она используется в других таблицах.");
                }
            }

            hideSubmenu();
        }
        #endregion

        #region Worker //Функции кнопки Сотрудники ГОТОВ
        private void worker_button_Click(object sender, EventArgs e)
        {
            showSubmenu(worker_menu);
        }


        private void select_worker_button_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=LR3.1;User id=postgres;Password=123456;");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select worker_name as \"ФИО\", worker_phone as \"Номер телефона\", worker_post as \"Должность\" from worker";
            NpgsqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                System.Data.DataTable dt = new System.Data.DataTable();
                dt.Load(dr);
                dgv.DataSource = dt;
            }
            comm.Dispose();
            conn.Close();

            hideSubmenu();
        }

        private void insert_worker_button_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            System.Data.DataTable dt = new System.Data.DataTable();

            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=LR3.1;User id=postgres;Password=123456;");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();

            WorkerInsert f = new WorkerInsert();
            form1 = this;
            f.ShowDialog();

            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select worker_name as \"ФИО\", worker_phone as \"Номер телефона\", worker_post as \"Должность\" from worker";
            NpgsqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                dt.Load(dr);
                dgv.DataSource = dt;
            }
            comm.Dispose();
            conn.Close();

            hideSubmenu();
        }

        private void update_worker_button_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            System.Data.DataTable dt = new System.Data.DataTable();

            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=LR3.1;User id=postgres;Password=123456;");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();

            WorkerInsert f = new WorkerInsert();
            form1 = this;
            f.ShowDialog();

            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select worker_name as \"ФИО\", worker_phone as \"Номер телефона\", worker_post as \"Должность\" from worker";
            NpgsqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                dt.Load(dr);
                dgv.DataSource = dt;
            }
            comm.Dispose();
            conn.Close();

            hideSubmenu();
        }



        #endregion

        private void оПрибылиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=LR3.1;User id=postgres;Password=123456;");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "SELECT * FROM public.orderslast30days";
            NpgsqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                System.Data.DataTable dt = new System.Data.DataTable();
                dt.Load(dr);
                dgv.DataSource = dt;
            }
            comm.Dispose();
            conn.Close();
        }

        private void оМоделиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=LR3.1;User id=postgres;Password=123456;");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "SELECT * FROM public.monthlyincomewithbonus1";
            NpgsqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                System.Data.DataTable dt = new System.Data.DataTable();
                dt.Load(dr);
                dgv.DataSource = dt;
            }
            comm.Dispose();
            conn.Close();
        }

        private void выгрузитьТаблицуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string saveFilePath = saveFileDialog.FileName;

                    using (var excelPackage = new ExcelPackage())
                    {
                        // Добавление нового листа в книгу Excel
                        ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");

                        // Получение данных из DataGridView
                        DataTable dt = new DataTable();
                        foreach (DataGridViewColumn column in dgv.Columns)
                        {
                            dt.Columns.Add(column.HeaderText);
                        }
                        foreach (DataGridViewRow row in dgv.Rows)
                        {
                            DataRow dataRow = dt.NewRow();
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                dataRow[cell.ColumnIndex] = cell.Value;
                            }
                            dt.Rows.Add(dataRow);
                        }

                        // Заполнение данных в листе Excel
                        worksheet.Cells.LoadFromDataTable(dt, true);

                        // Автофильтр для заголовков столбцов
                        worksheet.Cells[worksheet.Dimension.Address].AutoFilter = true;

                        // Стиль для заголовков столбцов
                        worksheet.Row(1).Style.Font.Bold = true;

                        // Авторазмер столбцов
                        worksheet.Cells.AutoFitColumns();

                        // Сохранение файла Excel
                        excelPackage.SaveAs(new System.IO.FileInfo(saveFilePath));

                        MessageBox.Show("Таблица успешно экспортирована в Excel!");
                    }
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=LR3.1;User id=postgres;Password=123456;");
            // Отключение от базы данных PGAdmin
            conn.Close();
        }
    }
}