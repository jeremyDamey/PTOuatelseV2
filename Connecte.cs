using System;
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
    public partial class Connecte : Form
    {
        string id = null;
        public Connecte(String test)
        {
            InitializeComponent();
            this.id = test;
        }

        private void BonjourText_Click(object sender, EventArgs e)
        {
            
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            Accueil accueil = new Accueil(id);
            accueil.Show();
            this.Hide();
        }

        private void Connecte_Load(object sender, EventArgs e)
        {
            Connexion connexion = new Connexion();
            BonjourText.Text = "Bonjour " + this.id;
        }
    }
}
