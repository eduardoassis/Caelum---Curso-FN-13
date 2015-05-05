using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bhaskara
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int a = 1;
            int b = -4;
            int c = 5;

            double delta = calcularDelta(a, b, c);

            MessageBox.Show("X': " + calcularX1(a, b, delta)  + "\n" + "X'': " + calcularX2(a, b, delta));
        }


        private double calcularDelta(int a, int b, int c)
        {
            return b * b - 4 * a * c;
        }

        private double calcularX1(int a, int b, double delta)
        {
            return (-b + Math.Sqrt(delta)) / (2 * a);
        }

        private double calcularX2(int a, int b, double delta)
        {
            return (-b - Math.Sqrt(delta))/ (2 * a);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
