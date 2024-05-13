using Centro_Estetica.DB.Base.Entregavel1.controle_Funcionario;
using Centro_Estetica.DB.Base.Entregavel1.Folha_de_Pagamento;
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

namespace Centro_Estetica.TELAS.folha_de_pagamento
{
    public partial class frmFolhaPagamento : Form
    {
        

        FolhaPagamento folhapagamento = new FolhaPagamento();

        public frmFolhaPagamento()
        {

 
            InitializeComponent();
            lblText.Visible = false;
            lblSalarioLiquido.Visible = false;

            lblPorcentagem.Visible = true;
            nudPorcentagem.Visible = true;
            lblHoraExtra.Visible = true;
            nudHorasExtras.Visible = true;
            CarregarCombo();

        }

        void CarregarCombo()
        {
            FuncionarioBusiness business = new FuncionarioBusiness();
            List<FuncionarioDTO> Funcionarios = business.Listar();

            cboFuncionario.ValueMember = nameof(FuncionarioDTO.Id);
            cboFuncionario.DisplayMember = nameof(FuncionarioDTO.Nome);
            cboFuncionario.DataSource = Funcionarios;


        }
        decimal VT = 0;
        decimal SalarioBruto = 0;
        decimal DSR;
        decimal INSS;
        decimal IR;
        decimal FGTS;
        decimal SalarioLiquido;


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int ht = Convert.ToInt32(nudHorasTrabalhadas.Value);
                int he = Convert.ToInt32(nudHorasExtras.Value);
                decimal porcentagem = nudPorcentagem.Value;
                int diastrabalhados = folhapagamento.CalcularDiasTrabalhados(Convert.ToInt32(txtFaltasPriSemana.Text), Convert.ToInt32(txtFaltaSegSemana.Text), Convert.ToInt32(txtFaltaTerSemana.Text), Convert.ToInt32(txtFaltaQuarSemana.Text));
                int finaisdesemana = folhapagamento.CalcularFinaisdeSemanas(Convert.ToInt32(txtFaltasPriSemana.Text), Convert.ToInt32(txtFaltaSegSemana.Text), Convert.ToInt32(txtFaltaTerSemana.Text), Convert.ToInt32(txtFaltaQuarSemana.Text));
                int totaldefaltas = folhapagamento.CalcularTotalDeFaltas(Convert.ToInt32(txtFaltasPriSemana.Text), Convert.ToInt32(txtFaltaSegSemana.Text), Convert.ToInt32(txtFaltaTerSemana.Text), Convert.ToInt32(txtFaltaQuarSemana.Text));

                FuncionarioDTO funcionario = cboFuncionario.SelectedItem as FuncionarioDTO;
                SalarioBruto = funcionario.Salario;

                if (nudHorasExtras.Value > 0 && chkVT.Checked == true)
                {
                    decimal valorporhora = folhapagamento.CalcularValorPorHora(SalarioBruto, ht);
                    decimal totalhorasextras = folhapagamento.CalcularValorHoraExtra(valorporhora, porcentagem, he);
                    DSR = folhapagamento.CalcularDSR(totalhorasextras, diastrabalhados, finaisdesemana);
                    decimal TotalSalarioBruto = SalarioBruto + totalhorasextras + DSR;



                    INSS = folhapagamento.CalcularINSS(SalarioBruto, TotalSalarioBruto);
                    IR = folhapagamento.CalcularIR(TotalSalarioBruto, INSS);
                    FGTS = folhapagamento.CalcularFGTS(TotalSalarioBruto);
                    VT = SalarioBruto * 0.06m;

                    SalarioLiquido = SalarioBruto + totalhorasextras + DSR - INSS - folhapagamento.ValordeDesconto - VT;

                    lblText.Visible = true;
                    lblSalarioLiquido.Visible = true;
                    lblSalarioLiquido.Text = "R$ " + Decimal.Round(SalarioLiquido).ToString();

                }
                else if (nudHorasExtras.Value > 0 && chkVT.Checked == false)
                {
                    decimal valorporhora = folhapagamento.CalcularValorPorHora(SalarioBruto, ht);
                    decimal totalhorasextras = folhapagamento.CalcularValorHoraExtra(valorporhora, porcentagem, he);
                    DSR = folhapagamento.CalcularDSR(totalhorasextras, diastrabalhados, finaisdesemana);
                    decimal TotalSalarioBruto = SalarioBruto + totalhorasextras + DSR;



                    INSS = folhapagamento.CalcularINSS(SalarioBruto, TotalSalarioBruto);
                    IR = folhapagamento.CalcularIR(TotalSalarioBruto, INSS);
                    FGTS = folhapagamento.CalcularFGTS(TotalSalarioBruto);


                    decimal SalarioLiquido = SalarioBruto + totalhorasextras + DSR - INSS - folhapagamento.ValordeDesconto - VT;

                    lblText.Visible = true;
                    lblSalarioLiquido.Visible = true;
                    lblSalarioLiquido.Text = "R$ " + Decimal.Round(SalarioLiquido).ToString();
                }
                else if (nudHorasExtras.Value == 0 && chkVT.Checked == true)
                {

                    decimal descontodosalariobruto = SalarioBruto / 30 * totaldefaltas;
                    SalarioBruto = SalarioBruto - descontodosalariobruto;

                    decimal valorporhora = folhapagamento.CalcularValorPorHora(SalarioBruto, ht);

                    INSS = folhapagamento.CalcularINSS(SalarioBruto, SalarioBruto);
                    IR = folhapagamento.CalcularIR(SalarioBruto, INSS);
                    FGTS = folhapagamento.CalcularFGTS(SalarioBruto);
                    VT = SalarioBruto * 0.06m;

                    SalarioLiquido = SalarioBruto - INSS - folhapagamento.ValordeDesconto - VT;

                    lblText.Visible = true;
                    lblSalarioLiquido.Visible = true;
                    lblSalarioLiquido.Text = "R$ " + Decimal.Round(SalarioLiquido).ToString();
                }

                else if (nudHorasExtras.Value == 0 && chkVT.Checked == false)
                {
                    decimal descontodosalariobruto = SalarioBruto / 30 * totaldefaltas;
                    SalarioBruto = SalarioBruto - descontodosalariobruto;

                    decimal valorporhora = folhapagamento.CalcularValorPorHora(SalarioBruto, ht);

                    INSS = folhapagamento.CalcularINSS(SalarioBruto, SalarioBruto);
                    IR = folhapagamento.CalcularIR(SalarioBruto, INSS);
                    FGTS = folhapagamento.CalcularFGTS(SalarioBruto);

                    SalarioLiquido = SalarioBruto - INSS - folhapagamento.ValordeDesconto - VT;

                    lblText.Visible = true;
                    lblSalarioLiquido.Visible = true;
                    lblSalarioLiquido.Text = "R$ " + Decimal.Round(SalarioLiquido).ToString();
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Dales Sorrisos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreru um erro, tente mais tarde.", "Dales Sorrisos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkHoraExtra_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHoraExtra.Checked == true)
            {
                lblPorcentagem.Visible = true;
                nudPorcentagem.Visible = true;
                lblHoraExtra.Visible = true;
                nudHorasExtras.Visible = true;
            }

            if (chkHoraExtra.Checked == false)
            {
                lblPorcentagem.Visible = false;
                nudPorcentagem.Visible = false;
                lblHoraExtra.Visible = false;
                nudHorasExtras.Visible = false;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            frmMenu tela = new frmMenu();
            tela.Show();
            Hide();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                FolhaPagamentoDTO dto = new FolhaPagamentoDTO();
                FuncionarioDTO funcionario = cboFuncionario.SelectedItem as FuncionarioDTO;

                dto.ds_mes = cboMes.Text;
                dto.bt_valetransporte = chkVT.Checked;
                dto.vl_fgts = FGTS;
                dto.hr_horasextras = Convert.ToInt32(nudHorasExtras.Value);
                dto.vl_inss = INSS;
                dto.vl_ir = IR;
                dto.vl_salarioliquido = Decimal.Round(SalarioLiquido);
                dto.vl_ValeTransporte = VT;
                dto.id_funcionario = funcionario.Id;

                FolhaPagamentoBusiness business = new FolhaPagamentoBusiness();
                business.Salvar(dto);
                MessageBox.Show("Folha de pagamento salva com sucesso"); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro " + ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

