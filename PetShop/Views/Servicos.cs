using EasyEncryption;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PetShop
{
    public partial class Servicos : Form
    {
        double custoPorte = 0;
        double custoServico = 0;
        public Servicos()
        {
            InitializeComponent();
        }

        private void rdbPequeno_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPequeno.Checked == true)
            {
                custoPorte = 10;
            }
        }
        private void rdbMedio_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMedio.Checked == true)
            {
                custoPorte = 20;
            }
        }

        private void rdbGrande_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbGrande.Checked == true)
            {
                custoPorte = 30;
            }
        }
        private void rdbBanho_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbBanho.Checked == true)
            {
                custoServico = 20;
            }
        }
        private void rdbTosa_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTosa.Checked == true)
            {
                custoServico = 30;
            }
        }
        private void rdbCombo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCombo.Checked == true)
            {
                custoServico = 10;
            }
        }

        private void lblValor_Click(object sender, EventArgs e)
        {
            
        }
    }
}
