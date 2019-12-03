using ProjetoSaude.BLL;
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

            catch(Exception ex)
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
