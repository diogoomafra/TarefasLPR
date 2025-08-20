using System;
using System.Globalization;
using System.Security.Cryptography;

namespace atividade1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            int[] pares = new int[10];
            int[] impares = new int[10];

            int contadorpares = 0;
            int contadorimpares = 0;


            for (int i = 0; i < 10; i++)
            {

                Console.Write("Digite um número: ");
                numeros[i] = int.Parse(Console.ReadLine());

            }

            //adicionando os pares ao grupo de pares e os impares ao dos impares
            for (int j = 0; j < 10; j++)
            {
                if (numeros[j] % 2 == 0 /* || numeros[j] % 2 != 0*/)
                {

                    pares[contadorpares] = numeros[j];
                    contadorpares++;

                }

                else
                {

                    impares[contadorimpares] = numeros[j];
                    contadorimpares++;

                }
            }
            Console.WriteLine("\nNumeros PARES");

            for (int i = 0; i < contadorpares; i++)
            {

                Console.WriteLine(pares[i]);

            }

            Console.WriteLine("\nNumeros IMPARES");

            for (int i = 0; i < contadorimpares; i++)
            {

                Console.WriteLine(impares[i]);

            }









        }
    }
}

                
                            
            

            

        