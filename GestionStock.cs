using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace PTOuatelse
{
    public partial class GestionStock : Form
    {
        string nomsProduits = null;
        string prixAchatProduit = null;
        public GestionStock()
        {
            InitializeComponent();
            DBConect connexion = new DBConect();
            connexion.Initialize();
            nomsProduits = connexion.requete("SELECT prix_achat FROM  produits", "prix_achat");
            //prixAchatProduit = connexion.requete("SELECT prix_achat FROM produits");
            MessageBox.Show(nomsProduits.ToString());
            //MessageBox.Show(prixAchatProduit.ToString());
        }

        private void modifierProduit_Click(object sender, EventArgs e)
        {

        }

        private void nouveauProduit_Click(object sender, EventArgs e)
        {

        }

        private void reaprovisionnerProduit_Click(object sender, EventArgs e)
        {

        }

        private void destockerProduit_Click(object sender, EventArgs e)
        {

        }

        private void supprimerProduit_Click(object sender, EventArgs e)
        {

        }

        private void rechercher_TextChanged(object sender, EventArgs e)
        {
            rechercher.ResetText();
        }

        private void recherche_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GestionStock_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
