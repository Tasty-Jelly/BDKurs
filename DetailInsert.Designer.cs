namespace IDZ_BD
{
    partial class DetailInsert
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
            this.comboBoxDetailNames = new System.Windows.Forms.ComboBox();
            this.comboBoxDetailName = new System.Windows.Forms.ComboBox();
            this.detail_amount_info = new System.Windows.Forms.TextBox();
            this.detail_price = new System.Windows.Forms.Label();
            this.detail_amount = new System.Windows.Forms.Label();
            this.cancel_button = new System.Windows.Forms.Button();
            this.accept_button = new System.Windows.Forms.Button();
            this.detail_price_info = new System.Windows.Forms.TextBox();
            this.detail_description = new System.Windows.Forms.Label();
            this.detail_name = new System.Windows.Forms.Label();
            this.detail_form_main_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxDetailNames);
            this.panel1.Controls.Add(this.comboBoxDetailName);
            this.panel1.Controls.Add(this.detail_amount_info);
            this.panel1.Controls.Add(this.detail_price);
            this.panel1.Controls.Add(this.detail_amount);
            this.panel1.Controls.Add(this.cancel_button);
            this.panel1.Controls.Add(this.accept_button);
            this.panel1.Controls.Add(this.detail_price_info);
            this.panel1.Controls.Add(this.detail_description);
            this.panel1.Controls.Add(this.detail_name);
            this.panel1.Controls.Add(this.detail_form_main_label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 317);
            this.panel1.TabIndex = 1;
            // 
            // comboBoxDetailNames
            // 
            this.comboBoxDetailNames.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxDetailNames.DropDownHeight = 100;
            this.comboBoxDetailNames.FormattingEnabled = true;
            this.comboBoxDetailNames.IntegralHeight = false;
            this.comboBoxDetailNames.ItemHeight = 15;
            this.comboBoxDetailNames.Location = new System.Drawing.Point(276, 158);
            this.comboBoxDetailNames.Name = "comboBoxDetailNames";
            this.comboBoxDetailNames.Size = new System.Drawing.Size(232, 23);
            this.comboBoxDetailNames.TabIndex = 12;
            this.comboBoxDetailNames.Click += new System.EventHandler(this.comboBoxDetailNames_Click);
            // 
            // comboBoxDetailName
            // 
            this.comboBoxDetailName.FormattingEnabled = true;
            this.comboBoxDetailName.Items.AddRange(new object[] {
            "Дисплей",
            "Аккумулятор",
            "Задняя крышка",
            "Нижняя плата"});
            this.comboBoxDetailName.Location = new System.Drawing.Point(276, 56);
            this.comboBoxDetailName.Name = "comboBoxDetailName";
            this.comboBoxDetailName.Size = new System.Drawing.Size(232, 23);
            this.comboBoxDetailName.TabIndex = 11;
            // 
            // detail_amount_info
            // 
            this.detail_amount_info.Location = new System.Drawing.Point(276, 124);
            this.detail_amount_info.Name = "detail_amount_info";
            this.detail_amount_info.Size = new System.Drawing.Size(232, 23);
            this.detail_amount_info.TabIndex = 9;
            // 
            // detail_price
            // 
            this.detail_price.AutoSize = true;
            this.detail_price.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.detail_price.Location = new System.Drawing.Point(12, 88);
            this.detail_price.Name = "detail_price";
            this.detail_price.Size = new System.Drawing.Size(120, 25);
            this.detail_price.TabIndex = 8;
            this.detail_price.Text = "Стоимость:";
            // 
            // detail_amount
            // 
            this.detail_amount.AutoSize = true;
            this.detail_amount.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.detail_amount.Location = new System.Drawing.Point(12, 124);
            this.detail_amount.Name = "detail_amount";
            this.detail_amount.Size = new System.Drawing.Size(225, 25);
            this.detail_amount.TabIndex = 7;
            this.detail_amount.Text = "Количество на складе:";
            // 
            // cancel_button
            // 
            this.cancel_button.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancel_button.Location = new System.Drawing.Point(305, 262);
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
            this.accept_button.Location = new System.Drawing.Point(51, 262);
            this.accept_button.Name = "accept_button";
            this.accept_button.Size = new System.Drawing.Size(168, 40);
            this.accept_button.TabIndex = 5;
            this.accept_button.Text = "Принять";
            this.accept_button.UseVisualStyleBackColor = true;
            this.accept_button.Click += new System.EventHandler(this.accept_button_Click);
            // 
            // detail_price_info
            // 
            this.detail_price_info.Location = new System.Drawing.Point(276, 90);
            this.detail_price_info.Name = "detail_price_info";
            this.detail_price_info.Size = new System.Drawing.Size(232, 23);
            this.detail_price_info.TabIndex = 4;
            // 
            // detail_description
            // 
            this.detail_description.AutoSize = true;
            this.detail_description.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.detail_description.Location = new System.Drawing.Point(12, 158);
            this.detail_description.Name = "detail_description";
            this.detail_description.Size = new System.Drawing.Size(109, 25);
            this.detail_description.TabIndex = 3;
            this.detail_description.Text = "Описание:";
            // 
            // detail_name
            // 
            this.detail_name.AutoSize = true;
            this.detail_name.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.detail_name.Location = new System.Drawing.Point(12, 54);
            this.detail_name.Name = "detail_name";
            this.detail_name.Size = new System.Drawing.Size(126, 25);
            this.detail_name.TabIndex = 2;
            this.detail_name.Text = "Тип детали:";
            // 
            // detail_form_main_label
            // 
            this.detail_form_main_label.AutoSize = true;
            this.detail_form_main_label.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.detail_form_main_label.Location = new System.Drawing.Point(101, 9);
            this.detail_form_main_label.Name = "detail_form_main_label";
            this.detail_form_main_label.Size = new System.Drawing.Size(327, 32);
            this.detail_form_main_label.TabIndex = 1;
            this.detail_form_main_label.Text = "Введите данные о детали";
            // 
            // DetailInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 317);
            this.Controls.Add(this.panel1);
            this.Name = "DetailInsert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DetailInsert";
            this.Load += new System.EventHandler(this.DetailInsert_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button cancel_button;
        private Button accept_button;
        private TextBox detail_price_info;
        private Label detail_description;
        private Label detail_name;
        private Label detail_form_main_label;
        private Label detail_price;
        private Label detail_amount;
        private TextBox detail_amount_info;
        private ComboBox comboBoxDetailName;
        public ComboBox comboBoxDetailNames;
    }
}