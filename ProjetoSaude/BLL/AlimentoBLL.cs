using ProjetoSaude.DAL;
using ProjetoSaude.Modelo;
using System;

namespace ProjetoSaude.BLL
{
    public static class AlimentoBLL
    {
        public static Alimento Cadastrar(string nome, int calorias, int quantidade, string medida)
        {
            if (calorias < 0)
            {
                throw new Exception("Calorias não pode ser menor que 0");
            }

            if (quantidade < 0)
            {
                throw new Exception("Quantidade não pode ser menor que 0");
            }

            return AlimentoDAL.Inserir(nome, calorias, quantidade, medida);
        }

        public static void Editar(Alimento alimento)
        {
            if (alimento.Calorias < 0)
            {
                throw new Exception("Calorias não pode ser menor que 0");
            }

            if (alimento.Quantidade < 0)
            {
                throw new Exception("Quantidade não pode ser menor que 0");
            }

            AlimentoDAL.Editar(alimento);
        }

        public static void Remover(int id)
        {
            AlimentoDAL.Remover(id);
        }
    }
}