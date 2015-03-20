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
        private string server;
        private string database;
        private string uid;
        private string password;
        private string codeP;
        private string EANP;
        private string designP;
        private string achatP;
        private string venteP;
        private string TVAP;
        private MySqlConnection connection;
        public NouveauProduit()
        {
            InitializeComponent();
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            codeP=textBox1.Text.ToString();
            EANP=textBox2.Text.ToString();
            designP=textBox3.Text.ToString();
            achatP=textBox4.Text.ToString();
            venteP=textBox5.Text.ToString();
            TVAP=textBox6.Text.ToString();

            /*
             * Tentative 1 :
             * 
             * MySqlDataAdapter myAdapter = new MySqlDataAdapter("SELECT * FROM produits", connection);
            myAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            DataSet myDataSet = new DataSet();
            myAdapter.SelectCommand.Connection = connection;
            myAdapter.Fill(myDataSet, "produits");
            object[] rowVals = new object[6];
            rowVals[0] = codeP;
            rowVals[1] = designP;
            rowVals[2] = achatP;
            rowVals[3] = venteP;
            rowVals[4] = TVAP;
            rowVals[5] = EANP;
            myDataSet.Tables["produits"].Rows.Add(rowVals);
            myAdapter.InsertCommand = new MySqlCommand("INSERT INTO produits (id, nom, prix_achat, prix_vente, tva, code_ean) VALUES (" + codeP + "," + designP + "," + achatP + "," + venteP + "," + TVAP + "," + EANP + ")", connection);
            myAdapter.Update(myDataSet, "produits");*/  

            /*
             * Tentative 2 :
             * 
             * MySqlDataAdapter myAdapter = new MySqlDataAdapter("SELECT * FROM produits", connection);
            DataSet myDataSet = new DataSet();
            
            //myAdapter.Fill(myDataSet, "produits");
            myAdapter.InsertCommand = new MySqlCommand("INSERT INTO produits (id, nom, prix_achat, prix_vente, tva, code_ean) VALUES ("+codeP+","+designP+","+achatP+","+venteP+","+TVAP+","+EANP+")");
            myAdapter.Fill(myDataSet, "produits");
            myAdapter.Update(myDataSet, "produits");*/
            this.Hide();
        }

        private void annuler_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void NouveauProduit_Load(object sender, EventArgs e)
        {
            server = "info-viviane.iut.bx1";
            database = "pt_ouatelse1";
            uid = "pt_ouatelse1";
            password = "DYwBqVhnNL5SPddK";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
            connection.Open();
        }
        
    }
}
