﻿namespace PTOuatelse
{
    partial class ClientModifie
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
            this.OKNouveauClient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OKNouveauClient
            // 
            this.OKNouveauClient.Location = new System.Drawing.Point(87, 55);
            this.OKNouveauClient.Name = "OKNouveauClient";
            this.OKNouveauClient.Size = new System.Drawing.Size(75, 23);
            this.OKNouveauClient.TabIndex = 3;
            this.OKNouveauClient.Text = "OK";
            this.OKNouveauClient.UseVisualStyleBackColor = true;
            this.OKNouveauClient.Click += new System.EventHandler(this.OKNouveauClient_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Client modifié.";
            // 
            // ClientModifie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 110);
            this.Controls.Add(this.OKNouveauClient);
            this.Controls.Add(this.label1);
            this.Name = "ClientModifie";
            this.Text = "ClientModifie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKNouveauClient;
        private System.Windows.Forms.Label label1;
    }
}