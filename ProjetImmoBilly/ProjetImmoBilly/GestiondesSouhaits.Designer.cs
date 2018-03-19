namespace ProjetImmoBilly
{
    partial class IGestiondesSouhaits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IGestiondesSouhaits));
            this.labelImmoBilly = new System.Windows.Forms.Label();
            this.buttonModifierSouhait = new System.Windows.Forms.Button();
            this.buttonNouveauSouhait = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.textBoxNomCommercial = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelParNom = new System.Windows.Forms.Label();
            this.textBoxNomAcheteur = new System.Windows.Forms.TextBox();
            this.labelSouhaitUNacheteur = new System.Windows.Forms.Label();
            this.checkBoxMesAcheteurs = new System.Windows.Forms.CheckBox();
            this.labelListeAcheteurs = new System.Windows.Forms.Label();
            this.grilleAcheteurs = new System.Windows.Forms.DataGridView();
            this.nUMEROACHETEURDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMACHETEURDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRENOMACHETEURDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vILLESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMMERCIAUX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCHETEURSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectionStatutSouhait = new System.Windows.Forms.ComboBox();
            this.grilleSouhaitsAcheteur = new System.Windows.Forms.DataGridView();
            this.nUMEROSOUHAITDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTATUTSOUHAITDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vILLESDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOUHAITSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCreerAcheteur = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilleAcheteurs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCHETEURSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilleSouhaitsAcheteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOUHAITSBindingSource)).BeginInit();
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
            this.labelImmoBilly.TabIndex = 40;
            this.labelImmoBilly.Text = "Immo Billy";
            // 
            // buttonModifierSouhait
            // 
            this.buttonModifierSouhait.Enabled = false;
            this.buttonModifierSouhait.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModifierSouhait.Location = new System.Drawing.Point(904, 524);
            this.buttonModifierSouhait.Name = "buttonModifierSouhait";
            this.buttonModifierSouhait.Size = new System.Drawing.Size(225, 92);
            this.buttonModifierSouhait.TabIndex = 38;
            this.buttonModifierSouhait.Text = "Modifier un souhait";
            this.buttonModifierSouhait.UseVisualStyleBackColor = true;
            this.buttonModifierSouhait.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // buttonNouveauSouhait
            // 
            this.buttonNouveauSouhait.Enabled = false;
            this.buttonNouveauSouhait.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNouveauSouhait.Location = new System.Drawing.Point(904, 426);
            this.buttonNouveauSouhait.Name = "buttonNouveauSouhait";
            this.buttonNouveauSouhait.Size = new System.Drawing.Size(225, 92);
            this.buttonNouveauSouhait.TabIndex = 37;
            this.buttonNouveauSouhait.Text = "Nouveau souhait";
            this.buttonNouveauSouhait.UseVisualStyleBackColor = true;
            this.buttonNouveauSouhait.Click += new System.EventHandler(this.buttonNouveau_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturn.Location = new System.Drawing.Point(904, 174);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(225, 92);
            this.buttonReturn.TabIndex = 36;
            this.buttonReturn.Text = "Retour accueil gestions";
            this.buttonReturn.UseVisualStyleBackColor = true;
            // 
            // textBoxNomCommercial
            // 
            this.textBoxNomCommercial.Location = new System.Drawing.Point(904, 136);
            this.textBoxNomCommercial.Name = "textBoxNomCommercial";
            this.textBoxNomCommercial.ReadOnly = true;
            this.textBoxNomCommercial.Size = new System.Drawing.Size(225, 20);
            this.textBoxNomCommercial.TabIndex = 35;
            this.textBoxNomCommercial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(904, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // labelParNom
            // 
            this.labelParNom.AutoSize = true;
            this.labelParNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParNom.Location = new System.Drawing.Point(265, 66);
            this.labelParNom.Name = "labelParNom";
            this.labelParNom.Size = new System.Drawing.Size(153, 20);
            this.labelParNom.TabIndex = 46;
            this.labelParNom.Text = "Recherche par nom:";
            // 
            // textBoxNomAcheteur
            // 
            this.textBoxNomAcheteur.Location = new System.Drawing.Point(424, 67);
            this.textBoxNomAcheteur.MaxLength = 50;
            this.textBoxNomAcheteur.Name = "textBoxNomAcheteur";
            this.textBoxNomAcheteur.Size = new System.Drawing.Size(180, 20);
            this.textBoxNomAcheteur.TabIndex = 45;
            this.textBoxNomAcheteur.TextChanged += new System.EventHandler(this.textBoxNomAcheteur_TextChanged);
            // 
            // labelSouhaitUNacheteur
            // 
            this.labelSouhaitUNacheteur.AutoSize = true;
            this.labelSouhaitUNacheteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSouhaitUNacheteur.Location = new System.Drawing.Point(12, 401);
            this.labelSouhaitUNacheteur.Name = "labelSouhaitUNacheteur";
            this.labelSouhaitUNacheteur.Size = new System.Drawing.Size(231, 20);
            this.labelSouhaitUNacheteur.TabIndex = 43;
            this.labelSouhaitUNacheteur.Text = "Liste souhait de l\'acheteur :";
            // 
            // checkBoxMesAcheteurs
            // 
            this.checkBoxMesAcheteurs.AutoSize = true;
            this.checkBoxMesAcheteurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMesAcheteurs.Location = new System.Drawing.Point(48, 64);
            this.checkBoxMesAcheteurs.Name = "checkBoxMesAcheteurs";
            this.checkBoxMesAcheteurs.Size = new System.Drawing.Size(141, 24);
            this.checkBoxMesAcheteurs.TabIndex = 42;
            this.checkBoxMesAcheteurs.Text = ": Mes acheteurs";
            this.checkBoxMesAcheteurs.UseVisualStyleBackColor = true;
            // 
            // labelListeAcheteurs
            // 
            this.labelListeAcheteurs.AutoSize = true;
            this.labelListeAcheteurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListeAcheteurs.Location = new System.Drawing.Point(12, 23);
            this.labelListeAcheteurs.Name = "labelListeAcheteurs";
            this.labelListeAcheteurs.Size = new System.Drawing.Size(177, 20);
            this.labelListeAcheteurs.TabIndex = 50;
            this.labelListeAcheteurs.Text = "Liste des acheteurs :";
            // 
            // grilleAcheteurs
            // 
            this.grilleAcheteurs.AllowUserToAddRows = false;
            this.grilleAcheteurs.AllowUserToDeleteRows = false;
            this.grilleAcheteurs.AutoGenerateColumns = false;
            this.grilleAcheteurs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grilleAcheteurs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grilleAcheteurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilleAcheteurs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nUMEROACHETEURDataGridViewTextBoxColumn,
            this.nOMACHETEURDataGridViewTextBoxColumn,
            this.pRENOMACHETEURDataGridViewTextBoxColumn,
            this.vILLESDataGridViewTextBoxColumn,
            this.COMMERCIAUX});
            this.grilleAcheteurs.DataSource = this.aCHETEURSBindingSource;
            this.grilleAcheteurs.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grilleAcheteurs.Location = new System.Drawing.Point(16, 96);
            this.grilleAcheteurs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grilleAcheteurs.Name = "grilleAcheteurs";
            this.grilleAcheteurs.ReadOnly = true;
            this.grilleAcheteurs.RowTemplate.Height = 33;
            this.grilleAcheteurs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grilleAcheteurs.Size = new System.Drawing.Size(798, 282);
            this.grilleAcheteurs.TabIndex = 51;
            this.grilleAcheteurs.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grilleAcheteurs_RowEnter);
            this.grilleAcheteurs.SelectionChanged += new System.EventHandler(this.grilleAcheteurs_SelectionChanged);
            this.grilleAcheteurs.DoubleClick += new System.EventHandler(this.grilleAcheteurs_DoubleClick);
            // 
            // nUMEROACHETEURDataGridViewTextBoxColumn
            // 
            this.nUMEROACHETEURDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nUMEROACHETEURDataGridViewTextBoxColumn.DataPropertyName = "NUMERO_ACHETEUR";
            this.nUMEROACHETEURDataGridViewTextBoxColumn.FillWeight = 126.9036F;
            this.nUMEROACHETEURDataGridViewTextBoxColumn.HeaderText = "N°";
            this.nUMEROACHETEURDataGridViewTextBoxColumn.Name = "nUMEROACHETEURDataGridViewTextBoxColumn";
            this.nUMEROACHETEURDataGridViewTextBoxColumn.ReadOnly = true;
            this.nUMEROACHETEURDataGridViewTextBoxColumn.Width = 44;
            // 
            // nOMACHETEURDataGridViewTextBoxColumn
            // 
            this.nOMACHETEURDataGridViewTextBoxColumn.DataPropertyName = "NOM_ACHETEUR";
            this.nOMACHETEURDataGridViewTextBoxColumn.FillWeight = 93.27411F;
            this.nOMACHETEURDataGridViewTextBoxColumn.HeaderText = "NOM";
            this.nOMACHETEURDataGridViewTextBoxColumn.Name = "nOMACHETEURDataGridViewTextBoxColumn";
            this.nOMACHETEURDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRENOMACHETEURDataGridViewTextBoxColumn
            // 
            this.pRENOMACHETEURDataGridViewTextBoxColumn.DataPropertyName = "PRENOM_ACHETEUR";
            this.pRENOMACHETEURDataGridViewTextBoxColumn.FillWeight = 93.27411F;
            this.pRENOMACHETEURDataGridViewTextBoxColumn.HeaderText = "PRENOM";
            this.pRENOMACHETEURDataGridViewTextBoxColumn.Name = "pRENOMACHETEURDataGridViewTextBoxColumn";
            this.pRENOMACHETEURDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vILLESDataGridViewTextBoxColumn
            // 
            this.vILLESDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.vILLESDataGridViewTextBoxColumn.DataPropertyName = "VILLES";
            this.vILLESDataGridViewTextBoxColumn.FillWeight = 93.27411F;
            this.vILLESDataGridViewTextBoxColumn.HeaderText = "VILLE";
            this.vILLESDataGridViewTextBoxColumn.Name = "vILLESDataGridViewTextBoxColumn";
            this.vILLESDataGridViewTextBoxColumn.ReadOnly = true;
            this.vILLESDataGridViewTextBoxColumn.Width = 61;
            // 
            // COMMERCIAUX
            // 
            this.COMMERCIAUX.DataPropertyName = "COMMERCIAUX";
            this.COMMERCIAUX.FillWeight = 93.27411F;
            this.COMMERCIAUX.HeaderText = "COMMERCIAL EN CHARGE";
            this.COMMERCIAUX.Name = "COMMERCIAUX";
            this.COMMERCIAUX.ReadOnly = true;
            // 
            // aCHETEURSBindingSource
            // 
            this.aCHETEURSBindingSource.DataSource = typeof(ProjetImmoBilly.ACHETEURS);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "COMMERCIAUX";
            this.dataGridViewTextBoxColumn1.HeaderText = "COMMERCIAL EN CHARGE";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 1552;
            // 
            // selectionStatutSouhait
            // 
            this.selectionStatutSouhait.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectionStatutSouhait.Enabled = false;
            this.selectionStatutSouhait.FormattingEnabled = true;
            this.selectionStatutSouhait.Location = new System.Drawing.Point(16, 440);
            this.selectionStatutSouhait.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.selectionStatutSouhait.Name = "selectionStatutSouhait";
            this.selectionStatutSouhait.Size = new System.Drawing.Size(199, 21);
            this.selectionStatutSouhait.TabIndex = 52;
            this.selectionStatutSouhait.SelectedIndexChanged += new System.EventHandler(this.selectionStatutSouhait_SelectedIndexChanged);
            // 
            // grilleSouhaitsAcheteur
            // 
            this.grilleSouhaitsAcheteur.AllowUserToAddRows = false;
            this.grilleSouhaitsAcheteur.AllowUserToDeleteRows = false;
            this.grilleSouhaitsAcheteur.AutoGenerateColumns = false;
            this.grilleSouhaitsAcheteur.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grilleSouhaitsAcheteur.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grilleSouhaitsAcheteur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilleSouhaitsAcheteur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nUMEROSOUHAITDataGridViewTextBoxColumn,
            this.sTATUTSOUHAITDataGridViewTextBoxColumn,
            this.vILLESDataGridViewTextBoxColumn1});
            this.grilleSouhaitsAcheteur.DataSource = this.sOUHAITSBindingSource;
            this.grilleSouhaitsAcheteur.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grilleSouhaitsAcheteur.Enabled = false;
            this.grilleSouhaitsAcheteur.Location = new System.Drawing.Point(234, 401);
            this.grilleSouhaitsAcheteur.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grilleSouhaitsAcheteur.Name = "grilleSouhaitsAcheteur";
            this.grilleSouhaitsAcheteur.ReadOnly = true;
            this.grilleSouhaitsAcheteur.RowTemplate.Height = 33;
            this.grilleSouhaitsAcheteur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grilleSouhaitsAcheteur.Size = new System.Drawing.Size(579, 233);
            this.grilleSouhaitsAcheteur.TabIndex = 53;
            this.grilleSouhaitsAcheteur.SelectionChanged += new System.EventHandler(this.grilleSouhaitsAcheteur_SelectionChanged);
            // 
            // nUMEROSOUHAITDataGridViewTextBoxColumn
            // 
            this.nUMEROSOUHAITDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nUMEROSOUHAITDataGridViewTextBoxColumn.DataPropertyName = "NUMERO_SOUHAIT";
            this.nUMEROSOUHAITDataGridViewTextBoxColumn.HeaderText = "N°";
            this.nUMEROSOUHAITDataGridViewTextBoxColumn.Name = "nUMEROSOUHAITDataGridViewTextBoxColumn";
            this.nUMEROSOUHAITDataGridViewTextBoxColumn.ReadOnly = true;
            this.nUMEROSOUHAITDataGridViewTextBoxColumn.Width = 44;
            // 
            // sTATUTSOUHAITDataGridViewTextBoxColumn
            // 
            this.sTATUTSOUHAITDataGridViewTextBoxColumn.DataPropertyName = "STATUT_SOUHAIT";
            this.sTATUTSOUHAITDataGridViewTextBoxColumn.HeaderText = "STATUT";
            this.sTATUTSOUHAITDataGridViewTextBoxColumn.Name = "sTATUTSOUHAITDataGridViewTextBoxColumn";
            this.sTATUTSOUHAITDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vILLESDataGridViewTextBoxColumn1
            // 
            this.vILLESDataGridViewTextBoxColumn1.DataPropertyName = "VILLES";
            this.vILLESDataGridViewTextBoxColumn1.HeaderText = "VILLE";
            this.vILLESDataGridViewTextBoxColumn1.Name = "vILLESDataGridViewTextBoxColumn1";
            this.vILLESDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // sOUHAITSBindingSource
            // 
            this.sOUHAITSBindingSource.DataSource = typeof(ProjetImmoBilly.SOUHAITS);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "COMMERCIAUX";
            this.dataGridViewTextBoxColumn2.HeaderText = "COMMERCIAL EN CHARGE";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 755;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "COMMERCIAUX";
            this.dataGridViewTextBoxColumn3.FillWeight = 93.27411F;
            this.dataGridViewTextBoxColumn3.HeaderText = "COMMERCIAL EN CHARGE";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 755;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "COMMERCIAUX";
            this.dataGridViewTextBoxColumn4.FillWeight = 93.27411F;
            this.dataGridViewTextBoxColumn4.HeaderText = "COMMERCIAL EN CHARGE";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 755;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "COMMERCIAUX";
            this.dataGridViewTextBoxColumn5.FillWeight = 93.27411F;
            this.dataGridViewTextBoxColumn5.HeaderText = "COMMERCIAL EN CHARGE";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // buttonCreerAcheteur
            // 
            this.buttonCreerAcheteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreerAcheteur.Location = new System.Drawing.Point(904, 273);
            this.buttonCreerAcheteur.Name = "buttonCreerAcheteur";
            this.buttonCreerAcheteur.Size = new System.Drawing.Size(225, 92);
            this.buttonCreerAcheteur.TabIndex = 54;
            this.buttonCreerAcheteur.Text = "Créer un acheteur";
            this.buttonCreerAcheteur.UseVisualStyleBackColor = true;
            this.buttonCreerAcheteur.Click += new System.EventHandler(this.buttonCreerAcheteur_Click);
            // 
            // IGestiondesSouhaits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 650);
            this.Controls.Add(this.buttonCreerAcheteur);
            this.Controls.Add(this.grilleSouhaitsAcheteur);
            this.Controls.Add(this.selectionStatutSouhait);
            this.Controls.Add(this.grilleAcheteurs);
            this.Controls.Add(this.labelListeAcheteurs);
            this.Controls.Add(this.labelParNom);
            this.Controls.Add(this.textBoxNomAcheteur);
            this.Controls.Add(this.labelSouhaitUNacheteur);
            this.Controls.Add(this.checkBoxMesAcheteurs);
            this.Controls.Add(this.labelImmoBilly);
            this.Controls.Add(this.buttonModifierSouhait);
            this.Controls.Add(this.buttonNouveauSouhait);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.textBoxNomCommercial);
            this.Controls.Add(this.pictureBox1);
            this.Name = "IGestiondesSouhaits";
            this.Text = "Gestion des Souhaits";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilleAcheteurs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCHETEURSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilleSouhaitsAcheteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOUHAITSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelImmoBilly;
        private System.Windows.Forms.Button buttonModifierSouhait;
        private System.Windows.Forms.Button buttonNouveauSouhait;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.TextBox textBoxNomCommercial;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelParNom;
        private System.Windows.Forms.TextBox textBoxNomAcheteur;
        private System.Windows.Forms.Label labelSouhaitUNacheteur;
        private System.Windows.Forms.CheckBox checkBoxMesAcheteurs;
        private System.Windows.Forms.Label labelListeAcheteurs;
        private System.Windows.Forms.DataGridView grilleAcheteurs;
        private System.Windows.Forms.BindingSource aCHETEURSBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.ComboBox selectionStatutSouhait;
        private System.Windows.Forms.DataGridView grilleSouhaitsAcheteur;
        private System.Windows.Forms.BindingSource sOUHAITSBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMEROSOUHAITDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTATUTSOUHAITDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vILLESDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMEROACHETEURDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMACHETEURDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRENOMACHETEURDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vILLESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMMERCIAUX;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button buttonCreerAcheteur;
    }
}