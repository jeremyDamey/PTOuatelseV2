namespace PTOuatelse
{
    partial class SalarieModifie
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
            this.OKNouveauSalarie = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OKNouveauSalarie
            // 
            this.OKNouveauSalarie.Location = new System.Drawing.Point(97, 68);
            this.OKNouveauSalarie.Name = "OKNouveauSalarie";
            this.OKNouveauSalarie.Size = new System.Drawing.Size(75, 23);
            this.OKNouveauSalarie.TabIndex = 3;
            this.OKNouveauSalarie.Text = "OK";
            this.OKNouveauSalarie.UseVisualStyleBackColor = true;
            this.OKNouveauSalarie.Click += new System.EventHandler(this.OKNouveauSalarie_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Salarié modifié.";
            // 
            // SalarieModifie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 120);
            this.Controls.Add(this.OKNouveauSalarie);
            this.Controls.Add(this.label1);
            this.Name = "SalarieModifie";
            this.Text = "SalarieModifie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKNouveauSalarie;
        private System.Windows.Forms.Label label1;
    }
}