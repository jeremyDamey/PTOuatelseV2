﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }

        private void Connexion_Load(object sender, EventArgs e)
        {
            this.Text = IdentifiantBox.Text;
        }

        private void ConnectionButton_Click(object sender, EventArgs e)
        {
            if (MDPBox.Text != "aa")
            {
                PTOuatelse.EchecConnexion echec = new PTOuatelse.EchecConnexion();
                echec.Show();
            }
            else
            {
                Connecte connection = new Connecte();
                connection.Show();
            }
           
        }

        private void AnnulerButton_Click(object sender, EventArgs e)
        {
            MDPBox.ResetText();
            IdentifiantBox.ResetText();
        }
    }
}
