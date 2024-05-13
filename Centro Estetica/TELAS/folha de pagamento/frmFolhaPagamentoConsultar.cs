using Centro_Estetica.DB.Base.Entregavel1.Folha_de_Pagamento;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centro_Estetica.TELAS.folha_de_pagamento
{
    public partial class frmFolhaPagamentoConsultar : Form
    {
        public frmFolhaPagamentoConsultar()
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
            FolhaPagamentoBusiness business = new FolhaPagamentoBusiness();
            List<VVwConsultarFolhapagamento> a = business.Consultarmes(txtConsultar.Text);
            dgvConsultarFolha.AutoGenerateColumns = false;
            dgvConsultarFolha.DataSource = a;
        }
    }
}
