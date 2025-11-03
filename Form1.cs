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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            Cadastro_produtos cadProdutos = new Cadastro_produtos();
            cadProdutos.Show();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {

        }
    }
}
