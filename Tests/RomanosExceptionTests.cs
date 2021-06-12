using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using NumerosRomanos;


namespace Tests
{
    [TestClass]
    public class RomanosExceptionTests
    {
        NumeraisRomanos numeros;

        public RomanosExceptionTests()
        {
             numeros = new NumeraisRomanos();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DeveRetornarArgumentException()
        {
            Assert.AreEqual("6", numeros.RomanoParaInteiro("VIIII"));
        }

        [TestMethod]
        public void NaoDeveRetornarArgumentException()
        {
            Assert.AreEqual("2000", numeros.RomanoParaInteiro("DDDD"));
        }

    }
}
