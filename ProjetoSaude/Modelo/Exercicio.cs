using System.Collections.Generic;

namespace ProjetoSaude.Modelo
{
    public class Exercicio
    {
        public static readonly Exercicio Corrida = new Exercicio(TipoExercicio.Corrida, 400);

        public static readonly Dictionary<TipoExercicio, Exercicio> exercicios = new Dictionary<TipoExercicio, Exercicio>(){
            {TipoExercicio.Natacao, Natacao},
            {TipoExercicio.Spinning, Spinning},
            {TipoExercicio.Corrida, Corrida},
            {TipoExercicio.Zumba, Zumba}
        };

        public static readonly Exercicio Natacao = new Exercicio(TipoExercicio.Natacao, 400);
        public static readonly Exercicio Spinning = new Exercicio(TipoExercicio.Spinning, 600);
        public static readonly Exercicio Zumba = new Exercicio(TipoExercicio.Zumba, 500);
        private int calorias;
        private TipoExercicio tipoExercicio;

        private Exercicio(TipoExercicio tipoExercicio, int calorias)
        {
            TipoExercicio = tipoExercicio;
            Calorias = calorias;
        }

        public int Calorias { get => calorias; private set => calorias = value; }
        public TipoExercicio TipoExercicio { get => tipoExercicio; private set => tipoExercicio = value; }
    }
}