using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModelObjet;

namespace ProjetDeTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod()]
        public void ValiderTest()
        {
            // Le nombre de jours d'achat est < à 30 jours
            bool jour1 = Condition.Valider(29);
            Assert.AreEqual(true, jour1);

            // Le nombre de jours d'achat est > à 30 jours
            bool jour2 = Condition.Valider(45);
            Assert.AreEqual(false, jour2);
        }

        [TestMethod()]
        public void CalculerMontantMaxTest()
        {
            // Pour la catégorie livre
            string categorie1 = Condition.CalculerMontantMax("Livres").ToString();
            Assert.AreEqual(30, categorie1);
            // Pour la catégorie jouet
            string categorie2 = Condition.CalculerMontantMax("Jouets").ToString();
            Assert.AreEqual(30, categorie2);

            // Pour la catégorie informatique
            string categorie3 = Condition.CalculerMontantMax("Informatique").ToString();
            Assert.AreEqual(30, categorie3);

        }

        [TestMethod()]
        public void CalculerMontantRembourseTest()
        {
            // Un livre achété 24 euros depuis 15 jours avec un état "Très abimé" en étant non membre

            // Un livre achété 24 euros depuis 15 jours avec un état "Bon" en étant membre

        }

        [TestMethod()]
        public void CalculerReductionMembreTest()
        {
            // Il est membre
            double membre1 = Condition.CalculerReductionMembre(true);
            Assert.AreEqual(0.80, membre1);




            // Il n'est pas membre
            double membre2 = Condition.CalculerReductionMembre(false);
            Assert.AreEqual()

        }

        [TestMethod()]
        public void CalculerReductionTest()
        {
            // Pour un état "bon"
            double reduction1 = Condition.CalculerReduction("bon");
            Assert.AreEqual(0.1, reduction1);

            // Pour un état "abimé"

            double reduction2 = Condition.CalculerReduction("Abimé");
            Assert.AreEqual(0.3, reduction2);
        }
    }
}
