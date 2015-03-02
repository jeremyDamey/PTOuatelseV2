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
    public partial class GestionClients : Form
    {
        public GestionClients()
        {
            InitializeComponent();
        }

        private void GestionClients_Load(object sender, EventArgs e)
        {

        }

        private void NouveauClient_Click(object sender, EventArgs e)
        {
            NouveauClient nouveau = new NouveauClient();
            nouveau.Show();
        }

        private void modifierClient_Click(object sender, EventArgs e)
        {
            ModifierClient modifier = new ModifierClient();
            modifier.Show();
        }
    }
}
