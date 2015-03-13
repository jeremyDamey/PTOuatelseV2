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
    {
        public ModifierSalarié()
        {
            InitializeComponent();
        }

        private void Mail_TextChanged(object sender, EventArgs e)
        {

        }

        private void annulerModifierSalarie_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
