using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using NS_Bouteille;

namespace UnitTestProject_Bouteille
{
    [TestClass]
    public class UnitTest_Classe_Bouteille
    {
        [TestMethod]
        public void Ouvrir_OuvrirQuandFerme_RetourneTrue()
        {

            NS_Bouteille.Bouteille maBouteille = new NS_Bouteille.Bouteille(0, 0, false);
            Assert.IsTrue(maBouteille.Ouvrir());
        }
        [TestMethod]
        public void Ferme_FermeQuandOuvert_RetourneTrue()
        {

            NS_Bouteille.Bouteille maBouteille = new NS_Bouteille.Bouteille(0, 0, true);
            Assert.IsTrue(maBouteille.Fermer());
        }
    }
}
