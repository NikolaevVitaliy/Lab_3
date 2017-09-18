using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model


{   ///<summary>
    ///Рассчет зарплаты по часам 
    ///<summary>
    public class SalaryHourly : ISalary
    {
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
        /// Кол-во часов
        /// </summary>
        private int _hour;
        /// <summary>
        /// Зарплата в час
        /// </summary>
        private double _moneyhour;
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
        /// Свойство часы
        /// </summary>
        public int Hour
        {
            get { return _hour; }
            set
            {
                if (value <= 0 || value>220) 
                    throw new ArgumentException("Значение меньше  или равно 0 или больше 220. Введите число от 0 до 220");
                _hour = value;
            }
        }

        /// <summary>
        /// Свойство деньги
        /// </summary>
        public double Money
        {
            get { return _moneyhour; }
            set
            {
                if (value <= 0) throw new ArgumentException("Значение меньше  или равно 0. Введите число больше 0");
                _moneyhour = value;
            }
        }
        /// <summary>
        /// Метод расчета зарплаты
        /// </summary>
        public double GetSalary()
        {
            return ((_hour * _moneyhour) - ((_hour * _moneyhour)*(0.13)));
        }

    }
}
