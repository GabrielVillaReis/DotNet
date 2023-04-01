using System;
using System.Globalization;

namespace exercicios7
{
    internal class ContaBancaria
    {
        private string _nome;
        public int Id { get; private set; }
        public double Saldo { get; set; }

        public ContaBancaria(int id, string nome)
        {
            _nome = nome;
            Id = id;
            Saldo = 0;
        }

        public ContaBancaria(int id, string nome,double  saldo) : this(id,nome)
        {
            Saldo = saldo;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1) { _nome = value; }
            }
        }

        public void Depositar(double deposito)
        {
            Saldo += deposito;
        }   

        public void Sacar(double saque)
        {
            Saldo -= saque + 5;
        }

        public override string ToString()
        {
            return "Conta: "
                + Id
                + ", Titular: "
                + _nome
                + ", Saldo: $"
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
