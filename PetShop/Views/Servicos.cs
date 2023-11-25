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

        public Servicos()
        {
            InitializeComponent();
        }

        private void rdbPequeno_CheckedChanged(object sender, EventArgs e)
        {
            var porte = 10;
        }
        private void rdbMedio_CheckedChanged(object sender, EventArgs e)
        {
            var porte = 15;
        }

        private void rdbGrande_CheckedChanged(object sender, EventArgs e)
        {
            var porte = 20;
        }
        private void rdbBanho_CheckedChanged(object sender, EventArgs e)
        {
            var servico = 20;
        }
        private void rdbTosa_CheckedChanged(object sender, EventArgs e)
        {
            var servico = 30;
        }
        private void rdbCombo_CheckedChanged(object sender, EventArgs e)
        {
            var servico = 40;
        }

        private void lblValor_Click(object sender, EventArgs e)
        {
            
        }
    }
}
