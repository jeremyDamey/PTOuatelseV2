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
    {
        private string server;
        private string database;
        private string uid;
        private string password;
        private MySqlConnection connection;
        private MySqlDataAdapter mySqlDataAdapter;

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
            this.Hide();
        }

        private void modifierClient_Click(object sender, EventArgs e)
        {
            int var = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            ModifierClient modifier = new ModifierClient(var);
            modifier.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void supprimerClient_Click(object sender, EventArgs e)
        {
            int var = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Console.Write(var);
            DBConect db = new DBConect();
            db.Initialize();
            db.supprimerClient(var);
            this.Hide();
        }
    }
}
