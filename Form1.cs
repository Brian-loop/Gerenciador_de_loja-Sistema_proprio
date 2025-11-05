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
//using System.Data;
//using MySql.Data.MySqlClient;       //conexao com o banco de dados

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
            Cadastro_clientes cadClientes = new Cadastro_clientes();
            cadClientes.Show();
        }
        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            Cadastro_funcionarios cadFuncionarios = new Cadastro_funcionarios();
            cadFuncionarios.Show();
        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            Cadastro_fornecedores cadFornecedores = new Cadastro_fornecedores();
            cadFornecedores.Show();
        }
    }

    //=============================================================================================================================
    //class de conexao com o banco de dados

    public class BancoDeDados
    {
        private static string servidor = "localhost";
        private static string banco = "db_loja_carros";
        private static string usuario = "root";
        private static string senha = "";
        private static string stringConexao = $"SERVER={servidor}; DATABASE={banco}; UID={usuario}; PWD={senha};";

        private MySqlConnection conexao = new MySqlConnection(stringConexao);

        public MySqlConnection AbrirConexao()
        {
            try
            {
                if (conexao.State == System.Data.ConnectionState.Closed)
                {
                    conexao.Open();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao abrir a conexão: " + ex.Message);
            }
            return conexao;
        }

        public void FecharConexao()
        {
            try
            {
                if (conexao.State == System.Data.ConnectionState.Open)
                {
                    conexao.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao fechar a conexão: " + ex.Message);
            }
        }
    }

    //=============================================================================================================================


}
