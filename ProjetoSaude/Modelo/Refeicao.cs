using System;
using System.Collections.Generic;

namespace ProjetoSaude.Modelo
{
    public class Refeicao
    {
        private HashSet<Tuple<Alimento, int>> alimentos = new HashSet<Tuple<Alimento, int>>();
        private TipoRefeicao tipoRefeicao;
        //Tuple é alimento e quantidade

        public Refeicao()
        {
        }

        public Refeicao(TipoRefeicao tipoRefeicao, HashSet<Tuple<Alimento, int>> alimentos)
        {
            this.TipoRefeicao = tipoRefeicao;
            this.Alimentos = alimentos;
        }

        public HashSet<Tuple<Alimento, int>> Alimentos { get => alimentos; set => alimentos = value; }
        public TipoRefeicao TipoRefeicao { get => tipoRefeicao; set => tipoRefeicao = value; }

        public Tuple<Alimento, int> AdicionarAlimento(Alimento alimento, int quantidade)
        {
            Tuple<Alimento, int> tuple = new Tuple<Alimento, int>(alimento, quantidade);
            alimentos.Add(tuple);
            return tuple;
        }
    }
}