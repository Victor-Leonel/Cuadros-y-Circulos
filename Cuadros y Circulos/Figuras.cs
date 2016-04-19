using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Cuadros_y_Circulos
{
    abstract class Figuras
    {
        public int X, Y;
        public Pen pluma;
        public Brush brocha;
        public int ancho, largo;

        public Figuras(int x, int y)
        {
            X = x;
            Y = y;
            pluma = new Pen(Color.Red, 2);
            ancho = 30;
            largo = 30;

        }
        public abstract void Dibuja(Form f);
    }
    class Rectangulo : Figuras
    {
        public Rectangulo(int x, int y) : base(x, y)
        {

        }
        public override void Dibuja(Form f)
        {
            Graphics g = f.CreateGraphics();
            g.DrawRectangle(pluma, X, Y, ancho, largo);
        }
    }

    class Circulo : Figuras
    {
        public Circulo(int x, int y) : base(x, y)
        {

        }
        public override void Dibuja(Form f)
        {
            Graphics g = f.CreateGraphics();
            g.DrawEllipse(pluma, X, Y, ancho, largo);
        }
    }
}
