using MySql.Data.MySqlClient;
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
    public partial class NouveauProduit : Form
    {
       /* private string server;
        private string database;
        private string uid;
        private string password;
        private string codeP;
        private string EANP;
        private string designP;
        private string achatP;
        private string venteP;
        private string TVAP;
        private MySqlConnection connection;*/
        public NouveauProduit()
        {
            InitializeComponent();
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            ProduitAjoute produitAjoute = new ProduitAjoute();
            DBConect db = new DBConect();
            db.Initialize();

            db.insererProduit(textBox1.Text,textBox2.Text,textBox3.Text,textBox4.Text,textBox5.Text,textBox6.Text);
            produitAjoute.Show();
            this.Hide();
        }

        private void annuler_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void NouveauProduit_Load(object sender, EventArgs e)
        {
            /*server = "info-viviane.iut.bx1";
            database = "pt_ouatelse1";
            uid = "pt_ouatelse1";
            password = "DYwBqVhnNL5SPddK";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
            connection.Open();*/
        }
        
    }
}
