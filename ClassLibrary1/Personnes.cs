using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Personnes
    {
        private string nom;
        private string prenom;
        private DateTime dateNaissance;
        private string adresse;
        private string cp;
        private string ville;
        private string taille;
        private string poids;

        public Personnes()
        {
        }

        public Personnes(string nom, string prenom, DateTime dateNaissance, string adresse, string cp, string taille, string poids, string ville)
        {
            Nom = nom;
            Prenom = prenom;
            DateNaissance = dateNaissance;
            Adresse = adresse;
            Cp = cp;
            Taille = taille;
            Poids = poids;
            Ville = ville;
        }

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public DateTime DateNaissance { get => dateNaissance; set => dateNaissance = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string Cp { get => cp; set => cp = value; }
        public string Taille { get => taille; set => taille = value; }
        public string Poids { get => poids; set => poids = value; }
        public string NomComplet { get => Prenom + " " + Nom; }
        public int Age
        {
            get
            {

                int age = DateTime.Now.Year - DateNaissance.Year;
                DateTime dateAnniversaire =
                    new DateTime(
                        DateTime.Now.Year,
                        DateNaissance.Month,
                        DateNaissance.Day);

                if (dateAnniversaire >= DateTime.Now)
                {
                    age--;
                }

                return age;
            }
        }

        public string Ville { get => ville; set => ville = value; }

        public string SePresenter()
        {
            return "Bonjour je m'appelle " + NomComplet+".J'ai "+Age+" ans. J'habite à "+ Ville ;
        }

    }
}
