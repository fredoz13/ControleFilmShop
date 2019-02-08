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
        public void Le_Titre_Du_Film_Ne_Doit_Pas_Exeder_50_Caracteres()
        {
            var film = new Films();

            Assert.ThrowsException<ArgumentException>(
                () => film.Titre = ""
                );
        }


    }
    
}
