using ProjetoSaude.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSaude.DAL
{
    public static class AlimentoDAL
    {
        public static Alimento Inserir(string nome, int calorias, int quantitade, string medida)
        {

            SqlCommand cmd = new SqlCommand
            {
                CommandText = "INSERT INTO alimento (nome, calorias, quantidade, medida) values (@n,@c,@q,@p);SELECT SCOPE_IDENTITY()"
            };

            cmd.Parameters.AddWithValue("@n", nome);
            cmd.Parameters.AddWithValue("@c", calorias);
            cmd.Parameters.AddWithValue("@q", quantitade);
            cmd.Parameters.AddWithValue("@p", medida);

            cmd.Connection = ConexaoFactory.GetConexao();
            int id = decimal.ToInt32((decimal)cmd.ExecuteScalar());

            ConexaoFactory.Desconectar();

            return new Alimento(id, nome, calorias, quantitade, medida);
        }
        public static HashSet<Alimento> Encontrar()
        {
            HashSet<Alimento> alimentos = new HashSet<Alimento>();

            SqlCommand cmd = new SqlCommand
            {
                CommandText = "SELECT * FROM alimento"
            };

            cmd.Connection = ConexaoFactory.GetConexao();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                alimentos.Add(new Alimento((int)reader[0], (string)reader[1], (int)reader[2], (int)reader[3], (string)reader[4]));
            }
            reader.Close();
            ConexaoFactory.Desconectar();
            return alimentos;
        }

        public static Alimento Encontrar(string id)
        {
           
            Alimento alimento;

            SqlCommand cmd = new SqlCommand
            {
                CommandText = "SELECT * FROM alimento WHERE id = @id"
            };

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Connection = ConexaoFactory.GetConexao();

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                alimento = new Alimento((int)reader[0], (string)reader[1], (int)reader[2], (int)reader[3], (string)reader[4]);
            }
            else
            {
                alimento = null;
            }
            reader.Close();
            ConexaoFactory.Desconectar();
            return alimento;
        }


        public static void Editar(Alimento alimento)
        {

            SqlCommand cmd = new SqlCommand
            {
                CommandText = "UPDATE alimento set nome = @n, calorias = @c , quantidade = @q , medida = @m where id = @id"
            };

            cmd.Parameters.AddWithValue("@n", alimento.Nome);
            cmd.Parameters.AddWithValue("@c", alimento.Calorias);
            cmd.Parameters.AddWithValue("@q", alimento.Quantidade);
            cmd.Parameters.AddWithValue("@m", alimento.Medida);
            cmd.Parameters.AddWithValue("@id", alimento.Id);

            cmd.Connection = ConexaoFactory.GetConexao();
            cmd.ExecuteScalar();
            ConexaoFactory.Desconectar();
        }

        public static void Remover(Alimento alimento)
        {
            Remover(alimento.Id);
        }

        public static void Remover(int id)
        {
            SqlCommand cmd = new SqlCommand
            {
                CommandText = "DELETE FROM alimento where id = @id"
            };

            cmd.Parameters.AddWithValue("@id", id);

            cmd.Connection = ConexaoFactory.GetConexao();
            cmd.ExecuteScalar();
            ConexaoFactory.Desconectar();
        }
    }

}
