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
    public partial class ModifierSalarié : Form
    { // A SUPPRIEMR    
        int id;
        public ModifierSalarié(int var)
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

            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("SELECT salaries.identifiant,civilite.nom,salaries.nom,salaries.prenom,salaries.adresse1,villes.code_postal,villes.libelle,magasin.adresse,pays.libelle,salaries.fixe,salaries.mail FROM salaries  INNER JOIN villes on salaries.villes_id = villes.id  INNER JOIN magasin on salaries.magasin_id = magasin.id  INNER  JOIN pays on salaries.pays_id = pays.id  INNER JOIN civilite on salaries.civilite_id=civilite.id  WHERE salaries.id=" + var + "", connection);
            

            DataSet ds = new DataSet();
            mySqlDataAdapter.Fill(ds);
            string identifiant = ds.Tables[0].Rows[0].ItemArray.GetValue(0).ToString();
            string civilité = ds.Tables[0].Rows[0].ItemArray.GetValue(1).ToString();
            string nom = ds.Tables[0].Rows[0].ItemArray.GetValue(2).ToString();
            string prénom = ds.Tables[0].Rows[0].ItemArray.GetValue(3).ToString();
            string adresse = ds.Tables[0].Rows[0].ItemArray.GetValue(4).ToString();
            string CP = ds.Tables[0].Rows[0].ItemArray.GetValue(5).ToString();
            string nomVille = ds.Tables[0].Rows[0].ItemArray.GetValue(6).ToString();
            string adrMag = ds.Tables[0].Rows[0].ItemArray.GetValue(7).ToString();
            string CPMag = ds.Tables[0].Rows[0].ItemArray.GetValue(5).ToString();
            string nomVilleMag = ds.Tables[0].Rows[0].ItemArray.GetValue(6).ToString();
            string pays = ds.Tables[0].Rows[0].ItemArray.GetValue(8).ToString();
            string fixe = ds.Tables[0].Rows[0].ItemArray.GetValue(9).ToString();
            string mail = ds.Tables[0].Rows[0].ItemArray.GetValue(10).ToString();
        
            idSalarie.Text = identifiant;
            Genre.Text = civilité;
            Nom.Text = nom;
            Prenom.Text = prénom;
            Adresse1.Text = adresse;
            CodePostalSal.Text = CP;
            VilleSal.Text = nomVille;

            AdresseMag.Text = adrMag;
            CodePostalMag.Text = CPMag;
            VilleMag.Text = nomVilleMag;

            NomPays.Text = pays;
            Téléphone.Text = fixe;
            Mail.Text = mail;
       
        }

        private void Mail_TextChanged(object sender, EventArgs e)
        {

        }

        private void annulerModifierSalarie_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ModifierSalarié_Load(object sender, EventArgs e)
        {
            

        }

        private void validerModifSalarie_Click(object sender, EventArgs e)
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
            string CP = CodePostalSal.Text;
            string nomVille = VilleSal.Text;
            string fixe = Téléphone.Text;
            string mail = Mail.Text;
            db.modifierSalarié(var, nom, prénom, adresse, fixe, mail);
            //salarieAjoute.Show();
            this.Hide();
        }
    }
}
