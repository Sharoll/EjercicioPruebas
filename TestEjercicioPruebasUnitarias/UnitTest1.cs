namespace TestEjercicioPruebasUnitarias
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestEjercicioPrueba()
        {
            int valor = EjercicioPruebas.Program.serieFibonacci(0);
            Assert.AreEqual(0, valor);

        }

        [TestMethod]
        public void TestEjercicioPrueba1()
        {
            int valor = EjercicioPruebas.Program.serieFibonacci(1);
            Assert.AreEqual(1, valor);

        }

        [TestMethod]
        public void TestEjercicioPrueba2()
        {
            int valor = EjercicioPruebas.Program.serieFibonacci(2);
            Assert.AreEqual(1, valor);

        }

        [TestMethod]
        public void TestEjercicioPrueba3()
        {
            int valor = EjercicioPruebas.Program.serieFibonacci(3);
            Assert.AreEqual(2, valor);

        }

        [TestMethod]
        public void TestEjercicioPrueba4()
        {
            int valor = EjercicioPruebas.Program.serieFibonacci(4);
            Assert.AreEqual(3, valor);

        }

        [TestMethod]
        public void TestEjercicioPrueba5()
        {
            int valor = EjercicioPruebas.Program.serieFibonacci(5);
            Assert.AreEqual(5, valor);

        }

        [TestMethod]
        public void TestEjercicioPrueba6()
        {
            int valor = EjercicioPruebas.Program.serieFibonacci(12);
            Assert.AreEqual(144, valor);

        }

        [TestMethod]
        public void TestEjercicioPrueba7()
        {
            int valor = EjercicioPruebas.Program.serieFibonacci(70);
            Assert.AreEqual(885444751, valor);

        }

        [TestMethod]
        public void TestEjercicioPrueba8()
        {
            int valor = EjercicioPruebas.Program.serieFibonacci(15);
            Assert.AreEqual(610, valor);

        }

        [TestMethod]
        public void TestEjercicioPrueba9()
        {
            int valor = EjercicioPruebas.Program.serieFibonacci(150);
            Assert.AreEqual(1000, valor);

        }

    }
}