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

namespace Centro_Estetica.TELAS.Estoque
{
    public partial class dgvconsultacompra : Form
    {
        public dgvconsultacompra()
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
            ComprasBusiness business = new ComprasBusiness();
            List<ComprasDTO> a = business.Consultar(txtConsultar.Text);
            dgvconsultaestoq.AutoGenerateColumns = false;
            dgvconsultaestoq.DataSource = a;
        }

       
    }
}
