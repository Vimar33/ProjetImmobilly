namespace ProjetImmoBilly
{
    partial class Accueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxMotdePasse = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelMotdePasse = new System.Windows.Forms.Label();
            this.buttonConnection = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelImmoBilly = new System.Windows.Forms.Label();
            this.labelerrorMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(144, 250);
            this.textBoxLogin.MaxLength = 33;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(291, 20);
            this.textBoxLogin.TabIndex = 0;
            this.textBoxLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxMotdePasse
            // 
            this.textBoxMotdePasse.Location = new System.Drawing.Point(144, 317);
            this.textBoxMotdePasse.MaxLength = 33;
            this.textBoxMotdePasse.Name = "textBoxMotdePasse";
            this.textBoxMotdePasse.PasswordChar = '*';
            this.textBoxMotdePasse.Size = new System.Drawing.Size(291, 20);
            this.textBoxMotdePasse.TabIndex = 1;
            this.textBoxMotdePasse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.Location = new System.Drawing.Point(140, 227);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(151, 20);
            this.labelLogin.TabIndex = 2;
            this.labelLogin.Text = "Identifiant employé :";
            // 
            // labelMotdePasse
            // 
            this.labelMotdePasse.AutoSize = true;
            this.labelMotdePasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMotdePasse.Location = new System.Drawing.Point(140, 294);
            this.labelMotdePasse.Name = "labelMotdePasse";
            this.labelMotdePasse.Size = new System.Drawing.Size(113, 20);
            this.labelMotdePasse.TabIndex = 3;
            this.labelMotdePasse.Text = "Mot de passe :";
            // 
            // buttonConnection
            // 
            this.buttonConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnection.Location = new System.Drawing.Point(226, 361);
            this.buttonConnection.Name = "buttonConnection";
            this.buttonConnection.Size = new System.Drawing.Size(147, 38);
            this.buttonConnection.TabIndex = 4;
            this.buttonConnection.Text = "Se connecter";
            this.buttonConnection.UseVisualStyleBackColor = true;
            this.buttonConnection.Click += new System.EventHandler(this.buttonConnection_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(144, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // labelImmoBilly
            // 
            this.labelImmoBilly.AutoSize = true;
            this.labelImmoBilly.BackColor = System.Drawing.Color.DimGray;
            this.labelImmoBilly.Font = new System.Drawing.Font("Lucida Console", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImmoBilly.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelImmoBilly.Location = new System.Drawing.Point(152, 47);
            this.labelImmoBilly.Name = "labelImmoBilly";
            this.labelImmoBilly.Size = new System.Drawing.Size(150, 21);
            this.labelImmoBilly.TabIndex = 6;
            this.labelImmoBilly.Text = "Immo Billy";
            // 
            // labelerrorMessage
            // 
            this.labelerrorMessage.AutoSize = true;
            this.labelerrorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelerrorMessage.ForeColor = System.Drawing.Color.Red;
            this.labelerrorMessage.Location = new System.Drawing.Point(87, 419);
            this.labelerrorMessage.Name = "labelerrorMessage";
            this.labelerrorMessage.Size = new System.Drawing.Size(413, 25);
            this.labelerrorMessage.TabIndex = 8;
            this.labelerrorMessage.Text = "Identifiant ou Mot de passe incorrect *";
            this.labelerrorMessage.Visible = false;
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 480);
            this.Controls.Add(this.labelerrorMessage);
            this.Controls.Add(this.labelImmoBilly);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonConnection);
            this.Controls.Add(this.labelMotdePasse);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.textBoxMotdePasse);
            this.Controls.Add(this.textBoxLogin);
            this.Name = "Accueil";
            this.Text = "Ouvrir session";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxMotdePasse;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelMotdePasse;
        private System.Windows.Forms.Button buttonConnection;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelImmoBilly;
        private System.Windows.Forms.Label labelerrorMessage;
    }
}

