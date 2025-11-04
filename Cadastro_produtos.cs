using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_loja___SupremeCar
{
    public partial class Cadastro_produtos : Form
    {
        public Cadastro_produtos()
        {
            InitializeComponent();
        }

        private void toolStripButtonNovo_Click(object sender, EventArgs e)
        {
            tabControlProdutos.SelectedTab = tabCadastroProdutos;
        }

        private void toolStripButtonConsultar_Click(object sender, EventArgs e)
        {
            tabControlProdutos.SelectedTab = tabConsultaProdutos;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
