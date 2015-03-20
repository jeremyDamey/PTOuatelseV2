namespace PTOuatelse
{
    partial class ModifierProduit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifierProduit));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.produitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pt_ouatelse1DataSet = new PTOuatelse.pt_ouatelse1DataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.produitsTableAdapter = new PTOuatelse.pt_ouatelse1DataSetTableAdapters.produitsTableAdapter();
            this.tableAdapterManager = new PTOuatelse.pt_ouatelse1DataSetTableAdapters.TableAdapterManager();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.stock = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produitsidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magasinidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mouvementstockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.stats = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Mois = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nb_VentesMois = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Semaine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nb_Ventes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notes = new System.Windows.Forms.TabPage();
            this.mouvement_stockTableAdapter = new PTOuatelse.pt_ouatelse1DataSetTableAdapters.mouvement_stockTableAdapter();
            this.facturesproduitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.factures_produitsTableAdapter = new PTOuatelse.pt_ouatelse1DataSetTableAdapters.factures_produitsTableAdapter();
            this.valider = new System.Windows.Forms.Button();
            this.annuler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt_ouatelse1DataSet)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.stock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mouvementstockBindingSource)).BeginInit();
            this.stats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturesproduitsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(42, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(167, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 31);
            this.label1.TabIndex = 48;
            this.label1.Text = "Détails d\'un Produit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Code produit  :";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produitsBindingSource, "id", true));
            this.textBox1.Location = new System.Drawing.Point(150, 137);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 50;
            // 
            // produitsBindingSource
            // 
            this.produitsBindingSource.DataMember = "produits";
            this.produitsBindingSource.DataSource = this.pt_ouatelse1DataSet;
            // 
            // pt_ouatelse1DataSet
            // 
            this.pt_ouatelse1DataSet.DataSetName = "pt_ouatelse1DataSet";
            this.pt_ouatelse1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Code EAN :";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produitsBindingSource, "code_ean", true));
            this.textBox2.Location = new System.Drawing.Point(366, 137);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(258, 20);
            this.textBox2.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "Désignation :";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produitsBindingSource, "nom", true));
            this.textBox3.Location = new System.Drawing.Point(150, 170);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(474, 20);
            this.textBox3.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 55;
            this.label5.Text = "Prix d\'achat HT :";
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produitsBindingSource, "prix_achat", true));
            this.textBox4.Location = new System.Drawing.Point(150, 196);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(90, 20);
            this.textBox4.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(246, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 57;
            this.label6.Text = "Prix de vente HT :";
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produitsBindingSource, "prix_vente", true));
            this.textBox5.Location = new System.Drawing.Point(345, 196);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(85, 20);
            this.textBox5.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(446, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 59;
            this.label7.Text = "Taux TVA :";
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produitsBindingSource, "tva", true));
            this.textBox6.Location = new System.Drawing.Point(513, 196);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(111, 20);
            this.textBox6.TabIndex = 60;
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.stock);
            this.tabControl1.Controls.Add(this.stats);
            this.tabControl1.Controls.Add(this.notes);
            this.tabControl1.Location = new System.Drawing.Point(42, 257);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(582, 263);
            this.tabControl1.TabIndex = 62;
            // 
            // stock
            // 
            this.stock.Controls.Add(this.dataGridView1);
            this.stock.Controls.Add(this.textBox7);
            this.stock.Controls.Add(this.label9);
            this.stock.Controls.Add(this.label8);
            this.stock.Location = new System.Drawing.Point(4, 22);
            this.stock.Name = "stock";
            this.stock.Padding = new System.Windows.Forms.Padding(3);
            this.stock.Size = new System.Drawing.Size(574, 237);
            this.stock.TabIndex = 0;
            this.stock.Text = "Stock";
            this.stock.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.quantiteDataGridViewTextBoxColumn,
            this.produitsidDataGridViewTextBoxColumn,
            this.magasinidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mouvementstockBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(574, 150);
            this.dataGridView1.TabIndex = 65;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // quantiteDataGridViewTextBoxColumn
            // 
            this.quantiteDataGridViewTextBoxColumn.DataPropertyName = "quantite";
            this.quantiteDataGridViewTextBoxColumn.HeaderText = "quantite";
            this.quantiteDataGridViewTextBoxColumn.Name = "quantiteDataGridViewTextBoxColumn";
            // 
            // produitsidDataGridViewTextBoxColumn
            // 
            this.produitsidDataGridViewTextBoxColumn.DataPropertyName = "produits_id";
            this.produitsidDataGridViewTextBoxColumn.HeaderText = "produits_id";
            this.produitsidDataGridViewTextBoxColumn.Name = "produitsidDataGridViewTextBoxColumn";
            // 
            // magasinidDataGridViewTextBoxColumn
            // 
            this.magasinidDataGridViewTextBoxColumn.DataPropertyName = "magasin_id";
            this.magasinidDataGridViewTextBoxColumn.HeaderText = "magasin_id";
            this.magasinidDataGridViewTextBoxColumn.Name = "magasinidDataGridViewTextBoxColumn";
            // 
            // mouvementstockBindingSource
            // 
            this.mouvementstockBindingSource.DataMember = "mouvement_stock";
            this.mouvementstockBindingSource.DataSource = this.pt_ouatelse1DataSet;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(467, 3);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 64;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(370, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 63;
            this.label9.Text = "Stock actuel : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 13);
            this.label8.TabIndex = 62;
            this.label8.Text = "Historique des mouvements de stock :";
            // 
            // stats
            // 
            this.stats.Controls.Add(this.label11);
            this.stats.Controls.Add(this.label10);
            this.stats.Controls.Add(this.dataGridView3);
            this.stats.Controls.Add(this.dataGridView2);
            this.stats.Location = new System.Drawing.Point(4, 22);
            this.stats.Name = "stats";
            this.stats.Padding = new System.Windows.Forms.Padding(3);
            this.stats.Size = new System.Drawing.Size(574, 237);
            this.stats.TabIndex = 1;
            this.stats.Text = "Statistiques";
            this.stats.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(296, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(198, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Progression des ventes par mois :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(219, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Progression des ventes par semaine :";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mois,
            this.Nb_VentesMois});
            this.dataGridView3.Location = new System.Drawing.Point(299, 60);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(246, 159);
            this.dataGridView3.TabIndex = 1;
            // 
            // Mois
            // 
            this.Mois.HeaderText = "Mois";
            this.Mois.Name = "Mois";
            // 
            // Nb_VentesMois
            // 
            this.Nb_VentesMois.HeaderText = "Nb Ventes";
            this.Nb_VentesMois.Name = "Nb_VentesMois";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Semaine,
            this.Nb_Ventes});
            this.dataGridView2.Location = new System.Drawing.Point(18, 60);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(245, 159);
            this.dataGridView2.TabIndex = 0;
            // 
            // Semaine
            // 
            this.Semaine.HeaderText = "Semaine";
            this.Semaine.Name = "Semaine";
            // 
            // Nb_Ventes
            // 
            this.Nb_Ventes.HeaderText = "Nb_Ventes";
            this.Nb_Ventes.Name = "Nb_Ventes";
            // 
            // notes
            // 
            this.notes.Location = new System.Drawing.Point(4, 22);
            this.notes.Name = "notes";
            this.notes.Padding = new System.Windows.Forms.Padding(3);
            this.notes.Size = new System.Drawing.Size(574, 237);
            this.notes.TabIndex = 2;
            this.notes.Text = "Notes";
            this.notes.UseVisualStyleBackColor = true;
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
            // valider
            // 
            this.valider.Location = new System.Drawing.Point(173, 536);
            this.valider.Name = "valider";
            this.valider.Size = new System.Drawing.Size(75, 23);
            this.valider.TabIndex = 63;
            this.valider.Text = "Valider";
            this.valider.UseVisualStyleBackColor = true;
            this.valider.Click += new System.EventHandler(this.valider_Click);
            // 
            // annuler
            // 
            this.annuler.Location = new System.Drawing.Point(392, 536);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(75, 23);
            this.annuler.TabIndex = 64;
            this.annuler.Text = "Annuler";
            this.annuler.UseVisualStyleBackColor = true;
            this.annuler.Click += new System.EventHandler(this.annuler_Click);
            // 
            // ModifierProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 577);
            this.Controls.Add(this.annuler);
            this.Controls.Add(this.valider);
            this.Controls.Add(this.tabControl1);
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
            this.Name = "ModifierProduit";
            this.Text = "ModifierProduit";
            this.Load += new System.EventHandler(this.ModifierProduit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt_ouatelse1DataSet)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.stock.ResumeLayout(false);
            this.stock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mouvementstockBindingSource)).EndInit();
            this.stats.ResumeLayout(false);
            this.stats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturesproduitsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private pt_ouatelse1DataSet pt_ouatelse1DataSet;
        private System.Windows.Forms.BindingSource produitsBindingSource;
        private pt_ouatelse1DataSetTableAdapters.produitsTableAdapter produitsTableAdapter;
        private pt_ouatelse1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage stock;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage stats;
        private System.Windows.Forms.TabPage notes;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource mouvementstockBindingSource;
        private pt_ouatelse1DataSetTableAdapters.mouvement_stockTableAdapter mouvement_stockTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produitsidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn magasinidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource facturesproduitsBindingSource;
        private pt_ouatelse1DataSetTableAdapters.factures_produitsTableAdapter factures_produitsTableAdapter;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mois;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nb_VentesMois;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semaine;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nb_Ventes;
        private System.Windows.Forms.Button valider;
        private System.Windows.Forms.Button annuler;
    }
}