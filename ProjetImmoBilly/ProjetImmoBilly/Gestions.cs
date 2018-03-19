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
    public partial class IGestions : Form
    {
        public IGestions()
        {
            InitializeComponent();
            //récupération du nom du commercial logué dans la textbox
            //textBoxNomCommercial.Text = "commercial Logué ";
        }
        private void buttonGestiondesBiens_Click(object sender, EventArgs e)
        {
            IGestiondesBiens gestionsBiens = new IGestiondesBiens();
            if (gestionsBiens.ShowDialog() == System.Windows.Forms.DialogResult.OK) { }
        }

        private void buttonGestiondesSouhaits_Click(object sender, EventArgs e)
        {
            IGestiondesSouhaits gestionsSouhait = new IGestiondesSouhaits();
           if (gestionsSouhait.ShowDialog() == System.Windows.Forms.DialogResult.OK) { }
        }

        private void buttonGestiondesCommerciaux_Click(object sender, EventArgs e)
        {
            IGestionsdesCommerciaux gestionsCommerciaux = new IGestionsdesCommerciaux();
            if (gestionsCommerciaux.ShowDialog() == System.Windows.Forms.DialogResult.OK) { }
        }

        private void buttonGestiondesVisites_Click(object sender, EventArgs e)
        {
            IGestiondesPropoVisites gestionPropVisite = new IGestiondesPropoVisites();
            if (gestionPropVisite.ShowDialog() == System.Windows.Forms.DialogResult.OK) { }
        }
    }
}
