using PTOuatelse;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Connexion : Form
    {
        public string id = null;
        string mdp = null;
        public bool bonUser = false;
        public bool bonMdp = false;
        public string prenomUtilisateur = null;
        public Connexion()
        {
            InitializeComponent();
        }

        private void Connexion_Load(object sender, EventArgs e)
        {
            this.Text = IdentifiantBox.Text;
        }

        private void ConnectionButton_Click(object sender, EventArgs e)
        {            
                this.id = IdentifiantBox.Text.ToString();
                this.mdp = MDPBox.Text.ToString();
                DBConect connexion = new DBConect();
                connexion.Initialize();
                bonUser=connexion.validerConnexion("SELECT identifiant FROM salaries", "identifiant", this.id);
                bonMdp = connexion.validerConnexion("SELECT mot_de_passe FROM salaries WHERE identifiant='" + this.id + "'", "mot_de_passe", this.mdp);
                if(bonUser==true)
                {
                    if(bonMdp==true)
                    {
                        prenomUtilisateur = connexion.requete("SELECT prenom FROM salaries WHERE identifiant='" + this.id + "' AND mot_de_passe='" + this.mdp + "'", "prenom");
                        Connecte connection = new Connecte(prenomUtilisateur);
                        connection.Show();
                        this.Hide();
                    }
                    else
                    {
                        this.Hide();
                        EchecConnexion echec = new EchecConnexion();
                        echec.Show();
                    }
                }
                else
                {
                    this.Hide();
                    EchecConnexion echec = new EchecConnexion();
                    echec.Show();
                }
                         
        }

        private void AnnulerButton_Click(object sender, EventArgs e)
        {
            MDPBox.ResetText();
            IdentifiantBox.ResetText();
        }

        private void IdentifiantBox_TextChanged(object sender, EventArgs e)
        {
            IdentifiantBox.ResetText();
        }

        private void MDPBox_TextChanged(object sender, EventArgs e)
        {
            MDPBox.ResetText();
        }
    }
}
