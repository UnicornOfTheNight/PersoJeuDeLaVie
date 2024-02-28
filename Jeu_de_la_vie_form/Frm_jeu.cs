using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jeu_de_la_vie_form
{
	
	public partial class Frm_jeu : Form
	{
		int nbGeneration = 0;
		int hauteur = 50;
		int largeur = 50;
		int[,] tabIsAlive;
		List<int[,]> lstIsAliveSauv = new List<int[,]>();
		BackgroundWorker bw = new BackgroundWorker();
		
		/// <summary>
		/// Initialisation des éléments
		/// </summary>
		public Frm_jeu()
		{
			InitializeComponent();

			//Création des évènements
			bw.DoWork +=
				new DoWorkEventHandler(bw_DoWork);
			bw.RunWorkerCompleted +=
				new RunWorkerCompletedEventHandler(
			bw_RunWorkerCompleted);
			bw.ProgressChanged +=
				 new ProgressChangedEventHandler(
			bw_ProgressChanged);


			Num_Largeur.Value = 60;
			Num_Hauteur.Value = 60;
			InitialisationDgv();

			bw.WorkerSupportsCancellation = true;
			bw.WorkerReportsProgress = true;
			btn_Precedent.Enabled = false;
		}

		// This event handler updates the progress.
		private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			//lbl_Generation.Text = "Génération n° " + nbGeneration;
		}


		/// <summary>
		/// Excecution de la tache de fond
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bw_DoWork(object sender, DoWorkEventArgs e)
		{
			MethodInvoker changeLbl = delegate
			{
				lbl_Generation.Text = "Génération n° " + nbGeneration;
			};

			//Création de la tâche de fond
			BackgroundWorker worker = (BackgroundWorker)sender;
			int[,] tabTmp = new int[largeur, hauteur];

			//Initialisation du tableau tempon
			for(int i = 0; i < largeur; i++)
			{
				for(int j = 0; j < hauteur; j++)
				{
					tabTmp[i, j] = -1;
				} 
			}

			//Tant que le tableau tempon et le tableauIsAlive sont différents, pour savoir si tabIsAlive(n-1) = tabISAlive(n)
			while (CompareTab(tabTmp) == false)
			{
				//Le tableau tempon prend la meme valeur que le tableauIsAlive
				tabTmp = tabIsAlive;

				//Si l'utilisateur a appuyé sur Pause on arrête la tache de fond
				if (bw.CancellationPending == true)
				{
					e.Cancel = true;
					return;
				}
				//Sinon on continue
				else {		
					//On passe à tabIsAlive(n+1)
					NextStep();
					Invoke(changeLbl);
					//On attend 2 secondes avant de continuer
					Thread.Sleep(2000);
					
				}
			} 								
		}

		/// <summary>
		/// Fonction pour comparer les valeurs du tableau IsAlive avec un autre tableau
		/// </summary>
		/// <param name="pTabTmp"></param>
		/// <returns>Vrai si les 2 tableaux ont les mêmes valeurs, faux sinon</returns>
		private bool CompareTab(int[,] pTabTmp)
		{
			bool isSame = true;

			//On parcours la premiere dimension
			for(int i = 1; i < largeur; i++)
			{
				//On parcours la deuxième dimension
				for (int j = 1; j < hauteur; j++)
				{
					//Si les valeurs sont différentes la variable isSame prend la valeur fausse
					if (tabIsAlive[i, j] != pTabTmp[i, j])
						isSame = false;
				}
			}

			return isSame;
		}

		/// <summary>
		/// Initialisation du dgv et du tableau
		/// </summary>
		private void InitialisationDgv()
		{
			//On crée une variable hasard
			Random rnd = new Random();
			//On ajoute les colonnes au dgv
			for (int i = 0; i < largeur; i++)
			{
				//On ne met rien comme valeur
				DgvJeu.Columns.Add(i.ToString(), " ");
				//On met la taille de la colonne à 10
				DgvJeu.Columns[i].Width = 10;
			}

			//On ajoute les lignes au dgv
			for (int i = 0; i < hauteur; i++)
			{
				DgvJeu.Rows.Add();
				//On met la taille de la ligne a 10
				DgvJeu.Rows[i].Height = 10;
			}

			//On redimensionne le dgv 
			DgvJeu.Height = (hauteur + 1) * 10;
			DgvJeu.Width = (largeur + 1) * 10;

			//On initialise le tableau IsAlive
			tabIsAlive = new int[largeur, hauteur];

			//On met toutes les valeurs du tableau a -1 par defaut
			for (int i = 0; i < largeur; i++)
			{
				for (int j = 0; j < hauteur; j++)
				{
					tabIsAlive[i, j] = -1;
				}
			}
		}
		
		/// <summary>
		/// Genere un tableau avec des valeurs positives et négatives
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_Random_Click(object sender, EventArgs e)
		{
			nbGeneration = 0;
			lbl_Generation.Text = "Génération n° " + nbGeneration;

			//On crée une variable hasard
			Random rnd = new Random();
			//On choisi le nombre de cellules qui seront vivantes (minimum 10 et maximum le nombre de cellules moins 5
			int nbAlive = rnd.Next(10, (hauteur * largeur) - 5);
			//Represente le numero de la ligne
			int cellY = 0;
			//Represente le numero de la colonne
			int cellX = 0;

			//On réinitialise le tableau isAlive
			for (int i = 0; i < largeur; i++)
			{
				for(int j = 0; j < hauteur; j++)
				{
					tabIsAlive[i, j] = -1;
				}
			}

			//On repete la boucle autant de fois que le nombre au hasard choisis pour le nombre de cellules vivantes à mettre
			for (int i = 0; i < nbAlive; i++)
			{
				//On attribue des valeurs au hasard au variable representant le numero de la colonne et de la ligne
				cellX = rnd.Next(0,largeur);
				cellY = rnd.Next(0,hauteur);

				//On met la cellule vivante
				tabIsAlive[cellX,cellY] = 1;
			}

			//On parcours le dgv pour mettre les couleurs selon la valeur de la cellule
			for (int i = 0; i < largeur; i++)
			{
				for (int j = 0; j < hauteur; j++)
				{
					//Si la cellule est vivante on la met noire
					if (tabIsAlive[i,j] > 0)
						DgvJeu.Rows[j].Cells[i].Style.BackColor = Color.Black;
					//Si la cellule est morte on la met blanche
					else
						DgvJeu.Rows[j].Cells[i].Style.BackColor = Color.White;
				}
			}
		}

		/// <summary>
		/// Methode quand la tache de fond a fini de s'executé
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bw_RunWorkerCompleted(Object sender, RunWorkerCompletedEventArgs e)
		{
			btn_Pause.Enabled = false;
			btn_Play.Enabled = true;
		}
			
		/// <summary>
		/// Methode qui permet de passer de tabIsAlive(n) à tabIsAlive(n+1)
		/// </summary>
		public void NextStep()
		{			
			int nbCelluleVivante = 0;
			int[,] tabTmp = new int[largeur, hauteur];

			//On initialise le tableau tempon a -1
			for (int i = 0; i < largeur; i++)
			{
				for (int j = 0; j < hauteur; j++)
				{
					tabTmp[i, j] = -1;
				}
			}

			//On parcours le tableau IsAlive
			for (int x = 0; x < largeur; x++)
			{
				for (int y = 0; y < hauteur; y++)
				{
					//On initialise le nombre de cellules vivantes autour de la cellule actuelle à 0
					nbCelluleVivante = 0;

					// Si on ne se trouve pas sur les bords
					if (x > 0 && y > 0 && x < largeur - 1 && y < hauteur - 1)
					{
						//A chaque fois qu'une cellule voisine est vivante on incrémente la variable nbCelluleVivante
						if (tabIsAlive[x - 1, y + 1] > 0)
							nbCelluleVivante++;

						if (tabIsAlive[x, y + 1] > 0)
							nbCelluleVivante++;

						if (tabIsAlive[x + 1, y + 1] > 0)
							nbCelluleVivante++;

						if (tabIsAlive[x - 1, y] > 0)
							nbCelluleVivante++;

						if (tabIsAlive[x + 1, y] > 0)
							nbCelluleVivante++;

						if (tabIsAlive[x - 1, y - 1] > 0)
							nbCelluleVivante++;

						if (tabIsAlive[x, y - 1] > 0)
							nbCelluleVivante++;

						if (tabIsAlive[x + 1, y - 1] > 0)
							nbCelluleVivante++;

						//On modifie dans un tableau tempon 
						//Si le nb de cellules voisines vivantes est < 2 alors la cellule meurt
						if (nbCelluleVivante < 2)
							tabTmp[x, y] = -1;
						//Si le nb de cellules voisines vivantes est > 3 alors la cellule meurt
						else if (nbCelluleVivante > 3)
							tabTmp[x, y] = -1;
						//Si le nb de cellules voisines vivantes est = 3 alors la cellule nait
						else if (nbCelluleVivante == 3)
							tabTmp[x, y] = 1;
						//Si le nb de cellules voisines vivantes est = 2 alors la cellule reste la meme
						else if (nbCelluleVivante == 2)
							tabTmp[x, y] = tabIsAlive[x, y];
					}
				}
			}

			lstIsAliveSauv.Add(tabIsAlive);
			//On remplace l'ancien tableau isAlive par le tableau Tempon, passage de tabIsAlive(n) à tabIsAlive(n+1)
			tabIsAlive = tabTmp;

			//On actualise les couleurs du dgv
			for (int i = 0; i < largeur; i++)
			{
				for (int j = 0; j < hauteur; j++)
				{
					if (tabIsAlive[i, j] > 0)
						DgvJeu.Rows[j].Cells[i].Style.BackColor = Color.Black;
					else
						DgvJeu.Rows[j].Cells[i].Style.BackColor = Color.White;
				}
			}

			nbGeneration++;
		}

		/// <summary>
		/// Definie le nb de cellules
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Btn_Taille_Click(object sender, EventArgs e)
		{
			//On remet le dgv à 0
			DgvJeu.Rows.Clear();
			DgvJeu.Columns.Clear();

			//Si la valeur pour la hauteur entrée par l'utilisateur est entre 15 et 60 on accepte la valeur
			if (Convert.ToInt16(Num_Hauteur.Value) >= 15 && Convert.ToInt16(Num_Hauteur.Value) <= 60)
			{
				hauteur = Convert.ToInt16(Num_Hauteur.Value);
				lbl_Erreur_Hauteur.ForeColor = Color.Black;
			}			
			else
				lbl_Erreur_Hauteur.ForeColor = Color.Red;

			//Si la valeur pour la largeur entrée par l'utilisateur est entre 15 et 60 on accepte la valeur
			if (Convert.ToInt16(Num_Largeur.Value) >= 15 && Convert.ToInt16(Num_Largeur.Value) <= 80)
			{
				largeur = Convert.ToInt16(Num_Largeur.Value);
				lbl_Erreur_Largeur.ForeColor = Color.Black;
			}
			else
				lbl_Erreur_Largeur.ForeColor = Color.Red;
				
			//On initialise le dgv
			InitialisationDgv();
		}

		/// <summary>
		/// Methode quand on clique sur le bouton play
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_Play_Click(object sender, EventArgs e)
		{
			//On ne permet plus a l'utilisateur de modifier le dgv
			DgvJeu.ClearSelection();
			DgvJeu.Enabled = false;			
			btn_Play.Enabled = false;

			//L'utilisateur peut appuyer sur Pause
			btn_Pause.Enabled = true;

			//On lance la tache de fond
			bw.RunWorkerAsync(sender);
			
		}
		/// <summary>
		/// Methode quand on clique sur le bouton pause 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_Pause_Click(object sender, EventArgs e)
		{			
			if (bw.WorkerSupportsCancellation == true)
			{
				DgvJeu.Enabled = true;
				// Annule l'opération asynchrone
				bw.CancelAsync();

				//L'utilisateur peut appuyer sur Play
				btn_Play.Enabled = true;
				btn_Pause.Enabled = false;
				btn_Precedent.Enabled = true;

				
			}
		}

		/// <summary>
		/// Methode quand l'utilisateur appuie sur le bouton Suivant
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_Suivant_Click(object sender, EventArgs e)
		{
			//On appelle la méthode qui amène le tabIsAlive(n) au tabIsAlive(n+1)
			NextStep();
			btn_Precedent.Enabled = true;

			lbl_Generation.Text = "Génération n° " + nbGeneration;
		}

		/// <summary>
		/// Permet de revenir à la génération précédente
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_Precedent_Click(object sender, EventArgs e)
		{
			int[,] tabTmp;
			tabTmp = lstIsAliveSauv.ElementAt(lstIsAliveSauv.Count - 1);
			//On actualise les couleurs du dgv
			for (int i = 0; i < largeur; i++)
			{
				for (int j = 0; j < hauteur; j++)
				{
					if (tabTmp[i,j] > 0)
						DgvJeu.Rows[j].Cells[i].Style.BackColor = Color.Black;
					else
						DgvJeu.Rows[j].Cells[i].Style.BackColor = Color.White;
				}
			}

			lstIsAliveSauv.RemoveAt(lstIsAliveSauv.Count - 1);

			if (lstIsAliveSauv.Count == 0)
				btn_Precedent.Enabled = false;

			tabIsAlive = tabTmp;
			nbGeneration--;
			lbl_Generation.Text = "Génération n° " + nbGeneration;
		}
		
	}
}
