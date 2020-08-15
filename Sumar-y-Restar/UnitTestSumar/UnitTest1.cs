using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sumar.Controllers;

namespace UnitTestSumar
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd1()
        {
            //Arrange

            SumaController sumaController = new SumaController();
            int a = 5;
            int b = 8;
            int esperado = 13;

            //Act

            int resultado = sumaController.Add(a, b);

            //Assert

            Assert.AreEqual(esperado, resultado);
        }
        [TestMethod]
        public void TestAdd2()
        {
            //Arrange

            SumaController sumaController = new SumaController();
            int a = -2;
            int b = -3;
            int esperado = -5;

            //Act

            int resultado = sumaController.Add(a, b);

            //Assert

            Assert.AreEqual(esperado, resultado);
        }
        [TestMethod]
        public void TestProduct()
        {
            //Arrange

            SumaController sumaController = new SumaController();
            int a = 3;
            int b = 5;
            int esperado = 15;

            //Act

            int resultado = sumaController.Product(a, b);

            //Assert

            Assert.AreEqual(esperado, resultado);
        }
    }
}
