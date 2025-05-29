using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
        private int ticks = 20;
        private string nomeJogador1;
        private string nomeJogador2;
        public frmJogoDados(string nomeJogador1, string nomeJogador2)
        {
            InitializeComponent();
            this.nomeJogador1 = nomeJogador1;
            this.nomeJogador2 = nomeJogador2;
            pcJogador1.Image = Image.FromFile(".\\imagens\\dado1.jpg");
            pcJogador2.Image = Image.FromFile(".\\imagens\\dado1.jpg");

        }

        private void frmJogoDados_Load(object sender, EventArgs e)
        {
            lblJogador1.Text = nomeJogador1;
            lblJogador2.Text = nomeJogador2;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Deseja sair",
                                "Jogo de Dados CTI",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
                this.Close();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
           lblPlacar1.Text = "0";
           lblPlacar2.Text = "0";
            
        }

        private void timerDado_Tick(object sender, EventArgs e)
        {
          int dadoJog1 = sorteio.Next(1, 7);
          int dadoJog2 = sorteio.Next(1, 7);
          pcJogador1.Image= Image.FromFile(".\\imagens\\dado" + dadoJog1.ToString() + ".jpg");
          pcJogador2.Image = Image.FromFile(".\\imagens\\dado" + dadoJog2.ToString() + ".jpg");

            ticks--;  
            if (ticks <= 0)
            {
                timerDado.Stop();
                btnJogar.Text = "Jogar";
                ticks = 20;
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
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            if (timerDado.Enabled)
            {
                timerDado.Stop();
                btnJogar.Text = "Jogar";
            }
            else
            {
                timerDado.Start();
                btnJogar.Text = "Parar";
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
