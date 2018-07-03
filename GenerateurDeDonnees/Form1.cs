using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenerateurDeDonnees
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*-----Divers Affichages-----*/
            progressBar_Generation.Value = 0;
            progressBar_Envoi.Value = 0;
            Label_retour.Text = "";
            
            Label_retour.Text = "OK - Génération terminée";
            Label_retour.ForeColor = Color.Green;
            progressBar_Generation.Value = 100;
            /*-----Fin Divers Affichages-----*/

            if (radioButton_Donnees.Checked == true)
            {
                //appel methode données
            }
            if (radioButton_Processus.Checked == true)
            {
                //appel methode processus
            }
            if (radioButton_Commandes.Checked == true)
            {
                //apple methode commandes
            }

        }

        private void Btn_envoi_Click(object sender, EventArgs e)
        {
            /*-----Divers Affichages-----*/
            progressBar_Envoi.Value = 0;
            Label_retour.Text = "";

            Label_retour.Text = "Erreur - Base Oracle introuvable";
            Label_retour.ForeColor = Color.Red;
            progressBar_Envoi.Value = 23;
            /*-----Fin Divers Affichages-----*/

            //Connexion Base Oracle
            //+ Envoie des données dans la base
        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            Label_retour.Text = "";
        }
    }
}
