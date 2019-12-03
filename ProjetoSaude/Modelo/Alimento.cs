using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSaude.Modelo
{
    public class Alimento
    {
        private int id;
        private string nome;
        private int calorias;
        private int quantidade;
        private string medida;

        public Alimento(int id, string nome, int calorias, int quantidade, string medida)
        {
            this.Id = id;
            this.Nome = nome;
            this.Calorias = calorias;
            this.Quantidade = quantidade;
            this.Medida = this.medida;
        }

        public int Id { get => id; private set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public int Calorias { get => calorias; set => calorias = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
        public string Medida { get => medida; set => medida = value; }

        public override string ToString()
        {
            return this.Nome + " " + this.Quantidade + " " + this.Medida;
        }
    }
}
