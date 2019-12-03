using ProjetoSaude.BLL;
using ProjetoSaude.DAL;
using ProjetoSaude.Modelo;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjetoSaude.Apresentacao
{
    public partial class RemoverAlimento : Form
    {
        private HashSet<Alimento> alimentos = new HashSet<Alimento>();

        public RemoverAlimento()
        {
            InitializeComponent();
            AtualizarSet();
        }
     

        private void BtnRemover_Click(object sender, EventArgs e)
        {
            if(selecaoAlimento.SelectedIndex != -1)
            {
                Alimento alimento = (Alimento)((ItemCombo)selecaoAlimento.SelectedItem).Value;
                AlimentoBLL.Remover(alimento.Id);
                MessageBox.Show("Alimento excluido com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                AtualizarSet();
            }
        }

        private void AtualizarSet()
        {
            selecaoAlimento.SelectedIndex = -1;
            selecaoAlimento.Items.Clear();
            alimentos = AlimentoDAL.Encontrar();
            int i = 0;
            foreach(Alimento alimento in alimentos)
            {
                selecaoAlimento.Items.Insert(i++, new ItemCombo(alimento.ToString(), alimento));
            }
        }
    }
}
