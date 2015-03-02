namespace WindowsFormsApplication1
{
    partial class Connexion
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
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.IdentifiantBox = new System.Windows.Forms.TextBox();
            this.MDPBox = new System.Windows.Forms.TextBox();
            this.ConnectionButton = new System.Windows.Forms.Button();
            this.AnnulerButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // logoBox
            // 
            this.logoBox.Location = new System.Drawing.Point(124, 42);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(100, 96);
            this.logoBox.TabIndex = 0;
            this.logoBox.TabStop = false;
            this.logoBox.Click += new System.EventHandler(this.logoBox_Click);
            // 
            // IdentifiantBox
            // 
            this.IdentifiantBox.Location = new System.Drawing.Point(124, 179);
            this.IdentifiantBox.Name = "IdentifiantBox";
            this.IdentifiantBox.Size = new System.Drawing.Size(100, 20);
            this.IdentifiantBox.TabIndex = 1;
            this.IdentifiantBox.Text = "identifiant";
            // 
            // MDPBox
            // 
            this.MDPBox.Location = new System.Drawing.Point(124, 223);
            this.MDPBox.Name = "MDPBox";
            this.MDPBox.Size = new System.Drawing.Size(100, 20);
            this.MDPBox.TabIndex = 2;
            this.MDPBox.Text = "*******";
            // 
            // ConnectionButton
            // 
            this.ConnectionButton.Location = new System.Drawing.Point(242, 282);
            this.ConnectionButton.Name = "ConnectionButton";
            this.ConnectionButton.Size = new System.Drawing.Size(75, 23);
            this.ConnectionButton.TabIndex = 3;
            this.ConnectionButton.Text = "Connection";
            this.ConnectionButton.UseVisualStyleBackColor = true;
            this.ConnectionButton.Click += new System.EventHandler(this.ConnectionButton_Click);
            // 
            // AnnulerButton
            // 
            this.AnnulerButton.Location = new System.Drawing.Point(26, 282);
            this.AnnulerButton.Name = "AnnulerButton";
            this.AnnulerButton.Size = new System.Drawing.Size(75, 23);
            this.AnnulerButton.TabIndex = 4;
            this.AnnulerButton.Text = "Annuler";
            this.AnnulerButton.UseVisualStyleBackColor = true;
            this.AnnulerButton.Click += new System.EventHandler(this.AnnulerButton_Click);
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 333);
            this.Controls.Add(this.AnnulerButton);
            this.Controls.Add(this.ConnectionButton);
            this.Controls.Add(this.MDPBox);
            this.Controls.Add(this.IdentifiantBox);
            this.Controls.Add(this.logoBox);
            this.Name = "Connexion";
            this.Text = "Connexion";
            this.Load += new System.EventHandler(this.Connexion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.Button ConnectionButton;
        private System.Windows.Forms.Button AnnulerButton;
        public System.Windows.Forms.TextBox IdentifiantBox;
        public System.Windows.Forms.TextBox MDPBox;
    }
}