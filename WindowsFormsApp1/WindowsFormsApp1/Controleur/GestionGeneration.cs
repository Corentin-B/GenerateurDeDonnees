using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1.Controleur
{
    class GestionGeneration
    {
        public static string ControlGenerateur(int nbDonne)
        {
            try
            {
                StreamWriter sw = new StreamWriter("Ressources\\Donnee.csv");

                for (int i = 1; i <= nbDonne; i++)
                {
                    string Client = Generateur.GenerateurdonneeClient();

                    Random rndo = new Random();
                    int PlusieursCommandes = rndo.Next(1, 100);
                    string Commande = null;

                    String[] sousClient = Client.Split(',');

                    if (PlusieursCommandes <= 70)
                    {
                        for (int j = 1; j <= rndo.Next(1, 10); j++)
                        {
                            Commande = Generateur.GenerateurdonneeCommande(sousClient[0], sousClient[1]);
                            sw.WriteLine(Client + Commande);
                        }
                    }

                    Commande = Generateur.GenerateurdonneeCommande(sousClient[0], sousClient[1]);
                    sw.WriteLine(Client + Commande);
                }
                sw.Close();

                string ValMachine = ConnexionEnvoiOracle.LectureDonneeOracle();

                String[] sousMachine = ValMachine.Split(',');

                foreach(string valeur in sousMachine)
                {
                    Generateur.GenerateurdonneeMachine(Convert.ToInt32(valeur));
                }
                    return "OK - Génération terminée";
            }
            catch (Exception e)
            {
                MessageBox.Show(e + "");
                return "Erreur";
            }
        }
    }
}
