using ProjetoSaude.BLL;
using ProjetoSaude.DAL;
using ProjetoSaude.Modelo;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjetoSaude.Apresentacao
{
    public partial class EditarAlimento : Form
    {
        private Alimento alimento;

        public EditarAlimento()
        {
            InitializeComponent();
            PopularComboAlimento();
        }

        public void SetFormulario(Alimento alimento)
        {
            if (alimento != null)
            {
                this.alimento = alimento;
                txtNome.Text = alimento.Nome;
                calorias.Value = alimento.Calorias;
                quantidade.Value = alimento.Quantidade;
                medida.Text = alimento.Medida;
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                AlimentoBLL.Editar(this.alimento);
                MessageBox.Show("Alimento editado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PopularComboAlimento();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Calorias_ValueChanged(object sender, EventArgs e)
        {
            alimento.Calorias = decimal.ToInt32(calorias.Value);
        }

        private void ComboAlimento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboAlimento.SelectedIndex != -1)
            {
                Alimento alimento = (Alimento)((ItemCombo)comboAlimento.SelectedItem).Value;
                SetFormulario(alimento);
            }
        }

        private void Medida_TextChanged(object sender, EventArgs e)
        {
            alimento.Medida = medida.Text.Trim();
        }

        private void PopularComboAlimento()
        {
            HashSet<Alimento> alimentos = AlimentoDAL.Encontrar();
            int i = 0;
            foreach (Alimento alimento in alimentos)
            {
                comboAlimento.Items.Insert(i++, new ItemCombo(alimento.ToString(), alimento));
            }
            comboAlimento.SelectedIndex = -1;
        }

        private void Quantidade_ValueChanged(object sender, EventArgs e)
        {
            alimento.Quantidade = decimal.ToInt32(quantidade.Value);
        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {
            alimento.Nome = txtNome.Text.Trim();
        }
    }
}