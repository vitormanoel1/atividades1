using System;

namespace desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            if(idade >=5 && idade <=7){
                Console.WriteLine("voce é da categoria infantil A");
            }
            else if(idade >=8 && idade <=10){
                Console.WriteLine("voce é da categoria infantil B");
            }
            else if(idade >=11 && idade <=13){
                Console.WriteLine(" voce é da categoria juvenil A");
            }
            else if(idade >=14 && idade <=17){
                Console.WriteLine("voce é da categoria juvenil B");
            }
            else if(idade >=18){
                Console.WriteLine("voce é da categoria senior");
            }
        }
    }
}
