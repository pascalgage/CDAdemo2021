using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using rayonR;

namespace UnitTestProject1RAYON
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1VOLUME()
        {
            double volume = Program.Volume(7);
            Assert.AreEqual(volume, 1436,76);
        }

        [TestMethod]
        public void TestMethod1AIRE()
        {
            double aire = Program.Aire(7);
            Assert.AreEqual(aire, 615,752);
        }
    }
}
