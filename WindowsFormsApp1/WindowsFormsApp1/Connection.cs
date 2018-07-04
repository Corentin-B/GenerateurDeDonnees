using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace WindowsFormsApp1.Model
{
    public class Connection
    {
        static OracleConnection con;

        public Connection()
        {
            con = new OracleConnection(" Data Source = projet-data.c5iadtb7wbsy.eu-west-1.rds.amazonaws.com:1521/orcl; User ID = projet_data; Password = DouilleD4ta");
            con.Open();
        }
/*
        public OracleConnection getConnection()
        {
            return con;
        }
*/
        public void EnvoiDonneeOracle(string Nom, string Prenom, string Pays, string Liste, string Couleur, string Variante, string Texture, string Conditionnement, string Quantite, string Statut)
        {
            OracleCommand cmd = con.CreateCommand();

            cmd.CommandText = "INSERT INTO CUSTOMERS VALUES ('10','bernard')";
            try
            {
                OracleDataReader reader = cmd.ExecuteReader();
                reader.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e + "");
            }
            // reader.Read();

            cmd.Dispose();

        }
    }
}

