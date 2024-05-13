using Centro_Estetica.DB.Base.Entregavel4.FluxoDCaixa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centro_Estetica.TELAS.FluxoDcaixa
{
    public partial class frmConsultarCaixa : Form
    {
        public frmConsultarCaixa()
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

        }

        private void btnConsultar_Click_1(object sender, EventArgs e)
        {
            FluxoCaixaBusiness bus = new FluxoCaixaBusiness();

            List<FluxoCaixaDTO> vendas = bus.filtro(dtpInicio.Value.Date, dtoFim.Value.Date.AddHours(23).AddMinutes(59).AddSeconds(59));

            dgvFluxoCaixa.DataSource = vendas;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                decimal saldo = 0;
                decimal totalentrada = 0;
                decimal totalsaida = 0;

                foreach (DataGridViewRow row in dgvFluxoCaixa.Rows)
                {
                    FluxoCaixaDTO dto = row.DataBoundItem as FluxoCaixaDTO;

                    if (dto.Operacao == "Entrada")
                    {
                        decimal entrada = dto.Total;
                        totalentrada = entrada + totalentrada;
                    }
                    else
                    {
                        decimal saida = dto.Total;
                        totalsaida = saida + totalsaida;
                    }

                }
                lblEnt.Text = totalentrada.ToString();
                lblSai.Text = totalsaida.ToString();
                saldo = totalentrada - totalsaida;
                lblSit.Text = saldo.ToString();
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
