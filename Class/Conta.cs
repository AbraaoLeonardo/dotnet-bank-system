using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace banko.Class
{
    public class Conta
    {
        private TipoDeConta tipoDeConta { get; set; }
        private string nome { get; set; }
        private double saldo { get; set; }
        private double credito { get; set; }
        public Conta(string nome, double saldo, double credito, TipoDeConta tipoDeConta)
        {
            this.nome = nome;
            this.saldo = saldo;
            this.credito = credito;
            this.tipoDeConta = tipoDeConta;
        }

        public Conta()
        {

        }
        public bool Sacar()
        {
            double valor = double.Parse(Console.ReadLine());
            if (this.saldo <= valor)
            {
                Console.WriteLine("Saldo insuficiente");
                return false;
            }
            else
            {
                this.saldo -= valor;
                Console.WriteLine("Novo saldo: " + this.saldo);
                return true;
            }
        }
        public void Depositar()
        {
            Console.WriteLine("Digite o valor a ser depositado");
            double valor = double.Parse(Console.ReadLine());
            this.saldo += valor;
            Console.WriteLine("Saldo atual {0}\nNovo saldo {1} ", this.saldo - valor, this.saldo);
        }

        public void Transferir()
        {
            Console.WriteLine("Digite o valor que será transferido");
            if (!Sacar())
            {
                Console.WriteLine("Saldo insuficiente. \nSaldo atual: " + this.saldo);
            }
        }
        public void MostrarSaldo()
        {
            Console.WriteLine("O saldo da sua conta e: " + this.saldo);
        }
        public bool ConferirNome(string nome)
        {
            if (this.nome == nome)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}