using Centro_Estetica.TELAS.Cliente;
using Centro_Estetica.TELAS.ControlesDVendas;
using Centro_Estetica.TELAS.Estoque;
using Centro_Estetica.TELAS.FluxoDcaixa;
using Centro_Estetica.TELAS.folha_de_pagamento;
using Centro_Estetica.TELAS.Fonecedor;
using Centro_Estetica.TELAS.Funcionario;
using Centro_Estetica.TELAS.Pedido;
using Centro_Estetica.TELAS.Produto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centro_Estetica.TELAS
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void usuaríoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
            Close();
        }

        private void folhaDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFolhaPagamento tela = new frmFolhaPagamento();
            tela.Show();
            Hide();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void funciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastrarFuncionario tela = new frmCadastrarFuncionario();
            tela.Show();
            Hide();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClienteCadastrar tela = new frmClienteCadastrar();
            tela.Show();
            Hide();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastrarFornecedor tela = new frmCadastrarFornecedor();
            tela.Show();
            Hide();
        }

        private void serviçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastrarTramamento tela = new frmCadastrarTramamento();
            tela.Show();
            Hide();
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarFuncionario tela = new frmConsultarFuncionario();
            tela.Show();
            Hide();
        }

        private void serviçosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultarTratamento tela = new frmConsultarTratamento();
            tela.Show();
            Hide();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmClienteConsultar tela = new frmClienteConsultar();
            tela.Show();
            Hide();
        }

        private void fornecedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultarFornecedor tela = new frmConsultarFornecedor();
            tela.Show();
            Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

       
        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvconsultacompra tela = new dgvconsultacompra();
            tela.Show();
            Hide();
        }

        private void serviçosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmControleVendas tela = new frmControleVendas();
            tela.Show();
            Hide();
        }

        private void fluxoDeCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarCaixa tela = new frmConsultarCaixa();
            tela.Show();
            Hide();
        }

        private void configuraçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void serviçosToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void estoqueToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
        }

        private void estoqueToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            
        }

        private void estoqueToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            dgvconsultacompra tela = new dgvconsultacompra();
            tela.Show();
            Hide();
        }

        private void pedidoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
      frmCadastrarPedido tela = new frmCadastrarPedido();
            tela.Show();
            Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
