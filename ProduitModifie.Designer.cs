namespace PTOuatelse
{
    partial class ProduitModifie
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
            this.OKProduitAjoute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Produit modifié.";
            // 
            // OKProduitAjoute
            // 
            this.OKProduitAjoute.Location = new System.Drawing.Point(100, 79);
            this.OKProduitAjoute.Name = "OKProduitAjoute";
            this.OKProduitAjoute.Size = new System.Drawing.Size(75, 23);
            this.OKProduitAjoute.TabIndex = 2;
            this.OKProduitAjoute.Text = "OK";
            this.OKProduitAjoute.UseVisualStyleBackColor = true;
            this.OKProduitAjoute.Click += new System.EventHandler(this.OKProduitAjoute_Click);
            // 
            // ProduitModifie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 125);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OKProduitAjoute);
            this.Name = "ProduitModifie";
            this.Text = "ProduitModifie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OKProduitAjoute;
    }
}