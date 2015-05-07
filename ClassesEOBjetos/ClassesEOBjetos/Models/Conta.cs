using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesEOBjetos.Models
{
    class Conta
    {
        public int Numero { get; set;}
        public double Saldo{get; private set;}
        public Cliente Titular { get; set; }

        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }

        public bool Saca(double valor)
        {
            if(valor <= this.Saldo)
            {
                this.Saldo -= valor;
                return true;
            }

            return false;
        }

        public void Transfere(double valor, Conta destino)
        {
            if(this.Saldo >= valor)
            {
                this.Saldo -= valor;
                destino.Deposita(valor);
            }
        }
    }
}
