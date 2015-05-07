using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesEOBjetos.Models
{
    class Conta
    {
        public int numero;
        public double saldo;
        public Cliente titular;

        public void Deposita(double valor)
        {
            this.saldo += valor;
        }

        public bool Saca(double valor)
        {
            if(valor <= this.saldo)
            {
                this.saldo -= valor;
                return true;
            }

            return false;
        }

        public void Transfere(double valor, Conta destino)
        {
            if(this.saldo >= valor)
            {
                this.saldo -= valor;
                destino.Deposita(valor);
            }
        }
    }
}
