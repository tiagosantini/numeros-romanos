using Microsoft.VisualStudio.TestTools.UnitTesting;

using NumerosRomanos;

namespace Tests
{
    [TestClass]
    public class RomanosParaIndoArabicoTests
    {
        NumeraisRomanos numeros;

        public RomanosParaIndoArabicoTests()
        {
             numeros = new NumeraisRomanos();
        }

        #region Testes com valores básicos, sem subtração ou adição

        [TestMethod]
        public void DeveConverterParaUm()
        {
            Assert.AreEqual("1", numeros.RomanoParaInteiro("I"));
        }


        [TestMethod]
        public void DeveConverterParaCinco()
        {
            Assert.AreEqual("5", numeros.RomanoParaInteiro("V"));
        }

        [TestMethod]
        public void DeveConverterParaDez()
        {
            Assert.AreEqual("10", numeros.RomanoParaInteiro("X"));
        }

        [TestMethod]
        public void DeveConverterParaCinquenta()
        {
            Assert.AreEqual("50", numeros.RomanoParaInteiro("L"));
        }

        [TestMethod]
        public void DeveConverterParaCem()
        {
            Assert.AreEqual("100", numeros.RomanoParaInteiro("C"));
        }

        [TestMethod]
        public void DeveConverterParaQuinhentos()
        {
            Assert.AreEqual("500", numeros.RomanoParaInteiro("D"));
        }

        [TestMethod]
        public void DeveConverterParaMil()
        {
            Assert.AreEqual("1000", numeros.RomanoParaInteiro("M"));
        }


        [TestMethod]
        public void DeveConverterParaCincoMil()
        {
            Assert.AreEqual("5000", numeros.RomanoParaInteiro("V̄"));
        }

        #endregion
    }
}
