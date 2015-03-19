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
    public partial class NouveauClient : Form
    {
        public NouveauClient()
        {
            InitializeComponent();
        }

        private void annuler_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void CodeClient_TextChanged(object sender, EventArgs e)
        {
            this.Text = CodeClient.Text;
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

        private void DateNaissance_TextChanged(object sender, EventArgs e)
        {
            this.Text = DateNaissance.Text;
        }

        private void Mail_TextChanged(object sender, EventArgs e)
        {
            this.Text = Mail.Text; //RIEN
        }

        private void valider_Click(object sender, EventArgs e)
        {
            ClientAjoute clientAjoute = new ClientAjoute();
            clientAjoute.Show();
            this.Hide();
        }

        private void NouveauClient_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'pt_ouatelse1DataSet.clients'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.clientsTableAdapter.Fill(this.pt_ouatelse1DataSet.clients);

        }
    }
}
