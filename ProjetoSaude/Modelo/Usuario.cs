namespace ProjetoSaude.Modelo
{
    public class Usuario
    {
        private string cpf;
        private int id;
        private string nome;
        private int perfil;
        private string rg;
        private string senha;
        private int status;

        public Usuario(int id, string nome, string cpf, string rg, string senha, int status, int perfil)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Rg = rg;
            Senha = senha;
            Status = status;
            Perfil = perfil;
        }

        public string Cpf { get => cpf; private set => cpf = value; }
        public int Id { get => id; private set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public int Perfil { get => perfil; set => perfil = value; }
        public string Rg { get => rg; set => rg = value; }
        public string Senha { get => senha; set => senha = value; }
        public int Status { get => status; set => status = value; }

        public override string ToString()
        {
            return id + " - " + nome;
        }
    }
}