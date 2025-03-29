using System;
using System.ComponentModel;

namespace exerc4
{
    internal class Program
    {
        static void Main(string[] args)
        {
                
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("==========================");
            Console.WriteLine("       Exercicio-4          ");
            Console.WriteLine("       Tarefa A5          ");
            Console.WriteLine("==========================");
            Console.ResetColor();
            
            Console.WriteLine("Insira um valor: ");
            int n = int.Parse(Console.ReadLine());

            int quadrado = n*n;

            string quadradochar = quadrado.ToString();

            int soma = 0;

            for (int i = 0; i < quadradochar.Length; i++ ){

                soma += int.Parse(quadradochar[i].ToString());


            }
            
             Console.WriteLine("A soma dos dígitos do quadrado de " + n + " é: " + soma);

        }
    }
}
/*
ESCOLHA A MELHOR ESTRUTURA DE
REPETIÇÃO: Solicite ao usuário para inserir
um número e calcule a soma dos dígitos do
quadrado desse número. Por exemplo, se o
número fornecido for 123, calcule 123² =
15129 e então a soma dos seus dígitos: 1 +
5 + 1 + 2 + 9 = 18.
*/