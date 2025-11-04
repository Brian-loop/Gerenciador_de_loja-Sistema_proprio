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
    public partial class Cadastro_fornecedores : Form
    {
        public Cadastro_fornecedores()
        {
            InitializeComponent();
        }

        private void toolStripButtonNovo_Click(object sender, EventArgs e)
        {
            tabControlFornecedores.SelectedTab = tabCadastroFornecedores;
        }

        private void toolStripButtonConsultar_Click(object sender, EventArgs e)
        {
            tabControlFornecedores.SelectedTab = tabConsultaFornecedores;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
