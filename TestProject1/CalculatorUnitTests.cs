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
            //Arrange

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
        {

            //Act + Assert
            Assert.That(calc.Multiply(a, b), Is.EqualTo(result));
        }

        [Test]
        public void Test_Power()
        {
            double result = calc.Power(9, 2);

            Assert.That(result, Is.EqualTo(81));
        }

        [Test]
        public void Test_Divide()
        {
            double result = calc.Divide(10, 2);

            Assert.That(result, Is.EqualTo(5));
        }


        [Test]
        public void Test_Accumulator()
        {
            calc.Add(2, 3);
            
            Assert.That(calc.Accumulator, Is.EqualTo(5));
        }

    }
}