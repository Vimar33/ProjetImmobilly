namespace ProjetImmoBilly
{
    partial class IGestionsdesCommerciaux
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IGestionsdesCommerciaux));
            this.labelImmoBilly = new System.Windows.Forms.Label();
            this.buttonModifierCommercial = new System.Windows.Forms.Button();
            this.buttonAjouterCommercial = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.textBoxNomCommercial = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listViewCommerciaux = new System.Windows.Forms.ListView();
            this.columnHeaderCodeCommercial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNomCommercial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPrénomCommercial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNbAcheteur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStatutCommercial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelListeCommerciaux = new System.Windows.Forms.Label();
            this.labelParNom = new System.Windows.Forms.Label();
            this.textBoxNomCommerciaux = new System.Windows.Forms.TextBox();
            this.checkBoxActifs = new System.Windows.Forms.CheckBox();
            this.labelMailCommercial = new System.Windows.Forms.Label();
            this.textBoxMailCommercial = new System.Windows.Forms.TextBox();
            this.labelTelPerso = new System.Windows.Forms.Label();
            this.textBoxTelFixePerso = new System.Windows.Forms.TextBox();
            this.labelTelFixePro = new System.Windows.Forms.Label();
            this.labelPrénomPrénomNouveauCommercial = new System.Windows.Forms.Label();
            this.labelNomCommercial = new System.Windows.Forms.Label();
            this.textBoxTelFixePro = new System.Windows.Forms.TextBox();
            this.textBoxPrénomNouveauCommercial = new System.Windows.Forms.TextBox();
            this.textBoxNomNouveauCommercial = new System.Windows.Forms.TextBox();
            this.labelInfoNouveauCommercial = new System.Windows.Forms.Label();
            this.checkBoxAncienEmployé = new System.Windows.Forms.CheckBox();
            this.checkBoxActif = new System.Windows.Forms.CheckBox();
            this.labelStatutCommercial = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelImmoBilly
            // 
            this.labelImmoBilly.AutoSize = true;
            this.labelImmoBilly.BackColor = System.Drawing.Color.DimGray;
            this.labelImmoBilly.Font = new System.Drawing.Font("Lucida Console", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImmoBilly.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelImmoBilly.Location = new System.Drawing.Point(910, 23);
            this.labelImmoBilly.Name = "labelImmoBilly";
            this.labelImmoBilly.Size = new System.Drawing.Size(118, 16);
            this.labelImmoBilly.TabIndex = 46;
            this.labelImmoBilly.Text = "Immo Billy";
            // 
            // buttonModifierCommercial
            // 
            this.buttonModifierCommercial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModifierCommercial.Location = new System.Drawing.Point(904, 283);
            this.buttonModifierCommercial.Name = "buttonModifierCommercial";
            this.buttonModifierCommercial.Size = new System.Drawing.Size(225, 92);
            this.buttonModifierCommercial.TabIndex = 45;
            this.buttonModifierCommercial.Text = "Modifier";
            this.buttonModifierCommercial.UseVisualStyleBackColor = true;
            this.buttonModifierCommercial.Click += new System.EventHandler(this.buttonModifierCommercial_Click);
            // 
            // buttonAjouterCommercial
            // 
            this.buttonAjouterCommercial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjouterCommercial.Location = new System.Drawing.Point(904, 393);
            this.buttonAjouterCommercial.Name = "buttonAjouterCommercial";
            this.buttonAjouterCommercial.Size = new System.Drawing.Size(225, 92);
            this.buttonAjouterCommercial.TabIndex = 44;
            this.buttonAjouterCommercial.Text = "Ajouter un commercial";
            this.buttonAjouterCommercial.UseVisualStyleBackColor = true;
            this.buttonAjouterCommercial.Click += new System.EventHandler(this.buttonAjouterCommercial_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturn.Location = new System.Drawing.Point(904, 174);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(225, 92);
            this.buttonReturn.TabIndex = 43;
            this.buttonReturn.Text = "Retour accueil gestions";
            this.buttonReturn.UseVisualStyleBackColor = true;
            // 
            // textBoxNomCommercial
            // 
            this.textBoxNomCommercial.Location = new System.Drawing.Point(904, 136);
            this.textBoxNomCommercial.Name = "textBoxNomCommercial";
            this.textBoxNomCommercial.ReadOnly = true;
            this.textBoxNomCommercial.Size = new System.Drawing.Size(225, 20);
            this.textBoxNomCommercial.TabIndex = 42;
            this.textBoxNomCommercial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(904, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // listViewCommerciaux
            // 
            this.listViewCommerciaux.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderCodeCommercial,
            this.columnHeaderNomCommercial,
            this.columnHeaderPrénomCommercial,
            this.columnHeaderNbAcheteur,
            this.columnHeaderStatutCommercial});
            this.listViewCommerciaux.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewCommerciaux.GridLines = true;
            this.listViewCommerciaux.Location = new System.Drawing.Point(12, 124);
            this.listViewCommerciaux.Name = "listViewCommerciaux";
            this.listViewCommerciaux.Size = new System.Drawing.Size(803, 240);
            this.listViewCommerciaux.TabIndex = 47;
            this.listViewCommerciaux.UseCompatibleStateImageBehavior = false;
            this.listViewCommerciaux.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderCodeCommercial
            // 
            this.columnHeaderCodeCommercial.Text = "Code commercial";
            this.columnHeaderCodeCommercial.Width = 200;
            // 
            // columnHeaderNomCommercial
            // 
            this.columnHeaderNomCommercial.Text = "Nom";
            this.columnHeaderNomCommercial.Width = 150;
            // 
            // columnHeaderPrénomCommercial
            // 
            this.columnHeaderPrénomCommercial.Text = "Prénom";
            this.columnHeaderPrénomCommercial.Width = 150;
            // 
            // columnHeaderNbAcheteur
            // 
            this.columnHeaderNbAcheteur.Text = "Portefeuille client";
            this.columnHeaderNbAcheteur.Width = 200;
            // 
            // columnHeaderStatutCommercial
            // 
            this.columnHeaderStatutCommercial.Text = "Statut";
            this.columnHeaderStatutCommercial.Width = 100;
            // 
            // labelListeCommerciaux
            // 
            this.labelListeCommerciaux.AutoSize = true;
            this.labelListeCommerciaux.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListeCommerciaux.Location = new System.Drawing.Point(8, 34);
            this.labelListeCommerciaux.Name = "labelListeCommerciaux";
            this.labelListeCommerciaux.Size = new System.Drawing.Size(201, 20);
            this.labelListeCommerciaux.TabIndex = 54;
            this.labelListeCommerciaux.Text = "Liste des commerciaux :";
            // 
            // labelParNom
            // 
            this.labelParNom.AutoSize = true;
            this.labelParNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParNom.Location = new System.Drawing.Point(261, 77);
            this.labelParNom.Name = "labelParNom";
            this.labelParNom.Size = new System.Drawing.Size(153, 20);
            this.labelParNom.TabIndex = 53;
            this.labelParNom.Text = "Recherche par nom:";
            // 
            // textBoxNomCommerciaux
            // 
            this.textBoxNomCommerciaux.Location = new System.Drawing.Point(420, 78);
            this.textBoxNomCommerciaux.MaxLength = 50;
            this.textBoxNomCommerciaux.Name = "textBoxNomCommerciaux";
            this.textBoxNomCommerciaux.Size = new System.Drawing.Size(180, 20);
            this.textBoxNomCommerciaux.TabIndex = 52;
            // 
            // checkBoxActifs
            // 
            this.checkBoxActifs.AutoSize = true;
            this.checkBoxActifs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxActifs.Location = new System.Drawing.Point(44, 75);
            this.checkBoxActifs.Name = "checkBoxActifs";
            this.checkBoxActifs.Size = new System.Drawing.Size(68, 24);
            this.checkBoxActifs.TabIndex = 51;
            this.checkBoxActifs.Text = ": Actif";
            this.checkBoxActifs.UseVisualStyleBackColor = true;
            // 
            // labelMailCommercial
            // 
            this.labelMailCommercial.AutoSize = true;
            this.labelMailCommercial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMailCommercial.Location = new System.Drawing.Point(488, 417);
            this.labelMailCommercial.Name = "labelMailCommercial";
            this.labelMailCommercial.Size = new System.Drawing.Size(45, 20);
            this.labelMailCommercial.TabIndex = 71;
            this.labelMailCommercial.Text = "Mail :";
            // 
            // textBoxMailCommercial
            // 
            this.textBoxMailCommercial.Location = new System.Drawing.Point(492, 440);
            this.textBoxMailCommercial.MaxLength = 100;
            this.textBoxMailCommercial.Name = "textBoxMailCommercial";
            this.textBoxMailCommercial.Size = new System.Drawing.Size(204, 20);
            this.textBoxMailCommercial.TabIndex = 70;
            // 
            // labelTelPerso
            // 
            this.labelTelPerso.AutoSize = true;
            this.labelTelPerso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelPerso.Location = new System.Drawing.Point(261, 479);
            this.labelTelPerso.Name = "labelTelPerso";
            this.labelTelPerso.Size = new System.Drawing.Size(132, 20);
            this.labelTelPerso.TabIndex = 69;
            this.labelTelPerso.Text = "N° tel. personnel :";
            // 
            // textBoxTelFixePerso
            // 
            this.textBoxTelFixePerso.Location = new System.Drawing.Point(265, 502);
            this.textBoxTelFixePerso.MaxLength = 10;
            this.textBoxTelFixePerso.Name = "textBoxTelFixePerso";
            this.textBoxTelFixePerso.Size = new System.Drawing.Size(204, 20);
            this.textBoxTelFixePerso.TabIndex = 68;
            // 
            // labelTelFixePro
            // 
            this.labelTelFixePro.AutoSize = true;
            this.labelTelFixePro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelFixePro.Location = new System.Drawing.Point(261, 417);
            this.labelTelFixePro.Name = "labelTelFixePro";
            this.labelTelFixePro.Size = new System.Drawing.Size(157, 20);
            this.labelTelFixePro.TabIndex = 67;
            this.labelTelFixePro.Text = "N° tel. professionnel :";
            // 
            // labelPrénomPrénomNouveauCommercial
            // 
            this.labelPrénomPrénomNouveauCommercial.AutoSize = true;
            this.labelPrénomPrénomNouveauCommercial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrénomPrénomNouveauCommercial.Location = new System.Drawing.Point(30, 477);
            this.labelPrénomPrénomNouveauCommercial.Name = "labelPrénomPrénomNouveauCommercial";
            this.labelPrénomPrénomNouveauCommercial.Size = new System.Drawing.Size(72, 20);
            this.labelPrénomPrénomNouveauCommercial.TabIndex = 64;
            this.labelPrénomPrénomNouveauCommercial.Text = "Prénom :";
            // 
            // labelNomCommercial
            // 
            this.labelNomCommercial.AutoSize = true;
            this.labelNomCommercial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomCommercial.Location = new System.Drawing.Point(30, 417);
            this.labelNomCommercial.Name = "labelNomCommercial";
            this.labelNomCommercial.Size = new System.Drawing.Size(50, 20);
            this.labelNomCommercial.TabIndex = 63;
            this.labelNomCommercial.Text = "Nom :";
            // 
            // textBoxTelFixePro
            // 
            this.textBoxTelFixePro.Location = new System.Drawing.Point(265, 440);
            this.textBoxTelFixePro.MaxLength = 10;
            this.textBoxTelFixePro.Name = "textBoxTelFixePro";
            this.textBoxTelFixePro.Size = new System.Drawing.Size(204, 20);
            this.textBoxTelFixePro.TabIndex = 62;
            // 
            // textBoxPrénomNouveauCommercial
            // 
            this.textBoxPrénomNouveauCommercial.Location = new System.Drawing.Point(34, 500);
            this.textBoxPrénomNouveauCommercial.MaxLength = 50;
            this.textBoxPrénomNouveauCommercial.Name = "textBoxPrénomNouveauCommercial";
            this.textBoxPrénomNouveauCommercial.Size = new System.Drawing.Size(204, 20);
            this.textBoxPrénomNouveauCommercial.TabIndex = 59;
            // 
            // textBoxNomNouveauCommercial
            // 
            this.textBoxNomNouveauCommercial.Location = new System.Drawing.Point(34, 440);
            this.textBoxNomNouveauCommercial.MaxLength = 50;
            this.textBoxNomNouveauCommercial.Name = "textBoxNomNouveauCommercial";
            this.textBoxNomNouveauCommercial.Size = new System.Drawing.Size(204, 20);
            this.textBoxNomNouveauCommercial.TabIndex = 58;
            // 
            // labelInfoNouveauCommercial
            // 
            this.labelInfoNouveauCommercial.AutoSize = true;
            this.labelInfoNouveauCommercial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoNouveauCommercial.Location = new System.Drawing.Point(12, 382);
            this.labelInfoNouveauCommercial.Name = "labelInfoNouveauCommercial";
            this.labelInfoNouveauCommercial.Size = new System.Drawing.Size(270, 20);
            this.labelInfoNouveauCommercial.TabIndex = 57;
            this.labelInfoNouveauCommercial.Text = "Ajouter un nouveau commercial :";
            // 
            // checkBoxAncienEmployé
            // 
            this.checkBoxAncienEmployé.AutoSize = true;
            this.checkBoxAncienEmployé.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAncienEmployé.Location = new System.Drawing.Point(613, 502);
            this.checkBoxAncienEmployé.Name = "checkBoxAncienEmployé";
            this.checkBoxAncienEmployé.Size = new System.Drawing.Size(148, 24);
            this.checkBoxAncienEmployé.TabIndex = 73;
            this.checkBoxAncienEmployé.Text = ": Ancien employé";
            this.checkBoxAncienEmployé.UseVisualStyleBackColor = true;
            // 
            // checkBoxActif
            // 
            this.checkBoxActif.AutoSize = true;
            this.checkBoxActif.Checked = true;
            this.checkBoxActif.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxActif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxActif.Location = new System.Drawing.Point(492, 502);
            this.checkBoxActif.Name = "checkBoxActif";
            this.checkBoxActif.Size = new System.Drawing.Size(68, 24);
            this.checkBoxActif.TabIndex = 72;
            this.checkBoxActif.Text = ": Actif";
            this.checkBoxActif.UseVisualStyleBackColor = true;
            // 
            // labelStatutCommercial
            // 
            this.labelStatutCommercial.AutoSize = true;
            this.labelStatutCommercial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatutCommercial.Location = new System.Drawing.Point(488, 479);
            this.labelStatutCommercial.Name = "labelStatutCommercial";
            this.labelStatutCommercial.Size = new System.Drawing.Size(61, 20);
            this.labelStatutCommercial.TabIndex = 74;
            this.labelStatutCommercial.Text = "Statut :";
            // 
            // IGestionsdesCommerciaux
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 653);
            this.Controls.Add(this.labelStatutCommercial);
            this.Controls.Add(this.checkBoxAncienEmployé);
            this.Controls.Add(this.checkBoxActif);
            this.Controls.Add(this.labelMailCommercial);
            this.Controls.Add(this.textBoxMailCommercial);
            this.Controls.Add(this.labelTelPerso);
            this.Controls.Add(this.textBoxTelFixePerso);
            this.Controls.Add(this.labelTelFixePro);
            this.Controls.Add(this.labelPrénomPrénomNouveauCommercial);
            this.Controls.Add(this.labelNomCommercial);
            this.Controls.Add(this.textBoxTelFixePro);
            this.Controls.Add(this.textBoxPrénomNouveauCommercial);
            this.Controls.Add(this.textBoxNomNouveauCommercial);
            this.Controls.Add(this.labelInfoNouveauCommercial);
            this.Controls.Add(this.labelListeCommerciaux);
            this.Controls.Add(this.labelParNom);
            this.Controls.Add(this.textBoxNomCommerciaux);
            this.Controls.Add(this.checkBoxActifs);
            this.Controls.Add(this.listViewCommerciaux);
            this.Controls.Add(this.labelImmoBilly);
            this.Controls.Add(this.buttonModifierCommercial);
            this.Controls.Add(this.buttonAjouterCommercial);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.textBoxNomCommercial);
            this.Controls.Add(this.pictureBox1);
            this.Name = "IGestionsdesCommerciaux";
            this.Text = "Gestions des commerciaux";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelImmoBilly;
        private System.Windows.Forms.Button buttonModifierCommercial;
        private System.Windows.Forms.Button buttonAjouterCommercial;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.TextBox textBoxNomCommercial;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listViewCommerciaux;
        private System.Windows.Forms.ColumnHeader columnHeaderCodeCommercial;
        private System.Windows.Forms.ColumnHeader columnHeaderNomCommercial;
        private System.Windows.Forms.ColumnHeader columnHeaderPrénomCommercial;
        private System.Windows.Forms.ColumnHeader columnHeaderNbAcheteur;
        private System.Windows.Forms.Label labelListeCommerciaux;
        private System.Windows.Forms.Label labelParNom;
        private System.Windows.Forms.TextBox textBoxNomCommerciaux;
        private System.Windows.Forms.CheckBox checkBoxActifs;
        private System.Windows.Forms.ColumnHeader columnHeaderStatutCommercial;
        private System.Windows.Forms.Label labelMailCommercial;
        private System.Windows.Forms.TextBox textBoxMailCommercial;
        private System.Windows.Forms.Label labelTelPerso;
        private System.Windows.Forms.TextBox textBoxTelFixePerso;
        private System.Windows.Forms.Label labelTelFixePro;
        private System.Windows.Forms.Label labelPrénomPrénomNouveauCommercial;
        private System.Windows.Forms.Label labelNomCommercial;
        private System.Windows.Forms.TextBox textBoxTelFixePro;
        private System.Windows.Forms.TextBox textBoxPrénomNouveauCommercial;
        private System.Windows.Forms.TextBox textBoxNomNouveauCommercial;
        private System.Windows.Forms.Label labelInfoNouveauCommercial;
        private System.Windows.Forms.CheckBox checkBoxAncienEmployé;
        private System.Windows.Forms.CheckBox checkBoxActif;
        private System.Windows.Forms.Label labelStatutCommercial;
    }
}