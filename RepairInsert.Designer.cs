﻿namespace IDZ_BD
{
    partial class RepairInsert
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
            this.comboBoxServiceNames = new System.Windows.Forms.ComboBox();
            this.repair_price_info = new System.Windows.Forms.TextBox();
            this.repair_price = new System.Windows.Forms.Label();
            this.cancel_button = new System.Windows.Forms.Button();
            this.accept_button = new System.Windows.Forms.Button();
            this.repair_date = new System.Windows.Forms.Label();
            this.service_id = new System.Windows.Forms.Label();
            this.repair_form_main_label = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.comboBoxServiceNames);
            this.panel1.Controls.Add(this.repair_price_info);
            this.panel1.Controls.Add(this.repair_price);
            this.panel1.Controls.Add(this.cancel_button);
            this.panel1.Controls.Add(this.accept_button);
            this.panel1.Controls.Add(this.repair_date);
            this.panel1.Controls.Add(this.service_id);
            this.panel1.Controls.Add(this.repair_form_main_label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(481, 275);
            this.panel1.TabIndex = 2;
            // 
            // comboBoxServiceNames
            // 
            this.comboBoxServiceNames.FormattingEnabled = true;
            this.comboBoxServiceNames.Location = new System.Drawing.Point(225, 91);
            this.comboBoxServiceNames.Name = "comboBoxServiceNames";
            this.comboBoxServiceNames.Size = new System.Drawing.Size(232, 23);
            this.comboBoxServiceNames.TabIndex = 9;
            this.comboBoxServiceNames.Click += new System.EventHandler(this.comboBoxServiceNames_Click);
            // 
            // repair_price_info
            // 
            this.repair_price_info.Location = new System.Drawing.Point(225, 165);
            this.repair_price_info.Name = "repair_price_info";
            this.repair_price_info.Size = new System.Drawing.Size(232, 23);
            this.repair_price_info.TabIndex = 8;
            // 
            // repair_price
            // 
            this.repair_price.AutoSize = true;
            this.repair_price.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.repair_price.Location = new System.Drawing.Point(12, 163);
            this.repair_price.Name = "repair_price";
            this.repair_price.Size = new System.Drawing.Size(205, 25);
            this.repair_price.TabIndex = 7;
            this.repair_price.Text = "Стоимость ремонта:";
            // 
            // cancel_button
            // 
            this.cancel_button.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancel_button.Location = new System.Drawing.Point(267, 212);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(168, 40);
            this.cancel_button.TabIndex = 6;
            this.cancel_button.Text = "Отменить";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // accept_button
            // 
            this.accept_button.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.accept_button.Location = new System.Drawing.Point(39, 212);
            this.accept_button.Name = "accept_button";
            this.accept_button.Size = new System.Drawing.Size(168, 40);
            this.accept_button.TabIndex = 5;
            this.accept_button.Text = "Принять";
            this.accept_button.UseVisualStyleBackColor = true;
            this.accept_button.Click += new System.EventHandler(this.accept_button_Click);
            // 
            // repair_date
            // 
            this.repair_date.AutoSize = true;
            this.repair_date.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.repair_date.Location = new System.Drawing.Point(12, 125);
            this.repair_date.Name = "repair_date";
            this.repair_date.Size = new System.Drawing.Size(148, 25);
            this.repair_date.TabIndex = 3;
            this.repair_date.Text = "Дата ремонта:";
            // 
            // service_id
            // 
            this.service_id.AutoSize = true;
            this.service_id.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.service_id.Location = new System.Drawing.Point(12, 86);
            this.service_id.Name = "service_id";
            this.service_id.Size = new System.Drawing.Size(124, 25);
            this.service_id.TabIndex = 2;
            this.service_id.Text = "Вид услуги:";
            // 
            // repair_form_main_label
            // 
            this.repair_form_main_label.AutoSize = true;
            this.repair_form_main_label.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.repair_form_main_label.Location = new System.Drawing.Point(63, 29);
            this.repair_form_main_label.Name = "repair_form_main_label";
            this.repair_form_main_label.Size = new System.Drawing.Size(344, 32);
            this.repair_form_main_label.TabIndex = 1;
            this.repair_form_main_label.Text = "Введите данные о ремонте";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy.mm.dd";
            this.dateTimePicker1.Location = new System.Drawing.Point(225, 127);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(232, 23);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // RepairInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 275);
            this.Controls.Add(this.panel1);
            this.Name = "RepairInsert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RepairInsert";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TextBox repair_price_info;
        private Label repair_price;
        private Button cancel_button;
        private Button accept_button;
        private Label repair_date;
        private Label service_id;
        private Label repair_form_main_label;
        private TextBox textBox1;
        private ComboBox comboBoxServiceNames;
        private DateTimePicker dateTimePicker1;
    }
}