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
            figuras = new Figura[5] 
            {
                new Circulo(10),
                new Rectangulo(20,30),
                new Cuadrado(40),
                new Isosceles(50,60),
                new Equilatero(70)
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
                figuras[i].Dibujar(pen, gr, i * 70, 50);
            }

        }
    }
}
