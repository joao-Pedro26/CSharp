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
    public partial class frmCarregaFoto : Form
    {
        public frmCarregaFoto()
        {
            InitializeComponent();
        }

        private void btnCarregarFoto1_Click(object sender, EventArgs e)
        {
            opdFoto.Filter = "JPEG(*.jpg)|*.jpg|PNG(*.png)|*.png|BMP(*.bmp)|*.bmp";
            if (opdFoto.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opdFoto.FileName);
            }
            else
            {
                pictureBox1.Image = null;
            }

        }

        private void btnCarregaFoto2_Click(object sender, EventArgs e)
        {
            opdFoto.Filter = "JPEG(*.jpg)|*.jpg|PNG(*.png)|*.png|BMP(*.bmp)|*.bmp";
            if (opdFoto.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(opdFoto.FileName);
            }
            else
            {
                pictureBox2.Image = null;
            }
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            frmJogoDados jogo = new frmJogoDados(txtNomeJog1.Text, txtNomeJog2.Text, pictureBox1.Image,pictureBox2.Image);
            this.Hide();
            jogo.ShowDialog();
            this.Show();
        }
    }
}
