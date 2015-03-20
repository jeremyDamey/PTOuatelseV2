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
    public partial class ModifierProduit : Form
    {
        public ModifierProduit()
        {
            InitializeComponent();
        }

        private void ModifierProduit_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'pt_ouatelse1DataSet.factures_produits'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.factures_produitsTableAdapter.Fill(this.pt_ouatelse1DataSet.factures_produits);
            // TODO: cette ligne de code charge les données dans la table 'pt_ouatelse1DataSet.mouvement_stock'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.mouvement_stockTableAdapter.Fill(this.pt_ouatelse1DataSet.mouvement_stock);
            // TODO: cette ligne de code charge les données dans la table 'pt_ouatelse1DataSet.produits'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.produitsTableAdapter.Fill(this.pt_ouatelse1DataSet.produits);

        }
    }
}
