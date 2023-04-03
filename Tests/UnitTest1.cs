using net_calculator_tester;

namespace Tests
{
    public class Tests
    {
        Calculator calculator;
        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        public void Test_Add()
        {
            var res = calculator.Add(2.5f, 7.5f);
            //Assert.That(res, Is.EqualTo(10f));
            Assert.AreEqual(10f, res, "Addizione errata");
        }

        [Test]
        public void Test_Subtract()
        {
            var res = calculator.Subtract(6.2f, 3.3f);
            //Assert.That(res, Is.EqualTo(2.9f), "Sottrazione errata");
            Assert.AreEqual(2.89999986f, res, "Addizione errata");
        }

        [Test]
        public void Test_Divide()
        {
            var res = calculator.Divide(5.5f, 1.1f);
            Assert.AreEqual(5f, res, "Divisione errata");
        }

        [Test]
        public void Test_Multilpy()
        {
            var res = calculator.Multiply(1.7f, 4.2f);
            Assert.AreEqual(7.14f, res, "Moltiplicazione errata");
        }

    }
}