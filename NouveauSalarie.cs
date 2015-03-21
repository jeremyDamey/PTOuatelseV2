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
    public partial class NouveauSalarie : Form
    {
        public NouveauSalarie()
        {
            InitializeComponent();
            Genre.Items.Add("Mr.");
            Genre.Items.Add("Mme.");

        }

        private void annuler_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }



        private void Nom_TextChanged(object sender, EventArgs e)
        {
            this.Text = Nom.Text;
        }

        private void Adresse1_TextChanged(object sender, EventArgs e)
        {
            this.Text = Adresse1.Text;
        }

        private void Adresse2_TextChanged(object sender, EventArgs e)
        {
            this.Text = Adresse2.Text;
        }

        private void CodePostal_TextChanged(object sender, EventArgs e)
        {
            this.Text = CodePostal.Text;
        }

        private void NomVille_TextChanged(object sender, EventArgs e)
        {
            this.Text = NomVille.Text;
        }

        private void NomPays_TextChanged(object sender, EventArgs e)
        {
            this.Text = NomPays.Text;
        }

        private void Téléphone_TextChanged(object sender, EventArgs e)
        {
            this.Text = Téléphone.Text;
        }


        private void Mail_TextChanged(object sender, EventArgs e)
        {
            this.Text = Mail.Text;
        }

        private void ValiderNouveauSalarie_Click(object sender, EventArgs e)
        {
            SalarieAjoute salarieAjoute = new SalarieAjoute();
            DBConect db = new DBConect();
            db.Initialize();
            string identifiant;
            int civ;
            if (Genre.SelectedIndex == 0)
                civ = 1;
            else
                civ = 2;

            Console.Write(civ);
            DateTime dateValue;
            dateValue = dateTimePicker1.Value;
            string MySQLFormatDate = dateValue.ToString("yyyy-MM-dd HH:mm:ss");

            identifiant = Prenom.Text.Substring(0, 1) + Nom.Text;
            db.insererSalarié(identifiant,textBox_Password.Text,Nom.Text, Prenom.Text, Adresse1.Text, Adresse2.Text, Téléphone.Text, Mail.Text, MySQLFormatDate,civ);
            salarieAjoute.Show();
            this.Hide();//sqdq
          
        }


        private void NouveauSalarie_Load(object sender, EventArgs e)
        {

        }

        private void textBox_Password_TextChanged(object sender, EventArgs e)
        {
            this.Text = textBox_Password.Text;
        }
    }
}
