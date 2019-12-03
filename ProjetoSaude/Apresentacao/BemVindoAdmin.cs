using ProjetoSaude.BLL;
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
    public partial class BemVindoAdmin : Form
    {
        public BemVindoAdmin()
        {
            InitializeComponent();
        }

        private void btnCalcularImc_Click(object sender, EventArgs e)
        {
            CalculaImc calculaImc = new CalculaImc();
            calculaImc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //CalculaImc calculaImc = new CalculaImc();
            //calculaImc.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //CalculaImc calculaImc = new CalculaImc();
            //calculaImc.Show();
        }

        private void CadAlimentos_Click(object sender, EventArgs e)
        {
            CadastroAlimento cadastroAlimento = new CadastroAlimento();
            cadastroAlimento.Show();
        }

        private void BtnRemoverAlimentos_Click(object sender, EventArgs e)
        {
            RemoverAlimento removerAlimento = new RemoverAlimento();
            removerAlimento.Show();
        }

        private void BtnControleCalorias_Click(object sender, EventArgs e)
        {
            ControleCaloriasBLL.Exibir();
        }
    }
}
