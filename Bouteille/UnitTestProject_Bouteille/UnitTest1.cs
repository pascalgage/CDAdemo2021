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
        [TestMethod]
        public void Remplir_RemplirQuantité_RetourneTrue()
        {
            decimal _aRajouterEnPourcentage = 30;
            NS_Bouteille.Bouteille maBouteille = new NS_Bouteille.Bouteille(0, 0, true);
            Assert.IsTrue(maBouteille.Remplir(_aRajouterEnPourcentage));
        }
        [TestMethod]
        public void Remplir_RemplirQuantité_RetourneFalse()
        {
            decimal _aRajouterEnPourcentage = 110;
            NS_Bouteille.Bouteille maBouteille = new NS_Bouteille.Bouteille(0, 0, true);
            Assert.IsFalse(maBouteille.Remplir(_aRajouterEnPourcentage));
        }
        [TestMethod]
        public void Vider_quantitéValide_retourneTrue()
        {
            //crée une bouteille valide
            Bouteille maBouteille = new Bouteille(2, 50, true);
            //Définir une quantité valide à vider
            decimal quantiteAvider = 45;
            //Vider une quantité valide
            bool resultat = maBouteille.Vider(quantiteAvider);
            //verifié que resultat est égal à true
            Assert.AreEqual(true, resultat);
            //Assert.IsTrue(resultat)
        }
       

    }
}
