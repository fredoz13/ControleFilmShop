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

        public string Titre { get => titre; set => titre = value; }
        public string Realisateur { get => realisateur; set => realisateur = value; }
        public DateTime DateSortie { get => dateSortie; set => dateSortie = value; }
        public string Resume { get => resume; set => resume = value; }
        public int Duree { get => duree; set => duree = value; }
        public List<Personnes> ListeActeurs { get => listeActeurs; set => listeActeurs = value; }
        public string Genre { get => genre; set => genre = value; }
    }
}
