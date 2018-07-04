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
            decimal valeur = numericUpDown1.Value;

            Label_retour.Text = "Génération en cours";
            Label_retour.ForeColor = Color.Orange;
            Label_retour.Update();

            string retour = Controleur.GestionGeneration.ControlGenerateur(Convert.ToInt32(valeur), comboBox1.Text);
            Label_retour.Text = retour;
            Label_retour.ForeColor = Color.Green;
            Label_retour.Update();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Label_retour.Text = "";
        }
    }
}
