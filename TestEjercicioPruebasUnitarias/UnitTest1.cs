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
            int valor = EjercicioPruebas.Program.serieFibonacci(100);
            Assert.AreEqual(1, valor);

        }

    }
}