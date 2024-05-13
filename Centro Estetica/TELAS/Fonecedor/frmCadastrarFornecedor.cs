using Centro_Estetica.DB.Base.Entregavel2.Foncesedor;
using Centro_Estetica.DB.Base.Objetos;
using Centro_Estetica.TELAS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centro_Estetica.TELAS.Fonecedor
{
    public partial class frmCadastrarFornecedor : Form
    {
        public frmCadastrarFornecedor()
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
                FornecedorDTO dto = new FornecedorDTO();
                dto.Nome = txtNome.Text.Trim();
                dto.Telefone = txtTelefone.Text.Trim();
                dto.Email = txtEmail.Text.Trim();
                dto.CEP = txtCEP.Text.Trim();
                dto.Rua = txtRua.Text.Trim();
                dto.CNPJ = mtbCNPJ.Text.Trim();
              
                dto.NdaCasa = txtNumero.Text.Trim();


                Fornecedorbusiness business = new Fornecedorbusiness();
                business.Salvar(dto);

                MessageBox.Show("Fornecedor salvo com sucesso.", "Hi",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);
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

        private void btnCep_Click(object sender, EventArgs e)
        {
            CorreioApi correioApi = new CorreioApi();

            string cep = txtCEP.Text.Trim().Replace("-", "");

            CorreioResponde correio = correioApi.Buscar(cep);

            txtRua.Text = correio.logradouro;
                }
        
    }
}
