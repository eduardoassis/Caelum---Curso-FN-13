using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassesEOBjetos.Models;

namespace ClassesEOBjetos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            Conta contaVictor = new Conta();

            contaVictor.titular = "Victor";
            contaVictor.numero = 1;
            contaVictor.Deposita(100.0);
            MessageBox.Show("Saldo: " + contaVictor.saldo);
            contaVictor.Saca(50.0);
            MessageBox.Show("Saldo: " + contaVictor.saldo);
            */

            Conta mauricio = new Conta();
            mauricio.saldo = 2000.0;

            Conta copia = mauricio;
            copia.saldo = 3000.0;

            MessageBox.Show("Mauricio: " + mauricio.saldo);
            MessageBox.Show("Copia: " + copia.saldo);


        }

    }
}
