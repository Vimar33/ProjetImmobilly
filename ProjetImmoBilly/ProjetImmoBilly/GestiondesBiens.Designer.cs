namespace ProjetImmoBilly
{
    partial class IGestiondesBiens
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IGestiondesBiens));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBoxNomCommercial = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.checkBoxDisponible = new System.Windows.Forms.CheckBox();
            this.checkBoxVendu = new System.Windows.Forms.CheckBox();
            this.checkBoxRetire = new System.Windows.Forms.CheckBox();
            this.checkBoxSousSeing = new System.Windows.Forms.CheckBox();
            this.buttonNouveauBien = new System.Windows.Forms.Button();
            this.buttonModifierBien = new System.Windows.Forms.Button();
            this.buttonSupprimerBien = new System.Windows.Forms.Button();
            this.labelStatut = new System.Windows.Forms.Label();
            this.labelRecherche = new System.Windows.Forms.Label();
            this.textBoxNumBien = new System.Windows.Forms.TextBox();
            this.textBoxNomVille = new System.Windows.Forms.TextBox();
            this.labelParNuméro = new System.Windows.Forms.Label();
            this.labelParVille = new System.Windows.Forms.Label();
            this.labelImmoBilly = new System.Windows.Forms.Label();
            this.labelListeBien = new System.Windows.Forms.Label();
            this.dataGridViewBien = new System.Windows.Forms.DataGridView();
            this.nUMEROBIENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vILLESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sURFACEHABITABLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBREPIECEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gARAGEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAVEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRIXVENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATEMISEENVENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTATUTBIENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bIENSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIENSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNomCommercial
            // 
            this.textBoxNomCommercial.Location = new System.Drawing.Point(904, 136);
            this.textBoxNomCommercial.Name = "textBoxNomCommercial";
            this.textBoxNomCommercial.ReadOnly = true;
            this.textBoxNomCommercial.Size = new System.Drawing.Size(225, 20);
            this.textBoxNomCommercial.TabIndex = 15;
            this.textBoxNomCommercial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(904, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // buttonReturn
            // 
            this.buttonReturn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturn.Location = new System.Drawing.Point(904, 174);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(225, 92);
            this.buttonReturn.TabIndex = 18;
            this.buttonReturn.Text = "Retour accueil gestions";
            this.buttonReturn.UseVisualStyleBackColor = true;
            // 
            // checkBoxDisponible
            // 
            this.checkBoxDisponible.AutoSize = true;
            this.checkBoxDisponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDisponible.Location = new System.Drawing.Point(141, 167);
            this.checkBoxDisponible.Name = "checkBoxDisponible";
            this.checkBoxDisponible.Size = new System.Drawing.Size(110, 24);
            this.checkBoxDisponible.TabIndex = 20;
            this.checkBoxDisponible.Text = ": Disponible";
            this.checkBoxDisponible.UseVisualStyleBackColor = true;
            // 
            // checkBoxVendu
            // 
            this.checkBoxVendu.AutoSize = true;
            this.checkBoxVendu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxVendu.Location = new System.Drawing.Point(321, 167);
            this.checkBoxVendu.Name = "checkBoxVendu";
            this.checkBoxVendu.Size = new System.Drawing.Size(83, 24);
            this.checkBoxVendu.TabIndex = 21;
            this.checkBoxVendu.Text = ": Vendu";
            this.checkBoxVendu.UseVisualStyleBackColor = true;
            // 
            // checkBoxRetire
            // 
            this.checkBoxRetire.AutoSize = true;
            this.checkBoxRetire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRetire.Location = new System.Drawing.Point(489, 167);
            this.checkBoxRetire.Name = "checkBoxRetire";
            this.checkBoxRetire.Size = new System.Drawing.Size(79, 24);
            this.checkBoxRetire.TabIndex = 22;
            this.checkBoxRetire.Text = ": Retiré";
            this.checkBoxRetire.UseVisualStyleBackColor = true;
            // 
            // checkBoxSousSeing
            // 
            this.checkBoxSousSeing.AutoSize = true;
            this.checkBoxSousSeing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSousSeing.Location = new System.Drawing.Point(669, 167);
            this.checkBoxSousSeing.Name = "checkBoxSousSeing";
            this.checkBoxSousSeing.Size = new System.Drawing.Size(116, 24);
            this.checkBoxSousSeing.TabIndex = 23;
            this.checkBoxSousSeing.Text = ": Sous-seing";
            this.checkBoxSousSeing.UseVisualStyleBackColor = true;
            // 
            // buttonNouveauBien
            // 
            this.buttonNouveauBien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNouveauBien.Location = new System.Drawing.Point(904, 272);
            this.buttonNouveauBien.Name = "buttonNouveauBien";
            this.buttonNouveauBien.Size = new System.Drawing.Size(225, 92);
            this.buttonNouveauBien.TabIndex = 24;
            this.buttonNouveauBien.Text = "Nouveau";
            this.buttonNouveauBien.UseVisualStyleBackColor = true;
            this.buttonNouveauBien.Click += new System.EventHandler(this.buttonNouveau_Click);
            // 
            // buttonModifierBien
            // 
            this.buttonModifierBien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModifierBien.Location = new System.Drawing.Point(904, 370);
            this.buttonModifierBien.Name = "buttonModifierBien";
            this.buttonModifierBien.Size = new System.Drawing.Size(225, 92);
            this.buttonModifierBien.TabIndex = 25;
            this.buttonModifierBien.Text = "Modifier";
            this.buttonModifierBien.UseVisualStyleBackColor = true;
            this.buttonModifierBien.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // buttonSupprimerBien
            // 
            this.buttonSupprimerBien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSupprimerBien.Location = new System.Drawing.Point(904, 468);
            this.buttonSupprimerBien.Name = "buttonSupprimerBien";
            this.buttonSupprimerBien.Size = new System.Drawing.Size(225, 92);
            this.buttonSupprimerBien.TabIndex = 26;
            this.buttonSupprimerBien.Text = "Supprimer";
            this.buttonSupprimerBien.UseVisualStyleBackColor = true;
            this.buttonSupprimerBien.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // labelStatut
            // 
            this.labelStatut.AutoSize = true;
            this.labelStatut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatut.Location = new System.Drawing.Point(55, 133);
            this.labelStatut.Name = "labelStatut";
            this.labelStatut.Size = new System.Drawing.Size(69, 20);
            this.labelStatut.TabIndex = 27;
            this.labelStatut.Text = "Statut :";
            // 
            // labelRecherche
            // 
            this.labelRecherche.AutoSize = true;
            this.labelRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecherche.Location = new System.Drawing.Point(55, 55);
            this.labelRecherche.Name = "labelRecherche";
            this.labelRecherche.Size = new System.Drawing.Size(106, 20);
            this.labelRecherche.TabIndex = 28;
            this.labelRecherche.Text = "Recherche :";
            // 
            // textBoxNumBien
            // 
            this.textBoxNumBien.Location = new System.Drawing.Point(227, 93);
            this.textBoxNumBien.MaxLength = 10;
            this.textBoxNumBien.Name = "textBoxNumBien";
            this.textBoxNumBien.Size = new System.Drawing.Size(180, 20);
            this.textBoxNumBien.TabIndex = 29;
            // 
            // textBoxNomVille
            // 
            this.textBoxNomVille.Location = new System.Drawing.Point(554, 95);
            this.textBoxNomVille.MaxLength = 50;
            this.textBoxNomVille.Name = "textBoxNomVille";
            this.textBoxNomVille.Size = new System.Drawing.Size(180, 20);
            this.textBoxNomVille.TabIndex = 30;
            // 
            // labelParNuméro
            // 
            this.labelParNuméro.AutoSize = true;
            this.labelParNuméro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParNuméro.Location = new System.Drawing.Point(120, 93);
            this.labelParNuméro.Name = "labelParNuméro";
            this.labelParNuméro.Size = new System.Drawing.Size(101, 20);
            this.labelParNuméro.TabIndex = 31;
            this.labelParNuméro.Text = "Par Numéro :";
            // 
            // labelParVille
            // 
            this.labelParVille.AutoSize = true;
            this.labelParVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParVille.Location = new System.Drawing.Point(470, 93);
            this.labelParVille.Name = "labelParVille";
            this.labelParVille.Size = new System.Drawing.Size(74, 20);
            this.labelParVille.TabIndex = 32;
            this.labelParVille.Text = "Par Ville :";
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
            this.labelImmoBilly.TabIndex = 33;
            this.labelImmoBilly.Text = "Immo Billy";
            // 
            // labelListeBien
            // 
            this.labelListeBien.AutoSize = true;
            this.labelListeBien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListeBien.Location = new System.Drawing.Point(51, 12);
            this.labelListeBien.Name = "labelListeBien";
            this.labelListeBien.Size = new System.Drawing.Size(140, 20);
            this.labelListeBien.TabIndex = 63;
            this.labelListeBien.Text = "Liste des biens :";
            // 
            // dataGridViewBien
            // 
            this.dataGridViewBien.AutoGenerateColumns = false;
            this.dataGridViewBien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nUMEROBIENDataGridViewTextBoxColumn,
            this.vILLESDataGridViewTextBoxColumn,
            this.sURFACEHABITABLEDataGridViewTextBoxColumn,
            this.nOMBREPIECEDataGridViewTextBoxColumn,
            this.gARAGEDataGridViewTextBoxColumn,
            this.cAVEDataGridViewTextBoxColumn,
            this.pRIXVENTEDataGridViewTextBoxColumn,
            this.dATEMISEENVENTEDataGridViewTextBoxColumn,
            this.sTATUTBIENDataGridViewTextBoxColumn});
            this.dataGridViewBien.DataSource = this.bIENSBindingSource;
            this.dataGridViewBien.Location = new System.Drawing.Point(55, 209);
            this.dataGridViewBien.Name = "dataGridViewBien";
            this.dataGridViewBien.Size = new System.Drawing.Size(744, 351);
            this.dataGridViewBien.TabIndex = 64;
            // 
            // nUMEROBIENDataGridViewTextBoxColumn
            // 
            this.nUMEROBIENDataGridViewTextBoxColumn.DataPropertyName = "NUMERO_BIEN";
            this.nUMEROBIENDataGridViewTextBoxColumn.HeaderText = "N°";
            this.nUMEROBIENDataGridViewTextBoxColumn.Name = "nUMEROBIENDataGridViewTextBoxColumn";
            this.nUMEROBIENDataGridViewTextBoxColumn.Width = 30;
            // 
            // vILLESDataGridViewTextBoxColumn
            // 
            this.vILLESDataGridViewTextBoxColumn.DataPropertyName = "VILLES";
            this.vILLESDataGridViewTextBoxColumn.HeaderText = "Villes";
            this.vILLESDataGridViewTextBoxColumn.Name = "vILLESDataGridViewTextBoxColumn";
            this.vILLESDataGridViewTextBoxColumn.Width = 200;
            // 
            // sURFACEHABITABLEDataGridViewTextBoxColumn
            // 
            this.sURFACEHABITABLEDataGridViewTextBoxColumn.DataPropertyName = "SURFACE_HABITABLE";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.sURFACEHABITABLEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.sURFACEHABITABLEDataGridViewTextBoxColumn.HeaderText = "Surf. hab m²";
            this.sURFACEHABITABLEDataGridViewTextBoxColumn.Name = "sURFACEHABITABLEDataGridViewTextBoxColumn";
            this.sURFACEHABITABLEDataGridViewTextBoxColumn.Width = 60;
            // 
            // nOMBREPIECEDataGridViewTextBoxColumn
            // 
            this.nOMBREPIECEDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE_PIECE";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nOMBREPIECEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.nOMBREPIECEDataGridViewTextBoxColumn.HeaderText = "Nb pièces";
            this.nOMBREPIECEDataGridViewTextBoxColumn.Name = "nOMBREPIECEDataGridViewTextBoxColumn";
            this.nOMBREPIECEDataGridViewTextBoxColumn.Width = 50;
            // 
            // gARAGEDataGridViewTextBoxColumn
            // 
            this.gARAGEDataGridViewTextBoxColumn.DataPropertyName = "GARAGE";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gARAGEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.gARAGEDataGridViewTextBoxColumn.HeaderText = "Garage";
            this.gARAGEDataGridViewTextBoxColumn.Name = "gARAGEDataGridViewTextBoxColumn";
            this.gARAGEDataGridViewTextBoxColumn.Width = 50;
            // 
            // cAVEDataGridViewTextBoxColumn
            // 
            this.cAVEDataGridViewTextBoxColumn.DataPropertyName = "CAVE";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cAVEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.cAVEDataGridViewTextBoxColumn.HeaderText = "Cave";
            this.cAVEDataGridViewTextBoxColumn.Name = "cAVEDataGridViewTextBoxColumn";
            this.cAVEDataGridViewTextBoxColumn.Width = 50;
            // 
            // pRIXVENTEDataGridViewTextBoxColumn
            // 
            this.pRIXVENTEDataGridViewTextBoxColumn.DataPropertyName = "PRIX_VENTE";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.pRIXVENTEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.pRIXVENTEDataGridViewTextBoxColumn.HeaderText = "Prix €";
            this.pRIXVENTEDataGridViewTextBoxColumn.Name = "pRIXVENTEDataGridViewTextBoxColumn";
            this.pRIXVENTEDataGridViewTextBoxColumn.Width = 80;
            // 
            // dATEMISEENVENTEDataGridViewTextBoxColumn
            // 
            this.dATEMISEENVENTEDataGridViewTextBoxColumn.DataPropertyName = "DATE_MISE_EN_VENTE";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dATEMISEENVENTEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.dATEMISEENVENTEDataGridViewTextBoxColumn.HeaderText = "Date mise en vente";
            this.dATEMISEENVENTEDataGridViewTextBoxColumn.Name = "dATEMISEENVENTEDataGridViewTextBoxColumn";
            this.dATEMISEENVENTEDataGridViewTextBoxColumn.Width = 90;
            // 
            // sTATUTBIENDataGridViewTextBoxColumn
            // 
            this.sTATUTBIENDataGridViewTextBoxColumn.DataPropertyName = "STATUT_BIEN";
            this.sTATUTBIENDataGridViewTextBoxColumn.HeaderText = "Statut";
            this.sTATUTBIENDataGridViewTextBoxColumn.Name = "sTATUTBIENDataGridViewTextBoxColumn";
            this.sTATUTBIENDataGridViewTextBoxColumn.Width = 91;
            // 
            // bIENSBindingSource
            // 
            this.bIENSBindingSource.DataSource = typeof(ProjetImmoBilly.BIENS);
            // 
            // IGestiondesBiens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 584);
            this.Controls.Add(this.dataGridViewBien);
            this.Controls.Add(this.labelListeBien);
            this.Controls.Add(this.labelImmoBilly);
            this.Controls.Add(this.labelParVille);
            this.Controls.Add(this.labelParNuméro);
            this.Controls.Add(this.textBoxNomVille);
            this.Controls.Add(this.textBoxNumBien);
            this.Controls.Add(this.labelRecherche);
            this.Controls.Add(this.labelStatut);
            this.Controls.Add(this.buttonSupprimerBien);
            this.Controls.Add(this.buttonModifierBien);
            this.Controls.Add(this.buttonNouveauBien);
            this.Controls.Add(this.checkBoxSousSeing);
            this.Controls.Add(this.checkBoxRetire);
            this.Controls.Add(this.checkBoxVendu);
            this.Controls.Add(this.checkBoxDisponible);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.textBoxNomCommercial);
            this.Controls.Add(this.pictureBox1);
            this.Name = "IGestiondesBiens";
            this.Text = "Gestions des biens";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIENSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNomCommercial;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.CheckBox checkBoxDisponible;
        private System.Windows.Forms.CheckBox checkBoxVendu;
        private System.Windows.Forms.CheckBox checkBoxRetire;
        private System.Windows.Forms.CheckBox checkBoxSousSeing;
        private System.Windows.Forms.Button buttonNouveauBien;
        private System.Windows.Forms.Button buttonModifierBien;
        private System.Windows.Forms.Button buttonSupprimerBien;
        private System.Windows.Forms.Label labelStatut;
        private System.Windows.Forms.Label labelRecherche;
        private System.Windows.Forms.TextBox textBoxNumBien;
        private System.Windows.Forms.TextBox textBoxNomVille;
        private System.Windows.Forms.Label labelParNuméro;
        private System.Windows.Forms.Label labelParVille;
        private System.Windows.Forms.Label labelImmoBilly;
        private System.Windows.Forms.Label labelListeBien;
        private System.Windows.Forms.DataGridView dataGridViewBien;
        private System.Windows.Forms.BindingSource bIENSBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMEROBIENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vILLESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sURFACEHABITABLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREPIECEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gARAGEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAVEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRIXVENTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATEMISEENVENTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTATUTBIENDataGridViewTextBoxColumn;
    }
}