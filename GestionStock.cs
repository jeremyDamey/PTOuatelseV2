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
using WindowsFormsApplication1;

namespace PTOuatelse
{
    public partial class GestionStock : Form
    {
        private string server;
        private string database;
        private string uid;
        private string password;
        private MySqlConnection connection;
        private MySqlDataAdapter mySqlDataAdapter;

        public GestionStock()
        {
            InitializeComponent();
        }

        private void modifierProduit_Click(object sender, EventArgs e)
        {
            ModifierProduit modifier = new ModifierProduit();
            modifier.Show();
        }

        private void nouveauProduit_Click(object sender, EventArgs e)
        {
            NouveauProduit prod = new NouveauProduit();
            prod.Show();
            this.Hide();
        }

        private void reaprovisionnerProduit_Click(object sender, EventArgs e)
        {

        }

        private void destockerProduit_Click(object sender, EventArgs e)
        {
            int var = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Console.Write(var);
            DBConect db = new DBConect();
            db.Initialize();
            db.destockerProduit(var);
            this.Hide();
        }

        private void supprimerProduit_Click(object sender, EventArgs e)
        {
            int var = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Console.Write(var);
            DBConect db = new DBConect();
            db.Initialize();
            db.supprimerProduit(var);
            this.Hide();
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
            server = "info-viviane.iut.bx1";
            database = "pt_ouatelse1";
            uid = "pt_ouatelse1";
            password = "DYwBqVhnNL5SPddK";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);

            mySqlDataAdapter = new MySqlDataAdapter("select nom,prix_achat,prix_vente,quantite,tva,code_ean from produits inner join mouvement_stock where produits.id = produits_id", connection);
            DataSet ds = new DataSet();
            mySqlDataAdapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
