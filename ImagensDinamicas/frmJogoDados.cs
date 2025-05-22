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
        }

        private int SorteioDado(PictureBox dado)
        {
            int valorDado = sorteio.Next(1, 7);
            String arquivoDado = "\'imagens\'dados/dado" + valorDado.ToString() + ".png";
            dado.Image = Image.FromFile(arquivoDado);
            return valorDado;



        }
    }
}
0