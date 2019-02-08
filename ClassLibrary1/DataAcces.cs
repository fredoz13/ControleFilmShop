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

        private static void AfficherFilms()
        {

            SqlConnection connection = new SqlConnection(DataAcces.CHEMINBDD);
            connection.Open();
            SqlCommand selectCommand = connection.CreateCommand();
            selectCommand.CommandText = "SELECT IdFilm, NomFilm,RealisateurFilm, ResumeFilm,GenreFilm,DureeFilm FROM Films ORDER BY NomFilm";

            try
            {
                SqlDataReader dataReader = selectCommand.ExecuteReader();
                if (!dataReader.HasRows)
                {
                    dataReader.Close();
                    Console.WriteLine();
                    Console.WriteLine("Oups pas de film trouvé!!!");
                    Console.ReadKey(true);
                    Console.Clear();
                }
                else
                {
                    while (dataReader.Read())
                    {
                        Console.WriteLine("Nom : " + dataReader[1]);
                        Console.WriteLine("Réalisateur : " + dataReader[2]);
                        Console.WriteLine("Résumé : " + dataReader[3]);
                        Console.WriteLine("Genre : " + dataReader[4]);
                        Console.WriteLine("Durée : " + dataReader[5]);
                        Console.ReadKey(true);
                        Console.WriteLine();
                    }
                    dataReader.Close();
                    Console.Clear();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Une erreur est survenue: ", ex.Message);
                Console.WriteLine("Veuillez recommencer...");
                connection.Close();
            }
            connection.Close();
        }
        private static void AfficherPersonne()
        {

            SqlConnection connection = new SqlConnection(DataAcces.CHEMINBDD);
            connection.Open();
            SqlCommand selectCommand = connection.CreateCommand();
            selectCommand.CommandText = "SELECT IdPersonne, NomPersonne,PrenomPersonne, DateNaissancePersonne,AdressePersonne,VillePersonne,CpPersonne,TaillePersonne,PoidsPersonne FROM Personnes ORDER BY NomPersonne";

            try
            {
                SqlDataReader dataReader = selectCommand.ExecuteReader();
                if (!dataReader.HasRows)
                {
                    dataReader.Close();
                    Console.WriteLine();
                    Console.WriteLine("Oups pas de personne trouvée!!!");
                    Console.ReadKey(true);
                    Console.Clear();
                }
                else
                {
                    while (dataReader.Read())
                    {
                        Console.WriteLine("Nom : " + dataReader[1]);
                        Console.WriteLine("Prénom : " + dataReader[2]);
                        Console.WriteLine("DateNaissance : " + dataReader[3]);
                        Console.WriteLine("AdressePersonne : " + dataReader[4]);
                        Console.WriteLine("VillePersonne : " + dataReader[5]);
                        Console.WriteLine("CpPersonne : " + dataReader[6]);
                        Console.WriteLine("TaillePersonne : " + dataReader[7]);
                        Console.WriteLine("PoidsPersonne : " + dataReader[8]);
                        Console.ReadKey(true);
                        Console.WriteLine();
                    }
                    dataReader.Close();
                    Console.Clear();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Une erreur est survenue: ", ex.Message);
                Console.WriteLine("Veuillez recommencer...");
                connection.Close();
            }
            connection.Close();
        }
    }
}
