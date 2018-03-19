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
    public partial class IGérerUnSouhait : Form
    {
        //liste de textbox obligatoires lors de la création d'un acheteur et de son souhait
        List<TextBox> liste_box_info_acheteur = new List<TextBox>();
        List<TextBox> liste_box_info_souhait = new List<TextBox>();

        private Immobilly_Groupe_SolveigEntities contexteBaseImmobilly;

        private SOUHAITS souhait;
        private ACHETEURS acheteur;
        private STATUT_SOUHAIT statutSouhaitSelectionne;

        private List<BIENS> biensTrouves;
        private List<VILLES> villes;
        private List<STATUT_SOUHAIT> listeStatutsSouhait;

        public IGérerUnSouhait()
        {
            InitializeComponent();
            //récupération du nom du commercial logué dans la textbox
            //textBoxNomCommercial.Text = "commercial Logué ";

            contexteBaseImmobilly = new Immobilly_Groupe_SolveigEntities();

            liste_box_info_acheteur.Add(textBoxNomAcheteur);
            liste_box_info_acheteur.Add(textBoxPrénomAcheteur);
            liste_box_info_acheteur.Add(textBoxAdresseAcheteur);
            liste_box_info_acheteur.Add(textBoxCodePostalAcheteur);
            liste_box_info_acheteur.Add(telMobileAcheteur);

            // On récupère la liste des statuts de souhait disponibles en base
            listeStatutsSouhait = new List<STATUT_SOUHAIT>();
            listeStatutsSouhait = contexteBaseImmobilly.STATUT_SOUHAIT.ToList();

            // On affiche la liste des statuts de souhaits dans la liste déroulante
            selectionStatutSouhait.DataSource = listeStatutsSouhait;
        }

        // Second constructeur : ouverture de la fenêtre pour modification d'un souhait
        public IGérerUnSouhait(SOUHAITS s) : this()
        {
            // On récupère le souhait qui a été sélectionné
            this.souhait = s;

            // On affiche les informations du souhait
            // On affiche les informations de l'acheteur rattaché à ce souhait
            textBoxVilleSouhait.Text = s.VILLES.NOM_VILLE;
            textBoxAdresseAcheteur.Text = s.ACHETEURS.ADRESSE_ACHETEUR;
            textBoxCodePostalAcheteur.Text = s.ACHETEURS.VILLES.CODE_POSTAL_VILLE.ToString();
            textBoxCodePostalSouhait.Text = s.VILLES.CODE_POSTAL_VILLE;
            textBoxCommercialAssigné.Text = s.ACHETEURS.COMMERCIAUX.ToString();
            textBoxMailAcheteur.Text = s.ACHETEURS.EMAIL_ACHETEUR;
            textBoxNomAcheteur.Text = s.ACHETEURS.NOM_ACHETEUR;
            textBoxPrénomAcheteur.Text = s.ACHETEURS.PRENOM_ACHETEUR;
            textBoxNomCommercial.Text = s.ACHETEURS.COMMERCIAUX.NOM_COMMERCIAL;
            textBoxNbChambreSouhait.Text = s.NBCHAMBREMINI.ToString();
            textBoxNbPièceSouhait.Text = s.NOMBRE_PIECE_MINIMALE.ToString();
            textBoxTelFixeAcheteur.Text = s.ACHETEURS.TELEPHONE_PRINCIPAL_ACHETEUR;
            telMobileAcheteur.Text = s.ACHETEURS.TELEPHONE_SECONDAIRE_ACHETEUR;
            textBoxPrixAchatMax.Text = s.PRIX_MAXIMAL.ToString();
            textBoxSurfTerrainSouhait.Text = s.SURFACE_PARCELLE_MINIMALE.ToString();
            textBoxSurfHabitableSouhait.Text = s.SURFACE_HABITABLE_MINIMALE.ToString();

        }

        // Troisième constructeur : ouverture de la fenêtre pour création d'un souhait
        public IGérerUnSouhait(ACHETEURS a) : this()
        {
            // On récupère l'acheteur qui a été sélectionné
            this.acheteur = a;

            // On affiche les informations de cet acheteur
            textBoxAdresseAcheteur.Text = a.ADRESSE_ACHETEUR;
            textBoxCodePostalAcheteur.Text = a.VILLES.CODE_POSTAL_VILLE;
            textBoxCommercialAssigné.Text = a.COMMERCIAUX.ToString();
            textBoxMailAcheteur.Text = a.EMAIL_ACHETEUR;
            textBoxNomAcheteur.Text = a.NOM_ACHETEUR;
            textBoxPrénomAcheteur.Text = a.PRENOM_ACHETEUR;
            textBoxNomCommercial.Text = a.COMMERCIAUX.ToString();
            textBoxTelFixeAcheteur.Text = a.TELEPHONE_PRINCIPAL_ACHETEUR;
            telMobileAcheteur.Text = a.TELEPHONE_SECONDAIRE_ACHETEUR;

        }

        // Fonction de recherche de biens
        private void rechercherBiens()
        {
            // On récupère les informations saisies : 
            //  - Surface parcelle minimale
            //  - Surface habitable minimale
            //  - Nombre de chambres minimal
            //  - Nombre de pièces minimal
            //  - Nombre de salles de bain minimal 
            int surfaceParcelleSouhaitee, surfaceHabitableSouhaitee, nbChambresSouhaite, nbPiecesSouhaite, nbSallesDeBainSouhaite;
            bool caveSouhaitee, garageSouhaite;

            caveSouhaitee = checkBoxCaveSouhait.Checked;
            garageSouhaite = checkBoxGarageSouhait.Checked;

            // La fonction "TryParse" permet de récupérer les valeurs saisies et de les convertir en "int". Pour les champs vides, la variable "int" de sortie portera la valeur 0.
            Int32.TryParse(textBoxSurfTerrainSouhait.Text, out surfaceParcelleSouhaitee);
            Int32.TryParse(textBoxSurfHabitableSouhait.Text, out surfaceHabitableSouhaitee);
            Int32.TryParse(textBoxNbChambreSouhait.Text, out nbChambresSouhaite);
            Int32.TryParse(textBoxNbPièceSouhait.Text, out nbPiecesSouhaite);
            Int32.TryParse(textBoxNbSalleBainSouhait.Text, out nbSallesDeBainSouhaite);

            // On recherche les biens correspondant aux critères saisis
            biensTrouves = contexteBaseImmobilly.BIENS
                            .Where(b => b.SURFACE_HABITABLE >= surfaceHabitableSouhaitee)
                            .Where(b => b.SURFACE_PARCELLE >= surfaceParcelleSouhaitee)
                            .Where(b => b.VILLES.CODE_POSTAL_VILLE.Trim() == textBoxCodePostalSouhait.Text.Trim())
                            .Where(b => b.NOMBRE_CHAMBRE >= nbChambresSouhaite)
                            .Where(b => b.NOMBRE_PIECE >= nbPiecesSouhaite)
                            .Where(b => b.NOMBRE_SDB >= nbSallesDeBainSouhaite)
                            .Where(b => (b.CAVE == caveSouhaitee && caveSouhaitee) || !caveSouhaitee)
                            .Where(b => (b.GARAGE == garageSouhaite && garageSouhaite) || !garageSouhaite).ToList();
            grilleBiensTrouves.DataSource = biensTrouves;
        }

        private void buttonOKsouhait_Click(object sender, EventArgs e)
        {
            foreach (TextBox box in liste_box_info_acheteur)
            {
                if (String.IsNullOrEmpty(box.Text))
                {
                    MessageBox.Show("Remplir tous les champs obligatoires");
                    return;
                }
            }
        }
        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            IGérerUnSouhait gérerSouhait = new IGérerUnSouhait();
            if (gérerSouhait.ShowDialog() == System.Windows.Forms.DialogResult.OK) { }
        }

        private void boutonRechercherBiens_Click(object sender, EventArgs e)
        {
            // Si on clique sur le bouton "Rechercher", on lance la recherche de biens
            rechercherBiens();

            // Après la recherche, si aucun bien n'a été trouvé, on informe l'utilisateur
            if(biensTrouves.ToList().Count() == 0)
            {
                MessageBox.Show("Aucun bien n'a été trouvé.", "Aucun résultat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Fonction qui se déclenche lorsque le contenu d'une cellule de la grille des biens trouvés doit être mise en forme pour être affichée
        // But : modifier l'affichage d'une variable booléenne dans la grille
        private void grilleBiensTrouves_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // On récupère la grille des biens trouvés en tant qu'objet
            var grid = (DataGridView)sender;

            // Si une valeur booléenne doit être affichée dans une cellule
            if (e.Value.GetType() == typeof(bool))
            {
                // On modifie la manière dont la variable va s'afficher
                e.Value = formaterBooleen((bool)e.Value);
                e.FormattingApplied = true;
            }
        }

        // Choix du texte représentant une variable booléenne selon son état ("true" ou "False")
        private string formaterBooleen(bool b)
        {
            return b ? "Oui" : "Non";
        }

        // Fonction qui se déclenche juste avant l'affichage de la fenêtre
        private void IGérerUnSouhait_Load(object sender, EventArgs e)
        {
            // On récupère la liste des villes disponibles dans la base de données
            villes = contexteBaseImmobilly.VILLES.ToList();

            // On veut suggérer des villes au fur-et-à-mesure que l'utilisateur saisit un nom de ville
            textBoxVilleSouhait.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBoxVilleSouhait.AutoCompleteSource = AutoCompleteSource.CustomSource;
            // Une liste de suggestions ne peut pas être une liste d'objets "VILLES".
            // Seules les chaines de caractères sont acceptées.
            // On va donc convertir la liste des villes en liste de chaines de caractères.
            // Grâce au format de cette chaine (NOM_VILLE - CODE_POSTAL), il sera facile de retrouver le nom d'une ville, ainsi que son code postal par la suite.
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            foreach (VILLES v in villes)
            {
                coll.Add(v.ToString());
            }
            // On ajoute la liste des suggestions au champ de saisie.
            // Une liste de suggestions s'affichera sous le champ de saisie lorsque l'utilisateur tapera un nom de ville au clavier
            textBoxVilleSouhait.AutoCompleteCustomSource = coll;
        }

        // Fonction qui permet d'afficher le nom de la ville et son code postal lorsqu'on sélectionne une ville dans la liste des suggestions
        // Fonctionne lorsqu'on appuie sur la touche "Flèche Bas" du clavier, mais aussi lorsqu'on clique sur une ville suggérée
        private void textBoxVilleSouhait_KeyDown(object sender, KeyEventArgs e)
        {
            // Si on appuie sur la touche "Entrée" après avoir sélectionné une ville
            // EQUIVALENT : si on clique sur une ville dans la liste des suggestions
            if (e.KeyData == Keys.Enter)
            {   
                if (textBoxVilleSouhait.Text.Split('-').Count() > 1)
                {
                    // On affiche le nom de la ville sélectionnée et son code postal     
                    textBoxCodePostalSouhait.Text = textBoxVilleSouhait.Text.Split('-')[1].Trim();
                    textBoxVilleSouhait.Text = textBoxVilleSouhait.Text.Split('-')[0].Trim();
                }                
            }
        }

        // Fonction qui se déclenche lorsqu'on fait un double clic sur une ligne de la grille des biens trouvés
        private void grilleBiensTrouves_DoubleClick(object sender, EventArgs e)
        {

        }

        private void textBoxVilleSouhait_Enter(object sender, EventArgs e)
        {
        }

        private void textBoxVilleSouhait_Leave(object sender, EventArgs e)
        {
            if (textBoxVilleSouhait.Text.Split('-').Count() > 1)
            {
                // On affiche le nom de la ville sélectionnée et son code postal     
                textBoxCodePostalSouhait.Text = textBoxVilleSouhait.Text.Split('-')[1].Trim();
                textBoxVilleSouhait.Text = textBoxVilleSouhait.Text.Split('-')[0].Trim();
            }

            else
            {
                textBoxCodePostalSouhait.Text = "";
            }
        }
    }
}
