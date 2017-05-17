using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Создаем интерфейс ISalary
    /// </summary>
   public interface ISalary
    {
        /// <summary>
        /// Имя
        /// </summary>      
       string FirstName { get; set; }
        /// <summary>
        /// Фамилия
        /// </summary>     
       string LastName { get; set; } 
        /// <summary>
        /// Дата приема
        /// </summary>     
       string DateOfReceipt { get; set; }
        /// <summary>
       /// Метод рассчет зарплаты
       /// </summary>
       /// <returns></returns>
       double GetSalary();
    }
}
