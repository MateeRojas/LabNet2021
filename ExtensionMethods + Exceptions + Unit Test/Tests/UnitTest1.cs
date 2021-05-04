using ExtensionMethods___Exceptions___Unit_Test.Extensions;
using ExtensionMethods___Exceptions___Unit_Test.Excepcions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test01DividoPorCero()
        {
            int numero = 10;
            bool huboExcepcion = numero.DividirPorCero();
            Assert.AreEqual(huboExcepcion, true);
        }

        [TestMethod]
        public void Test02DividoConArgumentosValidos()
        {
            int numero = 10;
            double resultado = numero.Dividir(2);
            Assert.AreEqual(5, resultado);
        }
        [TestMethod]
        public void Test03DividoConArgumentosNoValidos()
        {
            int numero = 10;
            double resultado = numero.Dividir(null);
            Assert.AreEqual(0, resultado);
        }
        [TestMethod]
        public void Test04TiroUnaExcepcionCualquiera()
        {
            Logic logic = new Logic();
            Assert.ThrowsException<IndexOutOfRangeException>(() => logic.TirarExcepcion());
        }

        [TestMethod]
        public void Test05TiroUnaExcepcionPersonalizada()
        {
            Logic logic = new Logic();
            Assert.ThrowsException<ExcepcionPersonalizada>(() => logic.TirarExcepcionPersonalizada());
        }
    }
}
