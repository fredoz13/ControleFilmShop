using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
            public void Le_Nom_Du_Film_Doit_S_Appeler_Felix()
        {
            var film = new Films();
            film.Titre = "Felix";

            Assert.AreEqual("FELIX", film.Titre);
        }

        [TestMethod]
        public void Le_Nom_Du_Film_Ne_Peut_Pas_Etre_Vide()
        {
            var film = new Films();

            Assert.ThrowsException<ArgumentException>(
                () => film.Titre = ""
                );
        }

        [TestMethod]
        public void Le_Titre_Du_Film_Ne_Peut_Pas_Avoir_Plus_De_50_Caracteres()
        {
            var film = new Films();

            var exception = Assert.ThrowsException<ArgumentException>(
            () => film.Titre = "fffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff"
            );
            Assert.AreEqual("Le titre saisi ne doit pas contenir plus de 50 caractères", exception.Message);
        }

        [TestMethod]
        public void Le_Nom_De_La_Personne_Doit_S_Appeler_Felix()
        {
            var personne = new Personnes();
            personne.Nom = "Felix";

            Assert.AreEqual("FELIX", personne.Nom);
        }

        [TestMethod]
        public void Le_Nom_De_La_Personne_Ne_Peut_Pas_Etre_Vide()
        {
            var personne = new Personnes();

            Assert.ThrowsException<ArgumentException>(
                () => personne.Nom = ""
                );
        }

        [TestMethod]
        public void Le_Nom_De_La_Personne_Peut_Pas_Avoir_Plus_De_50_Caracteres()
        {
            var personne = new Personnes();

            var exception = Assert.ThrowsException<ArgumentException>(
            () => personne.Nom = "fffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff"
            );
            Assert.AreEqual("Le nom saisi ne doit pas contenir plus de 50 caractères", exception.Message);
        }
    }
    
}
