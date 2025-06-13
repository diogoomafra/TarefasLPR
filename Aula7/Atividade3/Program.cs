using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace atividade3
{

    internal class Program
    {
        static void Main(string[] args)

        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\n=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=\n");
            Console.WriteLine("          Aplicação de Distância          ");
            Console.WriteLine("             Tarefa - LPR  07            ");
            Console.WriteLine("\n=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=");
            Console.ResetColor();

            //programa começa aqui  


            int[,] cidadeM = { { 0, 524, 521, 882 }, { 524, 0, 434, 586 }, { 521, 434, 0, 429 }, { 882, 586, 429, 0 } };
            

            string[] cidadeL = {"Vitória","Belo Horizonte", "Rio de Janeiro", "São Paulo"};
            string[] cidadeC = {"Vitória","Belo Horizonte", "Rio de Janeiro", "São Paulo"};


            string cidadeF1 = ".";
            string cidadeF2 = ","; 


            //Enquanto as cidades forem diferentes o código deve continuar rodando
            while (cidadeF1 != cidadeF2)
            {
                
                Console.WriteLine("\nCidades possíveis: Vitória, Belo Horizonte, Rio de Janeiro e São Paulo!");

                Console.Write("Digite uma cidade: ");
                cidadeF1 = Console.ReadLine();

                Console.Write("Digite a outra cidade: ");
                cidadeF2 = Console.ReadLine();
                if (cidadeF1 != cidadeF2)
                {

                    for (int i = 0; i < 4; i++)
                    {
                        if (cidadeL[i] == cidadeF1)
                        {
                            //se sim vamos fazer outro for para coluna 
                            for (int j = 0; j < 4; j++)
                            {
                                if (cidadeC[j] == cidadeF2)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine($"A distância entre {cidadeF1} e {cidadeF2} é de {cidadeM[i, j]}Km!");
                                    Console.ResetColor();
                                    Console.WriteLine("\n===========================================");
                                }
                            }

                        }

                    }


                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("A cidade informada é a mesma!");
                    Console.WriteLine("Saindo...");
                    Console.ResetColor();
                }

            }

            
        
            // passar por todos os elementos da cidade COLUNA e verificar se há alguma cidade com o primeiro nome indicado


            // o mesmo fazer com a cidade linha 


            // se der ok nas duas verificações mostrar a posição na matriz que corresponde ao valor da posição na linha x coluna 



        }

    }

}