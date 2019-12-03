using System;
using System.Collections.Generic;

namespace ProjetoSaude.Modelo
{
    public class CalculadoraCalorias
    {
        private readonly List<Tuple<Exercicio, int>> listaExercicios = new List<Tuple<Exercicio, int>>(); //Turple do tipo de exercício e horas
        private readonly Refeicao refeicao = new Refeicao(); //Turple do tipo de exercício e horas

        public int BalancoCaloricas
        {
            get
            {
                return CaloriasRefeicao - CaloriasExercicios;
            }
        }

        public int CaloriasExercicios
        {
            get
            {
                int total = 0;
                foreach (Tuple<Exercicio, int> tuple in listaExercicios)
                {
                    total += tuple.Item1.Calorias * tuple.Item2;
                }
                return total;
            }
        }

        public int CaloriasRefeicao
        {
            get
            {
                int total = 0;

                foreach (Tuple<Alimento, int> alimento in refeicao.Alimentos)
                {
                    total += alimento.Item1.Calorias * alimento.Item2;
                }
                return total;
            }
        }

        public List<Tuple<Exercicio, int>> ListaExercicios => listaExercicios;
        public Refeicao Refeicao => refeicao;

        public Tuple<Exercicio, int> AdicionarExercicio(Exercicio exercicio, int duracao)
        {
            Tuple<Exercicio, int> tuple = new Tuple<Exercicio, int>(exercicio, duracao);
            ListaExercicios.Add(tuple);
            return tuple;
        }
    }
}