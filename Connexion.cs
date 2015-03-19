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
            *if (IdentifiantBox.Text != "[A..Z]")
            {
                PTOuatelse.EchecConnexion echec = new PTOuatelse.EchecConnexion();                
                echec.Show();
                this.Hide();                
            }
            else
            {
                this.id = IdentifiantBox.Text.ToString();
                Connecte connection = new Connecte(id);
                connection.Show();
                this.Hide();
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
