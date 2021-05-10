using System;
using EQUATION;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestEQUATION
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            float a = 0;
            float b = 0;            
            Assert.ThrowsException<Exception>( () => Program.Calcul_EQ(a, b) );
        }
        [TestMethod]
        public void TestMethod2()
        {
            float a = 0;
            float b = 2;
            Assert.ThrowsException<Exception>(() => Program.Calcul_EQ(a, b));
        }
        [TestMethod]
        public void TestMethod3()
        {
            float a = 1;
            float b = 3;

            float Resultat = Program.Calcul_EQ(a, b);
            Assert.AreEqual(-3, Resultat);
        }
    }
}
