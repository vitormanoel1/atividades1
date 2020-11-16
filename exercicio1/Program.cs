using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Qual a sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("meses: " + idade* 12);
            Console.WriteLine("dias: " + idade * 365);
            Console.WriteLine("horas: " + idade * 24);
            Console.WriteLine("minutos: " + idade * 60);
        }
    }
}
