using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model
///<summary>
///Рассчет зарплаты по окладу
///<summary>
{
   public  class SalaryRate : ISalary
    {        
        /// Кол-во смен
        /// </summary
       private int _numberchange;
        /// <summary>
        /// Зарплата за одну смену
        /// </summary
       private double _moneyonechange;

       /// <summary>
       /// Имя
       /// </summary>
       private string _firstname;
       /// <summary>
       /// Фамилия
       /// </summary>
       private string _lastname;
       /// <summary>
       /// Дата приема
       /// </summary>
       private string _dateofreceipt;


       /// <summary>
       /// Свойство имя
       /// </summary
       public string FirstName
       {
           get { return _firstname; }
           set
           {
               _firstname = value;
           }
       }

       /// <summary>
       /// Свойство фамилия
       /// </summary
       public string LastName
       {
           get { return _lastname; }
           set
           {
               _lastname = value;
           }
       }

       /// <summary>
       /// Свойство дата приема
       /// </summary
       public string DateOfReceipt
       {
           get { return _dateofreceipt; }
           set
           {
               _dateofreceipt = value;
           }
       }
               
       /// <summary>
        /// Свойство кол-во смен
        /// </summary
        public int NumberChange
        {
            get { return _numberchange; }
            set
            {
                if (value < 0 || value > 31) throw new ArgumentException("Значение не может быть меньше 0 или больше 31. Введите число от 0 до 31");
                _numberchange = value;
            }
        }

        /// <summary>
        /// Свойство зарплата за одну смену
        /// </summary
        public double MoneyOneChange
        {
            get { return _moneyonechange; }
            set
            {
                if (value < 0) throw new ArgumentException("Значение не может быть меньше. Введите число больше 0");
                _moneyonechange = value;
            }
        }
      
        /// <summary>
        /// Метод расчета зарплаты
        /// </summary>
        public double GetSalary()
        {
            return (_numberchange * _moneyonechange) - ((_numberchange * _moneyonechange)*(0.13));
        }

    }
}

