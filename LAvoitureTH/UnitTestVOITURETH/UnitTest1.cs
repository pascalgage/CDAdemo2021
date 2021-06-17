using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassesVOITURETH;


namespace UnitTestVOITURETH
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMoteur()
        {
            Voiture bmw = new Voiture();
            Assert.AreEqual(bmw.SonMoteur.NbCV,4);
        }

        [TestMethod]
        public void TestMoteur2()
        {
            Voiture bmw = new Voiture();
            if (bmw.Demarrer())
            {
                Assert.AreEqual(bmw.SonMoteur.EstDemarre, true);
            }
            
        }
        [TestMethod]
        public void TestMoteur3()
        {
            Voiture bmw = new Voiture();
            if (bmw.Arreter())
            {
                Assert.AreEqual(bmw.MesRoues, false);
            }

        }
    }
}
