namespace PTOuatelse
{
    partial class ModifierClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifierClient));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ref = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix_HT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix_TTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail = new System.Windows.Forms.TextBox();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pt_ouatelse1DataSet = new PTOuatelse.pt_ouatelse1DataSet();
            this.DateNaissance = new System.Windows.Forms.TextBox();
            this.Téléphone = new System.Windows.Forms.TextBox();
            this.NomPays = new System.Windows.Forms.TextBox();
            this.paysBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NomVille = new System.Windows.Forms.TextBox();
            this.CodePostal = new System.Windows.Forms.TextBox();
            this.villesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Adresse2 = new System.Windows.Forms.TextBox();
            this.Adresse1 = new System.Windows.Forms.TextBox();
            this.CodeClient = new System.Windows.Forms.TextBox();
            this.Nom = new System.Windows.Forms.TextBox();
            this.Genre = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Factures = new System.Windows.Forms.TabPage();
            this.Statistiques = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Produit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Achats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fréquence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notes = new System.Windows.Forms.TabPage();
            this.validerClient = new System.Windows.Forms.Button();
            this.annulerClient = new System.Windows.Forms.Button();
            this.clientsTableAdapter = new PTOuatelse.pt_ouatelse1DataSetTableAdapters.clientsTableAdapter();
            this.tableAdapterManager = new PTOuatelse.pt_ouatelse1DataSetTableAdapters.TableAdapterManager();
            this.paysTableAdapter = new PTOuatelse.pt_ouatelse1DataSetTableAdapters.paysTableAdapter();
            this.villesTableAdapter = new PTOuatelse.pt_ouatelse1DataSetTableAdapters.villesTableAdapter();
            this.Prenom = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt_ouatelse1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paysBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.villesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Factures.SuspendLayout();
            this.Statistiques.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Size = new System.Drawing.Size(758, 122);
            this.dataGridView1.TabIndex = 43;
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
            this.Produits.Width = 400;
            // 
            // Prix_HT
            // 
            this.Prix_HT.HeaderText = "Prix_HT";
            this.Prix_HT.Name = "Prix_HT";
            this.Prix_HT.Width = 110;
            // 
            // Prix_TTC
            // 
            this.Prix_TTC.HeaderText = "Prix_TTC";
            this.Prix_TTC.Name = "Prix_TTC";
            this.Prix_TTC.Width = 110;
            // 
            // Mail
            // 
            this.Mail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "mail", true));
            this.Mail.Location = new System.Drawing.Point(151, 271);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(672, 20);
            this.Mail.TabIndex = 42;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "clients";
            this.clientsBindingSource.DataSource = this.pt_ouatelse1DataSet;
            // 
            // pt_ouatelse1DataSet
            // 
            this.pt_ouatelse1DataSet.DataSetName = "pt_ouatelse1DataSet";
            this.pt_ouatelse1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DateNaissance
            // 
            this.DateNaissance.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "naissance", true));
            this.DateNaissance.Location = new System.Drawing.Point(636, 239);
            this.DateNaissance.Name = "DateNaissance";
            this.DateNaissance.Size = new System.Drawing.Size(188, 20);
            this.DateNaissance.TabIndex = 41;
            // 
            // Téléphone
            // 
            this.Téléphone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "portable", true));
            this.Téléphone.Location = new System.Drawing.Point(151, 239);
            this.Téléphone.Name = "Téléphone";
            this.Téléphone.Size = new System.Drawing.Size(369, 20);
            this.Téléphone.TabIndex = 40;
            // 
            // NomPays
            // 
            this.NomPays.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paysBindingSource, "libelle", true));
            this.NomPays.Location = new System.Drawing.Point(568, 207);
            this.NomPays.Name = "NomPays";
            this.NomPays.Size = new System.Drawing.Size(255, 20);
            this.NomPays.TabIndex = 39;
            // 
            // paysBindingSource
            // 
            this.paysBindingSource.DataMember = "pays";
            this.paysBindingSource.DataSource = this.pt_ouatelse1DataSet;
            // 
            // NomVille
            // 
            this.NomVille.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "villes_id", true));
            this.NomVille.Location = new System.Drawing.Point(258, 207);
            this.NomVille.Name = "NomVille";
            this.NomVille.Size = new System.Drawing.Size(262, 20);
            this.NomVille.TabIndex = 38;
            // 
            // CodePostal
            // 
            this.CodePostal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.villesBindingSource, "code_postal", true));
            this.CodePostal.Location = new System.Drawing.Point(151, 207);
            this.CodePostal.Name = "CodePostal";
            this.CodePostal.Size = new System.Drawing.Size(100, 20);
            this.CodePostal.TabIndex = 37;
            // 
            // villesBindingSource
            // 
            this.villesBindingSource.DataMember = "villes";
            this.villesBindingSource.DataSource = this.pt_ouatelse1DataSet;
            // 
            // Adresse2
            // 
            this.Adresse2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "adresse2", true));
            this.Adresse2.Location = new System.Drawing.Point(151, 174);
            this.Adresse2.Name = "Adresse2";
            this.Adresse2.Size = new System.Drawing.Size(673, 20);
            this.Adresse2.TabIndex = 36;
            // 
            // Adresse1
            // 
            this.Adresse1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "adresse1", true));
            this.Adresse1.Location = new System.Drawing.Point(151, 148);
            this.Adresse1.Name = "Adresse1";
            this.Adresse1.Size = new System.Drawing.Size(673, 20);
            this.Adresse1.TabIndex = 35;
            // 
            // CodeClient
            // 
            this.CodeClient.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "id", true));
            this.CodeClient.Location = new System.Drawing.Point(151, 121);
            this.CodeClient.Name = "CodeClient";
            this.CodeClient.Size = new System.Drawing.Size(238, 20);
            this.CodeClient.TabIndex = 34;
            // 
            // Nom
            // 
            this.Nom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "nom", true));
            this.Nom.Location = new System.Drawing.Point(538, 123);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(120, 20);
            this.Nom.TabIndex = 33;
            // 
            // Genre
            // 
            this.Genre.FormattingEnabled = true;
            this.Genre.Items.AddRange(new object[] {
            "M.",
            "Mme"});
            this.Genre.Location = new System.Drawing.Point(475, 122);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(57, 21);
            this.Genre.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(395, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Nom Prénom :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(73, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Courriel :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(526, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Date de naissance :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Tel/Port :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(526, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Pays :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Ville :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Adresse :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Code client :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(145, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 31);
            this.label1.TabIndex = 22;
            this.label1.Text = "Détails d\'un client";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Factures);
            this.tabControl1.Controls.Add(this.Statistiques);
            this.tabControl1.Controls.Add(this.Notes);
            this.tabControl1.Location = new System.Drawing.Point(60, 308);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(772, 154);
            this.tabControl1.TabIndex = 44;
            // 
            // Factures
            // 
            this.Factures.Controls.Add(this.dataGridView1);
            this.Factures.Location = new System.Drawing.Point(4, 22);
            this.Factures.Name = "Factures";
            this.Factures.Padding = new System.Windows.Forms.Padding(3);
            this.Factures.Size = new System.Drawing.Size(764, 128);
            this.Factures.TabIndex = 0;
            this.Factures.Text = "Factures";
            this.Factures.UseVisualStyleBackColor = true;
            this.Factures.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // Statistiques
            // 
            this.Statistiques.Controls.Add(this.dataGridView2);
            this.Statistiques.Location = new System.Drawing.Point(4, 22);
            this.Statistiques.Name = "Statistiques";
            this.Statistiques.Padding = new System.Windows.Forms.Padding(3);
            this.Statistiques.Size = new System.Drawing.Size(764, 128);
            this.Statistiques.TabIndex = 1;
            this.Statistiques.Text = "Statistiques";
            this.Statistiques.UseVisualStyleBackColor = true;
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
            this.dataGridView2.Size = new System.Drawing.Size(758, 122);
            this.dataGridView2.TabIndex = 0;
            // 
            // Produit
            // 
            this.Produit.HeaderText = "Produit";
            this.Produit.Name = "Produit";
            this.Produit.Width = 400;
            // 
            // Nombre_Achats
            // 
            this.Nombre_Achats.HeaderText = "Nombre Achats";
            this.Nombre_Achats.Name = "Nombre_Achats";
            this.Nombre_Achats.Width = 200;
            // 
            // Fréquence
            // 
            this.Fréquence.HeaderText = "Fréquence";
            this.Fréquence.Name = "Fréquence";
            this.Fréquence.Width = 120;
            // 
            // Notes
            // 
            this.Notes.Location = new System.Drawing.Point(4, 22);
            this.Notes.Name = "Notes";
            this.Notes.Size = new System.Drawing.Size(764, 128);
            this.Notes.TabIndex = 2;
            this.Notes.Text = "Notes";
            this.Notes.UseVisualStyleBackColor = true;
            // 
            // validerClient
            // 
            this.validerClient.Location = new System.Drawing.Point(314, 468);
            this.validerClient.Name = "validerClient";
            this.validerClient.Size = new System.Drawing.Size(75, 23);
            this.validerClient.TabIndex = 45;
            this.validerClient.Text = "Valider";
            this.validerClient.UseVisualStyleBackColor = true;
            // 
            // annulerClient
            // 
            this.annulerClient.Location = new System.Drawing.Point(487, 468);
            this.annulerClient.Name = "annulerClient";
            this.annulerClient.Size = new System.Drawing.Size(75, 23);
            this.annulerClient.TabIndex = 46;
            this.annulerClient.Text = "Annuler";
            this.annulerClient.UseVisualStyleBackColor = true;
            this.annulerClient.Click += new System.EventHandler(this.annulerClient_Click);
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.civiliteTableAdapter = null;
            this.tableAdapterManager.clientsTableAdapter = this.clientsTableAdapter;
            this.tableAdapterManager.congeTableAdapter = null;
            this.tableAdapterManager.factures_produitsTableAdapter = null;
            this.tableAdapterManager.facturesTableAdapter = null;
            this.tableAdapterManager.magasinTableAdapter = null;
            this.tableAdapterManager.mouvement_stockTableAdapter = null;
            this.tableAdapterManager.moyen_de_paiementTableAdapter = null;
            this.tableAdapterManager.paysTableAdapter = this.paysTableAdapter;
            this.tableAdapterManager.produitsTableAdapter = null;
            this.tableAdapterManager.rolesTableAdapter = null;
            this.tableAdapterManager.salariesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PTOuatelse.pt_ouatelse1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.villesTableAdapter = this.villesTableAdapter;
            // 
            // paysTableAdapter
            // 
            this.paysTableAdapter.ClearBeforeFill = true;
            // 
            // villesTableAdapter
            // 
            this.villesTableAdapter.ClearBeforeFill = true;
            // 
            // Prenom
            // 
            this.Prenom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "prenom", true));
            this.Prenom.Location = new System.Drawing.Point(664, 123);
            this.Prenom.Name = "Prenom";
            this.Prenom.Size = new System.Drawing.Size(159, 20);
            this.Prenom.TabIndex = 47;
            // 
            // ModifierClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 522);
            this.Controls.Add(this.Prenom);
            this.Controls.Add(this.annulerClient);
            this.Controls.Add(this.validerClient);
            this.Controls.Add(this.tabControl1);
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
            this.Name = "ModifierClient";
            this.Text = "Détails d\'un client";
            this.Load += new System.EventHandler(this.ModifierClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt_ouatelse1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paysBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.villesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.Factures.ResumeLayout(false);
            this.Statistiques.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Mail;
        private System.Windows.Forms.TextBox DateNaissance;
        private System.Windows.Forms.TextBox Téléphone;
        private System.Windows.Forms.TextBox NomPays;
        private System.Windows.Forms.TextBox NomVille;
        private System.Windows.Forms.TextBox CodePostal;
        private System.Windows.Forms.TextBox Adresse2;
        private System.Windows.Forms.TextBox Adresse1;
        private System.Windows.Forms.TextBox CodeClient;
        private System.Windows.Forms.TextBox Nom;
        private System.Windows.Forms.ComboBox Genre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ref;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produits;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix_HT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix_TTC;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Factures;
        private System.Windows.Forms.TabPage Statistiques;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Achats;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fréquence;
        private System.Windows.Forms.TabPage Notes;
        private System.Windows.Forms.Button validerClient;
        private System.Windows.Forms.Button annulerClient;
        private pt_ouatelse1DataSet pt_ouatelse1DataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private pt_ouatelse1DataSetTableAdapters.clientsTableAdapter clientsTableAdapter;
        private pt_ouatelse1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private pt_ouatelse1DataSetTableAdapters.villesTableAdapter villesTableAdapter;
        private System.Windows.Forms.BindingSource villesBindingSource;
        private pt_ouatelse1DataSetTableAdapters.paysTableAdapter paysTableAdapter;
        private System.Windows.Forms.BindingSource paysBindingSource;
        private System.Windows.Forms.TextBox Prenom;

    }
}