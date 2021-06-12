using NumerosRomanos;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    [TestClass]
    public class IndoArabicoOperacoesMatematicasTests
    {
        NumeraisRomanos numerais;
        public IndoArabicoOperacoesMatematicasTests()
        {
            numerais = new NumeraisRomanos();
        }

        [TestMethod]
        public void DeveConverterParaNove()
        {
            Assert.AreEqual("IX", numerais.IndoArabicoParaRomano(9));
        }

        [TestMethod]
        public void DeveConverterParaOnze()
        {
            Assert.AreEqual("XI", numerais.IndoArabicoParaRomano(11));
        }
    }
}
