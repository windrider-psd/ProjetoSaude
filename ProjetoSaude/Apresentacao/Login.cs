using ProjetoSaude.BLL;
using System;
using System.Windows.Forms;

namespace ProjetoSaude.Apresentacao
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            Cadastro cad = new Cadastro();
            cad.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioBLL.Login(txtCpf.Text.Trim(), txtSenha.Text);
                BemVindo bv = new BemVindo();
                bv.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}