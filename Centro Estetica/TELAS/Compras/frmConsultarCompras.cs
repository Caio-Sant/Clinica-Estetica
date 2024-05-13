using Centro_Estetica.DB.Base.Entregavel2.compras;
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
    public partial class frmConsultarCompras : Form
    {
        public frmConsultarCompras()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            frmMenu tela = new frmMenu();
            tela.Show();
            Hide();
        }

        private void frmConsultarCompras_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ComprasBusiness business = new ComprasBusiness();
            List<ComprasDTO> a = business.Consultar(txtConsultar.Text);
            dgvconsultacompra.AutoGenerateColumns = false;
            dgvconsultacompra.DataSource = a;
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvconsultacompra.CurrentRow != null)
                {
                    ComprasDTO compra = dgvconsultacompra.CurrentRow.DataBoundItem as ComprasDTO;

                    DialogResult r = MessageBox.Show("Deseja excluir essa Compra?", "High Estetic",
                                           MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (r == DialogResult.Yes)
                    {
                        ComprasBusiness business = new ComprasBusiness();
                        business.Remover(compra.Id);

                        List<ComprasDTO> a = business.Consultar(txtConsultar.Text);
                        dgvconsultacompra.AutoGenerateColumns = false;
                        dgvconsultacompra.DataSource = a;

                    }
                }
                else
                {
                    MessageBox.Show("Selecione uma Compra");
                }

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
    }
}
