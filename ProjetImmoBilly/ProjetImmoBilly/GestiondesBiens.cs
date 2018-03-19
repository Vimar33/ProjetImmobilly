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
    public partial class IGestiondesBiens : Form
    {
        //Create an ObjectContext instance based on Immobilly_Groupe_SolveigEntities
        private Immobilly_Groupe_SolveigEntities contexteBaseImmobilly;
        private List<BIENS> biens;
        public IGestiondesBiens()
        {
            InitializeComponent();
            //récupération du nom du commercial logué dans la textbox
            //textBoxNomCommercial.Text = "commercial Logué ";

            //Initialiser le contexte
            contexteBaseImmobilly = new Immobilly_Groupe_SolveigEntities();
            try
            {
                biens = new List<BIENS>();

                // On récupère la liste des acheteurs disponibles en base
                biens = contexteBaseImmobilly.BIENS.ToList();

                // On affiche la liste des acheteurs dans la grille
                dataGridViewBien.DataSource = biens;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonNouveau_Click(object sender, EventArgs e)
        {
            IGérerUnBien gererBien = new IGérerUnBien();
            if (gererBien.ShowDialog() == System.Windows.Forms.DialogResult.OK) { }
        }
        private void buttonModifier_Click(object sender, EventArgs e)
        {
            IGérerUnBien gererBien = new IGérerUnBien();
            if (gererBien.ShowDialog() == System.Windows.Forms.DialogResult.OK) { }
        }
        private void buttonSupprimer_Click(object sender, EventArgs e)
        {

        }        
    }
}
