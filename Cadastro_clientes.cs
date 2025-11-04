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
    public partial class Cadastro_clientes : Form
    {
        public Cadastro_clientes()
        {
            InitializeComponent();
        }

        private void toolStripButtonNovo_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabCadastroUsuario;
        }

        private void toolStripButtonConsultar_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabListaUsuario;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
