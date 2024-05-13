using Centro_Estetica.DB.Base.Entregavel2.Produto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centro_Estetica.TELAS.Produto
{
    public partial class frmConsultarTratamento : Form
    {
        public frmConsultarTratamento()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            frmMenu tela = new frmMenu();
            tela.Show();
            Hide();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvConsultarProdutos.CurrentRow != null)
                {
                    ProdutoDTO produto = dgvConsultarProdutos.CurrentRow.DataBoundItem as ProdutoDTO;
                    DialogResult r = MessageBox.Show("Deseja excluir esse Produto?", "High Estetic ",
                                           MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        produtoBusiness business = new produtoBusiness();
                        business.Remover(produto.Id);

                        List<ProdutoDTO> a = business.Consultar(txtConsultar.Text);
                        dgvConsultarProdutos.AutoGenerateColumns = false;
                        dgvConsultarProdutos.DataSource = a;

                    }
                    else
                    {
                        MessageBox.Show("Selecione um cliente");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }
            
            
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            produtoBusiness Business = new produtoBusiness();
            List<ProdutoDTO> a = Business.Consultar(txtConsultar.Text);
            dgvConsultarProdutos.AutoGenerateColumns = false;
            dgvConsultarProdutos.DataSource = a;
        }
    }
    
}
