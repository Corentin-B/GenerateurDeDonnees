using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Generateur
    {
        public static string GenerateurdonneeClient()
        {
            //Nom
            string Nom = RandFichier("Ressources\\Nom.txt");
            //Prenom
            string Prenom = RandFichier("Ressources\\Prenom.txt");

            return Nom + "," + Prenom + ",";
        }

        public static string GenerateurdonneeCommande()
        {
            //Pays
            string Pays = RandFichier("Ressources\\Pays.txt");
            //Liste
            string Liste = RandFichier("Ressources\\Liste.txt");
            //Couleur
            string Couleur = RandFichier("Ressources\\Couleur.txt");
            //Variante
            string Variante = RandFichier("Ressources\\Variante.txt");
            //Texture
            string Texture = RandFichier("Ressources\\Texture.txt");
            //Conditionnement
            string Conditionnement = RandFichier("Ressources\\Conditionnement.txt");
            //Quantité
            Random rndo = new Random();
            System.Threading.Thread.Sleep(1);
            string Quantite = "" + rndo.Next(1, 500);

            return Pays + "," + Liste + "," + Couleur + "," + Variante + "," + Texture + "," + Conditionnement + "," + Quantite;
        }

        private static string RandFichier(string fichier)
        {
            string[] lignes = System.IO.File.ReadAllLines(fichier);

            System.Threading.Thread.Sleep(1);

            Random rnd = new Random();
            int nombrerandom = rnd.Next(1, lignes.Length);
            nombrerandom --;

            return lignes[nombrerandom];
        }
    }
}