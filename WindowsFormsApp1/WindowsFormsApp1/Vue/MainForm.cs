using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Btn_Generation_Click(object sender, EventArgs e)
        {
            Label_retour.Text = "";
            progressBar_generation.Value = 0;
            progressBar_envoi.Value = 0;

            progressBar_generation.Value = 100;
            Label_retour.Text = "OK - Génération effectuée";
            Label_retour.ForeColor = Color.Green;

            if(radioButton_donnees.Checked == true)
            {
                //Call genedonnees
            }

            if (radioButton_processus.Checked == true)
            {
                //Call geneprocess
            }

            if (radioButton_commandes.Checked == true)
            {
                //Call genecmd
            }
        }

        private void Btn_Envoi_Click(object sender, EventArgs e)
        {
            Label_retour.Text = "";
            progressBar_envoi.Value = 0;

            progressBar_envoi.Value = 23;
            Label_retour.Text = "Erreur - Pas de connexion Oracle";
            Label_retour.ForeColor = Color.Red;

            //Call envoi oracle
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Label_retour.Text = "";
        }
    }
}
