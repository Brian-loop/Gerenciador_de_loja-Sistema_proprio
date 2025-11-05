using MySql.Data.MySqlClient;
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

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text;
            string email = textBoxEmail.Text;
            string cpf = maskedTextBoxCpf.Text;
            string telefone = textBoxTelefone.Text;
            string cidade = textBoxCidade.Text;
            string cep = maskedTextBoxCep.Text;
            string estado = comboBoxEstado.Text;
            string endereco = textBoxEndereco.Text;

            BancoDeDados conexao = new BancoDeDados();

            try
            {
                using (MySqlConnection conn = conexao.AbrirConexao())
                {
                    string scriptSql = "INSERT INTO tb_clientes (nome, email, cpf, telefone, cidade, cep, estado, endereco)" + 
                        "VALUES (@nome, @email, @cpf, @telfone @cidade, @cep, @estado, @endereco)";
                    using (MySqlCommand)

                }
            }
            catch (Exception ex)
            {

            }



        }
    }
}
