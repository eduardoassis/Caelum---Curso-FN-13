using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstruturasDeRepeticao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double valorInvestido = 1000.0;

            /*
            for (int i = 0; i <= 11; i++)
            {
                valorInvestido = valorInvestido * 1.01;
            }
            */

            /*
            int i = 0;
            while(i <= 11)
            {
                valorInvestido = valorInvestido * 1.01;
                i++;
            }
            */

            /*
            int total = 2;

            for (int i = 0; i < 5; i++)
            {
                total = total * 2;
            }

            MessageBox.Show("O total é: " + total);
            */

            /*
            int soma = 0;

            for (int i = 1; i <= 1000; i++)
            {
                soma += i;
            }

            MessageBox.Show("Soma de 1 a 1000: " + soma);
            */

            for(int i = 1; i <= 100; i++)
            {
                if((i % 3) == 0)
                {
                    MessageBox.Show(i.ToString());
                }
            }
        }
    }
}
