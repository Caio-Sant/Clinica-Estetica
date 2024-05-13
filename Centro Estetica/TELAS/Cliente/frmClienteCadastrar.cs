using Centro_Estetica.DB.Base.Entregavel3.Cliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centro_Estetica.TELAS.Cliente
{
    public partial class frmClienteCadastrar : Form
    {
        public frmClienteCadastrar()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                PacientesDTO dto = new PacientesDTO();
                dto.Nome = mtbNome.Text.Trim();
                dto.Rg = mtbRG.Text.Trim();
                dto.Cpf = mtbCPF.Text.Trim();
                dto.Email = mtbEmail.Text.Trim();
                dto.DtNascimento = dtpNascimento.Value;
                dto.Telefone = mtbTelefone.Text.Trim();
                dto.Celular = mtbCelular.Text.Trim();
                dto.Cep = mtbCEP.Text.Trim();
                dto.Rua = mtbRua.Text.Trim();
                dto.NdaCasa = mtbNumero.Text.Trim();
                dto.Complemento = txtComp.Text.Trim();

                PacientesBusiness business = new PacientesBusiness();
                business.Salvar(dto);

                MessageBox.Show("Paciente salvo com sucesso.");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Occoreu um erro " + ex.Message);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frmClienteConsultar tela = new frmClienteConsultar();
            tela.Show();
            Hide();
        }



        private void btnSair_Click_1(object sender, EventArgs e)
        {
            frmMenu tela = new frmMenu();
            tela.Show();
            Hide();
        }
    }

}

