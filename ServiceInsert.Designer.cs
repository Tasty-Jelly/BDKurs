namespace IDZ_BD
{
    partial class ServiceInsert
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
            this.comboBoxServiceType = new System.Windows.Forms.ComboBox();
            this.service_description_info = new System.Windows.Forms.TextBox();
            this.service_name = new System.Windows.Forms.Label();
            this.cancel_button = new System.Windows.Forms.Button();
            this.accept_button = new System.Windows.Forms.Button();
            this.service_name_info = new System.Windows.Forms.TextBox();
            this.detail_description = new System.Windows.Forms.Label();
            this.service_type = new System.Windows.Forms.Label();
            this.service_form_main_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxServiceType);
            this.panel1.Controls.Add(this.service_description_info);
            this.panel1.Controls.Add(this.service_name);
            this.panel1.Controls.Add(this.cancel_button);
            this.panel1.Controls.Add(this.accept_button);
            this.panel1.Controls.Add(this.service_name_info);
            this.panel1.Controls.Add(this.detail_description);
            this.panel1.Controls.Add(this.service_type);
            this.panel1.Controls.Add(this.service_form_main_label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 285);
            this.panel1.TabIndex = 2;
            // 
            // comboBoxServiceType
            // 
            this.comboBoxServiceType.FormattingEnabled = true;
            this.comboBoxServiceType.Items.AddRange(new object[] {
            "Дисплей",
            "АКБ",
            "Разъем",
            "Крышка"});
            this.comboBoxServiceType.Location = new System.Drawing.Point(276, 54);
            this.comboBoxServiceType.Name = "comboBoxServiceType";
            this.comboBoxServiceType.Size = new System.Drawing.Size(232, 23);
            this.comboBoxServiceType.TabIndex = 11;
            // 
            // service_description_info
            // 
            this.service_description_info.Location = new System.Drawing.Point(276, 124);
            this.service_description_info.Multiline = true;
            this.service_description_info.Name = "service_description_info";
            this.service_description_info.Size = new System.Drawing.Size(232, 91);
            this.service_description_info.TabIndex = 10;
            // 
            // service_name
            // 
            this.service_name.AutoSize = true;
            this.service_name.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.service_name.Location = new System.Drawing.Point(12, 88);
            this.service_name.Name = "service_name";
            this.service_name.Size = new System.Drawing.Size(225, 25);
            this.service_name.TabIndex = 8;
            this.service_name.Text = "Наименование услуги:";
            // 
            // cancel_button
            // 
            this.cancel_button.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancel_button.Location = new System.Drawing.Point(307, 231);
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
            this.accept_button.Location = new System.Drawing.Point(53, 231);
            this.accept_button.Name = "accept_button";
            this.accept_button.Size = new System.Drawing.Size(168, 40);
            this.accept_button.TabIndex = 5;
            this.accept_button.Text = "Принять";
            this.accept_button.UseVisualStyleBackColor = true;
            this.accept_button.Click += new System.EventHandler(this.accept_button_Click);
            // 
            // service_name_info
            // 
            this.service_name_info.Location = new System.Drawing.Point(276, 90);
            this.service_name_info.Name = "service_name_info";
            this.service_name_info.Size = new System.Drawing.Size(232, 23);
            this.service_name_info.TabIndex = 4;
            // 
            // detail_description
            // 
            this.detail_description.AutoSize = true;
            this.detail_description.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.detail_description.Location = new System.Drawing.Point(12, 124);
            this.detail_description.Name = "detail_description";
            this.detail_description.Size = new System.Drawing.Size(109, 25);
            this.detail_description.TabIndex = 3;
            this.detail_description.Text = "Описание:";
            // 
            // service_type
            // 
            this.service_type.AutoSize = true;
            this.service_type.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.service_type.Location = new System.Drawing.Point(12, 54);
            this.service_type.Name = "service_type";
            this.service_type.Size = new System.Drawing.Size(126, 25);
            this.service_type.TabIndex = 2;
            this.service_type.Text = "Тип детали:";
            // 
            // service_form_main_label
            // 
            this.service_form_main_label.AutoSize = true;
            this.service_form_main_label.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.service_form_main_label.Location = new System.Drawing.Point(101, 9);
            this.service_form_main_label.Name = "service_form_main_label";
            this.service_form_main_label.Size = new System.Drawing.Size(335, 32);
            this.service_form_main_label.TabIndex = 1;
            this.service_form_main_label.Text = "Введите данные об услуге";
            // 
            // ServiceInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 285);
            this.Controls.Add(this.panel1);
            this.Name = "ServiceInsert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ServiceInsert";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TextBox service_description_info;
        private Label service_name;
        private Button cancel_button;
        private Button accept_button;
        private TextBox service_name_info;
        private Label detail_description;
        private Label service_type;
        private Label service_form_main_label;
        private ComboBox comboBoxServiceType;
    }
}