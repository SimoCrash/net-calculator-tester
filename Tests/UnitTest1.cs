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
        [Description("Questa è una sottrazione")]
        public void Test_Subtract()
        {
            var res = calculator.Subtract(6.2f, 3.3f);
            //Assert.That(res, Is.EqualTo(2.9f), "Sottrazione errata");
            Assert.AreEqual(2.89999986f, res, "Sottrazione errata");
        }

        [Test]
        public void Test_Divide()
        {
            var res = calculator.Divide(5.5f, 1.1f);
            Assert.AreEqual(5f, res, "Divisione errata");
        }

        [Test]
        [TestCase(5)]
        public void Test_Divide_per_zero(float num1)
        {
            Assert.AreEqual(num1 / 0, float.NaN);
        }
        //COME FACCIO A DICHIARARE L'ISTANZA CON [TestCase()]?

        [Test]
        public void Test_Multilpy()
        {
            var res = calculator.Multiply(1.7f, 4.2f);
            Assert.AreEqual(7.14f, res, "Moltiplicazione errata");
        }

        //[TestCase(2, 5, 10)]
        //public void Test_Multilpy(float num1, float num2, float ris)
        //{

        //    Assert.AreEqual(num1 * num2, ris);
        //}
        //COME FACCIO A DICHIARARE L'ISTANZA CON [TestCase()]?

        //[Test]
        //public void Test_divide_prova_exc_con_zero()
        //{
        //    Assert.Throws<System.ArgumentException>( () => { Divide_prova_exc(10, 0); }, "Messaggio: Non puoi dividere per zero!" );
        //}   -------------------------------------->NON TROVA Divide_prova_exc
    }
}