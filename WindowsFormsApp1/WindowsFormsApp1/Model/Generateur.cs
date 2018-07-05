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

            return Nom + "," + Prenom;
        }

        public static string GenerateurdonneeCommande(string Nom, string Prenom)
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
            //Statut
            int randstatut = rndo.Next(1, 100);
            string Statut;
            if(randstatut < 5)
            {
                Statut = "Fabrication";
            }
            else if(randstatut < 40)
            {
                Statut = "Fini";
            }
            else
            {
                Statut = "Attente";
            }

            //Envoi vers Oracle
            GestionEnvoi.EnvoiDonneeAuto(Nom ,Prenom ,Pays ,Liste ,Couleur ,Variante ,Texture ,Conditionnement ,Quantite ,Statut);

            return "," + Pays + "," + Liste + "," + Couleur + "," + Variante + "," + Texture + "," + Conditionnement + "," + Quantite + "," + Statut;
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

        public static string GenerateurdonneeMachine(string Id, string type)
        {
            Random rnd = new Random();

            int IdMachine = rnd.Next(1, 5);

            int jour = rnd.Next(1, 30);
            int moi = rnd.Next(1, 12);
            int annee = rnd.Next(2018, 2020);

            string dateDebut = jour+"/"+moi+"/"+annee;

            jour = jour + rnd.Next(1, 5);

            string dateFin = jour+"/"+moi+"/"+annee;

            GestionEnvoi.EnvoiMechineAuto(IdMachine, Id, dateDebut, dateFin, type);

            return "";
        }
    }
}