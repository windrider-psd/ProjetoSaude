using ProjetoSaude.Modelo;
using ProjetoSaude.Util;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ProjetoSaude.DAL
{
    public static class UsuarioDAL
    {
        public static void Atualizar(Usuario usuario, bool hashSenha)
        {
            string senhaSalva = (hashSenha) ? Encriptador.Sha256(usuario.Senha) : usuario.Senha;

            using (SqlCommand cmd = new SqlCommand { CommandText = "UPDATE LOGIN SET nome = @nome , rg = @rg, senha = @senha, status = @status, perfil = @perfil WHERE cpf = @cpf" })
            {
                cmd.Parameters.AddWithValue("@cpf", usuario.Cpf);
                cmd.Parameters.AddWithValue("@nome", usuario.Nome);
                cmd.Parameters.AddWithValue("@rg", usuario.Rg);
                cmd.Parameters.AddWithValue("@senha", senhaSalva);
                cmd.Parameters.AddWithValue("@status", usuario.Status);
                cmd.Parameters.AddWithValue("@perfil", usuario.Nome);
                cmd.Connection = ConexaoFactory.GetConexao();
                ConexaoFactory.Desconectar();
            }
        }

        public static Usuario EncontrarUsuarioCPF(string cpf)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM usuario WHERE cpf = @cpf";
            cmd.Parameters.AddWithValue("@cpf", cpf);
            cmd.Connection = ConexaoFactory.GetConexao();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                Usuario usuario = new Usuario((int)reader["id"], (string)reader["nome"], (string)reader["cpf"], (string)reader["rg"], (string)reader["senha"], (int)reader["status"], (int)reader["perfil"]);
                ConexaoFactory.Desconectar();
                return usuario;
            }
            else
            {
                ConexaoFactory.Desconectar();
                return null;
            }
        }

        public static Usuario EncontrarUsuarioRG(string rg)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM usuario WHERE rg = @rg";
            cmd.Parameters.AddWithValue("@rg", rg);
            cmd.Connection = ConexaoFactory.GetConexao();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                Usuario usuario = new Usuario((int)reader["id"], (string)reader["nome"], (string)reader["cpf"], (string)reader["rg"], (string)reader["senha"], (int)reader["status"], (int)reader["perfil"]);
                ConexaoFactory.Desconectar();
                return usuario;
            }
            else
            {
                ConexaoFactory.Desconectar();
                return null;
            }
        }

        public static HashSet<Usuario> EncontrarUsuarios()
        {
            HashSet<Usuario> usuarios = new HashSet<Usuario>();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM usuario";
            cmd.Connection = ConexaoFactory.GetConexao();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Usuario usuario = new Usuario((int)reader["id"], (string)reader["nome"], (string)reader["cpf"], (string)reader["rg"], (string)reader["senha"], (int)reader["status"], (int)reader["perfil"]);
                usuarios.Add(usuario);
            }

            ConexaoFactory.Desconectar();
            return usuarios;
        }

        public static Usuario Inserir(string nome, string cpf, string rg, string senha, int status, int perfil)
        {
            if (CpfValido(cpf))
            {
                if (EncontrarUsuarioRG(rg) != null)
                {
                    throw new Exception("RG já cadastrado");
                }

                if (EncontrarUsuarioCPF(cpf) != null)
                {
                    throw new Exception("CPF já cadastrado");
                }

                SqlCommand cmd = new SqlCommand
                {
                    CommandText = "INSERT INTO usuario (cpf, nome, rg, senha, status, perfil) values(@c,@n,@r,@s,@st,@p);"
                };

                string hashSenha = Encriptador.Sha256(senha);

                cmd.Parameters.AddWithValue("@c", cpf);
                cmd.Parameters.AddWithValue("@n", nome);
                cmd.Parameters.AddWithValue("@r", rg);
                cmd.Parameters.AddWithValue("@s", hashSenha);
                cmd.Parameters.AddWithValue("@st", status);
                cmd.Parameters.AddWithValue("@p", perfil);

                cmd.Connection = ConexaoFactory.GetConexao();
                cmd.ExecuteNonQuery();

                ConexaoFactory.Desconectar();

                return EncontrarUsuarioCPF(cpf);
            }
            else
            {
                throw new Exception("CPF inválido");
            }
        }

        public static Usuario Login(string cpf, string senha)
        {
            SqlCommand cmd = new SqlCommand
            {
                CommandText = "SELECT * FROM usuario where cpf = @cpf and senha = @senha"
            };
            cmd.Parameters.AddWithValue("@cpf", cpf);
            cmd.Parameters.AddWithValue("@senha", Encriptador.Sha256(senha));

            cmd.Connection = ConexaoFactory.GetConexao();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                Usuario usuario = new Usuario((int)reader["id"], (string)reader["nome"], (string)reader["cpf"], (string)reader["rg"], (string)reader["senha"], (int)reader["status"], (int)reader["perfil"]);
                reader.Close();
                ConexaoFactory.Desconectar();
                return usuario;
            }
            else
            {
                ConexaoFactory.Desconectar();
                throw new Exception("Usuário ou senha incorreta");
            }
        }

        private static bool CpfValido(string cpfValidado)
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