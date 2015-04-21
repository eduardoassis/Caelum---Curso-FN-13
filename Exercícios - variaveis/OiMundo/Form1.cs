using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OiMundo
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
            int idadeJoao = 30;
            int idadeMaria = 28;
            int idadePedro = 31;

            int mediaDeIdade = (idadeJoao + idadeMaria + idadePedro) / 3;

            MessageBox.Show("Média de didade: " + mediaDeIdade);

            // int pi = 3.14; Não compila pois 3.14 não "cabe" dentro de uma variável do tipo inteiro

            double pi = 3.14;

            int piQuebrado = (int)pi;

            MessageBox.Show("piQuebrado: " + piQuebrado); // Retorna 3



        }
    }
}
