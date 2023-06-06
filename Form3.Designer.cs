namespace IDZ_BD
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.comboBoxClientNames = new System.Windows.Forms.ComboBox();
            this.comboBoxDetailNames = new System.Windows.Forms.ComboBox();
            this.comboBoxDeviceNames = new System.Windows.Forms.ComboBox();
            this.comboBoxWorkerNames = new System.Windows.Forms.ComboBox();
            this.sell_price_info = new System.Windows.Forms.TextBox();
            this.buy_price_info = new System.Windows.Forms.TextBox();
            this.order_references_info = new System.Windows.Forms.TextBox();
            this.order_references = new System.Windows.Forms.Label();
            this.order_status = new System.Windows.Forms.Label();
            this.order_issue_date = new System.Windows.Forms.Label();
            this.order_date_receipt = new System.Windows.Forms.Label();
            this.order_sell_price = new System.Windows.Forms.Label();
            this.order_buy_price = new System.Windows.Forms.Label();
            this.worker_id = new System.Windows.Forms.Label();
            this.device_id = new System.Windows.Forms.Label();
            this.cancel_button = new System.Windows.Forms.Button();
            this.accept_button = new System.Windows.Forms.Button();
            this.detail_id = new System.Windows.Forms.Label();
            this.client_id = new System.Windows.Forms.Label();
            this.order_form_main_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.comboBoxStatus);
            this.panel1.Controls.Add(this.comboBoxClientNames);
            this.panel1.Controls.Add(this.comboBoxDetailNames);
            this.panel1.Controls.Add(this.comboBoxDeviceNames);
            this.panel1.Controls.Add(this.comboBoxWorkerNames);
            this.panel1.Controls.Add(this.sell_price_info);
            this.panel1.Controls.Add(this.buy_price_info);
            this.panel1.Controls.Add(this.order_references_info);
            this.panel1.Controls.Add(this.order_references);
            this.panel1.Controls.Add(this.order_status);
            this.panel1.Controls.Add(this.order_issue_date);
            this.panel1.Controls.Add(this.order_date_receipt);
            this.panel1.Controls.Add(this.order_sell_price);
            this.panel1.Controls.Add(this.order_buy_price);
            this.panel1.Controls.Add(this.worker_id);
            this.panel1.Controls.Add(this.device_id);
            this.panel1.Controls.Add(this.cancel_button);
            this.panel1.Controls.Add(this.accept_button);
            this.panel1.Controls.Add(this.detail_id);
            this.panel1.Controls.Add(this.client_id);
            this.panel1.Controls.Add(this.order_form_main_label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 508);
            this.panel1.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy.mm.dd";
            this.dateTimePicker2.Location = new System.Drawing.Point(658, 92);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(77, 23);
            this.dateTimePicker2.TabIndex = 28;
            this.dateTimePicker2.Value = new System.DateTime(2023, 6, 1, 0, 0, 0, 0);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy.mm.dd";
            this.dateTimePicker1.Location = new System.Drawing.Point(658, 56);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(77, 23);
            this.dateTimePicker1.TabIndex = 27;
            this.dateTimePicker1.Value = new System.DateTime(2023, 6, 1, 0, 0, 0, 0);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "В работе",
            "Готов",
            "Выдан"});
            this.comboBoxStatus.Location = new System.Drawing.Point(637, 285);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(98, 23);
            this.comboBoxStatus.TabIndex = 26;
            // 
            // comboBoxClientNames
            // 
            this.comboBoxClientNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClientNames.Location = new System.Drawing.Point(230, 59);
            this.comboBoxClientNames.Name = "comboBoxClientNames";
            this.comboBoxClientNames.Size = new System.Drawing.Size(232, 23);
            this.comboBoxClientNames.TabIndex = 25;
            this.comboBoxClientNames.Click += new System.EventHandler(this.comboBoxClientNames_Click);
            // 
            // comboBoxDetailNames
            // 
            this.comboBoxDetailNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDetailNames.Location = new System.Drawing.Point(230, 92);
            this.comboBoxDetailNames.Name = "comboBoxDetailNames";
            this.comboBoxDetailNames.Size = new System.Drawing.Size(232, 23);
            this.comboBoxDetailNames.TabIndex = 24;
            this.comboBoxDetailNames.Click += new System.EventHandler(this.comboBoxDetailNames_Click);
            // 
            // comboBoxDeviceNames
            // 
            this.comboBoxDeviceNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDeviceNames.Location = new System.Drawing.Point(230, 126);
            this.comboBoxDeviceNames.Name = "comboBoxDeviceNames";
            this.comboBoxDeviceNames.Size = new System.Drawing.Size(232, 23);
            this.comboBoxDeviceNames.TabIndex = 23;
            this.comboBoxDeviceNames.SelectedIndexChanged += new System.EventHandler(this.comboBoxDeviceNames_SelectedIndexChanged);
            this.comboBoxDeviceNames.Click += new System.EventHandler(this.comboBoxDeviceNames_Click);
            // 
            // comboBoxWorkerNames
            // 
            this.comboBoxWorkerNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWorkerNames.Location = new System.Drawing.Point(230, 168);
            this.comboBoxWorkerNames.Name = "comboBoxWorkerNames";
            this.comboBoxWorkerNames.Size = new System.Drawing.Size(232, 23);
            this.comboBoxWorkerNames.TabIndex = 22;
            this.comboBoxWorkerNames.Click += new System.EventHandler(this.comboBoxWorkerNames_Click);
            // 
            // sell_price_info
            // 
            this.sell_price_info.Location = new System.Drawing.Point(637, 328);
            this.sell_price_info.Name = "sell_price_info";
            this.sell_price_info.Size = new System.Drawing.Size(140, 23);
            this.sell_price_info.TabIndex = 21;
            // 
            // buy_price_info
            // 
            this.buy_price_info.Location = new System.Drawing.Point(230, 323);
            this.buy_price_info.Name = "buy_price_info";
            this.buy_price_info.Size = new System.Drawing.Size(140, 23);
            this.buy_price_info.TabIndex = 20;
            // 
            // order_references_info
            // 
            this.order_references_info.Location = new System.Drawing.Point(230, 213);
            this.order_references_info.Multiline = true;
            this.order_references_info.Name = "order_references_info";
            this.order_references_info.Size = new System.Drawing.Size(232, 95);
            this.order_references_info.TabIndex = 16;
            // 
            // order_references
            // 
            this.order_references.AutoSize = true;
            this.order_references.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.order_references.Location = new System.Drawing.Point(17, 208);
            this.order_references.Name = "order_references";
            this.order_references.Size = new System.Drawing.Size(169, 25);
            this.order_references.TabIndex = 15;
            this.order_references.Text = "Доп. пожелания:";
            // 
            // order_status
            // 
            this.order_status.AutoSize = true;
            this.order_status.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.order_status.Location = new System.Drawing.Point(493, 280);
            this.order_status.Name = "order_status";
            this.order_status.Size = new System.Drawing.Size(138, 25);
            this.order_status.TabIndex = 15;
            this.order_status.Text = "Статус заказ:";
            // 
            // order_issue_date
            // 
            this.order_issue_date.AutoSize = true;
            this.order_issue_date.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.order_issue_date.Location = new System.Drawing.Point(491, 87);
            this.order_issue_date.Name = "order_issue_date";
            this.order_issue_date.Size = new System.Drawing.Size(140, 25);
            this.order_issue_date.TabIndex = 14;
            this.order_issue_date.Text = "Дата выдачи:";
            // 
            // order_date_receipt
            // 
            this.order_date_receipt.AutoSize = true;
            this.order_date_receipt.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.order_date_receipt.Location = new System.Drawing.Point(491, 51);
            this.order_date_receipt.Name = "order_date_receipt";
            this.order_date_receipt.Size = new System.Drawing.Size(161, 25);
            this.order_date_receipt.TabIndex = 13;
            this.order_date_receipt.Text = "Дата принятия:";
            // 
            // order_sell_price
            // 
            this.order_sell_price.AutoSize = true;
            this.order_sell_price.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.order_sell_price.Location = new System.Drawing.Point(440, 323);
            this.order_sell_price.Name = "order_sell_price";
            this.order_sell_price.Size = new System.Drawing.Size(173, 25);
            this.order_sell_price.TabIndex = 12;
            this.order_sell_price.Text = "Продажная цена:";
            // 
            // order_buy_price
            // 
            this.order_buy_price.AutoSize = true;
            this.order_buy_price.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.order_buy_price.Location = new System.Drawing.Point(33, 323);
            this.order_buy_price.Name = "order_buy_price";
            this.order_buy_price.Size = new System.Drawing.Size(159, 25);
            this.order_buy_price.TabIndex = 11;
            this.order_buy_price.Text = "Покупная цена:";
            // 
            // worker_id
            // 
            this.worker_id.AutoSize = true;
            this.worker_id.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.worker_id.Location = new System.Drawing.Point(17, 166);
            this.worker_id.Name = "worker_id";
            this.worker_id.Size = new System.Drawing.Size(108, 25);
            this.worker_id.TabIndex = 9;
            this.worker_id.Text = "Работник:";
            // 
            // device_id
            // 
            this.device_id.AutoSize = true;
            this.device_id.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.device_id.Location = new System.Drawing.Point(17, 126);
            this.device_id.Name = "device_id";
            this.device_id.Size = new System.Drawing.Size(126, 25);
            this.device_id.TabIndex = 7;
            this.device_id.Text = "Устройство:";
            // 
            // cancel_button
            // 
            this.cancel_button.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancel_button.Location = new System.Drawing.Point(471, 430);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(208, 54);
            this.cancel_button.TabIndex = 6;
            this.cancel_button.Text = "Отменить";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // accept_button
            // 
            this.accept_button.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.accept_button.Location = new System.Drawing.Point(71, 430);
            this.accept_button.Name = "accept_button";
            this.accept_button.Size = new System.Drawing.Size(208, 54);
            this.accept_button.TabIndex = 5;
            this.accept_button.Text = "Принять";
            this.accept_button.UseVisualStyleBackColor = true;
            this.accept_button.Click += new System.EventHandler(this.accept_button_Click);
            // 
            // detail_id
            // 
            this.detail_id.AutoSize = true;
            this.detail_id.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.detail_id.Location = new System.Drawing.Point(17, 90);
            this.detail_id.Name = "detail_id";
            this.detail_id.Size = new System.Drawing.Size(86, 25);
            this.detail_id.TabIndex = 3;
            this.detail_id.Text = "Деталь:";
            // 
            // client_id
            // 
            this.client_id.AutoSize = true;
            this.client_id.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.client_id.Location = new System.Drawing.Point(17, 54);
            this.client_id.Name = "client_id";
            this.client_id.Size = new System.Drawing.Size(146, 25);
            this.client_id.TabIndex = 2;
            this.client_id.Text = "ФИО клиента:";
            // 
            // order_form_main_label
            // 
            this.order_form_main_label.AutoSize = true;
            this.order_form_main_label.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.order_form_main_label.Location = new System.Drawing.Point(238, 9);
            this.order_form_main_label.Name = "order_form_main_label";
            this.order_form_main_label.Size = new System.Drawing.Size(319, 32);
            this.order_form_main_label.TabIndex = 1;
            this.order_form_main_label.Text = "Введите данные о заказе";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label device_id;
        private Button cancel_button;
        private Button accept_button;
        private Label detail_id;
        private Label client_id;
        private Label order_form_main_label;
        private TextBox sell_price_info;
        private TextBox buy_price_info;
        private TextBox order_references_info;
        private Label order_references;
        private Label order_status;
        private Label order_issue_date;
        private Label order_date_receipt;
        private Label order_sell_price;
        private Label order_buy_price;
        private TextBox worker_id_info;
        private Label worker_id;
        private ComboBox comboBoxWorkerNames;
        private TextBox textBox1;
        private ComboBox comboBoxClientNames;
        private ComboBox comboBoxDetailNames;
        private ComboBox comboBoxDeviceNames;
        private ComboBox comboBoxStatus;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
    }
}