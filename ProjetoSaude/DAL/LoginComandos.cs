using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSaude.DAL
{
    class LoginComandos
    {
        public bool tem = false;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao conn = new Conexao();
        SqlDataReader dr;

        public bool verificaLogin(String cpf, String senha)
        {
            cmd.CommandText = "select * from login where cpf = @cpf and senha = @senha";
            cmd.Parameters.AddWithValue("@cpf", cpf);
            cmd.Parameters.AddWithValue("@senha", senha);

                try
            {
                cmd.Connection = conn.conectar();
                dr = cmd.ExecuteReader();
                
                if(dr.HasRows)
                {
                    tem = true;
                }
                conn.desconectar();
                dr.Close();
            }
            catch(SqlException)
            {
                this.mensagem = "Erro com o banco de dados.";
            }
            return tem;
            
        }

        public String cadastrar(String cpf, String nome, String rg, String senha, String confirmaSenha, String status, String perfil)
        {
            tem = false;

            if(senha.Equals(confirmaSenha))
            {
                cmd.CommandText = "insert into login values(@c,@n,@r,@s,@cs,@st,@p)";
                cmd.Parameters.AddWithValue("@c", cpf);
                cmd.Parameters.AddWithValue("@n", nome);
                cmd.Parameters.AddWithValue("@r", rg);
                cmd.Parameters.AddWithValue("@s", senha);
                cmd.Parameters.AddWithValue("@cs", confirmaSenha);
                cmd.Parameters.AddWithValue("@st", status);
                cmd.Parameters.AddWithValue("@p", perfil);

                try
                {
                    cmd.Connection = conn.conectar();
                    cmd.ExecuteNonQuery();
                    conn.desconectar();
                    this.mensagem = "Cadastro com sucesso!";
                    tem = true;

                }
                catch (SqlException)
                {
                    this.mensagem = "Erro no bando de dados.";
                }
            }
            else
            {
                this.mensagem = "Senhas não correspondem";
            }
            return mensagem;
        }
    }
}
