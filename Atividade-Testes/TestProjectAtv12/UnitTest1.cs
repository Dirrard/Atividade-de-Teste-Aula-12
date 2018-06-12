using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestProjectAtv12;

namespace Teste
{
    [TestClass]
    public class UnitTest1
    {
        Aluno a1 = new Aluno();
        Aluno a2 = new Aluno();
        Aluno a3 = new Aluno();

        [TestMethod]
        public void Idade1()
        {
            a1.DataNasc = new DateTime(1990, 04, 01);

            Assert.IsTrue(a1.Idade() > 0);
        }
        [TestMethod]
        public void Idade2()
        {
            a2.DataNasc = new DateTime(2020, 01, 01);

            Assert.IsTrue(a2.Idade() > 0);
        }
        [TestMethod]
        public void Idade3()
        {
            a3.DataNasc = new DateTime(1986, 03, 12);

            Assert.IsTrue(a3.Idade() > 0);
        }

        [TestMethod]
        public void nome1()
        {
            a1.Nome = "Felipe";
            a1.Snome = "Vozgeral Çanca";

            Assert.IsTrue(a1.validarNome() != 0);
        }
        [TestMethod]
        public void nome2()
        {
            a2.Nome = "Alin@";
            a2.Snome = "Branca";

            Assert.IsFalse(a2.validarNome() != 0);
        }
        [TestMethod]
        public void nome3()
        {
            a3.Nome = "Alfredo";
            a3.Snome = "Sella III";

            Assert.IsTrue(a3.validarNome() != 0);
        }

        [TestMethod]
        public void nomeC1()
        {
            a1.Nome = "Felipe";
            a2.Snome = "Vozgeral Çanca";

            Assert.AreEqual(("Felipe Vozgeral Çanca"), a1.nomeCompleto());
        }
        [TestMethod]
        public void nomeC2()
        {
            a2.Nome = "Alin@";
            a2.Snome = "Branca";

            Assert.AreEqual(("Aline Branca"), a2.nomeCompleto());
        }


        [TestMethod]
        public void erro1()
        {
            a1.Nome = "Felipe";
            a1.Snome = "Vozgeral Çanca";

            a1.validarNome();
            Assert.AreEqual("ERROR POR '@'", a1.ValidacaoErro(a1.validarNome()));
        }

        [TestMethod]
        public void erro3()
        {
            a3.Nome = "Alfredo";
            a3.Snome = "Sella III";

            a3.validarNome();
            Assert.AreEqual("ERROR POR 'Ç'", a3.ValidacaoErro(a3.validarNome()));
        }
    }
}
