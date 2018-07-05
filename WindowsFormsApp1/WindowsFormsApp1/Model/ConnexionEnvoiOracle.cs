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

                var commandText = "INSERT INTO Orders (VARIANT,TEXTURE,COLORS,QUANTITY,CONDITIONNING,NAME,NAME_CANDY_TYPE,NAME_COUNTRY,STATUT) VALUES(:Variante, :Texture, :Couleur, :Quantite, :Conditionnement, :Nprenom, :Liste, :Pays, :Statut)";
                string Nprenom = Nom + " " + Prenom;

                OracleCommand cmd2 = new OracleCommand(commandText, con);

                cmd2.Parameters.Add(new OracleParameter(":Variante", Variante));
                cmd2.Parameters.Add(new OracleParameter(":Texture", Texture));
                cmd2.Parameters.Add(new OracleParameter(":Couleur", Couleur));
                cmd2.Parameters.Add(new OracleParameter(":Quantite", Convert.ToInt32(Quantite)));
                cmd2.Parameters.Add(new OracleParameter(":Conditionnement", Conditionnement));
                cmd2.Parameters.Add(new OracleParameter(":Nprenom", Nprenom));
                cmd2.Parameters.Add(new OracleParameter(":Liste", Liste));
                cmd2.Parameters.Add(new OracleParameter(":Pays", Pays));
                cmd2.Parameters.Add(new OracleParameter(":Statut", Statut));

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

        public static string LectureDonneeOracle()
        {
            try
            {
                OracleConnection con = new OracleConnection(" Data Source = projet-data-v2.c5iadtb7wbsy.eu-west-1.rds.amazonaws.com:1521/orcl; User ID = dbadmin; Password = DouilleD4ta");

                var commandText = "SELECT ID_ORDERS FROM Orders WHERE STATUT = 'Attente'";

                OracleCommand cmd = new OracleCommand(commandText, con);

                con.Open();

                OracleDataReader reader;
                reader = cmd.ExecuteReader();

                string ValeurRetour = "";

                while (reader.Read())
                {
                    ValeurRetour = ValeurRetour + "," + reader.GetInt32(0);
                }

                con.Close();

                return ValeurRetour;
            }
            catch (Exception e)
            {
                MessageBox.Show(e + "");
                return "Erreur";
            }
        }

        public static string EnvoiMechineOracle(int IdMachine, string Id, string dateDebut, string dateFin, string type)
        {
            try
            {
                OracleConnection con = new OracleConnection(" Data Source = projet-data-v2.c5iadtb7wbsy.eu-west-1.rds.amazonaws.com:1521/orcl; User ID = dbadmin; Password = DouilleD4ta");

                var commandText2 = "UPDATE ORDERS SET STATUT = 'Planifiée' WHERE ID_ORDERS = '" + Id+"'";
                var commandText = "INSERT INTO COND_MACH (ID_MACH_COND,TIME_START,TIME_STOP,ID_ORDERS) VALUES(:IdMachine, :dateDebut, :dateFin, :Id)";

                if (type == "Fabrication")
                {
                    commandText = "INSERT INTO MANUF_MACH (ID_MACHINE,TIME_START,TIME_STOP,ID_ORDERS) VALUES(:IdMachine, :dateDebut, :dateFin, :Id)";
                }

                OracleCommand cmd1 = new OracleCommand(commandText, con);

                cmd1.Parameters.Add(new OracleParameter(":IdMachine", IdMachine));
                cmd1.Parameters.Add(new OracleParameter(":dateDebut", dateDebut));
                cmd1.Parameters.Add(new OracleParameter(":dateFin", dateFin));
                cmd1.Parameters.Add(new OracleParameter(":Id", Convert.ToInt32(Id)));


                OracleCommand cmd2 = new OracleCommand(commandText2, con);

                //cmd2.Parameters.Add(new OracleParameter(":Statut", "Planifiée"));

                con.Open();
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e + "");
                return "Erreur";
            }

            return "OK - Traitement Teminée";
        }
    }
}
