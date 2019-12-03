using ProjetoSaude.DAL;
using System;
using System.Data.SqlClient;

namespace ProjetoSaude.Modelo
{
    class Controle
    {
        public bool tem;
        public String mensagem = "";

        public bool acessar(String cpf, String senha)
        {
            LoginComandos loginComandos = new LoginComandos();
            tem = loginComandos.verificaLogin(cpf, senha);

            if(!loginComandos.mensagem.Equals(""))
            {
                this.mensagem = loginComandos.mensagem;
            }

            return tem;
        }

        public String cadastrar(String cpf, String nome, String rg, String senha, String confirmaSenha, String status, String perfil)
        {
            // Validar CPF
            bool cpfValidado = validaCpf(cpf);

            // Cadastrar usuário
            LoginComandos loginComandos = new LoginComandos();

            string response = cpf.Trim();

            if (response.Length == 11)
            {
                response = response.Insert(9, "-");
                response = response.Insert(6, ".");
                response = response.Insert(3, ".");
            }

            this.mensagem = loginComandos.cadastrar(cpf, nome, rg, senha, confirmaSenha, status, perfil);
            
            if(loginComandos.tem)
            {
                this.tem = true;
            }

            return mensagem;
        }

        public bool validaCpf(String cpfValidado)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;

            cpfValidado = cpfValidado.Trim();
            cpfValidado = cpfValidado.Replace(".", "").Replace("-", "");

            if (cpfValidado.Length != 11)
                return false;

            tempCpf = cpfValidado.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cpfValidado.EndsWith(digito);
        }
    }

}
