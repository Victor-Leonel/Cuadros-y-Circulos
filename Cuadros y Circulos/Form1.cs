using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cuadros_y_Circulos
{
    public partial class Form1 : Form
    {
        List<Figuras> figuras;

        public Form1()
        {
            figuras = new List<Figuras>();

            InitializeComponent();
        }

        private void Form1_Load(object sender,EventArgs e)
        {
           
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Circulo c = new Circulo(e.X, e.Y);
                c.Dibuja(this);
                figuras.Add(c);

            }
            else if (e.Button == MouseButtons.Right)
            {
                Rectangulo r = new Rectangulo(e.X, e.Y);
                r.Dibuja(this);
                figuras.Add(r);

            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Figuras f in figuras)
            {
                f.Dibuja(this);
            }
        }
    }
}