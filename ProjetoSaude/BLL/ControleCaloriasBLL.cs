using ProjetoSaude.Apresentacao;
using ProjetoSaude.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSaude.BLL
{
    public static class ControleCaloriasBLL
    {

        public static void Exibir()
        {
            if(Armazenador.usuarioLogado != null)
            {
                ControleCalorias controleCalorias = new ControleCalorias();
                controleCalorias.Show();
            }
        }
    }
}
