using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetImmoBilly
{
    public partial class IGérerUnBien : Form
    {
        #region attributs
        //pour l'impression
        private PrintDocument Impression;
        private PrinterSettings printer = null;
        private Font impressionFont = new Font("Arial", 12, FontStyle.Bold);
        private Pen gris = new Pen(Color.Gray, 10);
        //liste de textbox obligatoires lors de la création d'un vendeur et de son bien
        List<TextBox> liste_box_info_proprio = new List<TextBox>();
        List<TextBox> liste_box_info_bien = new List<TextBox>();
        #endregion
        public IGérerUnBien()
        {
            InitializeComponent();
            //récupération du nom du commercial logué dans la textbox
            //textBoxNomCommercial.Text = "commercial Loggué ";

            liste_box_info_proprio.Add(textBoxNomProprio);
            liste_box_info_proprio.Add(textBoxPrénomProprio);
            liste_box_info_proprio.Add(textBoxAdresseProprio);
            liste_box_info_proprio.Add(textBoxCPproprio);
            liste_box_info_proprio.Add(textBoxMobileProprio);

            //faire la même chose pour la listebox info bien
        }
        #region boutons  
        private void buttonOKbien_Click(object sender, EventArgs e)
        {
            foreach (TextBox box in liste_box_info_proprio)
            {
                if (String.IsNullOrEmpty(box.Text))
                {                    
                    MessageBox.Show("Remplir tous les champs obligatoires");
                    return;
                }
            }
        }
        private void buttonApercu_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog ptPrev = new PrintPreviewDialog();
            Impression = new PrintDocument();
            Impression.PrintPage += Impression_Printpage;
            ptPrev.Document = Impression;

            /// <summar>
            /// suppression du bouton imprimer par défaut de la boite de dialogue
            /// et création d'un nouveau bouton imprimer permettant un choix d'imrpimante
            /// </summary>
            
            ToolStripButton b = new ToolStripButton();
            b.ImageIndex = ((ToolStripButton)((ToolStrip)ptPrev.Controls[1]).Items[0]).ImageIndex;//on récupère l'image du bouton par défaut pour le nouveau bouton
            ((ToolStrip)ptPrev.Controls[1]).Items.Remove(((ToolStripButton)((ToolStrip)ptPrev.Controls[1]).Items[0]));//suppression du bouton par défaut
            b.Visible = true;
            ((ToolStrip)ptPrev.Controls[1]).Items.Insert(0, b);// insertion du nouveau bouton sur la même position que le bouton par défaut 
            ((ToolStripButton)((ToolStrip)ptPrev.Controls[1]).Items[0]).Click += new System.EventHandler(this.buttonImprimerDescription_Click);//on attribut la méthode imprimer avec choix imprimante
                        
            ptPrev.ShowDialog();
        }
        private void buttonImprimerDescription_Click(object sender, EventArgs e)
        {
                if (ChoixImprimante())
                {
                    if (printer != null)
                    {
                        Impression.PrinterSettings = printer;
                        Impression.Print();
                    }
                }
            }
        #endregion
        #region Méthodes
        #region Impression
        private void Impression_Printpage(object sender, PrintPageEventArgs e)
        {
            //information agence
            e.Graphics.DrawImage(pictureBox1.Image, 10, 10);
            e.Graphics.DrawString(labelImmoBilly.Text, new Font("lucida Console", 12, FontStyle.Italic), Brushes.White, 10, 30);
            e.Graphics.DrawString("Adresse :\n28 Cours Gambetta,\n33850 Léognan\n\nHoraire :\n-Lundi - vendredi :\n9h/12h - 14h/19h\n-Samedi :\n9h/12h sur RDV l'après midi\n\nTéléphone: 05 56 64 14 07", impressionFont, Brushes.Black, 15, 160);
            e.Graphics.DrawString("Commercial référent :\n" + textBoxNomCommercial.Text, impressionFont, Brushes.Black, 15, 400);
            //information du bien
            e.Graphics.DrawString(labelDescriptionBien.Text, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, 250, 40);
            e.Graphics.DrawRectangle(gris, new Rectangle(250, 80, 560, 370));
            e.Graphics.DrawString("Surface habitable : " + textBoxSurfHabitable.Text + " m²", impressionFont, Brushes.Black, 270, 100);
            e.Graphics.DrawString("Surface terrain : " + textBoxSurfTerrain.Text + " m²", impressionFont, Brushes.Black, 270, 150);
            e.Graphics.DrawString("Nombre de pièces : " + textBoxNbPièce.Text, impressionFont, Brushes.Black, 270, 200);
            e.Graphics.DrawString("Nombre de chambres : " + textBoxNbChambre.Text, impressionFont, Brushes.Black, 270, 250);
            e.Graphics.DrawString("Nombre de salle de bain : " + textBoxNbSalleBain.Text, impressionFont, Brushes.Black, 270, 300);
            e.Graphics.DrawString("Adresse : " + textBoxAdresseBien.Text, impressionFont, Brushes.Black, 550, 100);
            e.Graphics.DrawString("Code postal : " + textBoxCodePostalBien.Text, impressionFont, Brushes.Black, 550, 200);
            e.Graphics.DrawString("Ville : " + textBoxVille.Text, impressionFont, Brushes.Black, 550, 250);
            e.Graphics.DrawString("Remarque(s) :\n" + textBoxRemarque.Text, impressionFont, Brushes.Black, new RectangleF(new PointF(550, 300), new SizeF(204, 82)));
            e.Graphics.DrawString("Prix de vente : " + textBoxPrixVente.Text + " €", new Font("Arial", 15, FontStyle.Bold), Brushes.Red, 270, 400);
            if (checkBoxGarage.Checked)
            {
                e.Graphics.DrawString("Garage", impressionFont, Brushes.Black, 270, 350);
            }
            if (checkBoxCave.Checked)
            {
                e.Graphics.DrawString("Cave", impressionFont, Brushes.Black, 370, 350);
            }
            //photo du bien
            e.Graphics.DrawRectangle(gris, new Rectangle(15, 500, 795, 600));
            Image Image1 = Image.FromFile("C:\\Users\\bgiraud-adm\\Sources\\Repos\\ProjetImmoBilly\\images\\maison.jpg");
            Image Image2 = Image.FromFile("C:\\Users\\bgiraud-adm\\Sources\\Repos\\ProjetImmoBilly\\images\\plan_maison.jpg");
            e.Graphics.DrawImage(Image1, 30, 520);
            e.Graphics.DrawImage(Image2, 320, 750);

        }
        private bool ChoixImprimante()
        {
            PrintDialog printDial = new PrintDialog();
            printDial.AllowSelection = false;
            printDial.AllowSomePages = true;
            printDial.PrintToFile = false;
            if (printDial.ShowDialog() == DialogResult.OK)
            {
                printer = printDial.PrinterSettings;
                return true;
            }
            return false;
        }
        #endregion
        #region verification des textBox de type entier
        private void verifierInt(TextBox textBox)
        {
            int result;
            if (textBox.Text != "")
            {
                if (!int.TryParse(textBox.Text, out result))
                {
                    textBox.Text = "";
                    MessageBox.Show("Entrer un nombre");

                }
            }
        }
        private void textBoxSurfHabitable_TextChanged(object sender, EventArgs e)
        {
            verifierInt(textBoxSurfHabitable);
        }
        private void textBoxSurfTerrain_TextChanged(object sender, EventArgs e)
        {
            verifierInt(textBoxSurfTerrain);
        }

        private void textBoxNbPièce_TextChanged(object sender, EventArgs e)
        {
            verifierInt(textBoxNbPièce);
        }

        private void textBoxNbChambre_TextChanged(object sender, EventArgs e)
        {
            verifierInt(textBoxNbChambre);
        }

        private void textBoxNbSalleBain_TextChanged(object sender, EventArgs e)
        {
            verifierInt(textBoxNbSalleBain);
        }

        private void textBoxCodePostalBien_TextChanged(object sender, EventArgs e)
        {
            verifierInt(textBoxCodePostalBien);
        }

        private void textBoxPrixVente_TextChanged(object sender, EventArgs e)
        {
            verifierInt(textBoxPrixVente);
        }
        private void textBoxCPproprio_TextChanged(object sender, EventArgs e)
        {
            verifierInt(textBoxCPproprio);
        }
        private void textBoxFixProprio_TextChanged(object sender, EventArgs e)
        {
            verifierInt(textBoxFixProprio);
        }
        private void textBoxMobileProprio_TextChanged(object sender, EventArgs e)
        {
            verifierInt(textBoxMobileProprio);
        }
        #endregion
        #region verification textBox mail valide
        private void textBoxMailProprio_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            {
                string errorMsg;
                if (!ValidEmailAddress(textBoxMailProprio.Text, out errorMsg))
                {
                    // Si mail non valide, sélectionne le texte qui doit être corrigé par l'utilisateur.
                    e.Cancel = true;
                    textBoxMailProprio.Select(0, textBoxMailProprio.Text.Length);

                    // envoie du message d'erreur 
                    MessageBox.Show(errorMsg);
                }
            }
        }
        public bool ValidEmailAddress(string emailAddress, out string errorMessage)
        {
            // confirme qu'il y a un "@" et "." dans l'adresse mail, et dans l'ordre correcte.
            if (emailAddress.IndexOf("@") > -1)
            {
                if (emailAddress.IndexOf(".", emailAddress.IndexOf("@")) > emailAddress.IndexOf("@"))
                {
                    errorMessage = "";
                    return true;
                }
            }
            errorMessage = "e-mail invalide\nle format correct est de la forme : someone@example.com ";
            return false;
        }
        //trouver un code qui vérifie la validité numéro de tel
        //trouver un code qui vérifie la validité code postal
        #endregion
        #endregion        
    }
}
