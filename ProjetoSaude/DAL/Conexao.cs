using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSaude.DAL
{
    class Conexao
    {
        SqlConnection conn = new SqlConnection();

        public Conexao()
        {
            // conn.ConnectionString = @"Data Source=MANGO\SQLEXPRESS;Initial Catalog=ProjetoSaude;Integrated Security=True";
            conn.ConnectionString = "Server=localhost;Database=master;Trusted_Connection=True;";
        }

        public SqlConnection conectar()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;
        }

        public void desconectar()
        {
            if(conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
