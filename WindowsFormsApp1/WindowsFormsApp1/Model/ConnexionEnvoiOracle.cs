using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace WindowsFormsApp1
{
    class ConnexionEnvoiOracle
    {
        static OracleConnection con;

        public void ConnectionOracle()
        {
            con = new OracleConnection(" Data Source = projet-data-v2.c5iadtb7wbsy.eu-west-1.rds.amazonaws.com:1521/orcl; User ID = projet_data; Password = DouilleD4ta");
            con.Open();
        }

        public static string EnvoiDonneeOracle(string Nom, string Prenom, string Pays, string Liste, string Couleur, string Variante, string Texture, string Conditionnement, string Quantite, string Statut)
        {
            try
            {
                OracleCommand cmd = con.CreateCommand();

                cmd.CommandText = "INSERT INTO Customers VALUES ('"+Nom + Prenom+"')";
                cmd.CommandText = "INSERT INTO Orders VALUES ('"+Pays + " " + Liste + " " + Couleur + " " + Variante + " " + Texture + " " + Conditionnement + " " + Quantite + " " + Statut +"')";
                //cmd.CommandText = "INSERT INTO Customers VALUES('"+Nom + Prenom+"')";


                OracleDataReader reader = cmd.ExecuteReader();
//                reader.Read();
                reader.Dispose();
                cmd.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e + "");
                return "Erreur";
            }

            return "OK - Envoie Teminée";
        }
    }
}
