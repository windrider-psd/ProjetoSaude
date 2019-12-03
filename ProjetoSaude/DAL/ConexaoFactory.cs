using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSaude.DAL
{
    public static class ConexaoFactory
    {
        private static SqlConnection conexao = null;

        public static SqlConnection GetConexao()
        {
            if(conexao == null)
            {
                conexao = new SqlConnection();
                conexao.ConnectionString = "Server=localhost;Database=master;Trusted_Connection=True;";
            }

            if (conexao.State == System.Data.ConnectionState.Closed)
            {
                conexao.Open();
            }
            return conexao;
        }

        public static void Desconectar()
        {   
            if (conexao != null && conexao.State == System.Data.ConnectionState.Open)
            {
                conexao.Close();
            }
        }
    }
}
