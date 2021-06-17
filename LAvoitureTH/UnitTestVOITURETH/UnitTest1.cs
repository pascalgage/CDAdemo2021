using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassesVOITURETH;


namespace UnitTestVOITURETH
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Voiture bmw = new Voiture();
            Assert.AreEqual(bmw.SonMoteur.NbCV,4);
        }
    }
}
