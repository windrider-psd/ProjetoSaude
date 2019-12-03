namespace ProjetoSaude.Modelo
{
    public class Alimento
    {
        private int calorias;
        private int id;
        private string medida;
        private string nome;
        private int quantidade;

        public Alimento(int id, string nome, int calorias, int quantidade, string medida)
        {
            this.Id = id;
            this.Nome = nome;
            this.Calorias = calorias;
            this.Quantidade = quantidade;
            this.Medida = medida;
        }

        public int Calorias { get => calorias; set => calorias = value; }
        public int Id { get => id; private set => id = value; }
        public string Medida { get => medida; set => medida = value; }
        public string Nome { get => nome; set => nome = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }

        public override string ToString()
        {
            return this.Nome + " " + this.Quantidade + " " + this.Medida + " (" + Calorias + " cal)";
        }
    }
}