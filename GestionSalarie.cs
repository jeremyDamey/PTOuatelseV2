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
    public partial class GestionSalarie : Form
    {
        string chaine = null;
        public GestionSalarie()
        {
            InitializeComponent();
            DBConect connexion = new DBConect();
            connexion.Initialize();
            chaine = connexion.requete("SELECT nom FROM  salaries", "nom");
            MessageBox.Show(chaine.ToString());
        }

        private void NouveauSalarie_Click(object sender, EventArgs e)
        {
            NouveauSalarie nouveau = new NouveauSalarie();
            nouveau.Show();
        }

        private void modifierSalarie_Click(object sender, EventArgs e)
        {
            ModifierSalarié modifier = new ModifierSalarié();
            modifier.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void GestionSalarie_Load(object sender, EventArgs e)
        {

        }
    }
}
