using ProjetoSaude.Apresentacao;
using ProjetoSaude.DAL;
using ProjetoSaude.Modelo;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjetoSaude
{
    internal static class Program
    {
        private static string cpfPadrao = "51316975061";
        private static string nomePadrao = "Toyne";
        private static string rgPadrao = "319991507";
        private static string senhaPadrao = "123";

        //Cria um usuário administrador casa não houver um
        private static Usuario CriarUsuarioPadrao()
        {
            HashSet<Usuario> usuarios = UsuarioDAL.EncontrarUsuarios();
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.Perfil == 1)
                {
                    return null;
                }
            }

            return UsuarioDAL.Inserir(nomePadrao, cpfPadrao, rgPadrao, senhaPadrao, 0, 1);
        }

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            CriarUsuarioPadrao();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}