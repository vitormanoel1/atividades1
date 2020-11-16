using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite o ano atual: ");
            int anoAtual = int.Parse(Console.ReadLine());

            Console.WriteLine("digite seu ano de nascimento: ");
            int anoDeNascimento = int.Parse(Console.ReadLine());

            Console.WriteLine("Idade atual: " + (anoAtual - anoDeNascimento));
            Console.WriteLine("Sua idade em semanas: " + ((anoAtual - anoDeNascimento)*52));
        }
    }
}
