using Centro_Estetica.DB.Base.Entregavel2.compras;
using Centro_Estetica.DB.Base.Entregavel2.Foncesedor;
using Centro_Estetica.DB.Base.Entregavel4.Estoque;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centro_Estetica.TELAS.Compras
{
    public partial class frmCadastarCompras : Form
    {
        public frmCadastarCompras()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            frmMenu tela = new frmMenu();
            tela.Show();
            Hide();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                FornecedorDTO fornecedor = cboFornecedor.SelectedItem as FornecedorDTO;
                ComprasDTO dto = new ComprasDTO();
                dto.IdFornec = fornecedor.Id;
                dto.Nome = txtNome.Text;
                dto.Quantidade = Convert.ToInt32(txtQuantidade.Text);
                dto.Total = Convert.ToDecimal(txtTotal.Text);
                dto.Data = DateTime.Now;

                ComprasBusiness bussiness = new ComprasBusiness();
                bussiness.Salvar(dto);
                txtNome.Clear();
                txtTotal.Clear();

                EstoqueBusiness businessestoque = new EstoqueBusiness();

                List<vwcompra> lista = new List<vwcompra>();

                List<EstoqueDTO> estoque = new List<EstoqueDTO>();

                foreach (vwcompra item in lista)
                {
                    foreach (EstoqueDTO item2 in estoque)
                    {
                        if (item.Id == item2.id_estoque)
                        {
                            item2.qtd_produtos = item2.qtd_produtos + item.Id;
                        }
                    }
                }


                foreach (EstoqueDTO item in estoque)
                {
                    EstoqueDTO estoquedto = new EstoqueDTO();

                    estoquedto.vl_compra = item.vl_compra;
                    estoquedto.qtd_produtos = item.qtd_produtos;

                    businessestoque.Salvar(estoquedto);
                }

                MessageBox.Show("Compra efetuada com sucesso");
            }

            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "High Estetic",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreru um erro, tente mais tarde.", "High Estetic",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCadastarCompras_Load(object sender, EventArgs e)
        {

        }
    }
}
