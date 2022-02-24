using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            

                ContaBancaria conta;

                Console.WriteLine("Entre o número da conta:");
                int numero = int.Parse(Console.ReadLine());
                Console.WriteLine("Entre o titular da conta");
                string nome = Console.ReadLine();
                Console.WriteLine("Haverá depósito inicial (s/n)?");
                char resposta = char.Parse(Console.ReadLine());
                if (resposta == 's' || resposta == 'S')
                {
                    Console.WriteLine("Entre o valor de depósito inicial: ");
                    double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    conta = new ContaBancaria(numero, nome, depositoInicial);
                }
                else
                {
                    conta = new ContaBancaria(numero, nome);
                }

                Console.WriteLine();
                Console.WriteLine("Dados da conta: ");
                Console.WriteLine(conta);

                Console.WriteLine();
                Console.WriteLine("Entre um valor para deposito: ");
                double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta.Deposito(quantia);
                Console.WriteLine("Dados da conta atualizados:");
                Console.WriteLine(conta);

                Console.WriteLine();
                Console.Write("Entre um valor para saque: ");
                quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta.Saque(quantia);
                Console.WriteLine("Dados da conta atualizados:");
                Console.WriteLine(conta);
        }   
    }
}