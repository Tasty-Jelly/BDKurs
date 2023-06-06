namespace IDZ_BD
{
    partial class client_insert_form
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
            this.comboBoxClientNames = new System.Windows.Forms.ComboBox();
            this.cancel_button = new System.Windows.Forms.Button();
            this.accept_button = new System.Windows.Forms.Button();
            this.client_phone_info = new System.Windows.Forms.TextBox();
            this.client_phone = new System.Windows.Forms.Label();
            this.client_name = new System.Windows.Forms.Label();
            this.client_form_main_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxClientNames);
            this.panel1.Controls.Add(this.cancel_button);
            this.panel1.Controls.Add(this.accept_button);
            this.panel1.Controls.Add(this.client_phone_info);
            this.panel1.Controls.Add(this.client_phone);
            this.panel1.Controls.Add(this.client_name);
            this.panel1.Controls.Add(this.client_form_main_label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 247);
            this.panel1.TabIndex = 0;
            // 
            // comboBoxClientNames
            // 
            this.comboBoxClientNames.FormattingEnabled = true;
            this.comboBoxClientNames.Location = new System.Drawing.Point(225, 91);
            this.comboBoxClientNames.Name = "comboBoxClientNames";
            this.comboBoxClientNames.Size = new System.Drawing.Size(232, 23);
            this.comboBoxClientNames.TabIndex = 7;
            this.comboBoxClientNames.Click += new System.EventHandler(this.comboBoxClientNames_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancel_button.Location = new System.Drawing.Point(289, 189);
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
            this.accept_button.Location = new System.Drawing.Point(12, 189);
            this.accept_button.Name = "accept_button";
            this.accept_button.Size = new System.Drawing.Size(168, 40);
            this.accept_button.TabIndex = 5;
            this.accept_button.Text = "Принять";
            this.accept_button.UseVisualStyleBackColor = true;
            this.accept_button.Click += new System.EventHandler(this.accept_button_Click);
            // 
            // client_phone_info
            // 
            this.client_phone_info.Location = new System.Drawing.Point(225, 133);
            this.client_phone_info.Name = "client_phone_info";
            this.client_phone_info.Size = new System.Drawing.Size(232, 23);
            this.client_phone_info.TabIndex = 4;
            // 
            // client_phone
            // 
            this.client_phone.AutoSize = true;
            this.client_phone.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.client_phone.Location = new System.Drawing.Point(12, 131);
            this.client_phone.Name = "client_phone";
            this.client_phone.Size = new System.Drawing.Size(168, 25);
            this.client_phone.TabIndex = 3;
            this.client_phone.Text = "Номер телефона";
            // 
            // client_name
            // 
            this.client_name.AutoSize = true;
            this.client_name.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.client_name.Location = new System.Drawing.Point(12, 86);
            this.client_name.Name = "client_name";
            this.client_name.Size = new System.Drawing.Size(57, 25);
            this.client_name.TabIndex = 2;
            this.client_name.Text = "ФИО";
            // 
            // client_form_main_label
            // 
            this.client_form_main_label.AutoSize = true;
            this.client_form_main_label.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.client_form_main_label.Location = new System.Drawing.Point(80, 21);
            this.client_form_main_label.Name = "client_form_main_label";
            this.client_form_main_label.Size = new System.Drawing.Size(323, 32);
            this.client_form_main_label.TabIndex = 1;
            this.client_form_main_label.Text = "Введите данные клиента";
            // 
            // client_insert_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 247);
            this.Controls.Add(this.panel1);
            this.Name = "client_insert_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добаление записи Клиент";
            this.Load += new System.EventHandler(this.client_insert_form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button cancel_button;
        private Button accept_button;
        private TextBox client_phone_info;
        private Label client_phone;
        private Label client_name;
        private Label client_form_main_label;
        private TextBox client_name_info;
        private ComboBox comboBoxClientNames;
    }
}