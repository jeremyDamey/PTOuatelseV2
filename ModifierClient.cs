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
    public partial class ModifierClient : Form
    {
        int id;
        public ModifierClient(int var)
        {
            InitializeComponent();
            this.id = var;
            Console.Write(id);
            string server = "info-viviane.iut.bx1";
            string database = "pt_ouatelse1";
            string uid = "pt_ouatelse1";
            string password = "DYwBqVhnNL5SPddK";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            MySqlConnection connection = new MySqlConnection(connectionString);

            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("SELECT clients.id,civilite.nom,clients.nom,clients.prenom,clients.adresse1,villes.code_postal,villes.libelle,pays.libelle,clients.fixe,clients.mail FROM clients  INNER JOIN villes on clients.villes_id = villes.id  INNER JOIN pays on villes.pays_id = pays.id  INNER JOIN civilite on clients.civilite_id=civilite.id  WHERE clients.id=" + var + "", connection);


            DataSet ds = new DataSet();
            mySqlDataAdapter.Fill(ds);
            string identifiant = ds.Tables[0].Rows[0].ItemArray.GetValue(0).ToString();
            string civilité = ds.Tables[0].Rows[0].ItemArray.GetValue(1).ToString();
            string nom = ds.Tables[0].Rows[0].ItemArray.GetValue(2).ToString();
            string prénom = ds.Tables[0].Rows[0].ItemArray.GetValue(3).ToString();
            string adresse = ds.Tables[0].Rows[0].ItemArray.GetValue(4).ToString();
            string CP = ds.Tables[0].Rows[0].ItemArray.GetValue(5).ToString();
            string nomVille = ds.Tables[0].Rows[0].ItemArray.GetValue(6).ToString();
            string pays = ds.Tables[0].Rows[0].ItemArray.GetValue(7).ToString();
            string fixe = ds.Tables[0].Rows[0].ItemArray.GetValue(8).ToString();
            string mail = ds.Tables[0].Rows[0].ItemArray.GetValue(9).ToString();

            CodeClient.Text = identifiant;
            Genre.Text = civilité;
            Nom.Text = nom;
            Prenom.Text = prénom;
            Adresse1.Text = adresse;
            CodePostal.Text = CP;
            NomVille.Text = nomVille;

            NomPays.Text = pays;
            Téléphone.Text = fixe;
            Mail.Text = mail;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void annulerClient_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ModifierClient_Load(object sender, EventArgs e)
        {

        }

        private void validerClient_Click(object sender, EventArgs e)
        {
            //ModifierSalarie salarieModif = new ModifierSalarie();
            DBConect db = new DBConect();
            db.Initialize();
            string identifiant;

            //DateTime dateValue;
            //dateValue = dateTimePicker1.Value;
            //string MySQLFormatDate = dateValue.ToString("yyyy-MM-dd HH:mm:ss");
            int var = this.id;

            string nom = Nom.Text;
            string prénom = Prenom.Text;
            string adresse = Adresse1.Text;
            string CP = CodePostal.Text;
            string nomVille = NomVille.Text;
            string fixe = Téléphone.Text;
            string mail = Mail.Text;
            db.modifierClient(var, nom, prénom, adresse, fixe, mail);
            ClientModifie clientModifie = new ClientModifie();
            clientModifie.Show();
            this.Hide();
        }
    }
}
