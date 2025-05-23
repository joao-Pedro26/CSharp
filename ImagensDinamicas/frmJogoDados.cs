using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImagensDinamicas
{
    public partial class frmJogoDados : Form
    {

        private Random sorteio = new Random();
        private int dadoJog1, dadoJog2;
        private int contVitoria1 = 0, contVitoria2 = 0;
        
        public frmJogoDados()
        {
            InitializeComponent();
        }


        private void btnJogar_Click(object sender, EventArgs e)
        {
            dadoJog1 = SorteioDado(pcJogador1);
            dadoJog2 = SorteioDado(pcJogador2);
            if (dadoJog1 > dadoJog2)
            {
                contVitoria1++;
                lblPlacar1.Text = contVitoria1.ToString();
            }
            else if (dadoJog2 > dadoJog1)
            {
                contVitoria2++;
                lblPlacar2.Text = contVitoria2.ToString();
            }
            else
            {
                MessageBox.Show("Empate!",
                                "Jogo de Dados CTI",
                                 MessageBoxButtons.OK, 
                                 MessageBoxIcon.Exclamation);

            }
        }
        private int SorteioDado(PictureBox dado)
        {
            int valorDado = sorteio.Next(1, 7);
            String arquivoDado = ".\\imagens\\dado" + valorDado.ToString() + ".jpg";
            dado.Image = Image.FromFile(arquivoDado);
            return valorDado;



        }
    }
}
