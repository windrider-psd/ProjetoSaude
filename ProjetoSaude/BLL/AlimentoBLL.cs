using ProjetoSaude.DAL;
using ProjetoSaude.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSaude.BLL
{
    public static class AlimentoBLL
    {
        public static Alimento Cadastrar(string nome, int calorias, int quantidade, string medida)
        {
            return AlimentoDAL.Inserir(nome, calorias, quantidade, medida);
        }

        public static void Editar(Alimento alimento)
        {
            AlimentoDAL.Editar(alimento);
        }

        public static void Remover(int id)
        {
            AlimentoDAL.Remover(id);
        }

    }
}
