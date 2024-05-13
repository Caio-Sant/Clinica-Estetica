using Centro_Estetica.DB.Base.Entregavel2.Produto;
using Centro_Estetica.DB.Base.Entregavel3.Cliente;
using Centro_Estetica.DB.Base.Entregavel3.Controlepedido;
using Centro_Estetica.DB.Base.Entregavel4.FluxoDCaixa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centro_Estetica.TELAS.Pedido
{
    public partial class frmCadastrarPedido : Form
    {
        BindingList<ProdutoDTO> produtos = new BindingList<ProdutoDTO>();

        decimal valordavenda = 0;

  
        public frmCadastrarPedido()
        {
            InitializeComponent();
        }
        void CarregarCombos()
        {

            PacientesBusiness buss = new PacientesBusiness();
            List<PacientesDTO> listas = buss.Listar();
            cboClientes.ValueMember = nameof(PacientesDTO.Id);
            cboClientes.DisplayMember = nameof(PacientesDTO.Nome);
            cboClientes.DataSource = listas;

            produtoBusiness busi = new produtoBusiness();
            List<ProdutoDTO> list = busi.Listar();
            cboTratamento.ValueMember = nameof(ProdutoDTO.Id);
            cboTratamento.DisplayMember = nameof(ProdutoDTO.Nome);
            cboTratamento.DataSource = list;

        }

        void verificar()
        {
            if (cboClientes.Text == string.Empty)
            {
                MessageBox.Show("Escolha um cliente");
            }
            if (cboFormadePag.Text == string.Empty)
            {
                MessageBox.Show("Uma forma de pagamento");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            frmMenu tela = new frmMenu();
            tela.Show();
            Hide();
        }

        private void btnSalvar_Click_2(object sender, EventArgs e)
        {
            try
            {

                PacientesDTO cliente = cboClientes.SelectedItem as PacientesDTO;
                PedidoDTO dto = new PedidoDTO();
                dto.Data = DateTime.Now;
                dto.Pagamento = cboFormadePag.Text;
                dto.IdPaciente = cliente.Id;

                verificar();

                PedidoBusiness business = new PedidoBusiness();
                business.Salvar(dto, produtos.ToList());

                MessageBox.Show("Pedido salvo com sucesso.", "High Estetic", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtquantidade.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Occoreu um erro " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ProdutoDTO produto = cboTratamento.SelectedItem as ProdutoDTO;

                for (int i = 0; i < Convert.ToInt32(txtquantidade.Text); i++)
                {
                    produtos.Add(produto);
                    valordavenda = valordavenda + produto.Valor;
                    dgvPedido.AutoGenerateColumns = false;
                    dgvPedido.DataSource = produtos;
                    lblvalortotal.Text = "R$ " + valordavenda.ToString();

                }
            }
            catch (Exception ex)
            {
                if (txtquantidade.Text == string.Empty)
                {
                    MessageBox.Show("Quantidade é obrigatória.");
                }
                else
                {
                    MessageBox.Show("Occoreu um erro " + ex.Message);
                }
            }
            }
private void btnLimpar_Click(object sender, EventArgs e)
        {
            produtos = new BindingList<ProdutoDTO>();
            dgvPedido.AutoGenerateColumns = false;
            dgvPedido.DataSource = produtos;
            valordavenda = 0;
            lblvalortotal.Text = "R$ " + valordavenda.ToString();

            txtquantidade.Clear();
        }
    }
}




