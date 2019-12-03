using ProjetoSaude.BLL;
using ProjetoSaude.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoSaude.Apresentacao
{
    public partial class BemVindo : Form
    {
        public BemVindo()
        {
            InitializeComponent();
            EsconderBotoes();
        }

        private void EsconderBotoes()
        {
            if (Armazenador.usuarioLogado != null && Armazenador.usuarioLogado.Perfil != 1)
            {
                this.Controls.Remove(cadAlimentos);
                this.Controls.Remove(btnRemoverAlimentos);
                this.Controls.Remove(btnEditAlimentos);
            }
        }

        private void btnCalcularImc_Click(object sender, EventArgs e)
        {
            CalculaImc calculaImc = new CalculaImc();
            calculaImc.Show();
        }


        private void CadAlimentos_Click(object sender, EventArgs e)
        {
            if (Armazenador.usuarioLogado != null && Armazenador.usuarioLogado.Perfil == 1)
            {
                CadastroAlimento cadastroAlimento = new CadastroAlimento();
                cadastroAlimento.Show();
            }
        }

        private void BtnRemoverAlimentos_Click(object sender, EventArgs e)
        {
            if (Armazenador.usuarioLogado != null && Armazenador.usuarioLogado.Perfil == 1)
            {
                RemoverAlimento removerAlimento = new RemoverAlimento();
                removerAlimento.Show();
            }
        }

        private void BtnControleCalorias_Click(object sender, EventArgs e)
        {
            ControleCalorias controleCalorias = new ControleCalorias();
            controleCalorias.Show();
        }

        private void BtnEditAlimentos_Click(object sender, EventArgs e)
        {
            if (Armazenador.usuarioLogado != null && Armazenador.usuarioLogado.Perfil == 1)
            {
                EditarAlimento editarAlimento = new EditarAlimento();
                editarAlimento.Show();
            }
        }
    }
}
