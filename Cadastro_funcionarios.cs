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
    public partial class Cadastro_funcionarios : Form
    {
        public Cadastro_funcionarios()
        {
            InitializeComponent();
        }

        private void toolStripButtonNovo_Click(object sender, EventArgs e)
        {
            tabControlFuncionarios.SelectedTab = tabCadastroFuncionario;
        }

        private void toolStripButtonConsultar_Click(object sender, EventArgs e)
        {
            tabControlFuncionarios.SelectedTab = tabConsultaFuncionarios;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
