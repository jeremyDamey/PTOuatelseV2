namespace WindowsFormsApplication1
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
            this.FactureButton = new System.Windows.Forms.Button();
            this.ClientButton = new System.Windows.Forms.Button();
            this.SalarieButton = new System.Windows.Forms.Button();
            this.ProduitBbutton = new System.Windows.Forms.Button();
            this.AssistanceButton = new System.Windows.Forms.Button();
            this.DeconnexionButton = new System.Windows.Forms.Button();
            this.ConnecteLabel = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // FactureButton
            // 
            this.FactureButton.Location = new System.Drawing.Point(181, 157);
            this.FactureButton.Name = "FactureButton";
            this.FactureButton.Size = new System.Drawing.Size(131, 76);
            this.FactureButton.TabIndex = 0;
            this.FactureButton.Text = "Nouvelle Facture";
            this.FactureButton.UseVisualStyleBackColor = true;
            this.FactureButton.Click += new System.EventHandler(this.FactureButton_Click);
            // 
            // ClientButton
            // 
            this.ClientButton.Location = new System.Drawing.Point(318, 157);
            this.ClientButton.Name = "ClientButton";
            this.ClientButton.Size = new System.Drawing.Size(75, 34);
            this.ClientButton.TabIndex = 1;
            this.ClientButton.Text = "Clients";
            this.ClientButton.UseVisualStyleBackColor = true;
            this.ClientButton.Click += new System.EventHandler(this.ClientButton_Click);
            // 
            // SalarieButton
            // 
            this.SalarieButton.Location = new System.Drawing.Point(318, 199);
            this.SalarieButton.Name = "SalarieButton";
            this.SalarieButton.Size = new System.Drawing.Size(75, 34);
            this.SalarieButton.TabIndex = 2;
            this.SalarieButton.Text = "Salariés";
            this.SalarieButton.UseVisualStyleBackColor = true;
            this.SalarieButton.Click += new System.EventHandler(this.SalarieButton_Click);
            // 
            // ProduitBbutton
            // 
            this.ProduitBbutton.Location = new System.Drawing.Point(262, 239);
            this.ProduitBbutton.Name = "ProduitBbutton";
            this.ProduitBbutton.Size = new System.Drawing.Size(131, 23);
            this.ProduitBbutton.TabIndex = 3;
            this.ProduitBbutton.Text = "Produits / Stocks";
            this.ProduitBbutton.UseVisualStyleBackColor = true;
            this.ProduitBbutton.Click += new System.EventHandler(this.ProduitBbutton_Click);
            // 
            // AssistanceButton
            // 
            this.AssistanceButton.Location = new System.Drawing.Point(181, 239);
            this.AssistanceButton.Name = "AssistanceButton";
            this.AssistanceButton.Size = new System.Drawing.Size(75, 23);
            this.AssistanceButton.TabIndex = 4;
            this.AssistanceButton.Text = "Assistance";
            this.AssistanceButton.UseVisualStyleBackColor = true;
            this.AssistanceButton.Click += new System.EventHandler(this.AssistanceButton_Click);
            // 
            // DeconnexionButton
            // 
            this.DeconnexionButton.Location = new System.Drawing.Point(521, 46);
            this.DeconnexionButton.Name = "DeconnexionButton";
            this.DeconnexionButton.Size = new System.Drawing.Size(95, 23);
            this.DeconnexionButton.TabIndex = 5;
            this.DeconnexionButton.Text = "Se déconnecter";
            this.DeconnexionButton.UseVisualStyleBackColor = true;
            this.DeconnexionButton.Click += new System.EventHandler(this.DeconnexionButton_Click);
            // 
            // ConnecteLabel
            // 
            this.ConnecteLabel.AutoSize = true;
            this.ConnecteLabel.Location = new System.Drawing.Point(503, 9);
            this.ConnecteLabel.Name = "ConnecteLabel";
            this.ConnecteLabel.Size = new System.Drawing.Size(113, 13);
            this.ConnecteLabel.TabIndex = 6;
            this.ConnecteLabel.Text = "Connecté en tant que ";
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(12, 14);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(135, 129);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 7;
            this.Logo.TabStop = false;
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 435);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.ConnecteLabel);
            this.Controls.Add(this.DeconnexionButton);
            this.Controls.Add(this.AssistanceButton);
            this.Controls.Add(this.ProduitBbutton);
            this.Controls.Add(this.SalarieButton);
            this.Controls.Add(this.ClientButton);
            this.Controls.Add(this.FactureButton);
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.Acceuil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClientButton;
        private System.Windows.Forms.Button SalarieButton;
        private System.Windows.Forms.Button ProduitBbutton;
        private System.Windows.Forms.Button AssistanceButton;
        private System.Windows.Forms.Button DeconnexionButton;
        private System.Windows.Forms.Label ConnecteLabel;
        private System.Windows.Forms.PictureBox Logo;
        public System.Windows.Forms.Button FactureButton;
    }
}

