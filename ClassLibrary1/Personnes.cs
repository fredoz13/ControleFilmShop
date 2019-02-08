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
        private int taille;
        private int poids;

        public Personnes()
        {
        }

        public Personnes(string nom, string prenom, DateTime dateNaissance, string adresse, string cp, int taille, int poids, string ville)
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

        public string Nom
        {
            get => nom.ToUpper();
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Le nom ne peut pas être vide");
                }
                if (value.Length > 50)
                {
                    throw new ArgumentException("Le nom saisi ne doit pas contenir plus de 50 caractères");
                }
                nom = value;

            }
        }
        public string Prenom
        {
            get => prenom;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Le nom ne peut pas être vide");
                }
                if (value.Length > 50)
                {
                    throw new ArgumentException("Le nom saisi ne doit pas contenir plus de 50 caractères");
                }
                prenom = value;

            }
        }
        public DateTime DateNaissance { get => dateNaissance; set => dateNaissance = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string Cp { get => cp; set => cp = value; }


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
        public int Taille { get => taille; set => taille = value; }
        public int Poids { get => poids; set => poids = value; }

        public string SePresenter()
        {
            return "Bonjour je m'appelle " + NomComplet+".J'ai "+Age+" ans. J'habite à "+ Ville ;
        }

    }
}
