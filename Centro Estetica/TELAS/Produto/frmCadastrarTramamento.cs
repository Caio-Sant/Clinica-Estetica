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
    public partial class frmCadastrarTramamento : Form
    {
        public frmCadastrarTramamento()
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

                ProdutoDTO dto = new ProdutoDTO();
                dto.Nome = txtNome.Text;
                dto.Descrição = txtDescricao.Text;
                dto.Valor = Convert.ToDecimal(txtPreco.Text);


                produtoBusiness business = new produtoBusiness();
                business.Salvar(dto);

                MessageBox.Show("Tratamento salvo com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um  erro: " + ex.Message);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            
        }
    }
    }

