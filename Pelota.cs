using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoGol
{
    class Pelota
    {
        private double x;
        private double y;
        private double radio;

        private double ancho;
        private double alto;

        private double dir;
        private double angulo;
        private bool estado;

        public Pelota(double ancho, double alto)
        {
            Random r = new Random();

            this.ancho = ancho; // Ancho de la cancha
            this.alto = alto;   // Alto de la cancha

            this.x = ancho / 2; // Cambiar para que la posicion inicial sea encima de la plataforma
            this.y = alto / 2;  // Mismo aquí ...
            this.radio = Math.Min(ancho, alto) / 25;

            dir = 1;
            angulo = r.Next(0, 90);

            estado = false;
        }

        public void Mover()
        {
            if (estado)
            {
                double rad = (this.angulo * Math.PI) / 180.0;


                if (Math.Abs(angulo) <= 45)
                {
                    x += dir;
                    y += dir * Math.Tan(rad);

                    if ((this.y - this.radio <= 0) || (this.y + this.radio >= alto))
                    {
                        this.angulo = -this.angulo;
                    }

                    if ((this.x - this.radio <= 0) || (this.x + this.radio >= ancho))
                    {
                        this.dir = -this.dir;
                        this.angulo = -this.angulo;
                    }
                }
                else if (Math.Abs(angulo) < 90)
                {
                    y += dir;
                    x += dir / Math.Tan(rad);

                    if ((this.y - this.radio <= 0) || (this.y + this.radio >= alto))
                    {
                        this.dir = -this.dir;
                        this.angulo = -this.angulo;
                    }

                    if ((this.x - this.radio <= 0) || (this.x + this.radio >= ancho))
                    {
                        this.angulo = -this.angulo;
                    }
                }
                else
                {
                    this.y += this.dir;

                    if ((this.y - this.radio <= 0) || (this.y + this.radio >= alto))
                    {
                        this.dir = -this.dir;
                    }
                }
            }
        }

        public void setDir(int dir)
        {
            if (this.dir > 0)
                this.dir = dir;
            else
                this.dir = -dir;
        }

        public void CambiaEstado()
        {
            estado = !estado;
        }

        public bool GetEstado()
        {
            return estado;
        }

        public void Dibujar(Graphics graphics)
        {
            graphics.FillEllipse(Brushes.Maroon,
                (int)(x - radio), (int)(y - radio),
                (int)(2 * radio), (int)(2 * radio));
        }
    }
}
