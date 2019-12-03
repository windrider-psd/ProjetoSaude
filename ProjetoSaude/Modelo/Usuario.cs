using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSaude.Modelo
{
    public class Usuario
    {
        private int id;
        private string cpf;
        private string nome;
        private string rg;
        private string senha;
        private int status;
        private int perfil;

        
        public string Cpf { get => cpf; private set => cpf = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Rg { get => rg; set => rg = value; }
        public string Senha { get => senha; set => senha = value; }
        public int Status { get => status; set => status = value; }
        public int Perfil { get => perfil; set => perfil = value; }
        public int Id { get => id; private set => id = value; }

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

        public override string ToString()
        {
            return id + " - " + nome; 
        }
    }
}
