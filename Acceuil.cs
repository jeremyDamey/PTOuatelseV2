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

namespace WindowsFormsApplication1
{
    public partial class Acceuil : Form
    {
        string user = null;
        public Acceuil(string id)
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
            try
            {
                MySQLConnection conn = new MySQLConnection(new MySQLConnectionString("http://info-morgane.iut.u-bordeaux1.fr/phpmyadmin/index.php?server=3&token=bbc8f186c78fe58c25ba152288a4cdf8", "pt_ouatelse1", "pt_ouatelse1", "DYwBqVhnNL5SPddK").AsString);
                conn.Open();
                MessageBox.Show("CONNEXION REUSSIE");
            }
            catch (Exception ex)
            {
                MessageBox.Show("connexion non réussie : \n" + ex.Message);
            }
            salarie.Show();
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
