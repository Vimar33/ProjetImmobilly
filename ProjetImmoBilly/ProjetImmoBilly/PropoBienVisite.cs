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
    public partial class IPropoBienVisite : Form
    {
        //gérer une liste des info obligatoires qui empeche le bouton OK si non renseigner
        public IPropoBienVisite()
        {
            InitializeComponent();
            //récupération du nom du commercial logué dans la textbox
            //textBoxNomCommercial.Text = "commercial Logué ";
        }

        private void buttonOKpropo_visite_Click(object sender, EventArgs e)
        {

        }

        private void buttonImprimerBonVisite_Click(object sender, EventArgs e)
        {
            //aller voir le code dans gérer un bien pour reproduire la même idée
        }
    }
}
