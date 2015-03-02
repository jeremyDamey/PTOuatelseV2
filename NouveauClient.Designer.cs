namespace PTOuatelse
{
    partial class NouveauClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Genre = new System.Windows.Forms.ComboBox();
            this.Nom = new System.Windows.Forms.TextBox();
            this.CodeClient = new System.Windows.Forms.TextBox();
            this.Adresse1 = new System.Windows.Forms.TextBox();
            this.Adresse2 = new System.Windows.Forms.TextBox();
            this.CodePostal = new System.Windows.Forms.TextBox();
            this.NomVille = new System.Windows.Forms.TextBox();
            this.NomPays = new System.Windows.Forms.TextBox();
            this.Téléphone = new System.Windows.Forms.TextBox();
            this.DateNaissance = new System.Windows.Forms.TextBox();
            this.Mail = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Détails = new System.Windows.Forms.TabControl();
            this.Factures = new System.Windows.Forms.TabPage();
            this.Statistiques = new System.Windows.Forms.TabPage();
            this.Ref = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix_HT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix_TTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Produit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Achats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fréquence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notes = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Détails.SuspendLayout();
            this.Factures.SuspendLayout();
            this.Statistiques.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(137, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Détails d\'un client";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 59);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Code client :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Adresse :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ville :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(518, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Pays :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tel/Port :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(518, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Date de naissance :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(65, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Courriel :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(387, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Nom Prénom :";
            // 
            // Genre
            // 
            this.Genre.FormattingEnabled = true;
            this.Genre.Location = new System.Drawing.Point(467, 112);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(57, 21);
            this.Genre.TabIndex = 10;
            // 
            // Nom
            // 
            this.Nom.Location = new System.Drawing.Point(530, 113);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(286, 20);
            this.Nom.TabIndex = 11;
            // 
            // CodeClient
            // 
            this.CodeClient.Location = new System.Drawing.Point(143, 111);
            this.CodeClient.Name = "CodeClient";
            this.CodeClient.Size = new System.Drawing.Size(238, 20);
            this.CodeClient.TabIndex = 12;
            // 
            // Adresse1
            // 
            this.Adresse1.Location = new System.Drawing.Point(143, 138);
            this.Adresse1.Name = "Adresse1";
            this.Adresse1.Size = new System.Drawing.Size(673, 20);
            this.Adresse1.TabIndex = 13;
            // 
            // Adresse2
            // 
            this.Adresse2.Location = new System.Drawing.Point(143, 164);
            this.Adresse2.Name = "Adresse2";
            this.Adresse2.Size = new System.Drawing.Size(673, 20);
            this.Adresse2.TabIndex = 14;
            // 
            // CodePostal
            // 
            this.CodePostal.Location = new System.Drawing.Point(143, 197);
            this.CodePostal.Name = "CodePostal";
            this.CodePostal.Size = new System.Drawing.Size(100, 20);
            this.CodePostal.TabIndex = 15;
            // 
            // NomVille
            // 
            this.NomVille.Location = new System.Drawing.Point(250, 197);
            this.NomVille.Name = "NomVille";
            this.NomVille.Size = new System.Drawing.Size(262, 20);
            this.NomVille.TabIndex = 16;
            // 
            // NomPays
            // 
            this.NomPays.Location = new System.Drawing.Point(560, 197);
            this.NomPays.Name = "NomPays";
            this.NomPays.Size = new System.Drawing.Size(255, 20);
            this.NomPays.TabIndex = 17;
            // 
            // Téléphone
            // 
            this.Téléphone.Location = new System.Drawing.Point(143, 229);
            this.Téléphone.Name = "Téléphone";
            this.Téléphone.Size = new System.Drawing.Size(369, 20);
            this.Téléphone.TabIndex = 18;
            // 
            // DateNaissance
            // 
            this.DateNaissance.Location = new System.Drawing.Point(628, 229);
            this.DateNaissance.Name = "DateNaissance";
            this.DateNaissance.Size = new System.Drawing.Size(188, 20);
            this.DateNaissance.TabIndex = 19;
            // 
            // Mail
            // 
            this.Mail.Location = new System.Drawing.Point(143, 261);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(672, 20);
            this.Mail.TabIndex = 20;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ref,
            this.Produits,
            this.Prix_HT,
            this.Prix_TTC});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(789, 175);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Détails
            // 
            this.Détails.Controls.Add(this.Factures);
            this.Détails.Controls.Add(this.Statistiques);
            this.Détails.Controls.Add(this.Notes);
            this.Détails.Location = new System.Drawing.Point(38, 313);
            this.Détails.Name = "Détails";
            this.Détails.SelectedIndex = 0;
            this.Détails.Size = new System.Drawing.Size(803, 207);
            this.Détails.TabIndex = 22;
            // 
            // Factures
            // 
            this.Factures.Controls.Add(this.dataGridView1);
            this.Factures.Location = new System.Drawing.Point(4, 22);
            this.Factures.Name = "Factures";
            this.Factures.Padding = new System.Windows.Forms.Padding(3);
            this.Factures.Size = new System.Drawing.Size(795, 181);
            this.Factures.TabIndex = 0;
            this.Factures.Text = "Factures";
            this.Factures.UseVisualStyleBackColor = true;
            // 
            // Statistiques
            // 
            this.Statistiques.Controls.Add(this.dataGridView2);
            this.Statistiques.Location = new System.Drawing.Point(4, 22);
            this.Statistiques.Name = "Statistiques";
            this.Statistiques.Padding = new System.Windows.Forms.Padding(3);
            this.Statistiques.Size = new System.Drawing.Size(795, 181);
            this.Statistiques.TabIndex = 1;
            this.Statistiques.Text = "Statistiques";
            this.Statistiques.UseVisualStyleBackColor = true;
            // 
            // Ref
            // 
            this.Ref.HeaderText = "Ref";
            this.Ref.Name = "Ref";
            // 
            // Produits
            // 
            this.Produits.HeaderText = "Produits";
            this.Produits.Name = "Produits";
            this.Produits.Width = 300;
            // 
            // Prix_HT
            // 
            this.Prix_HT.HeaderText = "Prix_HT";
            this.Prix_HT.Name = "Prix_HT";
            this.Prix_HT.Width = 175;
            // 
            // Prix_TTC
            // 
            this.Prix_TTC.HeaderText = "Prix_TTC";
            this.Prix_TTC.Name = "Prix_TTC";
            this.Prix_TTC.Width = 175;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Produit,
            this.Nombre_Achats,
            this.Fréquence});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(789, 175);
            this.dataGridView2.TabIndex = 0;
            // 
            // Produit
            // 
            this.Produit.HeaderText = "Produits";
            this.Produit.Name = "Produit";
            this.Produit.Width = 400;
            // 
            // Nombre_Achats
            // 
            this.Nombre_Achats.HeaderText = "Nombre Achats";
            this.Nombre_Achats.Name = "Nombre_Achats";
            this.Nombre_Achats.Width = 175;
            // 
            // Fréquence
            // 
            this.Fréquence.HeaderText = "Fréquence";
            this.Fréquence.Name = "Fréquence";
            this.Fréquence.Width = 175;
            // 
            // Notes
            // 
            this.Notes.Location = new System.Drawing.Point(4, 22);
            this.Notes.Name = "Notes";
            this.Notes.Padding = new System.Windows.Forms.Padding(3);
            this.Notes.Size = new System.Drawing.Size(795, 181);
            this.Notes.TabIndex = 2;
            this.Notes.Text = "Notes";
            this.Notes.UseVisualStyleBackColor = true;
            // 
            // NouveauClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 532);
            this.Controls.Add(this.Détails);
            this.Controls.Add(this.Mail);
            this.Controls.Add(this.DateNaissance);
            this.Controls.Add(this.Téléphone);
            this.Controls.Add(this.NomPays);
            this.Controls.Add(this.NomVille);
            this.Controls.Add(this.CodePostal);
            this.Controls.Add(this.Adresse2);
            this.Controls.Add(this.Adresse1);
            this.Controls.Add(this.CodeClient);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "NouveauClient";
            this.Text = "Nouveau Client";
            this.Load += new System.EventHandler(this.NouveauClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Détails.ResumeLayout(false);
            this.Factures.ResumeLayout(false);
            this.Statistiques.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox Genre;
        private System.Windows.Forms.TextBox Nom;
        private System.Windows.Forms.TextBox CodeClient;
        private System.Windows.Forms.TextBox Adresse1;
        private System.Windows.Forms.TextBox Adresse2;
        private System.Windows.Forms.TextBox CodePostal;
        private System.Windows.Forms.TextBox NomVille;
        private System.Windows.Forms.TextBox NomPays;
        private System.Windows.Forms.TextBox Téléphone;
        private System.Windows.Forms.TextBox DateNaissance;
        private System.Windows.Forms.TextBox Mail;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ref;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produits;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix_HT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix_TTC;
        private System.Windows.Forms.TabControl Détails;
        private System.Windows.Forms.TabPage Factures;
        private System.Windows.Forms.TabPage Statistiques;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Achats;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fréquence;
        private System.Windows.Forms.TabPage Notes;
    }
}