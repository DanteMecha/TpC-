using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Figuras
{
    public partial class Form1 : Form
    {
        Figura[] figuras;

        public Form1()
        {
            InitializeComponent();
            figuras = new Figura[3] 
            {
                new Circulo(30),
                new Rectangulo(50,50),
                new Cuadrado(70),
            };

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Graphics gr = pictureBox1.CreateGraphics();
            for (int i = 0; i < figuras.Length; i++)
            {
                int r = rnd.Next(0, 90);
                int g = rnd.Next(0, 90);
                int b = rnd.Next(0, 90);
                Pen pen = new Pen(Color.FromArgb(r, g, b));
                figuras[i].Dibujar(pen, gr, i * 100, 50);
            }

        }
    }
}
