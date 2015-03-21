namespace WindowsFormsApplication1
{
    partial class NouvelleFacture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NouvelleFacture));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.reference = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.codeClient = new System.Windows.Forms.TextBox();
            this.nomPrenomClient = new System.Windows.Forms.TextBox();
            this.adresse = new System.Windows.Forms.TextBox();
            this.adresse2 = new System.Windows.Forms.TextBox();
            this.codePostal = new System.Windows.Forms.TextBox();
            this.ville = new System.Windows.Forms.TextBox();
            this.pays = new System.Windows.Forms.TextBox();
            this.rechercheProduit = new System.Windows.Forms.TextBox();
            this.RechercherProduit = new System.Windows.Forms.Button();
            this.ReglerLaFacture = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.moyenDePaiement = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.aRegler = new System.Windows.Forms.TextBox();
            this.regle = new System.Windows.Forms.TextBox();
            this.aRendre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RefFacture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixHTunite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixHT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label = new System.Windows.Forms.Label();
            this.remise = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.HT = new System.Windows.Forms.TextBox();
            this.TVA = new System.Windows.Forms.TextBox();
            this.TTC = new System.Windows.Forms.TextBox();
            this.ValiderNouvelleFacture = new System.Windows.Forms.Button();
            this.AnnulerNouvelleFacture = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nouvelle Facture";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ref : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date : ";
            // 
            // reference
            // 
            this.reference.Location = new System.Drawing.Point(157, 70);
            this.reference.Name = "reference";
            this.reference.Size = new System.Drawing.Size(100, 20);
            this.reference.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(583, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Client : ";
            // 
            // codeClient
            // 
            this.codeClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.codeClient.Location = new System.Drawing.Point(631, 48);
            this.codeClient.Name = "codeClient";
            this.codeClient.Size = new System.Drawing.Size(45, 20);
            this.codeClient.TabIndex = 7;
            // 
            // nomPrenomClient
            // 
            this.nomPrenomClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nomPrenomClient.Location = new System.Drawing.Point(682, 47);
            this.nomPrenomClient.Name = "nomPrenomClient";
            this.nomPrenomClient.Size = new System.Drawing.Size(164, 20);
            this.nomPrenomClient.TabIndex = 8;
            // 
            // adresse
            // 
            this.adresse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.adresse.Location = new System.Drawing.Point(631, 73);
            this.adresse.Name = "adresse";
            this.adresse.Size = new System.Drawing.Size(215, 20);
            this.adresse.TabIndex = 9;
            // 
            // adresse2
            // 
            this.adresse2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.adresse2.Location = new System.Drawing.Point(631, 99);
            this.adresse2.Name = "adresse2";
            this.adresse2.Size = new System.Drawing.Size(215, 20);
            this.adresse2.TabIndex = 10;
            // 
            // codePostal
            // 
            this.codePostal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.codePostal.Location = new System.Drawing.Point(631, 125);
            this.codePostal.Name = "codePostal";
            this.codePostal.Size = new System.Drawing.Size(45, 20);
            this.codePostal.TabIndex = 11;
            // 
            // ville
            // 
            this.ville.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ville.Location = new System.Drawing.Point(682, 125);
            this.ville.Name = "ville";
            this.ville.Size = new System.Drawing.Size(100, 20);
            this.ville.TabIndex = 12;
            // 
            // pays
            // 
            this.pays.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pays.Location = new System.Drawing.Point(788, 125);
            this.pays.Name = "pays";
            this.pays.Size = new System.Drawing.Size(58, 20);
            this.pays.TabIndex = 13;
            // 
            // rechercheProduit
            // 
            this.rechercheProduit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rechercheProduit.Location = new System.Drawing.Point(21, 476);
            this.rechercheProduit.Name = "rechercheProduit";
            this.rechercheProduit.Size = new System.Drawing.Size(100, 20);
            this.rechercheProduit.TabIndex = 15;
            // 
            // RechercherProduit
            // 
            this.RechercherProduit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RechercherProduit.Location = new System.Drawing.Point(127, 476);
            this.RechercherProduit.Name = "RechercherProduit";
            this.RechercherProduit.Size = new System.Drawing.Size(107, 20);
            this.RechercherProduit.TabIndex = 16;
            this.RechercherProduit.Text = "Recherche Produit";
            this.RechercherProduit.UseVisualStyleBackColor = true;
            // 
            // ReglerLaFacture
            // 
            this.ReglerLaFacture.Location = new System.Drawing.Point(520, 27);
            this.ReglerLaFacture.Name = "ReglerLaFacture";
            this.ReglerLaFacture.Size = new System.Drawing.Size(87, 48);
            this.ReglerLaFacture.TabIndex = 17;
            this.ReglerLaFacture.Text = "Régler la facture";
            this.ReglerLaFacture.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Moyen de Paiement : ";
            // 
            // moyenDePaiement
            // 
            this.moyenDePaiement.FormattingEnabled = true;
            this.moyenDePaiement.Location = new System.Drawing.Point(9, 61);
            this.moyenDePaiement.Name = "moyenDePaiement";
            this.moyenDePaiement.Size = new System.Drawing.Size(123, 21);
            this.moyenDePaiement.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(288, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "A régler :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(293, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Réglé : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(284, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "A rendre :";
            // 
            // aRegler
            // 
            this.aRegler.Location = new System.Drawing.Point(343, 13);
            this.aRegler.Name = "aRegler";
            this.aRegler.Size = new System.Drawing.Size(85, 20);
            this.aRegler.TabIndex = 23;
            // 
            // regle
            // 
            this.regle.Location = new System.Drawing.Point(343, 42);
            this.regle.Name = "regle";
            this.regle.Size = new System.Drawing.Size(85, 20);
            this.regle.TabIndex = 24;
            // 
            // aRendre
            // 
            this.aRendre.Location = new System.Drawing.Point(343, 66);
            this.aRendre.Name = "aRendre";
            this.aRendre.Size = new System.Drawing.Size(85, 20);
            this.aRendre.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.aRendre);
            this.groupBox1.Controls.Add(this.ReglerLaFacture);
            this.groupBox1.Controls.Add(this.moyenDePaiement);
            this.groupBox1.Controls.Add(this.regle);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.aRegler);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(12, 505);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(613, 110);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paiement";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RefFacture,
            this.produit,
            this.quantite,
            this.prixHTunite,
            this.prixHT});
            this.dataGridView1.Location = new System.Drawing.Point(8, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(864, 285);
            this.dataGridView1.TabIndex = 26;
            // 
            // RefFacture
            // 
            this.RefFacture.HeaderText = "Ref";
            this.RefFacture.Name = "RefFacture";
            this.RefFacture.Width = 160;
            // 
            // produit
            // 
            this.produit.HeaderText = "Produit";
            this.produit.Name = "produit";
            this.produit.Width = 170;
            // 
            // quantite
            // 
            this.quantite.HeaderText = "Qte";
            this.quantite.Name = "quantite";
            this.quantite.Width = 150;
            // 
            // prixHTunite
            // 
            this.prixHTunite.HeaderText = "Prix HT Unit.";
            this.prixHTunite.Name = "prixHTunite";
            this.prixHTunite.Width = 170;
            // 
            // prixHT
            // 
            this.prixHT.HeaderText = "Prix HT";
            this.prixHT.Name = "prixHT";
            this.prixHT.Width = 170;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(679, 490);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(51, 13);
            this.label.TabIndex = 27;
            this.label.Text = "Remise : ";
            // 
            // remise
            // 
            this.remise.Location = new System.Drawing.Point(736, 487);
            this.remise.Name = "remise";
            this.remise.Size = new System.Drawing.Size(100, 20);
            this.remise.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(679, 547);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "TVA :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(679, 518);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Total HT :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(679, 574);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Total TTC :";
            // 
            // HT
            // 
            this.HT.Location = new System.Drawing.Point(736, 515);
            this.HT.Name = "HT";
            this.HT.Size = new System.Drawing.Size(100, 20);
            this.HT.TabIndex = 32;
            // 
            // TVA
            // 
            this.TVA.Location = new System.Drawing.Point(736, 544);
            this.TVA.Name = "TVA";
            this.TVA.Size = new System.Drawing.Size(100, 20);
            this.TVA.TabIndex = 33;
            // 
            // TTC
            // 
            this.TTC.Location = new System.Drawing.Point(736, 571);
            this.TTC.Name = "TTC";
            this.TTC.Size = new System.Drawing.Size(100, 20);
            this.TTC.TabIndex = 34;
            // 
            // ValiderNouvelleFacture
            // 
            this.ValiderNouvelleFacture.Location = new System.Drawing.Point(365, 621);
            this.ValiderNouvelleFacture.Name = "ValiderNouvelleFacture";
            this.ValiderNouvelleFacture.Size = new System.Drawing.Size(75, 23);
            this.ValiderNouvelleFacture.TabIndex = 35;
            this.ValiderNouvelleFacture.Text = "Valider";
            this.ValiderNouvelleFacture.UseVisualStyleBackColor = true;
            this.ValiderNouvelleFacture.Click += new System.EventHandler(this.ValiderNouvelleFacture_Click);
            // 
            // AnnulerNouvelleFacture
            // 
            this.AnnulerNouvelleFacture.Location = new System.Drawing.Point(495, 621);
            this.AnnulerNouvelleFacture.Name = "AnnulerNouvelleFacture";
            this.AnnulerNouvelleFacture.Size = new System.Drawing.Size(75, 23);
            this.AnnulerNouvelleFacture.TabIndex = 36;
            this.AnnulerNouvelleFacture.Text = "Annuler";
            this.AnnulerNouvelleFacture.UseVisualStyleBackColor = true;
            this.AnnulerNouvelleFacture.Click += new System.EventHandler(this.AnnulerNouvelleFacture_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(157, 96);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(187, 20);
            this.dateTimePicker1.TabIndex = 37;
            // 
            // NouvelleFacture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 651);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.AnnulerNouvelleFacture);
            this.Controls.Add(this.ValiderNouvelleFacture);
            this.Controls.Add(this.TTC);
            this.Controls.Add(this.TVA);
            this.Controls.Add(this.HT);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.remise);
            this.Controls.Add(this.label);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RechercherProduit);
            this.Controls.Add(this.rechercheProduit);
            this.Controls.Add(this.pays);
            this.Controls.Add(this.ville);
            this.Controls.Add(this.codePostal);
            this.Controls.Add(this.adresse2);
            this.Controls.Add(this.adresse);
            this.Controls.Add(this.nomPrenomClient);
            this.Controls.Add(this.codeClient);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.reference);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NouvelleFacture";
            this.Text = "Nouvelle Facture";
            this.Load += new System.EventHandler(this.NouvelleFacture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox reference;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox codeClient;
        private System.Windows.Forms.TextBox nomPrenomClient;
        private System.Windows.Forms.TextBox adresse;
        private System.Windows.Forms.TextBox adresse2;
        private System.Windows.Forms.TextBox codePostal;
        private System.Windows.Forms.TextBox ville;
        private System.Windows.Forms.TextBox pays;
        private System.Windows.Forms.TextBox rechercheProduit;
        private System.Windows.Forms.Button RechercherProduit;
        private System.Windows.Forms.Button ReglerLaFacture;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox moyenDePaiement;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox aRegler;
        private System.Windows.Forms.TextBox regle;
        private System.Windows.Forms.TextBox aRendre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox remise;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox HT;
        private System.Windows.Forms.TextBox TVA;
        private System.Windows.Forms.TextBox TTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefFacture;
        private System.Windows.Forms.DataGridViewTextBoxColumn produit;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixHTunite;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixHT;
        private System.Windows.Forms.Button ValiderNouvelleFacture;
        private System.Windows.Forms.Button AnnulerNouvelleFacture;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}