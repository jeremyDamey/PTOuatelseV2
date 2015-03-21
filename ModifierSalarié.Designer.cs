namespace PTOuatelse
{
    partial class ModifierSalarié
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifierSalarié));
            this.Mail = new System.Windows.Forms.TextBox();
            this.salariesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pt_ouatelse1DataSet = new PTOuatelse.pt_ouatelse1DataSet();
            this.DateNaissance = new System.Windows.Forms.TextBox();
            this.Téléphone = new System.Windows.Forms.TextBox();
            this.NomPays = new System.Windows.Forms.TextBox();
            this.CodePostalSal = new System.Windows.Forms.TextBox();
            this.VilleSal = new System.Windows.Forms.TextBox();
            this.Adresse1 = new System.Windows.Forms.TextBox();
            this.idSalarie = new System.Windows.Forms.TextBox();
            this.Nom = new System.Windows.Forms.TextBox();
            this.Genre = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.validerModifSalarie = new System.Windows.Forms.Button();
            this.annulerModifierSalarie = new System.Windows.Forms.Button();
            this.salariesTableAdapter = new PTOuatelse.pt_ouatelse1DataSetTableAdapters.salariesTableAdapter();
            this.tableAdapterManager = new PTOuatelse.pt_ouatelse1DataSetTableAdapters.TableAdapterManager();
            this.Prenom = new System.Windows.Forms.TextBox();
            this.AdrMag = new System.Windows.Forms.Label();
            this.CodePostalMag = new System.Windows.Forms.TextBox();
            this.VilleMag = new System.Windows.Forms.TextBox();
            this.AdresseMag = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.salariesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt_ouatelse1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Mail
            // 
            this.Mail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salariesBindingSource, "mail", true));
            this.Mail.Location = new System.Drawing.Point(175, 274);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(672, 20);
            this.Mail.TabIndex = 65;
            this.Mail.TextChanged += new System.EventHandler(this.Mail_TextChanged);
            // 
            // salariesBindingSource
            // 
            this.salariesBindingSource.DataMember = "salaries";
            this.salariesBindingSource.DataSource = this.pt_ouatelse1DataSet;
            // 
            // pt_ouatelse1DataSet
            // 
            this.pt_ouatelse1DataSet.DataSetName = "pt_ouatelse1DataSet";
            this.pt_ouatelse1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DateNaissance
            // 
            this.DateNaissance.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salariesBindingSource, "naissance", true));
            this.DateNaissance.Location = new System.Drawing.Point(660, 242);
            this.DateNaissance.Name = "DateNaissance";
            this.DateNaissance.Size = new System.Drawing.Size(188, 20);
            this.DateNaissance.TabIndex = 64;
            // 
            // Téléphone
            // 
            this.Téléphone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salariesBindingSource, "portable", true));
            this.Téléphone.Location = new System.Drawing.Point(175, 242);
            this.Téléphone.Name = "Téléphone";
            this.Téléphone.Size = new System.Drawing.Size(369, 20);
            this.Téléphone.TabIndex = 63;
            // 
            // NomPays
            // 
            this.NomPays.Location = new System.Drawing.Point(609, 210);
            this.NomPays.Name = "NomPays";
            this.NomPays.ReadOnly = true;
            this.NomPays.Size = new System.Drawing.Size(238, 20);
            this.NomPays.TabIndex = 62;
            // 
            // CodePostalSal
            // 
            this.CodePostalSal.Location = new System.Drawing.Point(456, 155);
            this.CodePostalSal.Name = "CodePostalSal";
            this.CodePostalSal.Size = new System.Drawing.Size(100, 20);
            this.CodePostalSal.TabIndex = 60;
            // 
            // VilleSal
            // 
            this.VilleSal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salariesBindingSource, "adresse2", true));
            this.VilleSal.Location = new System.Drawing.Point(609, 154);
            this.VilleSal.Name = "VilleSal";
            this.VilleSal.Size = new System.Drawing.Size(238, 20);
            this.VilleSal.TabIndex = 59;
            // 
            // Adresse1
            // 
            this.Adresse1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salariesBindingSource, "adresse1", true));
            this.Adresse1.Location = new System.Drawing.Point(175, 151);
            this.Adresse1.Name = "Adresse1";
            this.Adresse1.Size = new System.Drawing.Size(238, 20);
            this.Adresse1.TabIndex = 58;
            // 
            // idSalarie
            // 
            this.idSalarie.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salariesBindingSource, "id", true));
            this.idSalarie.Location = new System.Drawing.Point(175, 124);
            this.idSalarie.Name = "idSalarie";
            this.idSalarie.ReadOnly = true;
            this.idSalarie.Size = new System.Drawing.Size(238, 20);
            this.idSalarie.TabIndex = 57;
            // 
            // Nom
            // 
            this.Nom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salariesBindingSource, "nom", true));
            this.Nom.Location = new System.Drawing.Point(562, 126);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(120, 20);
            this.Nom.TabIndex = 56;
            // 
            // Genre
            // 
            this.Genre.FormattingEnabled = true;
            this.Genre.Location = new System.Drawing.Point(499, 125);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(57, 21);
            this.Genre.TabIndex = 55;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(419, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 54;
            this.label9.Text = "Nom Prénom :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(97, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 53;
            this.label8.Text = "Courriel :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(96, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "Tel/Port :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(571, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Pays :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(419, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "CP :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Adresse :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Identifiant  :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(169, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 31);
            this.label1.TabIndex = 45;
            this.label1.Text = "Détails d\'un Salarié";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(550, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 52;
            this.label7.Text = "Date de naissance :";
            // 
            // validerModifSalarie
            // 
            this.validerModifSalarie.Location = new System.Drawing.Point(338, 317);
            this.validerModifSalarie.Name = "validerModifSalarie";
            this.validerModifSalarie.Size = new System.Drawing.Size(75, 23);
            this.validerModifSalarie.TabIndex = 66;
            this.validerModifSalarie.Text = "Valider";
            this.validerModifSalarie.UseVisualStyleBackColor = true;
            this.validerModifSalarie.Click += new System.EventHandler(this.validerModifSalarie_Click);
            // 
            // annulerModifierSalarie
            // 
            this.annulerModifierSalarie.Location = new System.Drawing.Point(481, 317);
            this.annulerModifierSalarie.Name = "annulerModifierSalarie";
            this.annulerModifierSalarie.Size = new System.Drawing.Size(75, 23);
            this.annulerModifierSalarie.TabIndex = 67;
            this.annulerModifierSalarie.Text = "Annuler";
            this.annulerModifierSalarie.UseVisualStyleBackColor = true;
            this.annulerModifierSalarie.Click += new System.EventHandler(this.annulerModifierSalarie_Click);
            // 
            // salariesTableAdapter
            // 
            this.salariesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.civiliteTableAdapter = null;
            this.tableAdapterManager.clientsTableAdapter = null;
            this.tableAdapterManager.congeTableAdapter = null;
            this.tableAdapterManager.factures_produitsTableAdapter = null;
            this.tableAdapterManager.facturesTableAdapter = null;
            this.tableAdapterManager.magasinTableAdapter = null;
            this.tableAdapterManager.mouvement_stockTableAdapter = null;
            this.tableAdapterManager.moyen_de_paiementTableAdapter = null;
            this.tableAdapterManager.paysTableAdapter = null;
            this.tableAdapterManager.produitsTableAdapter = null;
            this.tableAdapterManager.rolesTableAdapter = null;
            this.tableAdapterManager.salariesTableAdapter = this.salariesTableAdapter;
            this.tableAdapterManager.UpdateOrder = PTOuatelse.pt_ouatelse1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.villesTableAdapter = null;
            // 
            // Prenom
            // 
            this.Prenom.Location = new System.Drawing.Point(688, 125);
            this.Prenom.Name = "Prenom";
            this.Prenom.Size = new System.Drawing.Size(159, 20);
            this.Prenom.TabIndex = 68;
            // 
            // AdrMag
            // 
            this.AdrMag.AutoSize = true;
            this.AdrMag.Location = new System.Drawing.Point(91, 180);
            this.AdrMag.Name = "AdrMag";
            this.AdrMag.Size = new System.Drawing.Size(78, 13);
            this.AdrMag.TabIndex = 69;
            this.AdrMag.Text = "Adresse Mag. :";
            // 
            // CodePostalMag
            // 
            this.CodePostalMag.Location = new System.Drawing.Point(456, 180);
            this.CodePostalMag.Name = "CodePostalMag";
            this.CodePostalMag.ReadOnly = true;
            this.CodePostalMag.Size = new System.Drawing.Size(100, 20);
            this.CodePostalMag.TabIndex = 70;
            // 
            // VilleMag
            // 
            this.VilleMag.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salariesBindingSource, "adresse2", true));
            this.VilleMag.Location = new System.Drawing.Point(609, 180);
            this.VilleMag.Name = "VilleMag";
            this.VilleMag.ReadOnly = true;
            this.VilleMag.Size = new System.Drawing.Size(238, 20);
            this.VilleMag.TabIndex = 71;
            // 
            // AdresseMag
            // 
            this.AdresseMag.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salariesBindingSource, "adresse1", true));
            this.AdresseMag.Location = new System.Drawing.Point(175, 177);
            this.AdresseMag.Name = "AdresseMag";
            this.AdresseMag.ReadOnly = true;
            this.AdresseMag.Size = new System.Drawing.Size(238, 20);
            this.AdresseMag.TabIndex = 72;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(419, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 73;
            this.label10.Text = "CP :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(571, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 74;
            this.label11.Text = "Ville :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(571, 183);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 75;
            this.label12.Text = "Ville :";
            // 
            // ModifierSalarié
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 360);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.AdresseMag);
            this.Controls.Add(this.VilleMag);
            this.Controls.Add(this.CodePostalMag);
            this.Controls.Add(this.AdrMag);
            this.Controls.Add(this.Prenom);
            this.Controls.Add(this.annulerModifierSalarie);
            this.Controls.Add(this.validerModifSalarie);
            this.Controls.Add(this.Mail);
            this.Controls.Add(this.DateNaissance);
            this.Controls.Add(this.Téléphone);
            this.Controls.Add(this.NomPays);
            this.Controls.Add(this.CodePostalSal);
            this.Controls.Add(this.VilleSal);
            this.Controls.Add(this.Adresse1);
            this.Controls.Add(this.idSalarie);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Name = "ModifierSalarié";
            this.Text = "Modifier Salarié";
            this.Load += new System.EventHandler(this.ModifierSalarié_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salariesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt_ouatelse1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Mail;
        private System.Windows.Forms.TextBox DateNaissance;
        private System.Windows.Forms.TextBox Téléphone;
        private System.Windows.Forms.TextBox NomPays;
        private System.Windows.Forms.TextBox CodePostalSal;
        private System.Windows.Forms.TextBox VilleSal;
        private System.Windows.Forms.TextBox Adresse1;
        private System.Windows.Forms.TextBox idSalarie;
        private System.Windows.Forms.TextBox Nom;
        private System.Windows.Forms.ComboBox Genre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button validerModifSalarie;
        private System.Windows.Forms.Button annulerModifierSalarie;
        private pt_ouatelse1DataSet pt_ouatelse1DataSet;
        private System.Windows.Forms.BindingSource salariesBindingSource;
        private pt_ouatelse1DataSetTableAdapters.salariesTableAdapter salariesTableAdapter;
        private pt_ouatelse1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox Prenom;
        private System.Windows.Forms.Label AdrMag;
        private System.Windows.Forms.TextBox CodePostalMag;
        private System.Windows.Forms.TextBox VilleMag;
        private System.Windows.Forms.TextBox AdresseMag;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}