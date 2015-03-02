using PTOuatelse;
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
    public partial class Acceuil : Form
    {
        public Acceuil()
        {
            InitializeComponent();
        }

        private void Acceuil_Load(object sender, EventArgs e)
        {

        }

        private void DeconnexionButton_Click(object sender, EventArgs e)
        {

        }

        private void FactureButton_Click(object sender, EventArgs e)
        {
            NouvelleFacture facture = new NouvelleFacture();
            facture.Show();
            
        }

        private void ClientButton_Click(object sender, EventArgs e)
        {
            GestionClients client = new GestionClients();
            client.Show();
        }

        private void SalarieButton_Click(object sender, EventArgs e)
        {

        }

        private void AssistanceButton_Click(object sender, EventArgs e)
        {

        }

        private void ProduitBbutton_Click(object sender, EventArgs e)
        {
            GestionStock produit = new GestionStock();
            produit.Show();
        }

    }
}
