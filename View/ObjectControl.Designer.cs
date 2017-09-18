namespace View
{
    partial class ObjectControl
    {
        /// <summary> 
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerDateOfReceipt = new System.Windows.Forms.DateTimePicker();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.maskedTextBoxHour = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxMoneyHour = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxMoneyOneChange = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxNumberChange = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxBaseSalary = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxTimeOff = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxWeekend = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxWorkingDays = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePickerDateOfReceipt);
            this.groupBox1.Controls.Add(this.textBoxLastName);
            this.groupBox1.Controls.Add(this.textBoxFirstName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 182);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "InfoPerson";
            // 
            // dateTimePickerDateOfReceipt
            // 
            this.dateTimePickerDateOfReceipt.CustomFormat = "dd.MM.yyyy";
            this.dateTimePickerDateOfReceipt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDateOfReceipt.Location = new System.Drawing.Point(101, 127);
            this.dateTimePickerDateOfReceipt.Name = "dateTimePickerDateOfReceipt";
            this.dateTimePickerDateOfReceipt.Size = new System.Drawing.Size(98, 20);
            this.dateTimePickerDateOfReceipt.TabIndex = 26;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(99, 82);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastName.TabIndex = 4;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(99, 44);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFirstName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "DateOfReceipt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lastname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Firstname";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.maskedTextBoxHour);
            this.groupBox2.Controls.Add(this.maskedTextBoxMoneyHour);
            this.groupBox2.Controls.Add(this.maskedTextBoxMoneyOneChange);
            this.groupBox2.Controls.Add(this.maskedTextBoxNumberChange);
            this.groupBox2.Controls.Add(this.maskedTextBoxBaseSalary);
            this.groupBox2.Controls.Add(this.maskedTextBoxTimeOff);
            this.groupBox2.Controls.Add(this.maskedTextBoxWeekend);
            this.groupBox2.Controls.Add(this.maskedTextBoxWorkingDays);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(279, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(466, 334);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CalculateSalary";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Зарплата по окладу",
            "Зарплата по ставке",
            "Зарплата почасовая"});
            this.comboBox1.Location = new System.Drawing.Point(320, 71);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(341, 145);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(299, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Salary";
            // 
            // maskedTextBoxHour
            // 
            this.maskedTextBoxHour.Location = new System.Drawing.Point(136, 178);
            this.maskedTextBoxHour.Mask = "000";
            this.maskedTextBoxHour.Name = "maskedTextBoxHour";
            this.maskedTextBoxHour.Size = new System.Drawing.Size(76, 20);
            this.maskedTextBoxHour.TabIndex = 15;
            // 
            // maskedTextBoxMoneyHour
            // 
            this.maskedTextBoxMoneyHour.Location = new System.Drawing.Point(136, 263);
            this.maskedTextBoxMoneyHour.Mask = "#09.099";
            this.maskedTextBoxMoneyHour.Name = "maskedTextBoxMoneyHour";
            this.maskedTextBoxMoneyHour.Size = new System.Drawing.Size(76, 20);
            this.maskedTextBoxMoneyHour.TabIndex = 14;
            // 
            // maskedTextBoxMoneyOneChange
            // 
            this.maskedTextBoxMoneyOneChange.Location = new System.Drawing.Point(136, 301);
            this.maskedTextBoxMoneyOneChange.Mask = "#09.099";
            this.maskedTextBoxMoneyOneChange.Name = "maskedTextBoxMoneyOneChange";
            this.maskedTextBoxMoneyOneChange.Size = new System.Drawing.Size(76, 20);
            this.maskedTextBoxMoneyOneChange.TabIndex = 13;
            // 
            // maskedTextBoxNumberChange
            // 
            this.maskedTextBoxNumberChange.Location = new System.Drawing.Point(136, 224);
            this.maskedTextBoxNumberChange.Mask = "00";
            this.maskedTextBoxNumberChange.Name = "maskedTextBoxNumberChange";
            this.maskedTextBoxNumberChange.Size = new System.Drawing.Size(76, 20);
            this.maskedTextBoxNumberChange.TabIndex = 12;
            // 
            // maskedTextBoxBaseSalary
            // 
            this.maskedTextBoxBaseSalary.Location = new System.Drawing.Point(136, 144);
            this.maskedTextBoxBaseSalary.Mask = "###09.099";
            this.maskedTextBoxBaseSalary.Name = "maskedTextBoxBaseSalary";
            this.maskedTextBoxBaseSalary.Size = new System.Drawing.Size(76, 20);
            this.maskedTextBoxBaseSalary.TabIndex = 11;
            // 
            // maskedTextBoxTimeOff
            // 
            this.maskedTextBoxTimeOff.Location = new System.Drawing.Point(136, 105);
            this.maskedTextBoxTimeOff.Mask = "0";
            this.maskedTextBoxTimeOff.Name = "maskedTextBoxTimeOff";
            this.maskedTextBoxTimeOff.Size = new System.Drawing.Size(76, 20);
            this.maskedTextBoxTimeOff.TabIndex = 10;
            // 
            // maskedTextBoxWeekend
            // 
            this.maskedTextBoxWeekend.Location = new System.Drawing.Point(136, 72);
            this.maskedTextBoxWeekend.Mask = "0";
            this.maskedTextBoxWeekend.Name = "maskedTextBoxWeekend";
            this.maskedTextBoxWeekend.Size = new System.Drawing.Size(76, 20);
            this.maskedTextBoxWeekend.TabIndex = 9;
            // 
            // maskedTextBoxWorkingDays
            // 
            this.maskedTextBoxWorkingDays.Location = new System.Drawing.Point(136, 28);
            this.maskedTextBoxWorkingDays.Mask = "00";
            this.maskedTextBoxWorkingDays.Name = "maskedTextBoxWorkingDays";
            this.maskedTextBoxWorkingDays.Size = new System.Drawing.Size(76, 20);
            this.maskedTextBoxWorkingDays.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 308);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "MoneyOneChange";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 227);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "NumberChange";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 270);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "MoneyHour";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Hour";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "BaseSalary";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "TimeOff";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Weekend";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "WorkingDays";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 30);
            this.button1.TabIndex = 28;
            this.button1.Text = "Create Random Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ObjectControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ObjectControl";
            this.Size = new System.Drawing.Size(769, 357);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxHour;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxMoneyHour;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxMoneyOneChange;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNumberChange;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxBaseSalary;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTimeOff;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxWeekend;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxWorkingDays;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOfReceipt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
