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
        public static string ControlGenerateur(int nbDonne, string typeDonne)
        {
            try
            {
                StreamWriter sw = new StreamWriter("Ressources\\Donnee.csv");
           
                /*                if (typeDonne == "Données")
                                {
                */
                for (int i = 1; i <= nbDonne; i++)
                {
                    string Client = Generateur.GenerateurdonneeClient();

                    Random rndo = new Random();
                    System.Threading.Thread.Sleep(1);
                    int PlusieursCommandes = rndo.Next(1, 100);
                    string Commande = null;

                    String[] sousClient = Client.Split(',');

                    if (PlusieursCommandes <= 70)
                    {
                        for (int j = 1; j <= rndo.Next(1, 10); j++)
                        {
                            //Commande = Generateur.GenerateurdonneeCommande(sousClient[0], sousClient[1]);
                            sw.WriteLine(Client + Commande);
                        }
                    }

                    //Commande = Generateur.GenerateurdonneeCommande(sousClient[0], sousClient[1]);
                    sw.WriteLine(Client + Commande);

                    
                }
                sw.Close();
                return "OK - Génération terminée";
                /*                }
                                else if (typeDonne == "Processus")
                                {
                                    sw.Close();
                                    return "OK - Génération terminée";
                                }
                                else if (typeDonne == "Commandes")
                                {
                                    sw.Close();
                                    return "OK - Génération terminée";
                                }
                                else
                                {
                                    sw.Close();
                                    return "Erreur";
                                }
                */
            }
            catch (Exception e)
            {
                MessageBox.Show(e + "");
                return "Erreur";
            }
        }
    }
}
