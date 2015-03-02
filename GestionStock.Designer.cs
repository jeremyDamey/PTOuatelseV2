namespace PTOuatelse
{
    partial class GestionStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionStock));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nouveauProduit = new System.Windows.Forms.Button();
            this.modifierProduit = new System.Windows.Forms.Button();
            this.reaprovisionnerProduit = new System.Windows.Forms.Button();
            this.destockerProduit = new System.Windows.Forms.Button();
            this.supprimerProduit = new System.Windows.Forms.Button();
            this.rechercher = new System.Windows.Forms.TextBox();
            this.recherche = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ref = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomProduit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixAchat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixVente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gestion du Stock";
            // 
            // nouveauProduit
            // 
            this.nouveauProduit.Location = new System.Drawing.Point(12, 68);
            this.nouveauProduit.Name = "nouveauProduit";
            this.nouveauProduit.Size = new System.Drawing.Size(111, 35);
            this.nouveauProduit.TabIndex = 2;
            this.nouveauProduit.Text = "Nouveau Produit";
            this.nouveauProduit.UseVisualStyleBackColor = true;
            this.nouveauProduit.Click += new System.EventHandler(this.nouveauProduit_Click);
            // 
            // modifierProduit
            // 
            this.modifierProduit.Location = new System.Drawing.Point(129, 68);
            this.modifierProduit.Name = "modifierProduit";
            this.modifierProduit.Size = new System.Drawing.Size(111, 35);
            this.modifierProduit.TabIndex = 3;
            this.modifierProduit.Text = "Modifier Produit";
            this.modifierProduit.UseVisualStyleBackColor = true;
            this.modifierProduit.Click += new System.EventHandler(this.modifierProduit_Click);
            // 
            // reaprovisionnerProduit
            // 
            this.reaprovisionnerProduit.Location = new System.Drawing.Point(246, 68);
            this.reaprovisionnerProduit.Name = "reaprovisionnerProduit";
            this.reaprovisionnerProduit.Size = new System.Drawing.Size(111, 35);
            this.reaprovisionnerProduit.TabIndex = 4;
            this.reaprovisionnerProduit.Text = "Réapprovisionner Produit";
            this.reaprovisionnerProduit.UseVisualStyleBackColor = true;
            this.reaprovisionnerProduit.Click += new System.EventHandler(this.reaprovisionnerProduit_Click);
            // 
            // destockerProduit
            // 
            this.destockerProduit.Location = new System.Drawing.Point(363, 68);
            this.destockerProduit.Name = "destockerProduit";
            this.destockerProduit.Size = new System.Drawing.Size(111, 35);
            this.destockerProduit.TabIndex = 5;
            this.destockerProduit.Text = "Destocker Produit";
            this.destockerProduit.UseVisualStyleBackColor = true;
            this.destockerProduit.Click += new System.EventHandler(this.destockerProduit_Click);
            // 
            // supprimerProduit
            // 
            this.supprimerProduit.Location = new System.Drawing.Point(480, 68);
            this.supprimerProduit.Name = "supprimerProduit";
            this.supprimerProduit.Size = new System.Drawing.Size(111, 35);
            this.supprimerProduit.TabIndex = 6;
            this.supprimerProduit.Text = "Supprimer Produit";
            this.supprimerProduit.UseVisualStyleBackColor = true;
            this.supprimerProduit.Click += new System.EventHandler(this.supprimerProduit_Click);
            // 
            // rechercher
            // 
            this.rechercher.Location = new System.Drawing.Point(613, 76);
            this.rechercher.Name = "rechercher";
            this.rechercher.Size = new System.Drawing.Size(100, 20);
            this.rechercher.TabIndex = 7;
            this.rechercher.Text = "Rechercher...";
            this.rechercher.TextChanged += new System.EventHandler(this.rechercher_TextChanged);
            // 
            // recherche
            // 
            this.recherche.Location = new System.Drawing.Point(719, 73);
            this.recherche.Name = "recherche";
            this.recherche.Size = new System.Drawing.Size(75, 23);
            this.recherche.TabIndex = 8;
            this.recherche.Text = "Rechercher";
            this.recherche.UseVisualStyleBackColor = true;
            this.recherche.Click += new System.EventHandler(this.recherche_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ref,
            this.nomProduit,
            this.prixAchat,
            this.prixVente,
            this.TVA});
            this.dataGridView1.Location = new System.Drawing.Point(12, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(814, 242);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Ref
            // 
            this.Ref.HeaderText = "Ref";
            this.Ref.Name = "Ref";
            this.Ref.Width = 200;
            // 
            // nomProduit
            // 
            this.nomProduit.HeaderText = "Nom Produit";
            this.nomProduit.Name = "nomProduit";
            this.nomProduit.Width = 200;
            // 
            // prixAchat
            // 
            this.prixAchat.HeaderText = "Prix Achat";
            this.prixAchat.Name = "prixAchat";
            // 
            // prixVente
            // 
            this.prixVente.HeaderText = "Prix Vente";
            this.prixVente.Name = "prixVente";
            // 
            // TVA
            // 
            this.TVA.HeaderText = "TVA";
            this.TVA.Name = "TVA";
            this.TVA.Width = 170;
            // 
            // GestionStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 363);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.recherche);
            this.Controls.Add(this.rechercher);
            this.Controls.Add(this.supprimerProduit);
            this.Controls.Add(this.destockerProduit);
            this.Controls.Add(this.reaprovisionnerProduit);
            this.Controls.Add(this.modifierProduit);
            this.Controls.Add(this.nouveauProduit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GestionStock";
            this.Text = "Gestion du Stock";
            this.Load += new System.EventHandler(this.GestionStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button nouveauProduit;
        private System.Windows.Forms.Button modifierProduit;
        private System.Windows.Forms.Button reaprovisionnerProduit;
        private System.Windows.Forms.Button destockerProduit;
        private System.Windows.Forms.Button supprimerProduit;
        private System.Windows.Forms.TextBox rechercher;
        private System.Windows.Forms.Button recherche;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ref;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomProduit;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixAchat;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixVente;
        private System.Windows.Forms.DataGridViewTextBoxColumn TVA;
    }
}