using Centro_Estetica.DB.Base.Objetos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centro_Estetica.TELAS.Esqueci_a_Senha
{
    public partial class Esquecia : Form
    {
        public Esquecia()
        {
            InitializeComponent();
        }
        Email email = new Email();

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            email.Para = txtPara.Text;
            email.Assunto = txtAssunto.Text;
            email.Mensagem = txtMensagem.Text;

            email.Enviar();

            MessageBox.Show("E-mail enviado com sucesso.", "High Estetic",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);
        }

        private void lblAnexo_Click(object sender, EventArgs e)
        {
            OpenFileDialog janela = new OpenFileDialog();
            janela.ShowDialog();

            lstAnexos.Items.Add(janela.FileName);

            email.AdicionarAnexo(janela.FileName);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            frmMenu tela = new frmMenu();
            tela.Show();
            Hide();
        }
    }
    }

