using ProjetoSaude.Apresentacao;
using ProjetoSaude.DAL;
using ProjetoSaude.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoSaude
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CriarUsuarioPadrao();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }


        static Usuario CriarUsuarioPadrao()
        {
            HashSet<Usuario> usuarios = UsuarioDAL.EncontrarUsuarios();
            foreach (Usuario usuario in usuarios)
            {
               if(usuario.Perfil == 1)
                {
                    return null;
                }
            }

            return UsuarioDAL.Inserir("Maicon", "01363228080", "2121364117", "123", 0, 1);
        }
    }
}
