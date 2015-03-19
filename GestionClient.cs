using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTOuatelse
{
    public partial class GestionClients : Form
    {
        string chaine = null;
        public GestionClients()
        {
            InitializeComponent();
            DBConect connexion = new DBConect();
            connexion.Initialize();
            chaine = connexion.requete("SELECT nom FROM  clients","nom");
            MessageBox.Show(chaine.ToString());
        }

        private void GestionClients_Load(object sender, EventArgs e)
        {

        }

        private void NouveauClient_Click(object sender, EventArgs e)
        {
            NouveauClient nouveau = new NouveauClient();
            nouveau.Show();
        }

        private void modifierClient_Click(object sender, EventArgs e)
        {
            ModifierClient modifier = new ModifierClient();
            modifier.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void supprimerClient_Click(object sender, EventArgs e)
        {

        }
    }
}
