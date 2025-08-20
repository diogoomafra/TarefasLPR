using System;

namespace exercicioum
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("==========================");
                Console.WriteLine("       Exercicio-1          ");
                Console.WriteLine("       Tarefa A4          ");
                Console.WriteLine("==========================");
                Console.ResetColor();


                int num;
                
                Console.Write("Insira um número inteiro: ");
                num = Convert.ToInt32(Console.ReadLine());

                if ( num % 2 == 0){

                    Console.WriteLine("Par");

                } else{

                    Console.WriteLine("Ímpar");

                }



        }
    }
}