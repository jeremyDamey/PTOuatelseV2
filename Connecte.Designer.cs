namespace WindowsFormsApplication1
{
    partial class Connecte
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
            this.OKbutton = new System.Windows.Forms.Button();
            this.BonjourText = new System.Windows.Forms.Label();
            this.UtilisationText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OKbutton
            // 
            this.OKbutton.Location = new System.Drawing.Point(117, 74);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(75, 23);
            this.OKbutton.TabIndex = 0;
            this.OKbutton.Text = "OK";
            this.OKbutton.UseVisualStyleBackColor = true;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // BonjourText
            // 
            this.BonjourText.AutoSize = true;
            this.BonjourText.Location = new System.Drawing.Point(28, 21);
            this.BonjourText.Name = "BonjourText";
            this.BonjourText.Size = new System.Drawing.Size(43, 13);
            this.BonjourText.TabIndex = 1;
            this.BonjourText.Text = "Bonjour";
            this.BonjourText.Click += new System.EventHandler(this.BonjourText_Click);
            // 
            // UtilisationText
            // 
            this.UtilisationText.AutoSize = true;
            this.UtilisationText.Location = new System.Drawing.Point(28, 47);
            this.UtilisationText.Name = "UtilisationText";
            this.UtilisationText.Size = new System.Drawing.Size(262, 13);
            this.UtilisationText.TabIndex = 2;
            this.UtilisationText.Text = "Nous vous souhaitons une bonne utilisation du logiciel";
            // 
            // Connecte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 119);
            this.Controls.Add(this.UtilisationText);
            this.Controls.Add(this.BonjourText);
            this.Controls.Add(this.OKbutton);
            this.Name = "Connecte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connecté";
            this.Load += new System.EventHandler(this.Connecte_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKbutton;
        private System.Windows.Forms.Label BonjourText;
        private System.Windows.Forms.Label UtilisationText;
    }
}