using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;


 //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace View
{
    public partial class CreatingForm : Form
    {
        private bool _maskedFirstName = false;
        private bool _maskedLastName = false;
        private bool _maskedDateOfReceipt = false;
        private bool _maskedWorkingDays = false;
        private bool _maskedWeekend = false;
        private bool _maskedTimeOff = false;
        private bool _maskedBaseSalary = false;
        private bool _maskedHour = false;
        private bool _maskedNumberChange = false;
        private bool _maskedMoneyHour = false;
        private bool _maskedMoneyOneChange = false;
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////




        public CreatingForm()
        {
            InitializeComponent();
            #if DEBUG
            buttonCreateRandomData.Visible = true;
            #endif
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void radioButtonSalaryRate_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBoxWorkingDays.Visible = false;
            maskedTextBoxWeekend.Visible = false;
            maskedTextBoxTimeOff.Visible = false;
            maskedTextBoxBaseSalary.Visible = false;
            maskedTextBoxHour.Visible = false;
            maskedTextBoxNumberChange.Visible = true;
            maskedTextBoxMoneyHour.Visible = false;
            maskedTextBoxMoneyOneChange.Visible = true;

        }

        private void radioButtonSalary_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBoxWorkingDays.Visible = true;
            maskedTextBoxWeekend.Visible = true;
            maskedTextBoxTimeOff.Visible = true;
            maskedTextBoxBaseSalary.Visible = true;
            maskedTextBoxHour.Visible = false;
            maskedTextBoxNumberChange.Visible = false;
            maskedTextBoxMoneyHour.Visible = false;
            maskedTextBoxMoneyOneChange.Visible = false;
        }

        private void radioButtonSalaryHourly_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBoxWorkingDays.Visible = false;
            maskedTextBoxWeekend.Visible = false;
            maskedTextBoxTimeOff.Visible = false;
            maskedTextBoxBaseSalary.Visible = false;
            maskedTextBoxHour.Visible = true;
            maskedTextBoxNumberChange.Visible = false;
            maskedTextBoxMoneyHour.Visible = true;
            maskedTextBoxMoneyOneChange.Visible = false;
        }


        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Кнопка отмены
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //Кнопка добавления данных о человеке в список из формы создания 
        private void buttonОК_Click(object sender, EventArgs e)
        {
            bool a = false;
            if ((textBoxFirstName.Text != "") || (textBoxLastName.Text != "") || (dateTimePickerDateOfReceipt.Text != "") ||
                (maskedTextBoxWorkingDays.Text != "") || (maskedTextBoxWeekend.Text != "") || (maskedTextBoxTimeOff.Text != "") ||
                (maskedTextBoxBaseSalary.Text != "") || (maskedTextBoxHour.Text != "") || (maskedTextBoxNumberChange.Text != "") || (maskedTextBoxMoneyHour.Text != "")
                || (maskedTextBoxMoneyOneChange.Text != ""))
            {
                a = true;
            }
            if (!(_maskedFirstName && _maskedLastName && _maskedDateOfReceipt) && !(a))
            {
                MessageBox.Show("Введите фамилию имя и дату приема на работу!");
            }
            else if ((radioButtonSalaryRate.Checked) && !(a))
            {
                if (!(_maskedNumberChange && _maskedMoneyOneChange))
                    MessageBox.Show("Введите кол-во смен и кол-во денег за одну смену!");
                else
                    a = true;
            }

            else if ((radioButtonSalary.Checked) && !(a))
            {
                if (!(_maskedBaseSalary && _maskedWorkingDays && _maskedWeekend && _maskedTimeOff))
                    MessageBox.Show("Введите базовую зарплату, рабочие дни, выходные, и отгулы!");
                else
                    a = true;
            }

            else if ((radioButtonSalaryHourly.Checked) && !(a))
            {
                if (!(_maskedHour && _maskedMoneyHour))
                    MessageBox.Show("Введите кол-во часов и кол-во денег за один час!");
                else
                    a = true;
            }


            if (a)
            {
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private ISalary _person;


        //Описание данных о человеке
        public ISalary Person
        {
            get
            {
                if (radioButtonSalaryRate.Checked)
                {
                    var Rate = new Model.SalaryRate();
                    Rate.FirstName = Convert.ToString(textBoxFirstName.Text);
                    Rate.LastName = Convert.ToString(textBoxLastName.Text);
                    Rate.DateOfReceipt = Convert.ToString(dateTimePickerDateOfReceipt.Text);
                   

                    Rate.NumberChange = Convert.ToInt32(maskedTextBoxNumberChange.Text);
                    Rate.MoneyOneChange = Convert.ToDouble(maskedTextBoxMoneyOneChange.Text);
                    _person = Rate;
                }


                else if (radioButtonSalary.Checked)
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

                else if (radioButtonSalaryHourly.Checked)
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
               

                if (value is Model.SalaryRate)
                {
                    var Rate = (Model.SalaryRate)value;
                    maskedTextBoxNumberChange.Text = Convert.ToString(Rate.NumberChange);
                    maskedTextBoxMoneyOneChange.Text = Convert.ToString(Rate.MoneyOneChange);
                }
                else if (value is Model.Salary)
                {
                    var Salary = (Model.Salary)value;
                    maskedTextBoxBaseSalary.Text = Convert.ToString(Salary.Basesalary);
                    maskedTextBoxWorkingDays.Text = Convert.ToString(Salary.WorkingDays);
                    maskedTextBoxWeekend.Text = Convert.ToString(Salary.Weekend);
                    maskedTextBoxTimeOff.Text = Convert.ToString(Salary.Timeoff);
                }

                else if (value is Model.SalaryHourly)
                {
                    var Hourly = (Model.SalaryHourly)value;
                    maskedTextBoxHour.Text = Convert.ToString(Hourly.Hour);
                    maskedTextBoxMoneyHour.Text = Convert.ToString(Hourly.Money);

                }
            }
        }




        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



        //Кнопка  расчета зарплаты
        private void buttonCalculateSalary_Click(object sender, EventArgs e)
        {
            if ((_maskedNumberChange && _maskedMoneyOneChange) || (_maskedWorkingDays && _maskedWeekend && _maskedTimeOff && _maskedBaseSalary) || (_maskedHour && _maskedMoneyHour))
            { textBox3.Text = Convert.ToString(Person.GetSalary()); }
            else
                MessageBox.Show("Не все величины были введены");
        }
        private void textBoxFirstName_Leave(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text == "")
            {
                errorProviderFirstname.SetError(textBoxFirstName, "Данное поле должно быть заполненным");
            }
            else
            {
                errorProviderFirstname.Clear();
                _maskedFirstName = true;
            }
        }

        private void textBoxLastName_Leave(object sender, EventArgs e)
        {
            if (textBoxLastName.Text == ",")
            {
                errorProviderLastname.SetError(textBoxLastName, "Данное поле должно быть заполненным");
            }
            else
            {
                errorProviderLastname.Clear();
                _maskedLastName = true;
            }
        }


        private void dateTimePickerDateOfReceipt_Leave(object sender, EventArgs e)
        {
            if (dateTimePickerDateOfReceipt.Text == "")
            {
                errorProviderDateOfReceipt.SetError(dateTimePickerDateOfReceipt, "Данное поле должно быть заполненным");
            }
            else
            {
                errorProviderDateOfReceipt.Clear();
                _maskedDateOfReceipt = true;
            }
        }




        private void maskedTextBoxWorkingDays_Leave(object sender, EventArgs e)
        {
            if (maskedTextBoxWorkingDays.Text == "")
            {
                errorProviderWorkingDays.SetError(maskedTextBoxWorkingDays, "Данное поле должно быть заполненным");
            }
            else
            {
                errorProviderWorkingDays.Clear();
                _maskedWorkingDays = true;
            }
        }

        private void maskedTextBoxWeekend_Leave(object sender, EventArgs e)
        {
            if (maskedTextBoxWeekend.Text == "")
            {
                errorProviderWeekend.SetError(maskedTextBoxWeekend, "Данное поле должно быть заполненным");
            }
            else
            {
                errorProviderWeekend.Clear();
                _maskedWeekend = true;
            }
        }

        private void maskedTextBoxTimeOff_Leave(object sender, EventArgs e)
        {
            if (maskedTextBoxTimeOff.Text == "")
            {
                errorProviderTimeOff.SetError(maskedTextBoxTimeOff, "Данное поле должно быть заполненным");
            }
            else
            {
                errorProviderTimeOff.Clear();
                _maskedTimeOff = true;
            }
        }

        private void maskedTextBoxBaseSalary_Leave(object sender, EventArgs e)
        {
            if (maskedTextBoxBaseSalary.Text == "")
            {
                errorProviderBaseSalary.SetError(maskedTextBoxBaseSalary, "Данное поле должно быть заполненным");
            }
            else
            {
                errorProviderBaseSalary.Clear();
                _maskedBaseSalary = true;
            }
        }

        private void maskedTextBoxHour_Leave(object sender, EventArgs e)
        {
            if (maskedTextBoxHour.Text == "")
            {
                errorProviderHour.SetError(maskedTextBoxHour, "Данное поле должно быть заполненным");
            }
            else
            {
                errorProviderHour.Clear();
                _maskedHour = true;
            }
        }

        private void maskedTextBoxNumberChange_Leave(object sender, EventArgs e)
        {
            if (maskedTextBoxNumberChange.Text == " ")
            {
                errorProviderNumberChange.SetError(maskedTextBoxNumberChange, "Данное поле должно быть заполненным");
            }
            else
            {
                errorProviderNumberChange.Clear();
                _maskedNumberChange = true;
            }
        }

        private void maskedTextBoxMoneyHour_Leave(object sender, EventArgs e)
        {
            if (maskedTextBoxMoneyHour.Text == "")
            {
                errorProviderMoneyHour.SetError(maskedTextBoxMoneyHour, "Данное поле должно быть заполненным");
            }
            else
            {
                errorProviderMoneyHour.Clear();
                _maskedMoneyHour = true;
            }
        }

        private void maskedTextBoxMoneyOneChange_Leave(object sender, EventArgs e)
        {
            if (maskedTextBoxMoneyOneChange.Text == "     ,")
            {
                errorProviderMoneyOneChange.SetError(maskedTextBoxMoneyOneChange, "Данное поле должно быть заполненным");
            }
            else
            {
                errorProviderMoneyOneChange.Clear();
                _maskedMoneyOneChange = true;
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////


        //Кнопка  заполнения случайными величинами поле
        private void buttonCreateRandomData_Click(object sender, EventArgs e)
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

            if (radioButtonSalaryRate.Checked)
            {

                maskedTextBoxNumberChange.Text = Convert.ToString(1 + random.Next(31));
                maskedTextBoxMoneyOneChange.Text = Convert.ToString(50 + random.NextDouble() * (3000.99 - 1.11));
                _maskedNumberChange = true;
                _maskedMoneyOneChange = true;
            }

            else if (radioButtonSalary.Checked)
            {
                maskedTextBoxBaseSalary.Text = Convert.ToString(50 + random.NextDouble() * (99999.99-1.11));
                maskedTextBoxWorkingDays.Text = Convert.ToString(1 + random.Next(31));
                maskedTextBoxWeekend.Text = Convert.ToString(3.111 + random.NextDouble() * (7.999 - 1.111));
                maskedTextBoxTimeOff.Text = Convert.ToString(1.111 + random.NextDouble() * (4.999 - 1.111));
                _maskedBaseSalary = true;
                _maskedWorkingDays = true;
                _maskedWeekend = true;
                _maskedTimeOff = true;
            }
            else if (radioButtonSalaryHourly.Checked)
            {
                maskedTextBoxHour.Text = Convert.ToString(1 + random.Next(220));
                maskedTextBoxMoneyHour.Text = Convert.ToString(50 + random.NextDouble()*(1000.99-1.11));
                _maskedHour = true;
                _maskedMoneyHour = true;
            }
        }


      
    }
}

























        

       




        
   
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    

