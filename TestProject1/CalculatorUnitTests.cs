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
            //Arrangeashflkhasd
            //gasgsagasgasg

            calc = new Calculator();
        }


        [Test]
        public void Test_Add()
        {

            //Act
            double result = calc.Add(1, 2);

            //Assert
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Test_Subtract()
        {

            //Act
            double result = calc.Subtract(1, 2);

            //Assert
            Assert.That(result, Is.EqualTo(-1));
        }

        [Test]
        public void Test_Multiply()
        {

            //Act
            double result = calc.Multiply(1, 2);

            //Assert
            Assert.That(result, Is.EqualTo(2));
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