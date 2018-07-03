namespace GenerateurDeDonnees
{
    partial class Mainform
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
            this.Btn_generation = new System.Windows.Forms.Button();
            this.Btn_envoi = new System.Windows.Forms.Button();
            this.Label_Text_Titre = new System.Windows.Forms.Label();
            this.Label_Text_Nombrededonnees = new System.Windows.Forms.Label();
            this.progressBar_Generation = new System.Windows.Forms.ProgressBar();
            this.Label_retour = new System.Windows.Forms.Label();
            this.numericUpDown_Nombrededonnees = new System.Windows.Forms.NumericUpDown();
            this.radioButton_Donnees = new System.Windows.Forms.RadioButton();
            this.radioButton_Processus = new System.Windows.Forms.RadioButton();
            this.radioButton_Commandes = new System.Windows.Forms.RadioButton();
            this.Label_Text_Typededonnees = new System.Windows.Forms.Label();
            this.progressBar_Envoi = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Nombrededonnees)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_generation
            // 
            this.Btn_generation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_generation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_generation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_generation.Location = new System.Drawing.Point(15, 157);
            this.Btn_generation.Name = "Btn_generation";
            this.Btn_generation.Size = new System.Drawing.Size(94, 31);
            this.Btn_generation.TabIndex = 0;
            this.Btn_generation.Text = "Génération";
            this.Btn_generation.UseVisualStyleBackColor = false;
            this.Btn_generation.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_envoi
            // 
            this.Btn_envoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_envoi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_envoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_envoi.Location = new System.Drawing.Point(15, 194);
            this.Btn_envoi.Name = "Btn_envoi";
            this.Btn_envoi.Size = new System.Drawing.Size(94, 32);
            this.Btn_envoi.TabIndex = 1;
            this.Btn_envoi.Text = "Envoi";
            this.Btn_envoi.UseVisualStyleBackColor = true;
            this.Btn_envoi.Click += new System.EventHandler(this.Btn_envoi_Click);
            // 
            // Label_Text_Titre
            // 
            this.Label_Text_Titre.AutoSize = true;
            this.Label_Text_Titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Text_Titre.Location = new System.Drawing.Point(9, 9);
            this.Label_Text_Titre.Name = "Label_Text_Titre";
            this.Label_Text_Titre.Size = new System.Drawing.Size(370, 17);
            this.Label_Text_Titre.TabIndex = 900;
            this.Label_Text_Titre.Text = "Logiciel générateur de données pour base Oracle";
            // 
            // Label_Text_Nombrededonnees
            // 
            this.Label_Text_Nombrededonnees.AutoSize = true;
            this.Label_Text_Nombrededonnees.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Text_Nombrededonnees.Location = new System.Drawing.Point(12, 41);
            this.Label_Text_Nombrededonnees.Name = "Label_Text_Nombrededonnees";
            this.Label_Text_Nombrededonnees.Size = new System.Drawing.Size(128, 13);
            this.Label_Text_Nombrededonnees.TabIndex = 900;
            this.Label_Text_Nombrededonnees.Text = "Nombre de données :";
            // 
            // progressBar_Generation
            // 
            this.progressBar_Generation.Cursor = System.Windows.Forms.Cursors.Default;
            this.progressBar_Generation.Location = new System.Drawing.Point(115, 156);
            this.progressBar_Generation.Name = "progressBar_Generation";
            this.progressBar_Generation.Size = new System.Drawing.Size(264, 32);
            this.progressBar_Generation.TabIndex = 900;
            // 
            // Label_retour
            // 
            this.Label_retour.AutoSize = true;
            this.Label_retour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_retour.ForeColor = System.Drawing.Color.Green;
            this.Label_retour.Location = new System.Drawing.Point(17, 127);
            this.Label_retour.Name = "Label_retour";
            this.Label_retour.Size = new System.Drawing.Size(78, 13);
            this.Label_retour.TabIndex = 900;
            this.Label_retour.Text = "Label_retour";
            // 
            // numericUpDown_Nombrededonnees
            // 
            this.numericUpDown_Nombrededonnees.Cursor = System.Windows.Forms.Cursors.Default;
            this.numericUpDown_Nombrededonnees.Location = new System.Drawing.Point(15, 64);
            this.numericUpDown_Nombrededonnees.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numericUpDown_Nombrededonnees.Name = "numericUpDown_Nombrededonnees";
            this.numericUpDown_Nombrededonnees.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown_Nombrededonnees.TabIndex = 3;
            this.numericUpDown_Nombrededonnees.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // radioButton_Donnees
            // 
            this.radioButton_Donnees.AutoSize = true;
            this.radioButton_Donnees.Checked = true;
            this.radioButton_Donnees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton_Donnees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton_Donnees.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Donnees.Location = new System.Drawing.Point(247, 67);
            this.radioButton_Donnees.Name = "radioButton_Donnees";
            this.radioButton_Donnees.Size = new System.Drawing.Size(74, 17);
            this.radioButton_Donnees.TabIndex = 4;
            this.radioButton_Donnees.TabStop = true;
            this.radioButton_Donnees.Text = "Données";
            this.radioButton_Donnees.UseVisualStyleBackColor = true;
            // 
            // radioButton_Processus
            // 
            this.radioButton_Processus.AutoSize = true;
            this.radioButton_Processus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton_Processus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton_Processus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Processus.Location = new System.Drawing.Point(247, 96);
            this.radioButton_Processus.Name = "radioButton_Processus";
            this.radioButton_Processus.Size = new System.Drawing.Size(82, 17);
            this.radioButton_Processus.TabIndex = 5;
            this.radioButton_Processus.TabStop = true;
            this.radioButton_Processus.Text = "Processus";
            this.radioButton_Processus.UseVisualStyleBackColor = true;
            // 
            // radioButton_Commandes
            // 
            this.radioButton_Commandes.AutoSize = true;
            this.radioButton_Commandes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton_Commandes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton_Commandes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Commandes.Location = new System.Drawing.Point(247, 125);
            this.radioButton_Commandes.Name = "radioButton_Commandes";
            this.radioButton_Commandes.Size = new System.Drawing.Size(91, 17);
            this.radioButton_Commandes.TabIndex = 6;
            this.radioButton_Commandes.TabStop = true;
            this.radioButton_Commandes.Text = "Commandes";
            this.radioButton_Commandes.UseVisualStyleBackColor = true;
            // 
            // Label_Text_Typededonnees
            // 
            this.Label_Text_Typededonnees.AutoSize = true;
            this.Label_Text_Typededonnees.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Text_Typededonnees.Location = new System.Drawing.Point(244, 41);
            this.Label_Text_Typededonnees.Name = "Label_Text_Typededonnees";
            this.Label_Text_Typededonnees.Size = new System.Drawing.Size(113, 13);
            this.Label_Text_Typededonnees.TabIndex = 900;
            this.Label_Text_Typededonnees.Text = "Type de données :";
            // 
            // progressBar_Envoi
            // 
            this.progressBar_Envoi.Cursor = System.Windows.Forms.Cursors.Default;
            this.progressBar_Envoi.Location = new System.Drawing.Point(115, 194);
            this.progressBar_Envoi.Name = "progressBar_Envoi";
            this.progressBar_Envoi.Size = new System.Drawing.Size(264, 32);
            this.progressBar_Envoi.TabIndex = 900;
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 231);
            this.Controls.Add(this.progressBar_Envoi);
            this.Controls.Add(this.Label_Text_Typededonnees);
            this.Controls.Add(this.radioButton_Commandes);
            this.Controls.Add(this.radioButton_Processus);
            this.Controls.Add(this.radioButton_Donnees);
            this.Controls.Add(this.numericUpDown_Nombrededonnees);
            this.Controls.Add(this.Label_retour);
            this.Controls.Add(this.progressBar_Generation);
            this.Controls.Add(this.Label_Text_Nombrededonnees);
            this.Controls.Add(this.Label_Text_Titre);
            this.Controls.Add(this.Btn_envoi);
            this.Controls.Add(this.Btn_generation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Mainform";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Générateur de données";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Mainform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Nombrededonnees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_generation;
        private System.Windows.Forms.Button Btn_envoi;
        private System.Windows.Forms.Label Label_Text_Titre;
        private System.Windows.Forms.Label Label_Text_Nombrededonnees;
        private System.Windows.Forms.ProgressBar progressBar_Generation;
        private System.Windows.Forms.Label Label_retour;
        private System.Windows.Forms.NumericUpDown numericUpDown_Nombrededonnees;
        private System.Windows.Forms.RadioButton radioButton_Donnees;
        private System.Windows.Forms.RadioButton radioButton_Processus;
        private System.Windows.Forms.RadioButton radioButton_Commandes;
        private System.Windows.Forms.Label Label_Text_Typededonnees;
        private System.Windows.Forms.ProgressBar progressBar_Envoi;
    }
}

