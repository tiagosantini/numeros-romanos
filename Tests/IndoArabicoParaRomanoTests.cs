using Microsoft.VisualStudio.TestTools.UnitTesting;

using NumerosRomanos;

namespace Tests
{
    [TestClass]
    public class IndoArabicoParaRomanoTests
    {
        NumeraisRomanos numerais;
        public IndoArabicoParaRomanoTests()
        {
            numerais = new NumeraisRomanos();
        }

        [TestMethod]
        public void DeveConverterParaUm()
        {
            Assert.AreEqual("I", numerais.IndoArabicoParaRomano(1));
        }

        [TestMethod]
        public void DeveConverterParaCinco()
        {
            Assert.AreEqual("V", numerais.IndoArabicoParaRomano(5));
        }

        [TestMethod]
        public void DeveConverterParaNove()
        {
            Assert.AreEqual("IX", numerais.IndoArabicoParaRomano(9));
        }

        [TestMethod]
        public void DeveConverterParaDez()
        {
            Assert.AreEqual("X", numerais.IndoArabicoParaRomano(10));
        }

        [TestMethod]
        public void DeveConverterParaOnze()
        {
            Assert.AreEqual("XI", numerais.IndoArabicoParaRomano(11));
        }

        [TestMethod]
        public void DeveConverterParaQuinhentos()
        {
            Assert.AreEqual("D", numerais.IndoArabicoParaRomano(500));
        }

        [TestMethod]
        public void DeveConverterParaMil()
        {
            Assert.AreEqual("M", numerais.IndoArabicoParaRomano(1000));
        }
    }
}
