namespace ProjetImmoBilly
{
    partial class IGestions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IGestions));
            this.labelImmoBilly = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonGestiondesBiens = new System.Windows.Forms.Button();
            this.textBoxNomCommercial = new System.Windows.Forms.TextBox();
            this.buttonGestiondesSouhaits = new System.Windows.Forms.Button();
            this.buttonGestiondesVisites = new System.Windows.Forms.Button();
            this.buttonGestiondesCommerciaux = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelImmoBilly
            // 
            this.labelImmoBilly.AutoSize = true;
            this.labelImmoBilly.BackColor = System.Drawing.Color.DimGray;
            this.labelImmoBilly.Font = new System.Drawing.Font("Lucida Console", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImmoBilly.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelImmoBilly.Location = new System.Drawing.Point(303, 24);
            this.labelImmoBilly.Name = "labelImmoBilly";
            this.labelImmoBilly.Size = new System.Drawing.Size(118, 16);
            this.labelImmoBilly.TabIndex = 8;
            this.labelImmoBilly.Text = "Immo Billy";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(297, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // buttonGestiondesBiens
            // 
            this.buttonGestiondesBiens.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGestiondesBiens.Location = new System.Drawing.Point(52, 136);
            this.buttonGestiondesBiens.Name = "buttonGestiondesBiens";
            this.buttonGestiondesBiens.Size = new System.Drawing.Size(225, 152);
            this.buttonGestiondesBiens.TabIndex = 9;
            this.buttonGestiondesBiens.Text = "Gestion des biens";
            this.buttonGestiondesBiens.UseVisualStyleBackColor = true;
            this.buttonGestiondesBiens.Click += new System.EventHandler(this.buttonGestiondesBiens_Click);
            // 
            // textBoxNomCommercial
            // 
            this.textBoxNomCommercial.Location = new System.Drawing.Point(52, 12);
            this.textBoxNomCommercial.Name = "textBoxNomCommercial";
            this.textBoxNomCommercial.ReadOnly = true;
            this.textBoxNomCommercial.Size = new System.Drawing.Size(225, 20);
            this.textBoxNomCommercial.TabIndex = 13;
            this.textBoxNomCommercial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonGestiondesSouhaits
            // 
            this.buttonGestiondesSouhaits.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGestiondesSouhaits.Location = new System.Drawing.Point(297, 136);
            this.buttonGestiondesSouhaits.Name = "buttonGestiondesSouhaits";
            this.buttonGestiondesSouhaits.Size = new System.Drawing.Size(225, 152);
            this.buttonGestiondesSouhaits.TabIndex = 14;
            this.buttonGestiondesSouhaits.Text = "Gestion des souhaits";
            this.buttonGestiondesSouhaits.UseVisualStyleBackColor = true;
            this.buttonGestiondesSouhaits.Click += new System.EventHandler(this.buttonGestiondesSouhaits_Click);
            // 
            // buttonGestiondesVisites
            // 
            this.buttonGestiondesVisites.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGestiondesVisites.Location = new System.Drawing.Point(297, 306);
            this.buttonGestiondesVisites.Name = "buttonGestiondesVisites";
            this.buttonGestiondesVisites.Size = new System.Drawing.Size(225, 152);
            this.buttonGestiondesVisites.TabIndex = 15;
            this.buttonGestiondesVisites.Text = "Gestion des visites";
            this.buttonGestiondesVisites.UseVisualStyleBackColor = true;
            this.buttonGestiondesVisites.Click += new System.EventHandler(this.buttonGestiondesVisites_Click);
            // 
            // buttonGestiondesCommerciaux
            // 
            this.buttonGestiondesCommerciaux.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGestiondesCommerciaux.Location = new System.Drawing.Point(52, 306);
            this.buttonGestiondesCommerciaux.Name = "buttonGestiondesCommerciaux";
            this.buttonGestiondesCommerciaux.Size = new System.Drawing.Size(225, 152);
            this.buttonGestiondesCommerciaux.TabIndex = 16;
            this.buttonGestiondesCommerciaux.Text = "Gestion des commerciaux";
            this.buttonGestiondesCommerciaux.UseVisualStyleBackColor = true;
            this.buttonGestiondesCommerciaux.Click += new System.EventHandler(this.buttonGestiondesCommerciaux_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturn.Location = new System.Drawing.Point(52, 38);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(225, 92);
            this.buttonReturn.TabIndex = 17;
            this.buttonReturn.Text = "Retour accueil";
            this.buttonReturn.UseVisualStyleBackColor = true;
            // 
            // IGestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 480);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonGestiondesCommerciaux);
            this.Controls.Add(this.buttonGestiondesVisites);
            this.Controls.Add(this.buttonGestiondesSouhaits);
            this.Controls.Add(this.textBoxNomCommercial);
            this.Controls.Add(this.buttonGestiondesBiens);
            this.Controls.Add(this.labelImmoBilly);
            this.Controls.Add(this.pictureBox1);
            this.Name = "IGestions";
            this.Text = "Accueil";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelImmoBilly;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonGestiondesBiens;
        private System.Windows.Forms.TextBox textBoxNomCommercial;
        private System.Windows.Forms.Button buttonGestiondesSouhaits;
        private System.Windows.Forms.Button buttonGestiondesVisites;
        private System.Windows.Forms.Button buttonGestiondesCommerciaux;
        private System.Windows.Forms.Button buttonReturn;
    }
}