using Microsoft.VisualStudio.TestTools.UnitTesting;

using NumerosRomanos;

namespace Tests
{
    [TestClass]
    public class RomanosOperacoesMatematicasTests
    {
        NumeraisRomanos numeros;

        public RomanosOperacoesMatematicasTests()
        {
             numeros = new NumeraisRomanos();
        }

        [TestMethod]
        public void DeveSubtrairUm()
        {
            Assert.AreEqual("4", numeros.RomanoParaInteiro("IV"));
        }

        [TestMethod]
        public void DeveAdicionarUm()
        {
            Assert.AreEqual("6", numeros.RomanoParaInteiro("VI"));
        }

        [TestMethod]
        public void DeveConverterParaQuatroMil()
        {
            Assert.AreEqual("4000", numeros.RomanoParaInteiro("ĪV̄"));
        }

        [TestMethod]
        public void DeveConverterParaSeisMil()
        {
            Assert.AreEqual("6000", numeros.RomanoParaInteiro("V̄Ī"));
        }


    }
}
