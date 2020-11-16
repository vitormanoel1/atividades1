using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("quanto voce ganha de salario: ");
            double salario = double.Parse(Console.ReadLine());

            if(salario < 500){
                Console.WriteLine("Seu salário é de: " + (salario*1.3));
            }else{
                Console.WriteLine("voce nao tem direito de aumento");
            }
        }
    }
}
