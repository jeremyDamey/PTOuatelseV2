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
    public partial class Acceuil : Form
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
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
                server = "info-viviane.iut.bx1";
                database = "pt_ouatelse1";
                uid = "pt_ouatelse1";
                password = "DYwBqVhnNL5SPddK";
                string connectionString;
                connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

                connection = new MySqlConnection(connectionString);
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
