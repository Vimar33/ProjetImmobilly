using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetImmoBilly
{
    public partial class IGestiondesSouhaits : Form
    {
        //Create an ObjectContext instance based on Immobilly_Groupe_SolveigEntities
        private Immobilly_Groupe_SolveigEntities contexteBaseImmobilly;
        private List<ACHETEURS> acheteurs;
        private List<SOUHAITS> listeSouhaitsAcheteur;
        private List<STATUT_SOUHAIT> listeStatutsSouhait;

        private ACHETEURS acheteurSelectionne;
        private SOUHAITS souhaitSelectionne;
        private STATUT_SOUHAIT statutSouhaitSelectionne;

        public IGestiondesSouhaits()
        {
            InitializeComponent();
            //récupération du nom du commercial logué dans la textbox
            //textBoxNomCommercial.Text = "commercial Logué ";

            //Initialiser le contexte
            contexteBaseImmobilly = new Immobilly_Groupe_SolveigEntities();

            try
            {
                acheteurs = new List<ACHETEURS>();

                // On récupère la liste des acheteurs disponibles en base
                acheteurs = contexteBaseImmobilly.ACHETEURS.ToList();

                // On affiche la liste des acheteurs dans la grille
                grilleAcheteurs.DataSource = acheteurs;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonNouveau_Click(object sender, EventArgs e)
        {
            IGérerUnSouhait gérerSouhait = new IGérerUnSouhait(acheteurSelectionne);
            if (gérerSouhait.ShowDialog() == System.Windows.Forms.DialogResult.OK) { }
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            souhaitSelectionne = (SOUHAITS)grilleSouhaitsAcheteur.CurrentRow.DataBoundItem;

            IGérerUnSouhait gérerSouhait = new IGérerUnSouhait(souhaitSelectionne);
            if (gérerSouhait.ShowDialog() == System.Windows.Forms.DialogResult.OK) { }
        }

        private void selectionStatutSouhait_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Initialisation de la liste des souhaits d'un acheteur
            listeSouhaitsAcheteur = new List<SOUHAITS>();

            // Si un acheteur est sélectionné
            if (grilleAcheteurs.CurrentRow != null)
            {
                // On récupère l'acheteur qui a été sélectionné
                acheteurSelectionne = (ACHETEURS)grilleAcheteurs.CurrentRow.DataBoundItem;

                // On récupère le statut de souhait qui est actuellement sélectionné
                statutSouhaitSelectionne = (STATUT_SOUHAIT)selectionStatutSouhait.SelectedItem;

                // Si on veut afficher tous les souhaits (EN COURS et OBSOLETES)
                if (statutSouhaitSelectionne.LIBELLE_STATUT_SOUHAIT != "Tous")
                {
                    listeSouhaitsAcheteur = acheteurSelectionne.SOUHAITS.Where(s => s.STATUT_SOUHAIT.NUMERO_STATUT_SOUHAIT == statutSouhaitSelectionne.NUMERO_STATUT_SOUHAIT).ToList();
                }
                // Sinon, on affiche les souhaits dont le statut correspond au statut sélectionné
                else
                {
                    listeSouhaitsAcheteur = acheteurSelectionne.SOUHAITS.ToList();
                }
            }

            // Si aucun acheteur n'est sélectionné, on efface la liste de souhaits
            else
            {
                listeSouhaitsAcheteur.Clear();
            }

            // On affiche la nouvelle liste de souhaits dans la grille
            grilleSouhaitsAcheteur.DataSource = listeSouhaitsAcheteur;

        }

        private void grilleAcheteurs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void grilleAcheteurs_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {

        }

        private void grilleAcheteurs_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void grilleAcheteurs_SelectionChanged(object sender, EventArgs e)
        {
            // On efface la liste de souhaits qui est affichée
            grilleSouhaitsAcheteur.DataSource = null;

            // Si un acheteur a été sélectionné
            // ET qu'il y a des acheteurs affichés dans la grille
            if(grilleAcheteurs.CurrentRow != null && acheteurs.ToList().Count > 0)
            {
                // On récupère la liste des statuts de souhait disponibles en base
                listeStatutsSouhait = contexteBaseImmobilly.STATUT_SOUHAIT.ToList();

                // On ajoute en tête de liste le statut "Tous". 
                // But : afficher tous les souhaits quel que soit leur statut
                listeStatutsSouhait.Insert(0, new STATUT_SOUHAIT() { LIBELLE_STATUT_SOUHAIT = "Tous" });

                // On affiche la liste des statuts de souhaits dans la liste déroulante
                selectionStatutSouhait.DataSource = listeStatutsSouhait;

                // On récupère l'acheteur sélectionné dans la grille
                ACHETEURS acheteurSelectionne = (ACHETEURS)grilleAcheteurs.CurrentRow.DataBoundItem;

                // On récupère la liste des souhaits de l'acheteur sélectionné
                listeSouhaitsAcheteur = acheteurSelectionne.SOUHAITS.ToList();

                // On active les éléments graphiques suivants : 
                //  - Grille des souhaits de l'acheteur
                //  - Liste déroulante des statuts de souhait
                //  - Le bouton de création d'un nouveau souhait
                //  - Le bouton de modification d'un nouveau souhait
                grilleSouhaitsAcheteur.Enabled = true;
                selectionStatutSouhait.Enabled = true;
                buttonNouveauSouhait.Enabled = true;
                buttonModifierSouhait.Enabled = true;
            }

            else
            {
                // On désactive les éléments graphiques suivants : 
                //  - Grille des souhaits de l'acheteur
                //  - Liste déroulante des statuts de souhait
                //  - Le bouton de création d'un nouveau souhait
                //  - Le bouton de modification d'un nouveau souhait
                grilleSouhaitsAcheteur.Enabled = false;
                selectionStatutSouhait.Enabled = false;
                buttonNouveauSouhait.Enabled = false;
                buttonModifierSouhait.Enabled = false;

                // On efface la liste de souhaits de l'acheteur
                listeSouhaitsAcheteur.Clear();
            }

            // On affiche la liste des souhaits de l'acheteur
            grilleSouhaitsAcheteur.DataSource = listeSouhaitsAcheteur;
        }

        private void textBoxNomAcheteur_TextChanged(object sender, EventArgs e)
        {
            // On affiche uniquement les acheteurs dont le nom commence par le texte saisi dans la zone de recherche
            acheteurs = new List<ACHETEURS>();

            acheteurs = contexteBaseImmobilly.ACHETEURS.Where(c => c.NOM_ACHETEUR.StartsWith(textBoxNomAcheteur.Text)).ToList();

            grilleAcheteurs.DataSource = acheteurs;
        }

        private void grilleSouhaitsAcheteur_SelectionChanged(object sender, EventArgs e)
        {
            // Si un souhait a été sélectionné
            if(grilleSouhaitsAcheteur.CurrentRow != null && listeSouhaitsAcheteur.ToList().Count > 0)
            {
                // On active le bouton de modification de souhait
                buttonModifierSouhait.Enabled = true;
            }

            else
            {
                // On désactive le bouton de modification de souhait
                buttonModifierSouhait.Enabled = false;
            }
        }

        private void grilleAcheteurs_DoubleClick(object sender, EventArgs e)
        {

        }

        private void buttonCreerAcheteur_Click(object sender, EventArgs e)
        {
            IGérerUnSouhait gérerSouhait = new IGérerUnSouhait();
            if (gérerSouhait.ShowDialog() == System.Windows.Forms.DialogResult.OK) { }
        }
    }
}
