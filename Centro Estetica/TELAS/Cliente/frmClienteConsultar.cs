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
    public partial class frmClienteConsultar : Form
    {
        public frmClienteConsultar()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            PacientesBusiness business = new PacientesBusiness();
            List<PacientesDTO> a = business.Consultar(txtConsultar.Text);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = a;
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            try
            {
                PacientesDTO cliente = dataGridView1.CurrentRow.DataBoundItem as PacientesDTO;
                DialogResult r = MessageBox.Show("Deseja excluir esse cliente?", "Dales Sorrisos",
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    PacientesBusiness business = new PacientesBusiness();
                    business.Remover(cliente.Id);

                    List<PacientesDTO> a = business.Consultar(txtConsultar.Text);
                    dataGridView1.AutoGenerateColumns = false;
                    dataGridView1.DataSource = a;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
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
