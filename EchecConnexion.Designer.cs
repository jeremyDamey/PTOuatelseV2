namespace PTOuatelse
{
    partial class EchecConnexion
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
            this.OKButton = new System.Windows.Forms.Button();
            this.EchecLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(103, 57);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // EchecLabel
            // 
            this.EchecLabel.AutoSize = true;
            this.EchecLabel.Location = new System.Drawing.Point(12, 19);
            this.EchecLabel.Name = "EchecLabel";
            this.EchecLabel.Size = new System.Drawing.Size(262, 13);
            this.EchecLabel.TabIndex = 1;
            this.EchecLabel.Text = "Veuillez entrez un identifiant et un mot de passe valide";
            // 
            // EchecConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 107);
            this.Controls.Add(this.EchecLabel);
            this.Controls.Add(this.OKButton);
            this.Name = "EchecConnexion";
            this.Text = "Echec connexion";
            this.Load += new System.EventHandler(this.EchecConnexion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label EchecLabel;
    }
}