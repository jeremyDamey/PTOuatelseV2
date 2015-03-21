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
        public NouveauProduit()
        {
            InitializeComponent();
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            ProduitAjoute produitAjoute = new ProduitAjoute();
            DBConect db = new DBConect();
            db.Initialize();

            db.insererProduit(textBox1.Text,textBox2.Text,textBox3.Text,textBox4.Text,textBox5.Text,textBox6.Text,textBox7.Text);
            produitAjoute.Show();
            this.Hide();
        }

        private void annuler_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void NouveauProduit_Load(object sender, EventArgs e)
        {

        }
        
    }
}
