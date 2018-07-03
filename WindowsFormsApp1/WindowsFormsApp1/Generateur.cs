using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Generateur
    {
        public static string Generateurdonnee()
        {
            //Nom
            string Nom = RandFichier("Ressources\\Nom.txt");
            //Prenom
            string Prenom = RandFichier("Ressources\\Nom.txt");
            //Pays
            string Pays = RandFichier("Ressources\\Nom.txt");
            //Liste
            string Liste = RandFichier("Ressources\\Nom.txt");
            //Couleur
            string Couleur = RandFichier("Ressources\\Nom.txt");
            //Variante
            string Variante = RandFichier("Ressources\\Nom.txt");
            //Texture
            string Texture = RandFichier("Ressources\\Nom.txt");
            //Conditionnement
            string Conditionnement = RandFichier("Ressources\\Nom.txt");

            return Nom +","+ Prenom + "," + Pays + "," + Liste + "," + Couleur + "," + Variante + "," + Conditionnement;
        }

        private static string RandFichier(string fichier)
        {
            string[] lignes = System.IO.File.ReadAllLines(fichier);

            Random rnd = new Random();
            int nombrerandom = rnd.Next(1, lignes.Length);

            return lignes[nombrerandom];
        }
    }
}