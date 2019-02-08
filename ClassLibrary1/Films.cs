using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Films
    {
        private string titre;
        private string realisateur;
        private DateTime dateSortie;
        private string resume;
        private string genre;
        private int duree;
        private List<Personnes> listeActeurs;

        public Films()
        {
        }
        public string Titre
        {
            get => titre.ToUpper();
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Le titre ne peut pas être vide");
                }
                if (value.Length > 50)
                {
                    throw new ArgumentException("Le titre saisi ne doit pas contenir plus de 50 caractères");
                }
                titre = value;

            }
        }
        public string Realisateur
        {
            get => realisateur.ToUpper();
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Le nom du réalisateur ne peut pas être vide");
                }
                if (value.Length > 50)
                {
                    throw new ArgumentException("Le nom du réalisateur ne doit pas contenir plus de 50 caractères");
                }
                realisateur = value;

            }
        }
        public DateTime DateSortie { get => dateSortie; set => dateSortie = value; }
        public string Resume { get => resume; set => resume = value; }
        public int Duree { get => duree; set => duree = value; }
        public List<Personnes> ListeActeurs { get => listeActeurs; set => listeActeurs = value; }
        public string Genre { get => genre; set => genre = value; }
    }
}
