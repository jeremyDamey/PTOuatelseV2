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
using MySql.Data;
using MySql.Data.MySqlClient;
//using MySQLDriverCS;

namespace WindowsFormsApplication1
{
    public partial class Accueil : Form
    {
        string user = null;
        public Accueil(string id)
        {
            InitializeComponent();
            this.user = id;
        }

        private void Acceuil_Load(object sender, EventArgs e)
        {
            ConnecteLabel.Text = "Connecté en tant que : " + Environment.NewLine + user;
        }

        private void DeconnexionButton_Click(object sender, EventArgs e)
        {
            Connexion deconnexion = new Connexion();
            deconnexion.Show();
            this.Hide();
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
            GestionSalarie salarie = new GestionSalarie();
            salarie.Show();
        }

        private void AssistanceButton_Click(object sender, EventArgs e)
        {
            Assistance assistance = new Assistance();
            assistance.Show();
        }

        private void ProduitBbutton_Click(object sender, EventArgs e)
        {
            GestionStock produit = new GestionStock();
            produit.Show();
        }
    }
}
