using Centro_Estetica.DB.Base.Entregavel1.controle_Funcionario;
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
    public partial class frmConsultarFuncionario : Form
    {
        public frmConsultarFuncionario()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            FuncionarioBusiness business = new FuncionarioBusiness();
            List<FuncionarioDTO> a = business.Consultar(txtConsultar.Text);
            dgvFuncionario.AutoGenerateColumns = false;
            dgvFuncionario.DataSource = a;
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            try
            {
                FuncionarioDTO funcionario = dgvFuncionario.CurrentRow.DataBoundItem as FuncionarioDTO;
                DialogResult r = MessageBox.Show("Deseja excluir esse funcionário?", "High Estetic ",
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    FuncionarioBusiness business = new FuncionarioBusiness();
                    business.Remover(funcionario.Id);

                    List<FuncionarioDTO> a = business.Consultar(txtConsultar.Text);
                    dgvFuncionario.AutoGenerateColumns = false;
                    dgvFuncionario.DataSource = a;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        private void txtConsultar_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmConsultarFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            frmMenu tela = new frmMenu();
            tela.Show();
            Hide();
        }
    }
}
