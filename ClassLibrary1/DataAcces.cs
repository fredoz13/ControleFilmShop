using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ClassLibrary1
{
    public static class DataAcces
    {
        public const string CHEMINBDD = @"Server=.\SQLExpress;Database=FilmDatabase;Trusted_Connection=Yes";

        private static void InsertFilmIntoBDD(Films films)
        {
            SqlConnection connection = new SqlConnection(DataAcces.CHEMINBDD);
            connection.Open();
            SqlCommand firstInsert = connection.CreateCommand();
            firstInsert.CommandText = "INSERT INTO Films(TitreFilm,RealisateurFilm,DateSortiefilm,ResumeFilm,GenreFilm,DureeFilm) VALUES (@titre,@realisateur,@dateSortie,@resume,@genre,@duree)";
            firstInsert.Parameters.AddWithValue("@titre", films.Titre);
            firstInsert.Parameters.AddWithValue("@realisateur", films.Realisateur);
            firstInsert.Parameters.AddWithValue("@dateSortie", films.DateSortie);
            firstInsert.Parameters.AddWithValue("@resume", films.Resume);
            firstInsert.Parameters.AddWithValue("@genre", films.Genre);
            firstInsert.Parameters.AddWithValue("@duree", films.Duree);
            firstInsert.ExecuteNonQuery();
            connection.Close();
        }

        private static void InsertPersonneIntoBDD(Personnes personnes)
        {
            SqlConnection connection = new SqlConnection(DataAcces.CHEMINBDD);
            connection.Open();
            SqlCommand firstInsert = connection.CreateCommand();
            firstInsert.CommandText = "INSERT INTO Personnes(NomPersonne,PrenomPersonne,DateNaissancePersonne,AdressePersonnne,VillePersonne,CpPersonne,TaillePersonne,PoidsPersonne) VALUES (@nom,@prenom,@date,@adresse,@ville,@cp,@taille,@poids)";
            firstInsert.Parameters.AddWithValue("@nom", personnes.Nom);
            firstInsert.Parameters.AddWithValue("@prenom", personnes.Prenom);
            firstInsert.Parameters.AddWithValue("@date", personnes.DateNaissance);
            firstInsert.Parameters.AddWithValue("@adresse", personnes.Adresse);
            firstInsert.Parameters.AddWithValue("@ville", personnes.Ville);
            firstInsert.Parameters.AddWithValue("@cp", personnes.Cp);
            firstInsert.Parameters.AddWithValue("@taille", personnes.Taille);
            firstInsert.Parameters.AddWithValue("@poids", personnes.Poids);
            firstInsert.ExecuteNonQuery();
            connection.Close();
        }
    }
}
