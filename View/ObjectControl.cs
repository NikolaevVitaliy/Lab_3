using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using System.Text.RegularExpressions;

namespace View
{
    public partial class ObjectControl : UserControl
    {


        private ISalary _person;
        private bool _ExitCondition;
        private bool _readOnly;

        public ObjectControl()
        {
            InitializeComponent();

        }


   
        public bool ExitCondition
        {

            get
            {
                if (textBoxFirstName.Text == "" || textBoxLastName.Text == "")
                {
                    MessageBox.Show("Не были введены имя или фамилия!");
                    return _ExitCondition;
                }
                if (comboBox1.SelectedIndex == 0 && (maskedTextBoxNumberChange.Text == "" || maskedTextBoxMoneyOneChange.Text == ""))
                {
                    MessageBox.Show("Введите кол-во смен и кол-во денег за одну смену!");
                    return _ExitCondition;
                }
                if (comboBox1.SelectedIndex == 1 &&
                    (maskedTextBoxBaseSalary.Text == "" || maskedTextBoxWorkingDays.Text == "" || maskedTextBoxWeekend.Text == "" || maskedTextBoxTimeOff.Text == ""))
                {
                    MessageBox.Show("Введите базовую зарплату, рабочие дни, выходные, и отгулы!");
                    return _ExitCondition;
                }
                if (comboBox1.SelectedIndex == 2 && (maskedTextBoxHour.Text == "" || maskedTextBoxMoneyHour.Text == ""))
                {
                    MessageBox.Show("Введите кол-во часов и кол-во денег за один час!");
                    return _ExitCondition;
                }


                return _ExitCondition = true;
            }
        }



        public ISalary Person
        {
            get
            {


                if (comboBox1.SelectedIndex == 0)
                {

                    var Rate = new Model.SalaryRate();

                    Rate.FirstName = Convert.ToString(textBoxFirstName.Text);
                    Rate.LastName = Convert.ToString(textBoxLastName.Text);
                    Rate.DateOfReceipt = Convert.ToString(dateTimePickerDateOfReceipt.Text);

                    Rate.NumberChange = Convert.ToInt32(maskedTextBoxNumberChange.Text);
                    Rate.MoneyOneChange = Convert.ToDouble(maskedTextBoxMoneyOneChange.Text);
                    _person = Rate;
                }


                else if (comboBox1.SelectedIndex == 1)
                {
                    var Salary = new Model.Salary();
                    Salary.FirstName = Convert.ToString(textBoxFirstName.Text);
                    Salary.LastName = Convert.ToString(textBoxLastName.Text);
                    Salary.DateOfReceipt = Convert.ToString(dateTimePickerDateOfReceipt.Text);

                    Salary.Basesalary = Convert.ToDouble(maskedTextBoxBaseSalary.Text);
                    Salary.WorkingDays = Convert.ToInt32(maskedTextBoxWorkingDays.Text);
                    Salary.Weekend = Convert.ToInt32(maskedTextBoxWeekend.Text);
                    Salary.Timeoff = Convert.ToInt32(maskedTextBoxTimeOff.Text);

                    _person = Salary;
                }

                else if (comboBox1.SelectedIndex == 2)
                {
                    var Hourly = new Model.SalaryHourly();
                    Hourly.FirstName = Convert.ToString(textBoxFirstName.Text);
                    Hourly.LastName = Convert.ToString(textBoxLastName.Text);
                    Hourly.DateOfReceipt = Convert.ToString(dateTimePickerDateOfReceipt.Text);

                    Hourly.Hour = Convert.ToInt32(maskedTextBoxHour.Text);
                    Hourly.Money = Convert.ToDouble(maskedTextBoxMoneyHour.Text);

                    _person = Hourly;
                }
                return _person;
            }

            set
            {

                
                _person = value;

                textBoxFirstName.Text = Convert.ToString(value.FirstName);
                textBoxLastName.Text = Convert.ToString(value.LastName);
                dateTimePickerDateOfReceipt.Text = Convert.ToString(value.DateOfReceipt);

                textBox3.Text = Convert.ToString(Person.GetSalary());
                

                if (value is Model.SalaryRate)
                {
                    
                    var Rate = (Model.SalaryRate)value;

                    comboBox1.SelectedIndex = 0;

                    maskedTextBoxNumberChange.Text = Convert.ToString(Rate.NumberChange);
                    maskedTextBoxMoneyOneChange.Text = Convert.ToString(Rate.MoneyOneChange);
                   
                }
                else if (value is Model.Salary)
                {
                    var Salary = (Model.Salary)value;

                    comboBox1.SelectedIndex = 1;

                    maskedTextBoxBaseSalary.Text = Convert.ToString(Salary.Basesalary);
                    maskedTextBoxWorkingDays.Text = Convert.ToString(Salary.WorkingDays);
                    maskedTextBoxWeekend.Text = Convert.ToString(Salary.Weekend);
                    maskedTextBoxTimeOff.Text = Convert.ToString(Salary.Timeoff);
                }

                else if (value is Model.SalaryHourly)
                {
                    var Hourly = (Model.SalaryHourly)value;

                    comboBox1.SelectedIndex = 2;

                    maskedTextBoxHour.Text = Convert.ToString(Hourly.Hour);
                    maskedTextBoxMoneyHour.Text = Convert.ToString(Hourly.Money);

                }
            }
        }

        

        public bool ReadOnly
        {
            get
            {
                return _readOnly;
            }
            set
            {
                _readOnly = value;
                if (_readOnly)
                {
                    dateTimePickerDateOfReceipt.Enabled = false;
                    comboBox1.Enabled = false;
                    textBoxFirstName.ReadOnly = true;
                    textBoxLastName.ReadOnly = true;
                    maskedTextBoxNumberChange.ReadOnly = true;
                    maskedTextBoxMoneyOneChange.ReadOnly = true;
                    maskedTextBoxBaseSalary.ReadOnly = true;
                    maskedTextBoxWorkingDays.ReadOnly = true;
                    maskedTextBoxWeekend.ReadOnly = true;
                    maskedTextBoxTimeOff.ReadOnly = true;
                    maskedTextBoxHour.ReadOnly = true;
                    maskedTextBoxMoneyHour.ReadOnly = true;

                    _readOnly = true;
                }
                else
                {
                    dateTimePickerDateOfReceipt.Enabled = true;
                    comboBox1.Enabled = true;
                    textBoxFirstName.ReadOnly = false;
                    textBoxLastName.ReadOnly = false;
                    maskedTextBoxNumberChange.ReadOnly = false;
                    maskedTextBoxMoneyOneChange.ReadOnly = false;
                    maskedTextBoxBaseSalary.ReadOnly = false;
                    maskedTextBoxWorkingDays.ReadOnly = false;
                    maskedTextBoxWeekend.ReadOnly = false;
                    maskedTextBoxTimeOff.ReadOnly = false;
                    maskedTextBoxHour.ReadOnly = false;
                    maskedTextBoxMoneyHour.ReadOnly = false;
                    



                    _readOnly = false;
                }
            }
        }

       

        




        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();           
            int personsalary = random.Next();
  
           
            string[] FN = new string[10];
            FN[0] = "Иван";
            FN[1] = "Сергей";
            FN[2] = "Виталий";
            FN[3] = "Василий";
            FN[4] = "Ольга";
            FN[5] = "Катерина";
            FN[6] = "Петр";
            FN[7] = "Евгений";
            FN[8] = "Михаил";
            FN[9] = "Антон";

            int a = 0 + random.Next(9);
            textBoxFirstName.Text = FN[a];


            string[] LN = new string[10];
            LN[0] = "Иванович";
            LN[1] = "Сергеевич";
            LN[2] = "Витальевич";
            LN[3] = "Васильевич";
            LN[4] = "Максимович";
            LN[5] = "Кутузович";
            LN[6] = "Петрович";
            LN[7] = "Евгеньевич";
            LN[8] = "Михайлович";
            LN[9] = "Антонович";
            int b = 0 + random.Next(9);
            textBoxLastName.Text = LN[b];

            string[] DR = new string[10];
            DR[0] = "01.05.2017";
            DR[1] = "02.04.2017";
            DR[2] = "03.03.2017";
            DR[3] = "04.02.2017";
            DR[4] = "05.01.2017";
            DR[5] = "06.12.2016";
            DR[6] = "07.11.2016";
            DR[7] = "08.10.2016";
            DR[8] = "09.09.2016";
            DR[9] = "10.08.2016";
            int c = 0 + random.Next(9);
            dateTimePickerDateOfReceipt.Text = DR[c];

            if (comboBox1.SelectedIndex == 0)
            {

                maskedTextBoxNumberChange.Text = Convert.ToString(1 + random.Next(31));
                maskedTextBoxMoneyOneChange.Text = Convert.ToString(50 + random.NextDouble() * (3000.99 - 1.11));
               
            }

            else if (comboBox1.SelectedIndex == 1)
            {
                maskedTextBoxBaseSalary.Text = Convert.ToString(50 + random.NextDouble() * (99999.99-1.11));
                maskedTextBoxWorkingDays.Text = Convert.ToString(1 + random.Next(31));
                maskedTextBoxWeekend.Text = Convert.ToString(3.111 + random.NextDouble() * (7.999 - 1.111));
                maskedTextBoxTimeOff.Text = Convert.ToString(1.111 + random.NextDouble() * (4.999 - 1.111));
             
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                maskedTextBoxHour.Text = Convert.ToString(1 + random.Next(220));
                maskedTextBoxMoneyHour.Text = Convert.ToString(50 + random.NextDouble()*(1000.99-1.11));
               
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            maskedTextBoxWorkingDays.Visible = comboBox1.SelectedIndex == 1;
            maskedTextBoxWeekend.Visible = comboBox1.SelectedIndex == 1;
            maskedTextBoxTimeOff.Visible = comboBox1.SelectedIndex == 1;
            maskedTextBoxBaseSalary.Visible = comboBox1.SelectedIndex == 1;
            maskedTextBoxHour.Visible = comboBox1.SelectedIndex == 2;
            maskedTextBoxNumberChange.Visible = comboBox1.SelectedIndex == 0;
            maskedTextBoxMoneyHour.Visible = comboBox1.SelectedIndex == 2;
            maskedTextBoxMoneyOneChange.Visible = comboBox1.SelectedIndex == 0;
        }
        }

    


        
    }

