namespace IDZ_BD
{
    partial class UpdateOrder
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
            this.sell_price_info = new System.Windows.Forms.TextBox();
            this.buy_price_info = new System.Windows.Forms.TextBox();
            this.order_references_info = new System.Windows.Forms.TextBox();
            this.order_references = new System.Windows.Forms.Label();
            this.order_status = new System.Windows.Forms.Label();
            this.order_issue_date = new System.Windows.Forms.Label();
            this.order_sell_price = new System.Windows.Forms.Label();
            this.order_buy_price = new System.Windows.Forms.Label();
            this.cancel_button = new System.Windows.Forms.Button();
            this.accept_button = new System.Windows.Forms.Button();
            this.detail_id = new System.Windows.Forms.Label();
            this.order_form_main_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.comboBoxIdOrder = new System.Windows.Forms.ComboBox();
            this.comboBoxDetailNames = new System.Windows.Forms.ComboBox();
            this.order_id = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sell_price_info
            // 
            this.sell_price_info.Location = new System.Drawing.Point(630, 269);
            this.sell_price_info.Name = "sell_price_info";
            this.sell_price_info.Size = new System.Drawing.Size(140, 23);
            this.sell_price_info.TabIndex = 21;
            // 
            // buy_price_info
            // 
            this.buy_price_info.Location = new System.Drawing.Point(230, 264);
            this.buy_price_info.Name = "buy_price_info";
            this.buy_price_info.Size = new System.Drawing.Size(140, 23);
            this.buy_price_info.TabIndex = 20;
            // 
            // order_references_info
            // 
            this.order_references_info.Location = new System.Drawing.Point(230, 151);
            this.order_references_info.Multiline = true;
            this.order_references_info.Name = "order_references_info";
            this.order_references_info.Size = new System.Drawing.Size(232, 95);
            this.order_references_info.TabIndex = 16;
            // 
            // order_references
            // 
            this.order_references.AutoSize = true;
            this.order_references.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.order_references.Location = new System.Drawing.Point(17, 146);
            this.order_references.Name = "order_references";
            this.order_references.Size = new System.Drawing.Size(169, 25);
            this.order_references.TabIndex = 15;
            this.order_references.Text = "Доп. пожелания:";
            // 
            // order_status
            // 
            this.order_status.AutoSize = true;
            this.order_status.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.order_status.Location = new System.Drawing.Point(493, 218);
            this.order_status.Name = "order_status";
            this.order_status.Size = new System.Drawing.Size(138, 25);
            this.order_status.TabIndex = 15;
            this.order_status.Text = "Статус заказ:";
            // 
            // order_issue_date
            // 
            this.order_issue_date.AutoSize = true;
            this.order_issue_date.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.order_issue_date.Location = new System.Drawing.Point(491, 62);
            this.order_issue_date.Name = "order_issue_date";
            this.order_issue_date.Size = new System.Drawing.Size(140, 25);
            this.order_issue_date.TabIndex = 14;
            this.order_issue_date.Text = "Дата выдачи:";
            // 
            // order_sell_price
            // 
            this.order_sell_price.AutoSize = true;
            this.order_sell_price.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.order_sell_price.Location = new System.Drawing.Point(440, 264);
            this.order_sell_price.Name = "order_sell_price";
            this.order_sell_price.Size = new System.Drawing.Size(173, 25);
            this.order_sell_price.TabIndex = 12;
            this.order_sell_price.Text = "Продажная цена:";
            // 
            // order_buy_price
            // 
            this.order_buy_price.AutoSize = true;
            this.order_buy_price.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.order_buy_price.Location = new System.Drawing.Point(33, 264);
            this.order_buy_price.Name = "order_buy_price";
            this.order_buy_price.Size = new System.Drawing.Size(159, 25);
            this.order_buy_price.TabIndex = 11;
            this.order_buy_price.Text = "Покупная цена:";
            // 
            // cancel_button
            // 
            this.cancel_button.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancel_button.Location = new System.Drawing.Point(471, 321);
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
            this.accept_button.Location = new System.Drawing.Point(71, 321);
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
            this.detail_id.Location = new System.Drawing.Point(17, 107);
            this.detail_id.Name = "detail_id";
            this.detail_id.Size = new System.Drawing.Size(86, 25);
            this.detail_id.TabIndex = 3;
            this.detail_id.Text = "Деталь:";
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
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.comboBoxStatus);
            this.panel1.Controls.Add(this.comboBoxIdOrder);
            this.panel1.Controls.Add(this.comboBoxDetailNames);
            this.panel1.Controls.Add(this.order_id);
            this.panel1.Controls.Add(this.sell_price_info);
            this.panel1.Controls.Add(this.buy_price_info);
            this.panel1.Controls.Add(this.order_references_info);
            this.panel1.Controls.Add(this.order_references);
            this.panel1.Controls.Add(this.order_status);
            this.panel1.Controls.Add(this.order_issue_date);
            this.panel1.Controls.Add(this.order_sell_price);
            this.panel1.Controls.Add(this.order_buy_price);
            this.panel1.Controls.Add(this.cancel_button);
            this.panel1.Controls.Add(this.accept_button);
            this.panel1.Controls.Add(this.detail_id);
            this.panel1.Controls.Add(this.order_form_main_label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 398);
            this.panel1.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy.mm.dd";
            this.dateTimePicker2.Location = new System.Drawing.Point(660, 64);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(77, 23);
            this.dateTimePicker2.TabIndex = 32;
            this.dateTimePicker2.Value = new System.DateTime(2023, 6, 1, 0, 0, 0, 0);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "В работе",
            "Готов",
            "Выдан"});
            this.comboBoxStatus.Location = new System.Drawing.Point(639, 223);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(98, 23);
            this.comboBoxStatus.TabIndex = 31;
            // 
            // comboBoxIdOrder
            // 
            this.comboBoxIdOrder.FormattingEnabled = true;
            this.comboBoxIdOrder.Location = new System.Drawing.Point(230, 67);
            this.comboBoxIdOrder.Name = "comboBoxIdOrder";
            this.comboBoxIdOrder.Size = new System.Drawing.Size(232, 23);
            this.comboBoxIdOrder.TabIndex = 30;
            this.comboBoxIdOrder.Click += new System.EventHandler(this.comboBoxIdOrder_Click);
            // 
            // comboBoxDetailNames
            // 
            this.comboBoxDetailNames.FormattingEnabled = true;
            this.comboBoxDetailNames.Location = new System.Drawing.Point(230, 107);
            this.comboBoxDetailNames.Name = "comboBoxDetailNames";
            this.comboBoxDetailNames.Size = new System.Drawing.Size(232, 23);
            this.comboBoxDetailNames.TabIndex = 29;
            this.comboBoxDetailNames.Click += new System.EventHandler(this.comboBoxDetailNames_Click);
            // 
            // order_id
            // 
            this.order_id.AutoSize = true;
            this.order_id.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.order_id.Location = new System.Drawing.Point(17, 62);
            this.order_id.Name = "order_id";
            this.order_id.Size = new System.Drawing.Size(105, 25);
            this.order_id.TabIndex = 22;
            this.order_id.Text = "ID заказа:";
            // 
            // UpdateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 398);
            this.Controls.Add(this.panel1);
            this.Name = "UpdateOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UpdateOrder";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox sell_price_info;
        private TextBox buy_price_info;
        private TextBox order_references_info;
        private Label order_references;
        private Label order_status;
        private Label order_issue_date;
        private Label order_sell_price;
        private Label order_buy_price;
        private Button cancel_button;
        private Button accept_button;
        private Label detail_id;
        private Label order_form_main_label;
        private Panel panel1;
        private Label order_id;
        private DateTimePicker dateTimePicker2;
        private ComboBox comboBoxStatus;
        private ComboBox comboBoxIdOrder;
        private ComboBox comboBoxDetailNames;
    }
}