namespace View
{
    partial class CreatingForm
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerDateOfReceipt = new System.Windows.Forms.DateTimePicker();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonSalaryHourly = new System.Windows.Forms.RadioButton();
            this.radioButtonSalary = new System.Windows.Forms.RadioButton();
            this.radioButtonSalaryRate = new System.Windows.Forms.RadioButton();
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonОК = new System.Windows.Forms.Button();
            this.buttonCalculateSalary = new System.Windows.Forms.Button();
            this.errorProviderFirstname = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderLastname = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDateOfReceipt = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderWorkingDays = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderWeekend = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderTimeOff = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderBaseSalary = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderHour = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderNumberChange = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderMoneyHour = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderMoneyOneChange = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonCreateRandomData = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFirstname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLastname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDateOfReceipt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderWorkingDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderWeekend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTimeOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBaseSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNumberChange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMoneyHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMoneyOneChange)).BeginInit();
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
            this.groupBox1.Location = new System.Drawing.Point(27, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 182);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "InfoPerson";
            // 
            // dateTimePickerDateOfReceipt
            // 
            this.dateTimePickerDateOfReceipt.CustomFormat = "dd.MM.yyyy";
            this.dateTimePickerDateOfReceipt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDateOfReceipt.Location = new System.Drawing.Point(101, 127);
            this.dateTimePickerDateOfReceipt.Name = "dateTimePickerDateOfReceipt";
            this.dateTimePickerDateOfReceipt.Size = new System.Drawing.Size(142, 20);
            this.dateTimePickerDateOfReceipt.TabIndex = 26;
            this.dateTimePickerDateOfReceipt.Leave += new System.EventHandler(this.dateTimePickerDateOfReceipt_Leave);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(99, 82);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastName.TabIndex = 4;
            this.textBoxLastName.Leave += new System.EventHandler(this.textBoxLastName_Leave);
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(99, 44);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFirstName.TabIndex = 3;
            this.textBoxFirstName.Leave += new System.EventHandler(this.textBoxFirstName_Leave);
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
            this.groupBox2.Controls.Add(this.radioButtonSalaryHourly);
            this.groupBox2.Controls.Add(this.radioButtonSalary);
            this.groupBox2.Controls.Add(this.radioButtonSalaryRate);
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
            this.groupBox2.Location = new System.Drawing.Point(349, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(465, 344);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CalculateSalary";
            // 
            // radioButtonSalaryHourly
            // 
            this.radioButtonSalaryHourly.AutoSize = true;
            this.radioButtonSalaryHourly.Location = new System.Drawing.Point(302, 105);
            this.radioButtonSalaryHourly.Name = "radioButtonSalaryHourly";
            this.radioButtonSalaryHourly.Size = new System.Drawing.Size(129, 17);
            this.radioButtonSalaryHourly.TabIndex = 21;
            this.radioButtonSalaryHourly.TabStop = true;
            this.radioButtonSalaryHourly.Text = "Зарплата почасовая";
            this.radioButtonSalaryHourly.UseVisualStyleBackColor = true;
            this.radioButtonSalaryHourly.CheckedChanged += new System.EventHandler(this.radioButtonSalaryHourly_CheckedChanged);
            // 
            // radioButtonSalary
            // 
            this.radioButtonSalary.AutoSize = true;
            this.radioButtonSalary.Location = new System.Drawing.Point(302, 64);
            this.radioButtonSalary.Name = "radioButtonSalary";
            this.radioButtonSalary.Size = new System.Drawing.Size(126, 17);
            this.radioButtonSalary.TabIndex = 20;
            this.radioButtonSalary.TabStop = true;
            this.radioButtonSalary.Text = "Зарплата по ставке";
            this.radioButtonSalary.UseVisualStyleBackColor = true;
            this.radioButtonSalary.CheckedChanged += new System.EventHandler(this.radioButtonSalary_CheckedChanged);
            // 
            // radioButtonSalaryRate
            // 
            this.radioButtonSalaryRate.AutoSize = true;
            this.radioButtonSalaryRate.Location = new System.Drawing.Point(302, 31);
            this.radioButtonSalaryRate.Name = "radioButtonSalaryRate";
            this.radioButtonSalaryRate.Size = new System.Drawing.Size(126, 17);
            this.radioButtonSalaryRate.TabIndex = 19;
            this.radioButtonSalaryRate.TabStop = true;
            this.radioButtonSalaryRate.Text = "Зарплата по окладу";
            this.radioButtonSalaryRate.UseVisualStyleBackColor = true;
            this.radioButtonSalaryRate.CheckedChanged += new System.EventHandler(this.radioButtonSalaryRate_CheckedChanged);
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
            this.maskedTextBoxHour.Leave += new System.EventHandler(this.maskedTextBoxHour_Leave);
            // 
            // maskedTextBoxMoneyHour
            // 
            this.maskedTextBoxMoneyHour.Location = new System.Drawing.Point(136, 263);
            this.maskedTextBoxMoneyHour.Mask = "#09.099";
            this.maskedTextBoxMoneyHour.Name = "maskedTextBoxMoneyHour";
            this.maskedTextBoxMoneyHour.Size = new System.Drawing.Size(76, 20);
            this.maskedTextBoxMoneyHour.TabIndex = 14;
            this.maskedTextBoxMoneyHour.Leave += new System.EventHandler(this.maskedTextBoxMoneyHour_Leave);
            // 
            // maskedTextBoxMoneyOneChange
            // 
            this.maskedTextBoxMoneyOneChange.Location = new System.Drawing.Point(136, 301);
            this.maskedTextBoxMoneyOneChange.Mask = "#09.099";
            this.maskedTextBoxMoneyOneChange.Name = "maskedTextBoxMoneyOneChange";
            this.maskedTextBoxMoneyOneChange.Size = new System.Drawing.Size(76, 20);
            this.maskedTextBoxMoneyOneChange.TabIndex = 13;
            this.maskedTextBoxMoneyOneChange.Leave += new System.EventHandler(this.maskedTextBoxMoneyOneChange_Leave);
            // 
            // maskedTextBoxNumberChange
            // 
            this.maskedTextBoxNumberChange.Location = new System.Drawing.Point(136, 224);
            this.maskedTextBoxNumberChange.Mask = "00";
            this.maskedTextBoxNumberChange.Name = "maskedTextBoxNumberChange";
            this.maskedTextBoxNumberChange.Size = new System.Drawing.Size(76, 20);
            this.maskedTextBoxNumberChange.TabIndex = 12;
            this.maskedTextBoxNumberChange.Leave += new System.EventHandler(this.maskedTextBoxNumberChange_Leave);
            // 
            // maskedTextBoxBaseSalary
            // 
            this.maskedTextBoxBaseSalary.Location = new System.Drawing.Point(136, 144);
            this.maskedTextBoxBaseSalary.Mask = "###09.099";
            this.maskedTextBoxBaseSalary.Name = "maskedTextBoxBaseSalary";
            this.maskedTextBoxBaseSalary.Size = new System.Drawing.Size(76, 20);
            this.maskedTextBoxBaseSalary.TabIndex = 11;
            this.maskedTextBoxBaseSalary.Leave += new System.EventHandler(this.maskedTextBoxBaseSalary_Leave);
            // 
            // maskedTextBoxTimeOff
            // 
            this.maskedTextBoxTimeOff.Location = new System.Drawing.Point(136, 105);
            this.maskedTextBoxTimeOff.Mask = "0";
            this.maskedTextBoxTimeOff.Name = "maskedTextBoxTimeOff";
            this.maskedTextBoxTimeOff.Size = new System.Drawing.Size(76, 20);
            this.maskedTextBoxTimeOff.TabIndex = 10;
            this.maskedTextBoxTimeOff.Leave += new System.EventHandler(this.maskedTextBoxTimeOff_Leave);
            // 
            // maskedTextBoxWeekend
            // 
            this.maskedTextBoxWeekend.Location = new System.Drawing.Point(136, 72);
            this.maskedTextBoxWeekend.Mask = "0";
            this.maskedTextBoxWeekend.Name = "maskedTextBoxWeekend";
            this.maskedTextBoxWeekend.Size = new System.Drawing.Size(76, 20);
            this.maskedTextBoxWeekend.TabIndex = 9;
            this.maskedTextBoxWeekend.Leave += new System.EventHandler(this.maskedTextBoxWeekend_Leave);
            // 
            // maskedTextBoxWorkingDays
            // 
            this.maskedTextBoxWorkingDays.Location = new System.Drawing.Point(136, 28);
            this.maskedTextBoxWorkingDays.Mask = "00";
            this.maskedTextBoxWorkingDays.Name = "maskedTextBoxWorkingDays";
            this.maskedTextBoxWorkingDays.Size = new System.Drawing.Size(76, 20);
            this.maskedTextBoxWorkingDays.TabIndex = 8;
            this.maskedTextBoxWorkingDays.Leave += new System.EventHandler(this.maskedTextBoxWorkingDays_Leave);
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
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(597, 368);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(69, 23);
            this.buttonCancel.TabIndex = 23;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonОК
            // 
            this.buttonОК.Location = new System.Drawing.Point(485, 368);
            this.buttonОК.Name = "buttonОК";
            this.buttonОК.Size = new System.Drawing.Size(75, 23);
            this.buttonОК.TabIndex = 22;
            this.buttonОК.Text = "OK";
            this.buttonОК.UseVisualStyleBackColor = true;
            this.buttonОК.Click += new System.EventHandler(this.buttonОК_Click);
            // 
            // buttonCalculateSalary
            // 
            this.buttonCalculateSalary.Location = new System.Drawing.Point(27, 236);
            this.buttonCalculateSalary.Name = "buttonCalculateSalary";
            this.buttonCalculateSalary.Size = new System.Drawing.Size(153, 37);
            this.buttonCalculateSalary.TabIndex = 24;
            this.buttonCalculateSalary.Text = "Calculate Salary";
            this.buttonCalculateSalary.UseVisualStyleBackColor = true;
            this.buttonCalculateSalary.Click += new System.EventHandler(this.buttonCalculateSalary_Click);
            // 
            // errorProviderFirstname
            // 
            this.errorProviderFirstname.ContainerControl = this;
            // 
            // errorProviderLastname
            // 
            this.errorProviderLastname.ContainerControl = this;
            // 
            // errorProviderDateOfReceipt
            // 
            this.errorProviderDateOfReceipt.ContainerControl = this;
            // 
            // errorProviderWorkingDays
            // 
            this.errorProviderWorkingDays.ContainerControl = this;
            // 
            // errorProviderWeekend
            // 
            this.errorProviderWeekend.ContainerControl = this;
            // 
            // errorProviderTimeOff
            // 
            this.errorProviderTimeOff.ContainerControl = this;
            // 
            // errorProviderBaseSalary
            // 
            this.errorProviderBaseSalary.ContainerControl = this;
            // 
            // errorProviderHour
            // 
            this.errorProviderHour.ContainerControl = this;
            // 
            // errorProviderNumberChange
            // 
            this.errorProviderNumberChange.ContainerControl = this;
            // 
            // errorProviderMoneyHour
            // 
            this.errorProviderMoneyHour.ContainerControl = this;
            // 
            // errorProviderMoneyOneChange
            // 
            this.errorProviderMoneyOneChange.ContainerControl = this;
            // 
            // buttonCreateRandomData
            // 
            this.buttonCreateRandomData.Location = new System.Drawing.Point(27, 302);
            this.buttonCreateRandomData.Name = "buttonCreateRandomData";
            this.buttonCreateRandomData.Size = new System.Drawing.Size(153, 38);
            this.buttonCreateRandomData.TabIndex = 25;
            this.buttonCreateRandomData.Text = "Create Random Data";
            this.buttonCreateRandomData.UseVisualStyleBackColor = true;
            this.buttonCreateRandomData.Click += new System.EventHandler(this.buttonCreateRandomData_Click);
            // 
            // CreatingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 403);
            this.Controls.Add(this.buttonCreateRandomData);
            this.Controls.Add(this.buttonCalculateSalary);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonОК);
            this.Controls.Add(this.groupBox1);
            this.Name = "CreatingForm";
            this.Text = "CreatingForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFirstname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLastname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDateOfReceipt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderWorkingDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderWeekend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTimeOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBaseSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNumberChange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMoneyHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMoneyOneChange)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxHour;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxMoneyHour;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxMoneyOneChange;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNumberChange;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxBaseSalary;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTimeOff;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxWeekend;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxWorkingDays;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.RadioButton radioButtonSalaryHourly;
        private System.Windows.Forms.RadioButton radioButtonSalary;
        private System.Windows.Forms.RadioButton radioButtonSalaryRate;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonОК;
        private System.Windows.Forms.Button buttonCalculateSalary;
        private System.Windows.Forms.ErrorProvider errorProviderFirstname;
        private System.Windows.Forms.ErrorProvider errorProviderLastname;
        private System.Windows.Forms.ErrorProvider errorProviderDateOfReceipt;
        private System.Windows.Forms.ErrorProvider errorProviderWorkingDays;
        private System.Windows.Forms.ErrorProvider errorProviderWeekend;
        private System.Windows.Forms.ErrorProvider errorProviderTimeOff;
        private System.Windows.Forms.ErrorProvider errorProviderBaseSalary;
        private System.Windows.Forms.ErrorProvider errorProviderHour;
        private System.Windows.Forms.ErrorProvider errorProviderNumberChange;
        private System.Windows.Forms.ErrorProvider errorProviderMoneyHour;
        private System.Windows.Forms.ErrorProvider errorProviderMoneyOneChange;
        private System.Windows.Forms.Button buttonCreateRandomData;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOfReceipt;

    }
}