using System;
using System.Globalization;

namespace Exercitando
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite seu nome completo!");
            string nome = Console.ReadLine();
            Console.WriteLine("digite o saldo da sua conta!");
            double saldo = double.Parse(Console.ReadLine());
            Console.WriteLine("digite sua idade!");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua habilidade, seu numero da sorte, seu sexo, seu saldo na conta!");
            string[] let = Console.ReadLine().Split(' ');
            string N1 = let[0];
            int N2 = int.Parse(let [1]);
            char N3 = char.Parse(let[2]);
            double N4 = double.Parse(let[3]);



            Console.WriteLine(nome);
            Console.WriteLine(saldo.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(idade);
            Console.WriteLine(N1);
            Console.WriteLine(N2);
            Console.WriteLine(N3);
            Console.WriteLine(N4.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
