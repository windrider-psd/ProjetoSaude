using ProjetoSaude.DAL;
using ProjetoSaude.Modelo;
using ProjetoSaude.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoSaude.Apresentacao
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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
                Usuario usuario = UsuarioDAL.Login(txtCpf.Text.Trim(), txtSenha.Text);
                Armazenador.usuarioLogado = usuario;
                Console.WriteLine(usuario);

                BemVindoAdmin bv = new BemVindoAdmin();
                bv.Show();
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

            /*Controle controle = new Controle();
            controle.acessar(txtCpf.Text, txtSenha.Text);

            if(controle.mensagem.Equals(""))
            {
                if (controle.tem)
                {
                    MessageBox.Show("Logado com sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BemVindo bv = new BemVindo();
                    bv.Show();
                }
                else
                {
                    MessageBox.Show("Login não encontrado, verifique o login e senha", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
            */
           
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
