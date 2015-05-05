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

            for (int i = 0; i <= 11; i++)
            {
                valorInvestido = valorInvestido * 1.01;
            }

            MessageBox.Show("Valor investido depois de 12 meses rendendo 1% ao mês é: " + valorInvestido);
        }
    }
}
