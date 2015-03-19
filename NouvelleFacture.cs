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
    public partial class NouvelleFacture : Form
    {
        public NouvelleFacture()
        {
            InitializeComponent();
        }

        private void AnnulerNouvelleFacture_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ValiderNouvelleFacture_Click(object sender, EventArgs e)
        {
            NouvelleFactureAjoutee nouvelleFactureAjoutee = new NouvelleFactureAjoutee();
            nouvelleFactureAjoutee.Show();
            this.Hide();
        }

        private void NouvelleFacture_Load(object sender, EventArgs e)
        {

        }



    }
}
