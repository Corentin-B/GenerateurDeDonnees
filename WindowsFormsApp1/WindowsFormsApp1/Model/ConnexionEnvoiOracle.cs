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
        public static string EnvoiDonneeOracle(string Nom, string Prenom, string Pays, string Liste, string Couleur, string Variante, string Texture, string Conditionnement, string Quantite, string Statut)
        {
            try
            {
                OracleConnection con = new OracleConnection(" Data Source = projet-data-v2.c5iadtb7wbsy.eu-west-1.rds.amazonaws.com:1521/orcl; User ID = dbadmin; Password = DouilleD4ta");

                var commandText = "INSERT INTO Orders (VARIANT,TEXTURE,COLORS,QUANTITY,CONDITIONNING,NAME,NAME_CANDY_TYPE,NAME_COUNTRY) VALUES(:Variante, :Texture, :Couleur, :Quantite, :Conditionnement, :Nprenom, :Liste, :Pays)";
                string Nprenom = Nom + " " + Prenom;

                OracleCommand cmd2 = new OracleCommand(commandText, con);

                cmd2.Parameters.Add(new OracleParameter(":Variante", Variante));
                cmd2.Parameters.Add(new OracleParameter(":Texture", Texture));
                cmd2.Parameters.Add(new OracleParameter(":Couleur", Couleur));
                cmd2.Parameters.Add(new OracleParameter(":Quantite", Quantite));
                cmd2.Parameters.Add(new OracleParameter(":Conditionnement", Conditionnement));
                cmd2.Parameters.Add(new OracleParameter(":Nprenom", Nprenom));
                cmd2.Parameters.Add(new OracleParameter(":Liste", Liste));
                cmd2.Parameters.Add(new OracleParameter(":Pays", Pays));

                con.Open();
                cmd2.ExecuteNonQuery();
                con.Close();
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
