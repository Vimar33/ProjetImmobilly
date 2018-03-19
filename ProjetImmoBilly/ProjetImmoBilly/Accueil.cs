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
    public partial class Accueil : Form
    {
        #region variables globales
        //Create an ObjectContext instance based on Immobilly_Groupe_SolveigEntities
        private Immobilly_Groupe_SolveigEntities contexteBaseImmobilly;
        private List<COMMERCIAUX> commerciaux;
        #endregion
        #region initialisation de : form Accueil
        public Accueil()
        {
            InitializeComponent();
            //Initialise le contexte
            contexteBaseImmobilly = new Immobilly_Groupe_SolveigEntities();
        }
        #endregion
        #region Bouton
        private void buttonConnection_Click(object sender, EventArgs e)
        {
            if (EstceMonCommercial()) //vérification de la concordance login password avec table des commerciaux
            {
                authorisation();
            }
            labelerrorMessage.Visible = true;//message d'erreur identifiant ou password incorrect
        }
        #endregion
        #region Méthodes
        private bool EstceMonCommercial()
        {
            // On récupère la liste des acheteurs disponibles en base
            // qui correspondent au login et password entré, et dont le statut est actif
            commerciaux = new List<COMMERCIAUX>();
            commerciaux = contexteBaseImmobilly.COMMERCIAUX.Where(c => c.LOGIN.Equals(textBoxLogin.Text)
                        && c.PASS.Equals(textBoxMotdePasse.Text) && c.STATUT_COMMERCIAUX.NUMERO_STATUT_COMMERCIAL == 1).ToList();

            //si la taille de cette liste est égale a 1 (=commercial unique)
            if (commerciaux.Count() == 1)
            {
                return true;
            }

            return false;
        }
        private void authorisation()
        {            
                labelerrorMessage.Visible = false; // on masque le message d'erreur
                textBoxMotdePasse.Clear(); //on efface le password
                IGestions InterfaceGestions = new IGestions(); //on affiche l'interface de gestion
                if (InterfaceGestions.ShowDialog() == System.Windows.Forms.DialogResult.OK) { }                        
        }
        #endregion
    }
}
