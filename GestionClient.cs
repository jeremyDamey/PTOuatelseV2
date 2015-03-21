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
    public partial class GestionClients : Form
    {//hellorezr
        private string server;
        private string database;
        private string uid;
        private string password;
        private MySqlConnection connection;
        private MySqlDataAdapter mySqlDataAdapter;
        string chaine = null;
        public GestionClients()
        {
            InitializeComponent();
        }

        private void GestionClients_Load(object sender, EventArgs e)
        {
            server = "info-viviane.iut.bx1";
            database = "pt_ouatelse1";
            uid = "pt_ouatelse1";
            password = "DYwBqVhnNL5SPddK";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);

            mySqlDataAdapter = new MySqlDataAdapter("select id,nom,prenom,adresse1,mail from clients", connection);
            DataSet ds = new DataSet();
            mySqlDataAdapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
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
            int var = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            server = "info-viviane.iut.bx1";
            database = "pt_ouatelse1";
            uid = "pt_ouatelse1";
            password = "DYwBqVhnNL5SPddK";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
            connection.Open();

            string req = "DELETE FROM factures WHERE id IN (SELECT id From clients where id = " + var + ")";
            string req2 = "DELETE FROM factures_produits WHERE id IN (SELECT id From clients where id = " + var + ")";
            string req3 = "DELETE FROM produits WHERE id IN (SELECT id From clients where id = " + var + ")";
            string requete = "DELETE FROM clients where id = " + var + ")";

            MySqlCommand cmd = new MySqlCommand(req, connection);
            MySqlCommand cmd2 = new MySqlCommand(requete, connection);
            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            MySqlDataReader mySqlDataReader = cmd.ExecuteReader();
            MySqlDataReader mySqlDataReader2 = cmd2.ExecuteReader();
            mySqlDataReader.Close();
            mySqlDataReader2.Close();
            this.Refresh();
        }
    }
}
