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
    public partial class IGestionsdesCommerciaux : Form
    {
        //liste de textbox obligatoires lors de la création d'un commercial
        List<TextBox> liste_box_info_commerciaux = new List<TextBox>();
        public IGestionsdesCommerciaux()
        {
            InitializeComponent();
            //récupération du nom du commercial logué dans la textbox
            //textBoxNomCommercial.Text = "commercial Logué ";

            liste_box_info_commerciaux.Add(textBoxNomNouveauCommercial);
            liste_box_info_commerciaux.Add(textBoxPrénomNouveauCommercial);
            liste_box_info_commerciaux.Add(textBoxTelFixePro);
            liste_box_info_commerciaux.Add(textBoxTelFixePerso);
            liste_box_info_commerciaux.Add(textBoxMailCommercial);
        }
        private void buttonAjouterCommercial_Click(object sender, EventArgs e)
        {
            foreach (TextBox box in liste_box_info_commerciaux)
            {
                if (String.IsNullOrEmpty(box.Text))
                {
                    MessageBox.Show("Remplir tous les champs obligatoires");
                    return;
                }
            }
        }
        private void buttonModifierCommercial_Click(object sender, EventArgs e)
        {

        }
    }
}
