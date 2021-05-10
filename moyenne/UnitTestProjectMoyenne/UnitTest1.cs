using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using moyenne;

namespace UnitTestProjectMoyenne
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodDivisionNombreImpaire()
        {
            double resultat = Program.MOY(7, 8);

            Assert.AreEqual(resultat, 7.5);
        }

        [TestMethod]
        public void TestMethodDivisionNombreNEG()
        {
            double resultat = Program.MOY(-7, 8);

            Assert.AreEqual(resultat, 0,5);
        }
    }
}
