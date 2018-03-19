namespace ProjetImmoBilly
{
    partial class IGestiondesPropoVisites
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IGestiondesPropoVisites));
            this.labelImmoBilly = new System.Windows.Forms.Label();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.textBoxNomCommercial = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonNouvellePropoVisite = new System.Windows.Forms.Button();
            this.labelParNomCommercial = new System.Windows.Forms.Label();
            this.labelParNomClient = new System.Windows.Forms.Label();
            this.textBoxRechercheNomCommercial = new System.Windows.Forms.TextBox();
            this.textBoxRechercheNomClient = new System.Windows.Forms.TextBox();
            this.labelRecherche = new System.Windows.Forms.Label();
            this.buttonModifierSouhait = new System.Windows.Forms.Button();
            this.labelListePropositions = new System.Windows.Forms.Label();
            this.grilleVisites = new System.Windows.Forms.DataGridView();
            this.acheteurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commercialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nUMEROBIENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeBienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATEPROPOSITIONVISITEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bienVisiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATEVISITEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vueVisiteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilleVisites)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueVisiteBindingSource)).BeginInit();
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
            this.labelImmoBilly.TabIndex = 52;
            this.labelImmoBilly.Text = "Immo Billy";
            // 
            // buttonReturn
            // 
            this.buttonReturn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturn.Location = new System.Drawing.Point(904, 174);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(225, 92);
            this.buttonReturn.TabIndex = 49;
            this.buttonReturn.Text = "Retour accueil gestions";
            this.buttonReturn.UseVisualStyleBackColor = true;
            // 
            // textBoxNomCommercial
            // 
            this.textBoxNomCommercial.Location = new System.Drawing.Point(904, 136);
            this.textBoxNomCommercial.Name = "textBoxNomCommercial";
            this.textBoxNomCommercial.ReadOnly = true;
            this.textBoxNomCommercial.Size = new System.Drawing.Size(225, 20);
            this.textBoxNomCommercial.TabIndex = 48;
            this.textBoxNomCommercial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(904, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // buttonNouvellePropoVisite
            // 
            this.buttonNouvellePropoVisite.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNouvellePropoVisite.Location = new System.Drawing.Point(904, 272);
            this.buttonNouvellePropoVisite.Name = "buttonNouvellePropoVisite";
            this.buttonNouvellePropoVisite.Size = new System.Drawing.Size(225, 92);
            this.buttonNouvellePropoVisite.TabIndex = 54;
            this.buttonNouvellePropoVisite.Text = "Nouvelle proposition / visite";
            this.buttonNouvellePropoVisite.UseVisualStyleBackColor = true;
            this.buttonNouvellePropoVisite.Click += new System.EventHandler(this.buttonNouvellePropoVisite_Click);
            // 
            // labelParNomCommercial
            // 
            this.labelParNomCommercial.AutoSize = true;
            this.labelParNomCommercial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParNomCommercial.Location = new System.Drawing.Point(429, 108);
            this.labelParNomCommercial.Name = "labelParNomCommercial";
            this.labelParNomCommercial.Size = new System.Drawing.Size(160, 20);
            this.labelParNomCommercial.TabIndex = 60;
            this.labelParNomCommercial.Text = "Par nom commercial :";
            // 
            // labelParNomClient
            // 
            this.labelParNomClient.AutoSize = true;
            this.labelParNomClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParNomClient.Location = new System.Drawing.Point(79, 108);
            this.labelParNomClient.Name = "labelParNomClient";
            this.labelParNomClient.Size = new System.Drawing.Size(117, 20);
            this.labelParNomClient.TabIndex = 59;
            this.labelParNomClient.Text = "Par nom client :";
            // 
            // textBoxRechercheNomCommercial
            // 
            this.textBoxRechercheNomCommercial.Location = new System.Drawing.Point(595, 110);
            this.textBoxRechercheNomCommercial.MaxLength = 50;
            this.textBoxRechercheNomCommercial.Name = "textBoxRechercheNomCommercial";
            this.textBoxRechercheNomCommercial.Size = new System.Drawing.Size(180, 20);
            this.textBoxRechercheNomCommercial.TabIndex = 58;
            // 
            // textBoxRechercheNomClient
            // 
            this.textBoxRechercheNomClient.Location = new System.Drawing.Point(202, 110);
            this.textBoxRechercheNomClient.MaxLength = 50;
            this.textBoxRechercheNomClient.Name = "textBoxRechercheNomClient";
            this.textBoxRechercheNomClient.Size = new System.Drawing.Size(180, 20);
            this.textBoxRechercheNomClient.TabIndex = 57;
            // 
            // labelRecherche
            // 
            this.labelRecherche.AutoSize = true;
            this.labelRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecherche.Location = new System.Drawing.Point(14, 70);
            this.labelRecherche.Name = "labelRecherche";
            this.labelRecherche.Size = new System.Drawing.Size(106, 20);
            this.labelRecherche.TabIndex = 56;
            this.labelRecherche.Text = "Recherche :";
            // 
            // buttonModifierSouhait
            // 
            this.buttonModifierSouhait.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModifierSouhait.Location = new System.Drawing.Point(904, 370);
            this.buttonModifierSouhait.Name = "buttonModifierSouhait";
            this.buttonModifierSouhait.Size = new System.Drawing.Size(225, 92);
            this.buttonModifierSouhait.TabIndex = 61;
            this.buttonModifierSouhait.Text = "Modifier";
            this.buttonModifierSouhait.UseVisualStyleBackColor = true;
            this.buttonModifierSouhait.Click += new System.EventHandler(this.buttonModifierSouhait_Click);
            // 
            // labelListePropositions
            // 
            this.labelListePropositions.AutoSize = true;
            this.labelListePropositions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListePropositions.Location = new System.Drawing.Point(14, 23);
            this.labelListePropositions.Name = "labelListePropositions";
            this.labelListePropositions.Size = new System.Drawing.Size(195, 20);
            this.labelListePropositions.TabIndex = 62;
            this.labelListePropositions.Text = "Liste des propositions :";
            // 
            // grilleVisites
            // 
            this.grilleVisites.AllowUserToAddRows = false;
            this.grilleVisites.AllowUserToDeleteRows = false;
            this.grilleVisites.AutoGenerateColumns = false;
            this.grilleVisites.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grilleVisites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilleVisites.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.acheteurDataGridViewTextBoxColumn,
            this.commercialDataGridViewTextBoxColumn,
            this.nUMEROBIENDataGridViewTextBoxColumn,
            this.villeBienDataGridViewTextBoxColumn,
            this.dATEPROPOSITIONVISITEDataGridViewTextBoxColumn,
            this.bienVisiteDataGridViewTextBoxColumn,
            this.dATEVISITEDataGridViewTextBoxColumn});
            this.grilleVisites.DataSource = this.vueVisiteBindingSource;
            this.grilleVisites.Location = new System.Drawing.Point(17, 148);
            this.grilleVisites.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grilleVisites.Name = "grilleVisites";
            this.grilleVisites.ReadOnly = true;
            this.grilleVisites.RowTemplate.Height = 28;
            this.grilleVisites.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grilleVisites.Size = new System.Drawing.Size(867, 488);
            this.grilleVisites.TabIndex = 63;
            // 
            // acheteurDataGridViewTextBoxColumn
            // 
            this.acheteurDataGridViewTextBoxColumn.DataPropertyName = "acheteur";
            this.acheteurDataGridViewTextBoxColumn.HeaderText = "ACHETEUR";
            this.acheteurDataGridViewTextBoxColumn.Name = "acheteurDataGridViewTextBoxColumn";
            this.acheteurDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // commercialDataGridViewTextBoxColumn
            // 
            this.commercialDataGridViewTextBoxColumn.DataPropertyName = "commercial";
            this.commercialDataGridViewTextBoxColumn.HeaderText = "COMMERCIAL";
            this.commercialDataGridViewTextBoxColumn.Name = "commercialDataGridViewTextBoxColumn";
            this.commercialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nUMEROBIENDataGridViewTextBoxColumn
            // 
            this.nUMEROBIENDataGridViewTextBoxColumn.DataPropertyName = "NUMERO_BIEN";
            this.nUMEROBIENDataGridViewTextBoxColumn.HeaderText = "N° BIEN";
            this.nUMEROBIENDataGridViewTextBoxColumn.Name = "nUMEROBIENDataGridViewTextBoxColumn";
            this.nUMEROBIENDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // villeBienDataGridViewTextBoxColumn
            // 
            this.villeBienDataGridViewTextBoxColumn.DataPropertyName = "villeBien";
            this.villeBienDataGridViewTextBoxColumn.HeaderText = "VILLE";
            this.villeBienDataGridViewTextBoxColumn.Name = "villeBienDataGridViewTextBoxColumn";
            this.villeBienDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dATEPROPOSITIONVISITEDataGridViewTextBoxColumn
            // 
            this.dATEPROPOSITIONVISITEDataGridViewTextBoxColumn.DataPropertyName = "DATE_PROPOSITION_VISITE";
            this.dATEPROPOSITIONVISITEDataGridViewTextBoxColumn.HeaderText = "DATE PROPOSITION";
            this.dATEPROPOSITIONVISITEDataGridViewTextBoxColumn.Name = "dATEPROPOSITIONVISITEDataGridViewTextBoxColumn";
            this.dATEPROPOSITIONVISITEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bienVisiteDataGridViewTextBoxColumn
            // 
            this.bienVisiteDataGridViewTextBoxColumn.DataPropertyName = "bienVisite";
            this.bienVisiteDataGridViewTextBoxColumn.HeaderText = "BIEN VISITE";
            this.bienVisiteDataGridViewTextBoxColumn.Name = "bienVisiteDataGridViewTextBoxColumn";
            this.bienVisiteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dATEVISITEDataGridViewTextBoxColumn
            // 
            this.dATEVISITEDataGridViewTextBoxColumn.DataPropertyName = "DATE_VISITE";
            this.dATEVISITEDataGridViewTextBoxColumn.HeaderText = "DATE DE VISITE";
            this.dATEVISITEDataGridViewTextBoxColumn.Name = "dATEVISITEDataGridViewTextBoxColumn";
            this.dATEVISITEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vueVisiteBindingSource
            // 
            this.vueVisiteBindingSource.DataSource = typeof(ProjetImmoBilly.vueVisite);
            // 
            // IGestiondesPropoVisites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 651);
            this.Controls.Add(this.grilleVisites);
            this.Controls.Add(this.labelListePropositions);
            this.Controls.Add(this.buttonModifierSouhait);
            this.Controls.Add(this.labelParNomCommercial);
            this.Controls.Add(this.labelParNomClient);
            this.Controls.Add(this.textBoxRechercheNomCommercial);
            this.Controls.Add(this.textBoxRechercheNomClient);
            this.Controls.Add(this.labelRecherche);
            this.Controls.Add(this.buttonNouvellePropoVisite);
            this.Controls.Add(this.labelImmoBilly);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.textBoxNomCommercial);
            this.Controls.Add(this.pictureBox1);
            this.Name = "IGestiondesPropoVisites";
            this.Text = "Gestion des propositions / visites";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilleVisites)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueVisiteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelImmoBilly;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.TextBox textBoxNomCommercial;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonNouvellePropoVisite;
        private System.Windows.Forms.Label labelParNomCommercial;
        private System.Windows.Forms.Label labelParNomClient;
        private System.Windows.Forms.TextBox textBoxRechercheNomCommercial;
        private System.Windows.Forms.TextBox textBoxRechercheNomClient;
        private System.Windows.Forms.Label labelRecherche;
        private System.Windows.Forms.Button buttonModifierSouhait;
        private System.Windows.Forms.Label labelListePropositions;
        private System.Windows.Forms.DataGridView grilleVisites;
        private System.Windows.Forms.DataGridViewTextBoxColumn acheteurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commercialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMEROBIENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeBienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATEPROPOSITIONVISITEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bienVisiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATEVISITEDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vueVisiteBindingSource;
    }
}