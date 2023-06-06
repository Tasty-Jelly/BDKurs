namespace IDZ_BD
{
    partial class DeviceInsert
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
            this.comboBoxDeviceNames = new System.Windows.Forms.ComboBox();
            this.comboBoxDeviceStatus = new System.Windows.Forms.ComboBox();
            this.device_status = new System.Windows.Forms.Label();
            this.cancel_button = new System.Windows.Forms.Button();
            this.accept_button = new System.Windows.Forms.Button();
            this.repair_id_info = new System.Windows.Forms.TextBox();
            this.repair_id = new System.Windows.Forms.Label();
            this.device_name = new System.Windows.Forms.Label();
            this.device_form_main_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxDeviceNames);
            this.panel1.Controls.Add(this.comboBoxDeviceStatus);
            this.panel1.Controls.Add(this.device_status);
            this.panel1.Controls.Add(this.cancel_button);
            this.panel1.Controls.Add(this.accept_button);
            this.panel1.Controls.Add(this.repair_id_info);
            this.panel1.Controls.Add(this.repair_id);
            this.panel1.Controls.Add(this.device_name);
            this.panel1.Controls.Add(this.device_form_main_label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 269);
            this.panel1.TabIndex = 2;
            // 
            // comboBoxDeviceNames
            // 
            this.comboBoxDeviceNames.FormattingEnabled = true;
            this.comboBoxDeviceNames.Location = new System.Drawing.Point(234, 88);
            this.comboBoxDeviceNames.Name = "comboBoxDeviceNames";
            this.comboBoxDeviceNames.Size = new System.Drawing.Size(232, 23);
            this.comboBoxDeviceNames.TabIndex = 10;
            this.comboBoxDeviceNames.Click += new System.EventHandler(this.comboBoxDeviceNames_Click);
            // 
            // comboBoxDeviceStatus
            // 
            this.comboBoxDeviceStatus.FormattingEnabled = true;
            this.comboBoxDeviceStatus.Items.AddRange(new object[] {
            "В работе",
            "Готов",
            "Выдан"});
            this.comboBoxDeviceStatus.Location = new System.Drawing.Point(234, 168);
            this.comboBoxDeviceStatus.Name = "comboBoxDeviceStatus";
            this.comboBoxDeviceStatus.Size = new System.Drawing.Size(232, 23);
            this.comboBoxDeviceStatus.TabIndex = 9;
            // 
            // device_status
            // 
            this.device_status.AutoSize = true;
            this.device_status.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.device_status.Location = new System.Drawing.Point(12, 163);
            this.device_status.Name = "device_status";
            this.device_status.Size = new System.Drawing.Size(194, 25);
            this.device_status.TabIndex = 7;
            this.device_status.Text = "Статус устройства:";
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
            // repair_id_info
            // 
            this.repair_id_info.Location = new System.Drawing.Point(234, 127);
            this.repair_id_info.Name = "repair_id_info";
            this.repair_id_info.Size = new System.Drawing.Size(232, 23);
            this.repair_id_info.TabIndex = 4;
            // 
            // repair_id
            // 
            this.repair_id.AutoSize = true;
            this.repair_id.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.repair_id.Location = new System.Drawing.Point(12, 125);
            this.repair_id.Name = "repair_id";
            this.repair_id.Size = new System.Drawing.Size(124, 25);
            this.repair_id.TabIndex = 3;
            this.repair_id.Text = "ID ремонта:";
            // 
            // device_name
            // 
            this.device_name.AutoSize = true;
            this.device_name.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.device_name.Location = new System.Drawing.Point(12, 86);
            this.device_name.Name = "device_name";
            this.device_name.Size = new System.Drawing.Size(219, 25);
            this.device_name.TabIndex = 2;
            this.device_name.Text = "Название устройства:";
            // 
            // device_form_main_label
            // 
            this.device_form_main_label.AutoSize = true;
            this.device_form_main_label.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.device_form_main_label.Location = new System.Drawing.Point(39, 30);
            this.device_form_main_label.Name = "device_form_main_label";
            this.device_form_main_label.Size = new System.Drawing.Size(393, 32);
            this.device_form_main_label.TabIndex = 1;
            this.device_form_main_label.Text = "Введите данные об устройстве";
            // 
            // DeviceInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 269);
            this.Controls.Add(this.panel1);
            this.Name = "DeviceInsert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DeviceInsert";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label device_status;
        private Button cancel_button;
        private Button accept_button;
        private TextBox repair_id_info;
        private Label repair_id;
        private Label device_name;
        private Label device_form_main_label;
        private ComboBox comboBoxDeviceStatus;
        private ComboBox comboBoxDeviceNames;
    }
}