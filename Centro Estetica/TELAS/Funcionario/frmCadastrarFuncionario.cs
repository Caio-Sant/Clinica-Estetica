using Centro_Estetica.DB.Base.Entregavel1.controle_Funcionario;
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

namespace Centro_Estetica.TELAS.Funcionario
{
    public partial class frmCadastrarFuncionario : Form
    {
        public frmCadastrarFuncionario()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            try
            {
                FuncionarioDTO dto = new FuncionarioDTO();

                dto.Nome = txtNome.Text.Trim();
                dto.Sexo = cboSexo.Text.Trim();
                dto.DtNascimento = dtpNasc.Value;
                dto.Rg = mtbRG.Text.Trim();
                dto.Cpf = mtbCPF.Text.Trim();
                dto.Telefone = mtbTelefone.Text.Trim();
                dto.Cep = mtbCEP.Text.Trim();
                dto.NdaCasa = txtNumero.Text.Trim();
                dto.Email = txtEmail.Text.Trim();
                dto.DataAdm = dtpAdmissao.Value;
                dto.Cargo = txtCargo.Text.Trim();
                dto.Login = txtLogin.Text.Trim();
                dto.Senha = txtSenha.Text.Trim();
                dto.Salario = Convert.ToDecimal(txtSalario.Text.Trim());

                FuncionarioBusiness business = new FuncionarioBusiness();
                business.Salvar(dto);

                MessageBox.Show("Funcionário salvo com sucesso.", "High Estetic",
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
                MessageBox.Show("Ocorreru um erro, tente mais tarde.", "high Estetic",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            frmMenu tela = new frmMenu();
            tela.Show();
            Hide();
        }

        private void cboSexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
