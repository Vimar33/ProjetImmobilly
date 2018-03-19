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
    public partial class IGestiondesPropoVisites : Form
    {
        private Immobilly_Groupe_SolveigEntities contexteBaseImmobilly;
        private List<vueVisite> listeVisites;

        public IGestiondesPropoVisites()
        {
            InitializeComponent();
            //récupération du nom du commercial logué dans la textbox
            //textBoxNomCommercial.Text = "commercial Logué ";

            contexteBaseImmobilly = new Immobilly_Groupe_SolveigEntities();

            // Initialisation de la liste des visites
            listeVisites = new List<vueVisite>();

            // On récupère la liste des visites renvoyée par la vue "vueVisites"
            listeVisites = contexteBaseImmobilly.vueVisite.ToList();

            // On affiche la liste des visites dans la grille
            grilleVisites.DataSource = listeVisites;

        }

        private void buttonNouvellePropoVisite_Click(object sender, EventArgs e)
        {
            IPropoBienVisite propoVisite = new IPropoBienVisite();
            if (propoVisite.ShowDialog() == System.Windows.Forms.DialogResult.OK) { }
        }

        private void buttonModifierSouhait_Click(object sender, EventArgs e)
        {
            IPropoBienVisite propoVisite = new IPropoBienVisite();
            if (propoVisite.ShowDialog() == System.Windows.Forms.DialogResult.OK) { }
        }
    }
}
