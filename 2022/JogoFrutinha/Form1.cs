using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoFrutinha
{
    public partial class Form_principal : Form
    {
        public Form_principal()
        {
            InitializeComponent();
        }

        private void iniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_cobra.Visible = true;
            button_fruta.Visible = true;
            button_cobra.Focus();
            Movimenta.sorteiaPosicao(button_fruta, this);
            Movimenta.sorteiaPosicao(button_cobra, this);
        }

     

        private void button_cobra_KeyDown(object sender, KeyEventArgs e)
        {           
            switch (e.KeyCode)
            {
                case Keys.A:
                    //ir para esquerda
                    Movimenta.irEsquerda(button_cobra);
                    break;
                case Keys.D:
                    //ir para direita
                    Movimenta.irDireita(button_cobra, this);
                    break;
                case Keys.W:
                    //ir para cima
                    Movimenta.irCima(button_cobra);
                    break;
                case Keys.S:
                    //ir para baixo
                    Movimenta.irBaixo(button_cobra, this);
                    break;
                default:
                    break;
            }

            if (button_cobra.Bounds.IntersectsWith(button_fruta.Bounds))
            {
                Movimenta.sorteiaPosicao(button_fruta, this);
            }
        }
    }
}
