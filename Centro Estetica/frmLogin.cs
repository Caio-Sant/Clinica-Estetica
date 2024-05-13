using Centro_Estetica.DB.Base.Entregavel1.controle_Funcionario;
using System;
using System.Windows.Forms;

namespace Centro_Estetica
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            try
            {
                FuncionarioBusiness business = new FuncionarioBusiness();
                FuncionarioDTO funcionario = business.Logar(txtNome.Text, txtSenha.Text);

                if (funcionario != null)
                {
                    UserSession.UsuarioLogado = funcionario;

                     TELAS.frmMenu tela = new TELAS.frmMenu();
                   tela.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Credenciais inválidas.", "High Estetic", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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