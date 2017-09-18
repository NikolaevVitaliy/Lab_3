using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model
{
    ///<summary/>
    ///Рассчет зарплаты по ставке
    ///<summary/>
    public class Salary : ISalary
    {
        
        /// <summary>
        /// Рабочие дни
        /// </summary
        private int _workingdays;
          /// <summary>
        /// Выходные
        /// </summary
        private int _weekend;
          /// <summary>
        /// Отгулы
        /// </summary
        private int _timeoff;
          /// <summary>
        /// Базовая зарплата
        /// </summary
        private double _basesalary;
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
        /// Свойство базовая зарплата
        /// </summary>
        public double Basesalary
        {
            get { return _basesalary; }
            set
            {
                if ((value < 0)) throw new ArgumentException("Значение не может быть меньше   0. Введите число больше 0");
                _basesalary = value;
            }
        }
         /// <summary>
        /// Свойство рабочие дни
        /// </summary>
      public int WorkingDays
        {
            get { return _workingdays; }
            set
            {
                if (value <= 0) throw new ArgumentException("Значение меньше  или равно 0. Введите число больше 0");
                _workingdays = value;
            }
        }
         /// <summary>
        /// Свойство выходные
        /// </summary>
         public int Weekend
        {
         get { return _weekend; }
            set
            {
                if ((value <= 2)||(value>10)) throw new ArgumentException("Значение не может быть меньше  или равно 3, а также значение не может быть больше 31. Введите число от 3 до 10");
                _weekend = value;
            }
                    }

       /// <summary>
        /// Свойство отгулы
        /// </summary>
        public int Timeoff
        {
            get { return _timeoff; }
            set
            {
                if ((value < 0)) throw new ArgumentException("Значение не может быть меньше   0. Введите число больше 0");
                _timeoff = value;
            }
                    }

     

         /// <summary>
        /// Метод расчета зарплаты
        /// </summary>
        public double GetSalary()
        {
            return (((_basesalary/_workingdays)*(_workingdays-_timeoff))-(((_basesalary/_workingdays)*(_workingdays-_timeoff))*0.13)) ;
        }

    }
}





