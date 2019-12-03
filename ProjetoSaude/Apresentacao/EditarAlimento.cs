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
    public partial class EditarAlimento : Form
    {
        private Alimento alimento;
        public EditarAlimento(Alimento alimento)
        {
            InitializeComponent();
            this.alimento = alimento;
        }


        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                AlimentoBLL.Editar(this.alimento);
                MessageBox.Show("Alimento editado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {
            alimento.Nome = txtNome.Text.Trim();
        }

        private void Calorias_ValueChanged(object sender, EventArgs e)
        {
            alimento.Calorias = decimal.ToInt32(calorias.Value);
        }

        private void Quantidade_ValueChanged(object sender, EventArgs e)
        {
            alimento.Quantidade = decimal.ToInt32(quantidade.Value);
        }

        private void Medida_TextChanged(object sender, EventArgs e)
        {
            alimento.Medida = medida.Text.Trim();
        }
    }
}
