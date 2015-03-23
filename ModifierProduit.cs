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
    public partial class ModifierProduit : Form
    {
        int id;
        public ModifierProduit(int var)
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

            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("SELECT id,designation,prix_achat,prix_vente,tva,code_ean FROM produits  WHERE produits.id=" + var + "", connection);


            DataSet ds = new DataSet();
            mySqlDataAdapter.Fill(ds);
            string codeProduit = ds.Tables[0].Rows[0].ItemArray.GetValue(0).ToString();
            string codeEAN = ds.Tables[0].Rows[0].ItemArray.GetValue(1).ToString();
            string designation = ds.Tables[0].Rows[0].ItemArray.GetValue(2).ToString();
            string prixAchat = ds.Tables[0].Rows[0].ItemArray.GetValue(3).ToString();
            string prixVente = ds.Tables[0].Rows[0].ItemArray.GetValue(4).ToString();
            string tva = ds.Tables[0].Rows[0].ItemArray.GetValue(5).ToString();

            textBox1.Text = codeProduit;
            textBox2.Text = codeEAN;
            textBox3.Text = designation;
            textBox4.Text = prixAchat;
            textBox5.Text = prixVente;
            textBox6.Text = tva;
        }

        private void ModifierProduit_Load(object sender, EventArgs e)
        {

        }

        private void valider_Click(object sender, EventArgs e)
        {
            //ModifierSalarie salarieModif = new ModifierSalarie();
            DBConect db = new DBConect();
            db.Initialize();

            //DateTime dateValue;
            //dateValue = dateTimePicker1.Value;
            //string MySQLFormatDate = dateValue.ToString("yyyy-MM-dd HH:mm:ss");
            int var = this.id;

            string codeProduit = textBox1.Text;
            string codeEAN = textBox2.Text;
            string designation = textBox3.Text;
            string prixAchat = textBox4.Text;
            string prixVente = textBox5.Text;
            string tva = textBox6.Text;
            db.modifierProduit(var, codeProduit, codeEAN, designation, prixAchat, prixVente, tva);
            //salarieAjoute.Show();
            this.Hide();
            ProduitModifie produitModifie = new ProduitModifie();
            produitModifie.Show();
        }

        private void annuler_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
