namespace PTOuatelse
{
    partial class NouveauProduit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NouveauProduit));
            this.mouvementstockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pt_ouatelse1DataSet = new PTOuatelse.pt_ouatelse1DataSet();
            this.mouvement_stockTableAdapter = new PTOuatelse.pt_ouatelse1DataSetTableAdapters.mouvement_stockTableAdapter();
            this.facturesproduitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.factures_produitsTableAdapter = new PTOuatelse.pt_ouatelse1DataSetTableAdapters.factures_produitsTableAdapter();
            this.annuler = new System.Windows.Forms.Button();
            this.ajouter = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.produitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.produitsTableAdapter = new PTOuatelse.pt_ouatelse1DataSetTableAdapters.produitsTableAdapter();
            this.tableAdapterManager = new PTOuatelse.pt_ouatelse1DataSetTableAdapters.TableAdapterManager();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.mouvementstockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt_ouatelse1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturesproduitsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mouvementstockBindingSource
            // 
            this.mouvementstockBindingSource.DataMember = "mouvement_stock";
            this.mouvementstockBindingSource.DataSource = this.pt_ouatelse1DataSet;
            // 
            // pt_ouatelse1DataSet
            // 
            this.pt_ouatelse1DataSet.DataSetName = "pt_ouatelse1DataSet";
            this.pt_ouatelse1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mouvement_stockTableAdapter
            // 
            this.mouvement_stockTableAdapter.ClearBeforeFill = true;
            // 
            // facturesproduitsBindingSource
            // 
            this.facturesproduitsBindingSource.DataMember = "factures_produits";
            this.facturesproduitsBindingSource.DataSource = this.pt_ouatelse1DataSet;
            // 
            // factures_produitsTableAdapter
            // 
            this.factures_produitsTableAdapter.ClearBeforeFill = true;
            // 
            // annuler
            // 
            this.annuler.Location = new System.Drawing.Point(400, 276);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(75, 23);
            this.annuler.TabIndex = 81;
            this.annuler.Text = "Annuler";
            this.annuler.UseVisualStyleBackColor = true;
            this.annuler.Click += new System.EventHandler(this.annuler_Click);
            // 
            // ajouter
            // 
            this.ajouter.Location = new System.Drawing.Point(183, 276);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(75, 23);
            this.ajouter.TabIndex = 80;
            this.ajouter.Text = "Ajouter";
            this.ajouter.UseVisualStyleBackColor = true;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produitsBindingSource, "tva", true));
            this.textBox6.Location = new System.Drawing.Point(501, 187);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(111, 20);
            this.textBox6.TabIndex = 78;
            // 
            // produitsBindingSource
            // 
            this.produitsBindingSource.DataMember = "produits";
            this.produitsBindingSource.DataSource = this.pt_ouatelse1DataSet;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(434, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 77;
            this.label7.Text = "Taux TVA :";
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produitsBindingSource, "prix_vente", true));
            this.textBox5.Location = new System.Drawing.Point(333, 187);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(85, 20);
            this.textBox5.TabIndex = 76;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(234, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 75;
            this.label6.Text = "Prix de vente HT :";
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produitsBindingSource, "prix_achat", true));
            this.textBox4.Location = new System.Drawing.Point(138, 187);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(90, 20);
            this.textBox4.TabIndex = 74;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 73;
            this.label5.Text = "Prix d\'achat HT :";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produitsBindingSource, "nom", true));
            this.textBox3.Location = new System.Drawing.Point(138, 161);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(474, 20);
            this.textBox3.TabIndex = 72;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 71;
            this.label4.Text = "Désignation :";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produitsBindingSource, "code_ean", true));
            this.textBox2.Location = new System.Drawing.Point(354, 128);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(258, 20);
            this.textBox2.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 69;
            this.label3.Text = "Code EAN :";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produitsBindingSource, "id", true));
            this.textBox1.Location = new System.Drawing.Point(138, 128);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 67;
            this.label2.Text = "Code produit  :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(155, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 31);
            this.label1.TabIndex = 66;
            this.label1.Text = "Détails d\'un Produit";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 65;
            this.pictureBox1.TabStop = false;
            // 
            // produitsTableAdapter
            // 
            this.produitsTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.produitsTableAdapter = this.produitsTableAdapter;
            this.tableAdapterManager.rolesTableAdapter = null;
            this.tableAdapterManager.salariesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PTOuatelse.pt_ouatelse1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.villesTableAdapter = null;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 82;
            this.label8.Text = "Quantité :";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(138, 232);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 83;
            // 
            // NouveauProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 346);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.annuler);
            this.Controls.Add(this.ajouter);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "NouveauProduit";
            this.Text = "NouveauProduit";
            ((System.ComponentModel.ISupportInitialize)(this.mouvementstockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt_ouatelse1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturesproduitsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource mouvementstockBindingSource;
        private pt_ouatelse1DataSet pt_ouatelse1DataSet;
        private pt_ouatelse1DataSetTableAdapters.mouvement_stockTableAdapter mouvement_stockTableAdapter;
        private System.Windows.Forms.BindingSource facturesproduitsBindingSource;
        private pt_ouatelse1DataSetTableAdapters.factures_produitsTableAdapter factures_produitsTableAdapter;
        private System.Windows.Forms.Button annuler;
        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.BindingSource produitsBindingSource;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private pt_ouatelse1DataSetTableAdapters.produitsTableAdapter produitsTableAdapter;
        private pt_ouatelse1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox7;
    }
}