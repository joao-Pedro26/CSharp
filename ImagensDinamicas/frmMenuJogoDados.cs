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
    public partial class frmMenuJogoDados : Form
    {
        public frmMenuJogoDados()
        {
            InitializeComponent();
         
            Image imagemFoto = new Bitmap(new Bitmap(".\\imagens\\foto.jpg"), btFrmFotos.Width - 20, btFrmFotos.Height - 5);
            btFrmFotos.Image = imagemFoto;
        }

        private void btFrmDados_Click(object sender, EventArgs e)
        {
           
        }

        private void btFrmFotos_Click(object sender, EventArgs e)
        {
            frmCarregaFoto fotos = new frmCarregaFoto();
            this.Hide();
            fotos.ShowDialog();
            this.Show();
        }
    }
}
