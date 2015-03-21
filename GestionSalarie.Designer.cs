namespace PTOuatelse
{
    partial class GestionSalarie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionSalarie));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.supprimerSalarie = new System.Windows.Forms.Button();
            this.modifierSalarie = new System.Windows.Forms.Button();
            this.NouveauSalarie = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.recherche = new System.Windows.Forms.Button();
            this.rechercher = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(64, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(838, 231);
            this.dataGridView1.TabIndex = 13;
            // 
            // supprimerSalarie
            // 
            this.supprimerSalarie.Location = new System.Drawing.Point(301, 93);
            this.supprimerSalarie.Name = "supprimerSalarie";
            this.supprimerSalarie.Size = new System.Drawing.Size(100, 23);
            this.supprimerSalarie.TabIndex = 12;
            this.supprimerSalarie.Text = "Supprimer Salarié";
            this.supprimerSalarie.UseVisualStyleBackColor = true;
            this.supprimerSalarie.Click += new System.EventHandler(this.supprimerSalarie_Click);
            // 
            // modifierSalarie
            // 
            this.modifierSalarie.Location = new System.Drawing.Point(195, 93);
            this.modifierSalarie.Name = "modifierSalarie";
            this.modifierSalarie.Size = new System.Drawing.Size(100, 23);
            this.modifierSalarie.TabIndex = 11;
            this.modifierSalarie.Text = "Modifier Salarié";
            this.modifierSalarie.UseVisualStyleBackColor = true;
            this.modifierSalarie.Click += new System.EventHandler(this.modifierSalarie_Click);
            // 
            // NouveauSalarie
            // 
            this.NouveauSalarie.Location = new System.Drawing.Point(89, 93);
            this.NouveauSalarie.Name = "NouveauSalarie";
            this.NouveauSalarie.Size = new System.Drawing.Size(100, 23);
            this.NouveauSalarie.TabIndex = 10;
            this.NouveauSalarie.Text = "Nouveau Salarié";
            this.NouveauSalarie.UseVisualStyleBackColor = true;
            this.NouveauSalarie.Click += new System.EventHandler(this.NouveauSalarie_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Gestion des Salariés";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(64, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // recherche
            // 
            this.recherche.Location = new System.Drawing.Point(810, 93);
            this.recherche.Name = "recherche";
            this.recherche.Size = new System.Drawing.Size(75, 23);
            this.recherche.TabIndex = 15;
            this.recherche.Text = "Rechercher";
            this.recherche.UseVisualStyleBackColor = true;
            // 
            // rechercher
            // 
            this.rechercher.Location = new System.Drawing.Point(704, 93);
            this.rechercher.Name = "rechercher";
            this.rechercher.Size = new System.Drawing.Size(100, 20);
            this.rechercher.TabIndex = 14;
            // 
            // GestionSalarie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 356);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.supprimerSalarie);
            this.Controls.Add(this.modifierSalarie);
            this.Controls.Add(this.NouveauSalarie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.recherche);
            this.Controls.Add(this.rechercher);
            this.Name = "GestionSalarie";
            this.Text = "Gestion Salarié";
            this.Load += new System.EventHandler(this.GestionSalarie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button supprimerSalarie;
        private System.Windows.Forms.Button modifierSalarie;
        private System.Windows.Forms.Button NouveauSalarie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button recherche;
        private System.Windows.Forms.TextBox rechercher;
    }
}