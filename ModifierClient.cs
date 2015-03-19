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
    public partial class ModifierClient : Form
    {
        public ModifierClient()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void annulerClient_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ModifierClient_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'pt_ouatelse1DataSet.pays'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.paysTableAdapter.Fill(this.pt_ouatelse1DataSet.pays);
            // TODO: cette ligne de code charge les données dans la table 'pt_ouatelse1DataSet.villes'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.villesTableAdapter.Fill(this.pt_ouatelse1DataSet.villes);
            // TODO: cette ligne de code charge les données dans la table 'pt_ouatelse1DataSet.clients'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.clientsTableAdapter.Fill(this.pt_ouatelse1DataSet.clients);

        }
    }
}
