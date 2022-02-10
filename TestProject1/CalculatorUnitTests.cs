using System;
using NUnit.Framework;
using SW_test_opg;

namespace TestProject1
{
    public class Tests
    {
        private Calculator calc;

        [SetUp]
        public void Setup()
        {
            //Arrangee
            //gasgsagasgasg

            calc = new Calculator();
        }

        [TestCase(7,8,15)]
        [TestCase(-3,-4,-7)]
        [TestCase(2,-5,-3)]
        [TestCase(2.5, 2, 4.5)]
        public void AddNumbers_ResultIsCorrect(double a, double b, double result)
        {
            //Act + Assert
            Assert.That(calc.Add(a, b), Is.EqualTo(result));
        }

        [TestCase(7, 8, -1)]
        [TestCase(-3, -4, 1)]
        [TestCase(2, -5, 7)]
        public void SubtractNumbers_ResultIsCorrect(double a, double b, double result)
        {
            //Act + Assert
            Assert.That(calc.Subtract(a, b), Is.EqualTo(result));
        }
        [TestCase(7, 8, 56)]
        [TestCase(-3, -4, 12)]
        [TestCase(2, -5, -10)]
        public void MultiplyNumbers_ResultIsCorrect(double a,double b,double result)
        public void Test_Multiply()
        {

            //Act + Assert
            Assert.That(calc.Multiply(a, b), Is.EqualTo(result));
        }


        [TestCase(3, 2,9)]
        [TestCase(1, 1,1)]
        [TestCase(-2, 2,4)]
        [TestCase(1, 0,1)]
        public void Test_Power(double x,double exp,double result)
        {
            double result1 = calc.Power(x,exp);

            Assert.That(result, Is.EqualTo(result1));
        }




        [TestCase(15, 2, 7.5)]
        [TestCase(1, 1, 1)]
        [TestCase(-2, 2, -1)]
        [TestCase(2, 1, 2)]

        public void Test_Divide(double a, double b, double result)
        {
            double result1 = calc.Divide(a, b);

            Assert.That(result, Is.EqualTo(result1));
        }




        [Test]
        public void Test_Exception()
        {
            Assert.That(() => calc.Divide(2, 0), Throws.TypeOf<DivideByZeroException>());


        }




        [TestCase(15, 2)]
        [TestCase(1, 1)]
        [TestCase(-2, 2)]
        [TestCase(2, 1)]
        public void Test_Clear(int a, int b)
        {
            calc.Add(a, b);
            calc.Divide(a, b);
            calc.Clear();

            Assert.That(calc.Accumulator,Is.EqualTo(0));

        }


        [Test]
        public void Test_Accumulator()
        {
            calc.Add(2, 3);
            
            Assert.That(calc.Accumulator, Is.EqualTo(5));
        }





    }
}