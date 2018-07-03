namespace WindowsFormsApp1
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Label_Text_titre = new System.Windows.Forms.Label();
            this.Label_Text_nbdonnee = new System.Windows.Forms.Label();
            this.Label_Text_typedonnee = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.radioButton_donnees = new System.Windows.Forms.RadioButton();
            this.radioButton_processus = new System.Windows.Forms.RadioButton();
            this.radioButton_commandes = new System.Windows.Forms.RadioButton();
            this.Btn_generation = new System.Windows.Forms.Button();
            this.Btn_envoi = new System.Windows.Forms.Button();
            this.progressBar_generation = new System.Windows.Forms.ProgressBar();
            this.progressBar_envoi = new System.Windows.Forms.ProgressBar();
            this.Label_retour = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Text_titre
            // 
            this.Label_Text_titre.AutoSize = true;
            this.Label_Text_titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Text_titre.Location = new System.Drawing.Point(12, 9);
            this.Label_Text_titre.Name = "Label_Text_titre";
            this.Label_Text_titre.Size = new System.Drawing.Size(370, 17);
            this.Label_Text_titre.TabIndex = 0;
            this.Label_Text_titre.Text = "Logiciel générateur de données pour base Oracle";
            // 
            // Label_Text_nbdonnee
            // 
            this.Label_Text_nbdonnee.AutoSize = true;
            this.Label_Text_nbdonnee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Text_nbdonnee.Location = new System.Drawing.Point(12, 44);
            this.Label_Text_nbdonnee.Name = "Label_Text_nbdonnee";
            this.Label_Text_nbdonnee.Size = new System.Drawing.Size(126, 15);
            this.Label_Text_nbdonnee.TabIndex = 0;
            this.Label_Text_nbdonnee.Text = "Nombre de données :";
            // 
            // Label_Text_typedonnee
            // 
            this.Label_Text_typedonnee.AutoSize = true;
            this.Label_Text_typedonnee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Text_typedonnee.Location = new System.Drawing.Point(259, 44);
            this.Label_Text_typedonnee.Name = "Label_Text_typedonnee";
            this.Label_Text_typedonnee.Size = new System.Drawing.Size(107, 15);
            this.Label_Text_typedonnee.TabIndex = 0;
            this.Label_Text_typedonnee.Text = "Type de données :";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(15, 69);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(106, 21);
            this.numericUpDown1.TabIndex = 3;
            // 
            // radioButton_donnees
            // 
            this.radioButton_donnees.AutoSize = true;
            this.radioButton_donnees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton_donnees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_donnees.Location = new System.Drawing.Point(262, 69);
            this.radioButton_donnees.Name = "radioButton_donnees";
            this.radioButton_donnees.Size = new System.Drawing.Size(75, 19);
            this.radioButton_donnees.TabIndex = 4;
            this.radioButton_donnees.TabStop = true;
            this.radioButton_donnees.Text = "Données";
            this.radioButton_donnees.UseVisualStyleBackColor = true;
            // 
            // radioButton_processus
            // 
            this.radioButton_processus.AutoSize = true;
            this.radioButton_processus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton_processus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_processus.Location = new System.Drawing.Point(262, 92);
            this.radioButton_processus.Name = "radioButton_processus";
            this.radioButton_processus.Size = new System.Drawing.Size(82, 19);
            this.radioButton_processus.TabIndex = 5;
            this.radioButton_processus.TabStop = true;
            this.radioButton_processus.Text = "Processus";
            this.radioButton_processus.UseVisualStyleBackColor = true;
            // 
            // radioButton_commandes
            // 
            this.radioButton_commandes.AutoSize = true;
            this.radioButton_commandes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton_commandes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_commandes.Location = new System.Drawing.Point(262, 115);
            this.radioButton_commandes.Name = "radioButton_commandes";
            this.radioButton_commandes.Size = new System.Drawing.Size(96, 19);
            this.radioButton_commandes.TabIndex = 6;
            this.radioButton_commandes.TabStop = true;
            this.radioButton_commandes.Text = "Commandes";
            this.radioButton_commandes.UseVisualStyleBackColor = true;
            // 
            // Btn_generation
            // 
            this.Btn_generation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_generation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_generation.Location = new System.Drawing.Point(15, 177);
            this.Btn_generation.Name = "Btn_generation";
            this.Btn_generation.Size = new System.Drawing.Size(106, 33);
            this.Btn_generation.TabIndex = 1;
            this.Btn_generation.Text = "Génération";
            this.Btn_generation.UseVisualStyleBackColor = true;
            this.Btn_generation.Click += new System.EventHandler(this.Btn_Generation_Click);
            // 
            // Btn_envoi
            // 
            this.Btn_envoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_envoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_envoi.Location = new System.Drawing.Point(15, 216);
            this.Btn_envoi.Name = "Btn_envoi";
            this.Btn_envoi.Size = new System.Drawing.Size(106, 33);
            this.Btn_envoi.TabIndex = 2;
            this.Btn_envoi.Text = "Envoi";
            this.Btn_envoi.UseVisualStyleBackColor = true;
            this.Btn_envoi.Click += new System.EventHandler(this.Btn_Envoi_Click);
            // 
            // progressBar_generation
            // 
            this.progressBar_generation.Location = new System.Drawing.Point(127, 177);
            this.progressBar_generation.Name = "progressBar_generation";
            this.progressBar_generation.Size = new System.Drawing.Size(272, 33);
            this.progressBar_generation.TabIndex = 9;
            // 
            // progressBar_envoi
            // 
            this.progressBar_envoi.Location = new System.Drawing.Point(127, 216);
            this.progressBar_envoi.Name = "progressBar_envoi";
            this.progressBar_envoi.Size = new System.Drawing.Size(272, 33);
            this.progressBar_envoi.TabIndex = 10;
            // 
            // Label_retour
            // 
            this.Label_retour.AutoSize = true;
            this.Label_retour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_retour.ForeColor = System.Drawing.Color.Green;
            this.Label_retour.Location = new System.Drawing.Point(12, 157);
            this.Label_retour.Name = "Label_retour";
            this.Label_retour.Size = new System.Drawing.Size(101, 17);
            this.Label_retour.TabIndex = 0;
            this.Label_retour.Text = "Label_retour";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 261);
            this.Controls.Add(this.Label_retour);
            this.Controls.Add(this.progressBar_envoi);
            this.Controls.Add(this.progressBar_generation);
            this.Controls.Add(this.Btn_envoi);
            this.Controls.Add(this.Btn_generation);
            this.Controls.Add(this.radioButton_commandes);
            this.Controls.Add(this.radioButton_processus);
            this.Controls.Add(this.radioButton_donnees);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.Label_Text_typedonnee);
            this.Controls.Add(this.Label_Text_nbdonnee);
            this.Controls.Add(this.Label_Text_titre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Générateur de données";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Text_titre;
        private System.Windows.Forms.Label Label_Text_nbdonnee;
        private System.Windows.Forms.Label Label_Text_typedonnee;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.RadioButton radioButton_donnees;
        private System.Windows.Forms.RadioButton radioButton_processus;
        private System.Windows.Forms.RadioButton radioButton_commandes;
        private System.Windows.Forms.Button Btn_generation;
        private System.Windows.Forms.Button Btn_envoi;
        private System.Windows.Forms.ProgressBar progressBar_generation;
        private System.Windows.Forms.ProgressBar progressBar_envoi;
        private System.Windows.Forms.Label Label_retour;
    }
}

