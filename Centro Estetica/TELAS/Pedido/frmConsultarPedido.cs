using Centro_Estetica.DB.Base.Entregavel3.Controlepedido;
using Centro_Estetica.DB.Base.Entregavel3.Pedido;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centro_Estetica.TELAS.Pedido
{
    public partial class frmConsultarPedido : Form
    {
        public frmConsultarPedido()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            frmMenu tela = new frmMenu();
            tela.Show();
            Hide();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                pedidoBusiness business = new pedidoBusiness();
                List<PedidoConsultarView> lista = business.Consultar(txtConsultar.Text.Trim());

                dgvConsultarPedidos.AutoGenerateColumns = false;
                dgvConsultarPedidos.DataSource = lista;
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
            try
            {
                if (dgvConsultarPedidos.CurrentRow != null)
                {
                    PedidoConsultarView pedido = dgvConsultarPedidos.CurrentRow.DataBoundItem as PedidoConsultarView;

                    DialogResult r = MessageBox.Show("Deseja excluir esse pedido?", "High Estetic",
                                           MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (r == DialogResult.Yes)
                    {
                        PedidoItemBusiness business = new PedidoItemBusiness();
                        business.Remover(pedido.Id);

                        PedidoBusiness pedidobusiness = new PedidoBusiness();
                        pedidobusiness.Remover(pedido.Id);
                        btnConsultar_Click(null, null);

                    }
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "high Estetic",
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
