using ProjetoSaude.DAL;
using ProjetoSaude.Modelo;
using ProjetoSaude.Util;
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
        }

        public static Usuario Login(string cpf, string senha)
        {
            Usuario usuario = UsuarioDAL.Login(cpf, senha);

            Armazenador.usuarioLogado = usuario;

            return usuario;
        }

        public static void Logout()
        {
            Armazenador.usuarioLogado = null;
        }

        public static void Sair()
        {
            ConexaoFactory.Desconectar();
            Application.Exit();
        }
    }
}