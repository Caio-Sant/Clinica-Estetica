using Centro_Estetica.DB.Base.Entregavel2.Foncesedor;
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
    public partial class frmConsultarFornecedor : Form
    {
        public frmConsultarFornecedor()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            frmMenu tela = new frmMenu();
            tela.Show();
            Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                Fornecedorbusiness business = new Fornecedorbusiness();
                List<FornecedorDTO> lista = business.Consultar(string.Empty);
                dgvConsultarFornecedor.AutoGenerateColumns = false;
                dgvConsultarFornecedor.DataSource = lista;
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

        private void btnApagar_Click(object sender, EventArgs e)
        {
            FornecedorDTO fornecedor = dgvConsultarFornecedor.CurrentRow.DataBoundItem as FornecedorDTO;

            DialogResult r = MessageBox.Show("Deseja excluir esse Fornecedor?", "Dales Sorrisos",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {

                FornecedorDTO dto = dgvConsultarFornecedor.CurrentRow.DataBoundItem as FornecedorDTO;
                Fornecedorbusiness business = new Fornecedorbusiness();
                business.Remover(dto.Id);

            }
        }
    }
}