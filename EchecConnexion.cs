using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace PTOuatelse
{
    public partial class EchecConnexion : Form
    {
        public EchecConnexion()
        {
            InitializeComponent();
        }

        private void EchecConnexion_Load(object sender, EventArgs e)
        {

        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Connexion connexion = new Connexion();
            connexion.Show();
        }
    }
}
