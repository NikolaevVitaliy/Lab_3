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
    public class SalaryRateTest
    {
        /// Тестирование ввода кол-во смен (не должна быть меньше 0 или более 31)
        /// </summary>
        /// /// <param name="NumberChange">Кол-во смен</param>
         [Test]
        [TestCase(15, TestName = "Тестирование ввода кол-во смен при значении 15")]
        public void NumberChangeTest_Positive(int _numberchange)
        {
            var NumChang = new SalaryRate();
            NumChang.NumberChange = _numberchange;
        }

        [TestCase(-5, typeof(ArgumentException), TestName = "Тестирование ввода кол-во смен при значении -5")]
        [TestCase(35, typeof(ArgumentException), TestName = "Тестирование ввода кол-во смен при значении 35")]
         public void NumberChangeTest_Negative(int _numberchange, Type expectedException)
         {
             var NumChang = new SalaryRate();
             Assert.Throws(expectedException, () => NumChang.NumberChange = _numberchange);
         }

        /// <summary>
        /// Тестирование ввода зарплата за одну смену (не должна быть меньше 0)
        /// </summary>
        /// /// <param name="MoneyOneChange">зарплата за одну смену</param>
        
        [Test]
        [TestCase(2000, TestName = "Тестирование ввода зарплата за одну смену при значении 200")]
        public void MoneyOneChangeTest_Positive(double _moneyonechange)
        {
            var MoneyOnChan = new SalaryRate();
            MoneyOnChan.MoneyOneChange = _moneyonechange;
        }


        [TestCase(-2000, typeof(ArgumentException), TestName = "Тестирование ввода зарплата за одну смену при значении -200")]
        public void NumberChangeTest_Negative(double _moneyonechange, Type expectedException)
        {
            var MoneyOnChan = new SalaryRate();
            Assert.Throws(expectedException, () => MoneyOnChan.MoneyOneChange = _moneyonechange);
        }

         /// <summary>
         /// Тестирование ввода зарплаты работника
         /// </summary>
        /// <returns>Зарплата работника</returns>
        [Test]
        [TestCase(15, 2000, ExpectedResult=26100, TestName = "Тестирование зарплаты работника")]
        public double volumeTest_Positive(int _numberchange, double _moneyonechange)
        {
            var volumePSalary = new SalaryRate();
            volumePSalary.NumberChange = _numberchange;
            volumePSalary.MoneyOneChange = _moneyonechange;
            return volumePSalary.GetSalary();
        }
         
























    }
}
