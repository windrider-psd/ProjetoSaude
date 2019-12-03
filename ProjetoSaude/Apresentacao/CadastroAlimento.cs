using ProjetoSaude.BLL;
using System;
using System.Windows.Forms;

namespace ProjetoSaude.Apresentacao
{
    public partial class CadastroAlimento : Form
    {
        public CadastroAlimento()
        {
            InitializeComponent();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                AlimentoBLL.Cadastrar(txtNome.Text.Trim(), (int)calorias.Value, (int)quantidade.Value, medida.Text.Trim());
                MessageBox.Show("Alimento cadastrado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}