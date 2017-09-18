using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace UnitTests.Model
{
    [TestFixture]
    public class SalaryHourlyTest
    {

        /// Тестирование ввода кол-во часов в месяц (не должна быть меньше 0 или более 31)
        /// </summary>
        /// /// <param name="Hour">Кол-во часов</param>
        [Test]
        [TestCase(50, TestName = "Тестирование ввода кол-во часов в месяц при значении 50")]
        public void HourTest_Positive(int _hour)
        {
            var Hoourly = new SalaryHourly();
            Hoourly.Hour = _hour;
        }

        [TestCase(-250, typeof(ArgumentException), TestName = "Тестирование ввода кол-во часов в месяц при значении -250")]
        [TestCase(250, typeof(ArgumentException), TestName = "Тестирование ввода кол-во часов в месяц при значении 250")]
         public void HourTest_Negative(int _hour, Type expectedException)
         {
             var Hoourly = new SalaryHourly();
             Assert.Throws(expectedException, () => Hoourly.Hour = _hour);
         }

        /// Тестирование ввода кол-во денег в час (не должна быть меньше)
        /// </summary>
        /// /// <param name="Money">Кол-во денег в час</param>
        
            [Test]
            [TestCase(200, TestName = "Тестирование ввода кол-во денег в час при значении 200")]
            public void MoneyHourTest_Positive(int _moneyhour)
            {
                var MoneyHour = new SalaryHourly();
                MoneyHour.Money = _moneyhour;
            }
        [TestCase(-200, typeof(ArgumentException), TestName = "Тестирование ввода кол-во денег в час при значении -200")]
            public void MoneyHourTest_Negative(int _moneyhour, Type expectedException)
        {
            var MoneyHour = new SalaryHourly();
            Assert.Throws(expectedException, () => MoneyHour.Money = _moneyhour);
        }
        /// <summary>
        /// Тестирование ввода зарплаты работника
        /// </summary>
        /// <returns>Зарплата работника</returns>
        [Test]
        [TestCase(50, 200, ExpectedResult=8700, TestName = "Тестирование зарплаты работника")]
        public double volumeTest_Positive(int _hour, double _moneyhour)
        {
            var volumePSalary = new SalaryHourly();
            volumePSalary.Hour = _hour;
            volumePSalary.Money = _moneyhour;
            return volumePSalary.GetSalary();
        }
        [Test, TestCaseSource("AAA")]
        public void DivideTest(int n, int d, int q)
        {
            Assert.AreEqual(q, n / d);
        }

        static object[] AAA =
{
    new object[] { 12, 3, 4 },
    new object[] { 12, 2, 6 },
    new object[] { 12, 4, 3 } 
};
    }
}
