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

            Conta umaConta = new Conta();
            umaConta.Deposita(10000.0);
            
            Cliente victor = new Cliente();
            victor.Nome = "Victor";

            umaConta.Titular = victor;

            umaConta.Titular.RG = "000.000.000-00";

            MessageBox.Show("Nome: " + umaConta.Titular.Nome);
            MessageBox.Show("RG: " + victor.RG);
            MessageBox.Show("Saldo: " + umaConta.Saldo);
        }

    }
}
