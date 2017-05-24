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
    class SalaryRateTest
    {
        /// <summary>
        /// Тестирование ввода кол-во смен (не должна быть меньше 0 или более 31)
        /// </summary>
        /// /// <param name="NumberChange">Кол-во смен</param>
         [Test]
        [TestCase(-5, ExpectedException = typeof(ArgumentException), TestName = "Тестирование ввода кол-во смен при значении -5")]
        [TestCase(15, TestName = "Тестирование ввода кол-во смен при значении 15")]
        [TestCase(35, ExpectedException = typeof(ArgumentException), TestName = "Тестирование ввода кол-во смен при значении 35")]

        public void NumberChangeTest(int _numberchange)
        {
            var NumChang = new SalaryRate();
            NumChang.NumberChange = _numberchange;
        }

        /// <summary>
        /// Тестирование ввода зарплата за одну смену (не должна быть меньше 0)
        /// </summary>
        /// /// <param name="MoneyOneChange">зарплата за одну смену</param>
        [Test]
        [TestCase(-200, ExpectedException = typeof(ArgumentException), TestName = "Тестирование ввода зарплата за одну смену при значении -200")]
        [TestCase(200 , TestName = "Тестирование ввода зарплата за одну смену при значении 200")]
         public void MoneyOneChangeTest(double _moneyonechange)
         {
             var MoneyOnChan = new SalaryRate();
             MoneyOnChan.MoneyOneChange = _moneyonechange;
         }



























    }
}
