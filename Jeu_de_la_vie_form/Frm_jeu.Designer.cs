namespace Jeu_de_la_vie_form
{
	partial class Frm_jeu
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
			this.DgvJeu = new System.Windows.Forms.DataGridView();
			this.btn_Random = new System.Windows.Forms.Button();
			this.btn_Suivant = new System.Windows.Forms.Button();
			this.Num_Hauteur = new System.Windows.Forms.NumericUpDown();
			this.Num_Largeur = new System.Windows.Forms.NumericUpDown();
			this.Lbl_Hauteur = new System.Windows.Forms.Label();
			this.Lbl_Largeur = new System.Windows.Forms.Label();
			this.Btn_Taille = new System.Windows.Forms.Button();
			this.lbl_Erreur_Hauteur = new System.Windows.Forms.Label();
			this.lbl_Erreur_Largeur = new System.Windows.Forms.Label();
			this.btn_Play = new System.Windows.Forms.Button();
			this.btn_Pause = new System.Windows.Forms.Button();
			this.btn_Precedent = new System.Windows.Forms.Button();
			this.lbl_Generation = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.DgvJeu)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Num_Hauteur)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Num_Largeur)).BeginInit();
			this.SuspendLayout();
			// 
			// DgvJeu
			// 
			this.DgvJeu.AllowUserToAddRows = false;
			this.DgvJeu.AllowUserToDeleteRows = false;
			this.DgvJeu.AllowUserToOrderColumns = true;
			this.DgvJeu.AllowUserToResizeColumns = false;
			this.DgvJeu.AllowUserToResizeRows = false;
			this.DgvJeu.BackgroundColor = System.Drawing.Color.White;
			this.DgvJeu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DgvJeu.ColumnHeadersVisible = false;
			this.DgvJeu.Enabled = false;
			this.DgvJeu.GridColor = System.Drawing.Color.Black;
			this.DgvJeu.Location = new System.Drawing.Point(47, 145);
			this.DgvJeu.Name = "DgvJeu";
			this.DgvJeu.ReadOnly = true;
			this.DgvJeu.RowHeadersVisible = false;
			this.DgvJeu.RowHeadersWidth = 51;
			this.DgvJeu.RowTemplate.Height = 24;
			this.DgvJeu.Size = new System.Drawing.Size(796, 590);
			this.DgvJeu.TabIndex = 5;
			// 
			// btn_Random
			// 
			this.btn_Random.BackColor = System.Drawing.Color.LightBlue;
			this.btn_Random.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Random.Location = new System.Drawing.Point(882, 58);
			this.btn_Random.Name = "btn_Random";
			this.btn_Random.Size = new System.Drawing.Size(115, 36);
			this.btn_Random.TabIndex = 6;
			this.btn_Random.Text = "Générer";
			this.btn_Random.UseVisualStyleBackColor = false;
			this.btn_Random.Click += new System.EventHandler(this.btn_Random_Click);
			// 
			// btn_Suivant
			// 
			this.btn_Suivant.BackColor = System.Drawing.Color.LightBlue;
			this.btn_Suivant.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Suivant.Location = new System.Drawing.Point(882, 179);
			this.btn_Suivant.Name = "btn_Suivant";
			this.btn_Suivant.Size = new System.Drawing.Size(115, 36);
			this.btn_Suivant.TabIndex = 7;
			this.btn_Suivant.Text = "Suivant";
			this.btn_Suivant.UseVisualStyleBackColor = false;
			this.btn_Suivant.Click += new System.EventHandler(this.btn_Suivant_Click);
			// 
			// Num_Hauteur
			// 
			this.Num_Hauteur.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Num_Hauteur.Location = new System.Drawing.Point(16, 36);
			this.Num_Hauteur.Name = "Num_Hauteur";
			this.Num_Hauteur.Size = new System.Drawing.Size(62, 29);
			this.Num_Hauteur.TabIndex = 10;
			// 
			// Num_Largeur
			// 
			this.Num_Largeur.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Num_Largeur.Location = new System.Drawing.Point(169, 37);
			this.Num_Largeur.Name = "Num_Largeur";
			this.Num_Largeur.Size = new System.Drawing.Size(55, 27);
			this.Num_Largeur.TabIndex = 11;
			// 
			// Lbl_Hauteur
			// 
			this.Lbl_Hauteur.AutoSize = true;
			this.Lbl_Hauteur.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Lbl_Hauteur.Location = new System.Drawing.Point(12, 9);
			this.Lbl_Hauteur.Name = "Lbl_Hauteur";
			this.Lbl_Hauteur.Size = new System.Drawing.Size(81, 23);
			this.Lbl_Hauteur.TabIndex = 12;
			this.Lbl_Hauteur.Text = "Hauteur";
			// 
			// Lbl_Largeur
			// 
			this.Lbl_Largeur.AutoSize = true;
			this.Lbl_Largeur.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Lbl_Largeur.Location = new System.Drawing.Point(165, 9);
			this.Lbl_Largeur.Name = "Lbl_Largeur";
			this.Lbl_Largeur.Size = new System.Drawing.Size(78, 23);
			this.Lbl_Largeur.TabIndex = 13;
			this.Lbl_Largeur.Text = "Largeur";
			// 
			// Btn_Taille
			// 
			this.Btn_Taille.BackColor = System.Drawing.Color.LightBlue;
			this.Btn_Taille.FlatAppearance.BorderSize = 0;
			this.Btn_Taille.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Btn_Taille.Location = new System.Drawing.Point(88, 82);
			this.Btn_Taille.Name = "Btn_Taille";
			this.Btn_Taille.Size = new System.Drawing.Size(75, 36);
			this.Btn_Taille.TabIndex = 14;
			this.Btn_Taille.Text = "OK";
			this.Btn_Taille.UseVisualStyleBackColor = false;
			this.Btn_Taille.Click += new System.EventHandler(this.Btn_Taille_Click);
			// 
			// lbl_Erreur_Hauteur
			// 
			this.lbl_Erreur_Hauteur.AutoSize = true;
			this.lbl_Erreur_Hauteur.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Erreur_Hauteur.Location = new System.Drawing.Point(285, 9);
			this.lbl_Erreur_Hauteur.Name = "lbl_Erreur_Hauteur";
			this.lbl_Erreur_Hauteur.Size = new System.Drawing.Size(308, 23);
			this.lbl_Erreur_Hauteur.TabIndex = 15;
			this.lbl_Erreur_Hauteur.Text = "La hauteur doit être entre 15 et 60.";
			// 
			// lbl_Erreur_Largeur
			// 
			this.lbl_Erreur_Largeur.AutoSize = true;
			this.lbl_Erreur_Largeur.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Erreur_Largeur.Location = new System.Drawing.Point(285, 42);
			this.lbl_Erreur_Largeur.Name = "lbl_Erreur_Largeur";
			this.lbl_Erreur_Largeur.Size = new System.Drawing.Size(302, 23);
			this.lbl_Erreur_Largeur.TabIndex = 16;
			this.lbl_Erreur_Largeur.Text = "La largeur doit être entre 15 et 80.";
			// 
			// btn_Play
			// 
			this.btn_Play.BackColor = System.Drawing.Color.LightBlue;
			this.btn_Play.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Play.Location = new System.Drawing.Point(882, 100);
			this.btn_Play.Name = "btn_Play";
			this.btn_Play.Size = new System.Drawing.Size(115, 35);
			this.btn_Play.TabIndex = 17;
			this.btn_Play.Text = "Play";
			this.btn_Play.UseVisualStyleBackColor = false;
			this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
			// 
			// btn_Pause
			// 
			this.btn_Pause.BackColor = System.Drawing.Color.LightBlue;
			this.btn_Pause.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Pause.Location = new System.Drawing.Point(882, 141);
			this.btn_Pause.Name = "btn_Pause";
			this.btn_Pause.Size = new System.Drawing.Size(115, 32);
			this.btn_Pause.TabIndex = 18;
			this.btn_Pause.Text = "Pause";
			this.btn_Pause.UseVisualStyleBackColor = false;
			this.btn_Pause.Click += new System.EventHandler(this.btn_Pause_Click);
			// 
			// btn_Precedent
			// 
			this.btn_Precedent.BackColor = System.Drawing.Color.LightBlue;
			this.btn_Precedent.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Precedent.Location = new System.Drawing.Point(882, 221);
			this.btn_Precedent.Name = "btn_Precedent";
			this.btn_Precedent.Size = new System.Drawing.Size(115, 35);
			this.btn_Precedent.TabIndex = 19;
			this.btn_Precedent.Text = "Précedent";
			this.btn_Precedent.UseVisualStyleBackColor = false;
			this.btn_Precedent.Click += new System.EventHandler(this.btn_Precedent_Click);
			// 
			// lbl_Generation
			// 
			this.lbl_Generation.AutoSize = true;
			this.lbl_Generation.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Generation.Location = new System.Drawing.Point(864, 335);
			this.lbl_Generation.Name = "lbl_Generation";
			this.lbl_Generation.Size = new System.Drawing.Size(144, 23);
			this.lbl_Generation.TabIndex = 20;
			this.lbl_Generation.Text = "Génération n° 0";
			// 
			// Frm_jeu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			this.ClientSize = new System.Drawing.Size(1064, 790);
			this.Controls.Add(this.lbl_Generation);
			this.Controls.Add(this.btn_Precedent);
			this.Controls.Add(this.btn_Pause);
			this.Controls.Add(this.btn_Play);
			this.Controls.Add(this.lbl_Erreur_Largeur);
			this.Controls.Add(this.lbl_Erreur_Hauteur);
			this.Controls.Add(this.Btn_Taille);
			this.Controls.Add(this.Lbl_Largeur);
			this.Controls.Add(this.Lbl_Hauteur);
			this.Controls.Add(this.Num_Largeur);
			this.Controls.Add(this.Num_Hauteur);
			this.Controls.Add(this.btn_Suivant);
			this.Controls.Add(this.btn_Random);
			this.Controls.Add(this.DgvJeu);
			this.MaximizeBox = false;
			this.Name = "Frm_jeu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Jeu de la vie";
			((System.ComponentModel.ISupportInitialize)(this.DgvJeu)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Num_Hauteur)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Num_Largeur)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView DgvJeu;
		private System.Windows.Forms.Button btn_Random;
		private System.Windows.Forms.Button btn_Suivant;
		private System.Windows.Forms.NumericUpDown Num_Hauteur;
		private System.Windows.Forms.NumericUpDown Num_Largeur;
		private System.Windows.Forms.Label Lbl_Hauteur;
		private System.Windows.Forms.Label Lbl_Largeur;
		private System.Windows.Forms.Button Btn_Taille;
		private System.Windows.Forms.Label lbl_Erreur_Hauteur;
		private System.Windows.Forms.Label lbl_Erreur_Largeur;
		private System.Windows.Forms.Button btn_Play;
		private System.Windows.Forms.Button btn_Pause;
		private System.Windows.Forms.Button btn_Precedent;
		private System.Windows.Forms.Label lbl_Generation;
	}
}

