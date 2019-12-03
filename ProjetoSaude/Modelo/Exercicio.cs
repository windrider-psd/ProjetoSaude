using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSaude.Modelo
{
    public class Exercicio
    {
        private TipoExercicio tipoExercicio;
        private int calorias;

        public TipoExercicio TipoExercicio { get => tipoExercicio; private set => tipoExercicio = value; }
        public int Calorias { get => calorias; private set => calorias = value; }

        private Exercicio(TipoExercicio tipoExercicio, int calorias)
        {
            TipoExercicio = tipoExercicio;
            Calorias = calorias;
        }

        public static readonly Exercicio Natacao = new Exercicio(TipoExercicio.Natacao, 400);
        public static readonly Exercicio Spinning = new Exercicio(TipoExercicio.Spinning, 600);
        public static readonly Exercicio Corrida = new Exercicio(TipoExercicio.Corrida, 400);
        public static readonly Exercicio Zumba = new Exercicio(TipoExercicio.Zumba, 500);

        public static readonly Dictionary<TipoExercicio, Exercicio> exercicios= new Dictionary<TipoExercicio, Exercicio>(){
            {TipoExercicio.Natacao, Natacao},
            {TipoExercicio.Spinning, Spinning},
            {TipoExercicio.Corrida, Corrida},
            {TipoExercicio.Zumba, Zumba}
        };
    }
}
