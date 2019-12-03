using ProjetoSaude.DAL;
using ProjetoSaude.Modelo;
using ProjetoSaude.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoSaude.BLL
{
    public static class UsuarioBLL
    {

        public static Usuario Cadastrar(string nome, string cpf, string rg, string senha, int status, int perfil)
        {
            Usuario usuario = UsuarioDAL.Inserir(nome, cpf, rg, senha, status, perfil);

            Armazenador.usuarioLogado = usuario;

            return usuario;
            if(perfil == 1)
            {
               //adm
            }
            else
            {
                //entrar normal
            }

        }

        public static void Sair()
        {
            ConexaoFactory.Desconectar();
            Application.Exit();
        }
    }
}
