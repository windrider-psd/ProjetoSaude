using ProjetoSaude.DAL;
using ProjetoSaude.Modelo;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjetoSaude.Apresentacao
{
    public partial class ControleCalorias : Form
    {
        private CalculadoraCalorias calculadoraCalorias = new CalculadoraCalorias();

        public ControleCalorias()
        {
            InitializeComponent();
            IniciarComboTipoRefeicao();
            IniciarComboExercicio();
            IniciarComboAlimento();
        }

        private void AtualizarResultado()
        {
            exercicioCalorias.Text = calculadoraCalorias.CaloriasExercicios.ToString() + " Calorias";
            alimentoCalorias.Text = calculadoraCalorias.CaloriasRefeicao.ToString() + " Calorias";
            balancoCalorias.Text = calculadoraCalorias.BalancoCaloricas.ToString() + " Calorias";
        }

        private void BtnAddAlimento_Click(object sender, EventArgs e)
        {
            if (alimento.SelectedIndex != -1)
            {
                Alimento alimento = GetAlimentoSelecionado();

                int quantidade = decimal.ToInt32((quantidadeAlimento.Value));

                calculadoraCalorias.Refeicao.AdicionarAlimento(alimento, quantidade);
                AtualizarResultado();
            }
        }

        private void BtnAddExercicio_Click(object sender, EventArgs e)
        {
            if (exercicio.SelectedIndex != -1)
            {
                Exercicio exercicio = GetExercicioSelecionado();
                int duracao = decimal.ToInt32((horasExercicio.Value));
                calculadoraCalorias.AdicionarExercicio(exercicio, duracao);
                AtualizarResultado();
            }
        }

        private Alimento GetAlimentoSelecionado()
        {
            return (Alimento)((ItemCombo)alimento.SelectedItem).Value;
        }

        private Exercicio GetExercicioSelecionado()
        {
            return (Exercicio)((ItemCombo)exercicio.SelectedItem).Value;
        }

        private TipoRefeicao GetTipoRefeicao()
        {
            return (TipoRefeicao)((ItemCombo)tipoRefeicaoComboBox.SelectedItem).Value;
        }

        private void IniciarComboAlimento()
        {
            HashSet<Alimento> alimentos = AlimentoDAL.Encontrar();
            int i = 0;
            foreach (Alimento alimentovar in alimentos)
            {
                alimento.Items.Insert(i++, new ItemCombo(alimentovar.ToString(), alimentovar));
            }
        }

        private void IniciarComboExercicio()
        {
            int i = 0;
            foreach (KeyValuePair<TipoExercicio, Exercicio> entry in Exercicio.exercicios)
            {
                exercicio.Items.Insert(i++, new ItemCombo(entry.Key.ToString(), entry.Value));
            }
        }

        private void IniciarComboTipoRefeicao()
        {
            int i = 0;
            var valores = Enum.GetValues(typeof(TipoRefeicao));
            foreach (TipoRefeicao tipoRefeicao in valores)
            {
                tipoRefeicaoComboBox.Items.Insert(i++, new ItemCombo(tipoRefeicao.ToString(), tipoRefeicao));
            }
            tipoRefeicaoComboBox.SelectedIndex = 0;
        }

        private void TipoRefeicao_SelectedIndexChanged(object sender, EventArgs e)
        {
            TipoRefeicao tipoRefeicao = GetTipoRefeicao();

            this.calculadoraCalorias.Refeicao.TipoRefeicao = tipoRefeicao;
        }
    }
}