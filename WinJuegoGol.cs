using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoGol
{
    public partial class WinJuegoGol : Form
    {
        private Pelota pel;
        private Plataforma plat;
        private Arco arc;

        public WinJuegoGol()
        {
            InitializeComponent();
            pel = new Pelota(pbCancha.Width, pbCancha.Height);
        }

        private void pbCancha_Paint(object sender, PaintEventArgs e)
        {
            pel.Dibujar(e.Graphics);
            pbCancha.Invalidate();
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            pel.Mover();
            pbCancha.Invalidate();
        }

        private void botonComenzar_Click(object sender, EventArgs e)
        {
            if (pel.GetEstado())
                botonComenzar.Text = "Comenzar";
            else
                botonComenzar.Text = "Pausar";

            pel.CambiaEstado();
        }
    }
}
