using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FRACTION_CLASS;
namespace Test_FRaction
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodESTsuperieureA()
        {
            Fraction f = new Fraction(18, 6);
            Fraction g = new Fraction(24, 12);

            f.SuperieurA(g);
            Assert.IsTrue(f.SuperieurA(g));

            
        }

        [TestMethod]
        public void TestMethodESTsuperieureA_IsFalse()
        {
            Fraction f = new Fraction(18, 6);
            Fraction g = new Fraction(24, 12);

            g.SuperieurA(f);
            Assert.IsFalse(g.SuperieurA(f));


        }
    }
}
