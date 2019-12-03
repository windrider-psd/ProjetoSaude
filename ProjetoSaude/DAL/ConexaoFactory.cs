using System.Data.SqlClient;

namespace ProjetoSaude.DAL
{
    public static class ConexaoFactory
    {
        private static SqlConnection conexao = null;

        public static void Desconectar()
        {
            if (conexao != null && conexao.State == System.Data.ConnectionState.Open)
            {
                conexao.Close();
            }
        }

        public static SqlConnection GetConexao()
        {
            if (conexao == null)
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
    }
}