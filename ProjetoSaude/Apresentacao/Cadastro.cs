using ProjetoSaude.BLL;
using ProjetoSaude.Modelo;
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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtCPF.MaxLength = 11;
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            txtNome.MaxLength = 30;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            txtRG.MaxLength = 10;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            txtSenha.MaxLength = 11;

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            txtConfirmarSenha.MaxLength = 11;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSenha.Text.Equals(txtConfirmarSenha.Text))
                {
                    UsuarioBLL.Cadastrar(txtNome.Text.Trim(), txtCPF.Text.Trim(), txtRG.Text.Trim(), txtSenha.Text.Trim(), 0, 0);
                }
                else
                {
                    MessageBox.Show("Senha e confirmação de senha diferentes!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            //String mensagem = controle.cadastrar(txtCPF.Text,txtNome.Text, txtRG.Text, txtSenha.Text, txtConfirmarSenha.Text);
     
        }
    }
}
