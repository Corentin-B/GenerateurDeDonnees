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
            this.Btn_generation = new System.Windows.Forms.Button();
            this.Btn_envoi = new System.Windows.Forms.Button();
            this.progressBar_generation = new System.Windows.Forms.ProgressBar();
            this.progressBar_envoi = new System.Windows.Forms.ProgressBar();
            this.Label_retour = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.Label_Text_typedonnee.Location = new System.Drawing.Point(241, 44);
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
            // Btn_generation
            // 
            this.Btn_generation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_generation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_generation.Location = new System.Drawing.Point(15, 155);
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
            this.Btn_envoi.Location = new System.Drawing.Point(15, 194);
            this.Btn_envoi.Name = "Btn_envoi";
            this.Btn_envoi.Size = new System.Drawing.Size(106, 33);
            this.Btn_envoi.TabIndex = 2;
            this.Btn_envoi.Text = "Envoi";
            this.Btn_envoi.UseVisualStyleBackColor = true;
            this.Btn_envoi.Click += new System.EventHandler(this.Btn_Envoi_Click);
            // 
            // progressBar_generation
            // 
            this.progressBar_generation.Location = new System.Drawing.Point(127, 155);
            this.progressBar_generation.Name = "progressBar_generation";
            this.progressBar_generation.Size = new System.Drawing.Size(272, 33);
            this.progressBar_generation.TabIndex = 9;
            // 
            // progressBar_envoi
            // 
            this.progressBar_envoi.Location = new System.Drawing.Point(127, 194);
            this.progressBar_envoi.Name = "progressBar_envoi";
            this.progressBar_envoi.Size = new System.Drawing.Size(272, 33);
            this.progressBar_envoi.TabIndex = 10;
            // 
            // Label_retour
            // 
            this.Label_retour.AutoSize = true;
            this.Label_retour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_retour.ForeColor = System.Drawing.Color.Green;
            this.Label_retour.Location = new System.Drawing.Point(12, 135);
            this.Label_retour.Name = "Label_retour";
            this.Label_retour.Size = new System.Drawing.Size(101, 17);
            this.Label_retour.TabIndex = 0;
            this.Label_retour.Text = "Label_retour";
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "-";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Données",
            "Processus",
            "Commandes"});
            this.comboBox1.Location = new System.Drawing.Point(244, 70);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.Tag = "";
            this.comboBox1.ValueMember = "2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(384, 20);
            this.textBox1.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 239);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Label_retour);
            this.Controls.Add(this.progressBar_envoi);
            this.Controls.Add(this.progressBar_generation);
            this.Controls.Add(this.Btn_envoi);
            this.Controls.Add(this.Btn_generation);
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
        private System.Windows.Forms.Button Btn_generation;
        private System.Windows.Forms.Button Btn_envoi;
        private System.Windows.Forms.ProgressBar progressBar_generation;
        private System.Windows.Forms.ProgressBar progressBar_envoi;
        private System.Windows.Forms.Label Label_retour;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

