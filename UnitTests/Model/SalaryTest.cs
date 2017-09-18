using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using NUnit.Framework;

namespace UnitTests.Model
{
    [TestFixture]
    public class SalaryTest
    {
        /// Тестирование ввода базовая зарплата (не должна быть меньше 0)
        /// </summary>
        /// /// <param name="Basesalary">Базовая зарплата</param>
        [Test]
        [TestCase(10000, TestName = "Тестирование ввода базовая зарплата при значении 10000")]
        public void BasesalaryTest_Positive(double _basesalary)
        {
            var Basesalaryy = new Salary();
            Basesalaryy.Basesalary = _basesalary;
        }
        [TestCase(-250, typeof(ArgumentException), TestName = "Тестирование ввода базовая зарплата при значении -250")]
        public void BasesalaryTest_Negative(double _basesalary, Type expectedException)
        {
            var Basesalaryy = new Salary();
            Assert.Throws(expectedException, () => Basesalaryy.Basesalary = _basesalary);
        }
        /// Тестирование ввода кол-во рабочих дней (не должна быть меньше 0)
        /// </summary>
        /// /// <param name="WorkingDays">Рабочие дни</param>
        [Test]
        [TestCase(22, TestName = "Тестирование ввода рабочие дни  при значении 22")]
        public void WorkingDaysTest_Positive(int _workingdays)
        {
            var WorkingDayss = new Salary();
            WorkingDayss.WorkingDays = _workingdays;
        }
        [TestCase(-25, typeof(ArgumentException), TestName = "Тестирование ввода рабочие дни  при значении -25")]
        public void WorkingDaysTest_Negative(int _workingdays, Type expectedException)
        {
            var WorkingDayss = new Salary();
            Assert.Throws(expectedException, () => WorkingDayss.WorkingDays = _workingdays);
        }
        /// Тестирование ввода кол-во выходных (не должна быть меньше 2 или больше 10)
        /// </summary>
        /// /// <param name="Weekend">Выходные дни</param>
        [Test]
        [TestCase(5, TestName = "Тестирование ввода выходные  при значении 5")]
        public void WeekendTest_Positive(int _weekend)
        {
            var Weekendd = new Salary();
            Weekendd.Weekend = _weekend;
        }

        [TestCase(0, typeof(ArgumentException), TestName = "Тестирование ввода выходные  при значении 0")]
        [TestCase(15, typeof(ArgumentException), TestName = "Тестирование ввода выходные  при значении 15")]
        public void WeekendTest_Negative(int _weekend, Type expectedException)
        {
            var Weekendd = new Salary();
            Assert.Throws(expectedException, () => Weekendd.Weekend = _weekend);
        }
        /// Тестирование ввода кол-во отгулов (не должна быть меньше 0)
        /// </summary>
        /// /// <param name="Timeoff">Отгулы</param>
        [Test]
        [TestCase(5, TestName = "Тестирование ввода кол-во отгулов   при значении 5")]
        public void TimeoffTest_Positive(int _timeoff)
        {
            var Timeofff = new Salary();
            Timeofff.Timeoff = _timeoff;
        }
        [TestCase(-5, typeof(ArgumentException), TestName = "Тестирование ввода кол-во отгулов   при значении -5")]
        public void TimeoffTest_Negative(int _timeoff, Type expectedException)
        {
            var Timeofff = new Salary();
            Assert.Throws(expectedException, () => Timeofff.Timeoff = _timeoff);
        }
        /// <summary>
        /// Тестирование ввода зарплаты работника
        /// </summary>
        /// <returns>Зарплата работника</returns>
        [Test]
        [TestCase(10000, 22, 5, 5, ExpectedResult = 6722.727272727273d, TestName = "Тестирование зарплаты работника")]
        public double volumeTest_Positive(double _basesalary, int _workingdays, int _weekend, int _timeoff)
        {
            var volumePSalary = new Salary();
            volumePSalary.Basesalary = _basesalary;
            volumePSalary.WorkingDays = _workingdays;
            volumePSalary.Weekend = _weekend;
            volumePSalary.Timeoff = _timeoff;
            return volumePSalary.GetSalary();
        }













    }
}
