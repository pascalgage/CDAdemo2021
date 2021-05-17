using System;
using ClassPREMIER;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestPREMIER_LIST
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1_EstUnNombrepremier_true()
        {
            bool Estpremier = Class1.EstUnNombrepremier(2);
            Assert.IsTrue(Estpremier);
        }
        [TestMethod]
        public void TestMethod1_EstUnNombrepremier_false()
        {
            bool Estpremier = Class1.EstUnNombrepremier(4);
            Assert.IsFalse(Estpremier);
        }
        [TestMethod]
        public void TestMethod2_EstUnNombrepremier_false2()
        {
            bool Estpremier = Class1.EstUnNombrepremier(0);
            Assert.IsFalse(Estpremier);
        }
        [TestMethod]
        public void TestMethod2_EstUnNombrepremier_false()
        {
            bool Estpremier = Class1.EstUnNombrepremier(1);
            Assert.IsFalse(Estpremier);
        }


    }
}
