using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FRACTION_CLASS;
namespace Test_FRaction
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodESTsuperieureA_ISTrue()
        {
            Fraction f = new Fraction(18, 6);
            Fraction g = new Fraction(24, 12);

            f.SuperieurA(g);
            Assert.IsTrue(f.SuperieurA(g),"true");

            
        }

        [TestMethod]
        public void TestMethodESTsuperieureA_IsFalse()
        {
            Fraction f = new Fraction(18, 6);
            Fraction g = new Fraction(24, 12);

            g.SuperieurA(f);
            Assert.IsFalse(g.SuperieurA(f),"false");


        }

        [TestMethod]
        public void TestMethodESTinferieureA_IsTrue()
        {
            Fraction f = new Fraction(1,3);
            Fraction g = new Fraction(2,4);

            f.EstInferieurA(g);
            Assert.IsTrue(f.EstInferieurA(g), "true");


        }

        [TestMethod]
        public void TestMethodESTinferieureA_IsFalse()
        {
            Fraction f = new Fraction(1,3);
            Fraction g = new Fraction(2,4);

            g.EstInferieurA(f);
            Assert.IsFalse(g.EstInferieurA(f), "false");


        }






        [TestMethod]
        public void TestMethodPLUS()
        {
            Fraction f = new Fraction(-17, 25);
            Fraction g = new Fraction(-36, 2);

           
            Fraction r = f.Plus(g);

            Assert.AreEqual(-467,r.Numerateur);
            Assert.AreEqual(25,r.Denominateur);
        }
        

        [TestMethod]
        public void TestMethodMOINS()
        {
            Fraction f = new Fraction(6, 3);
            Fraction g = new Fraction(-128, 64);

            Fraction v = f.Moins(g);
            
            Assert.AreEqual(4, v.Numerateur);
            Assert.AreEqual(1, v.Denominateur);


        }

        [TestMethod]
        public void TestMethodDIVISE()
        {
            Fraction f = new Fraction(-17, 25);
            Fraction g = new Fraction(-36, 2);

            Fraction test=f.Divise(g);

            
            Assert.AreEqual(17, test.Numerateur);
            Assert.AreEqual(450, test.Denominateur);


        }
        
    }
}
