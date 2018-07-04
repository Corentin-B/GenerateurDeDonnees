using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    class GestionEnvoi
    {
        public static string EnvoiDonneeAuto(string Nom, string Prenom, string Pays, string Liste, string Couleur, string Variante, string Texture, string Conditionnement, string Quantite, string Statut)
        {
            //Envoi Vers Oracle
           return ConnexionEnvoiOracle.EnvoiDonneeOracle(Nom, Prenom, Pays, Liste, Couleur, Variante, Texture, Conditionnement, Quantite, Statut);
        }

        public static string EnvoiDonneeManu()
        {
            string line;
            try
            {
                StreamReader sr = new StreamReader("Ressources\\Donnee.csv");

                line = sr.ReadLine();

                //Lecture du fichier puis envoi vers Oracle

                sr.Close();
                return "";
            }
            catch (Exception e)
            {
                MessageBox.Show(e + "");
                return "Erreur";
            }
        }
    }
}
