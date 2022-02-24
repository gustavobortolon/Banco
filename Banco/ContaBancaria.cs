using System.Globalization;

namespace Course
{
    class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string nome)
        {
            Numero = numero;
            Nome = nome;
        }

        public ContaBancaria(int numero, string nome, double saldo) : this(numero, nome)
        {
            Saldo = saldo;
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.0;
        }

        public override string ToString()
        {
            return "conta "
                + Numero
                + ", Titular: "
                + Nome
                + ", Saldo: $"
                + Saldo.ToString("f2", CultureInfo.InvariantCulture);
                
        }


    }
}
