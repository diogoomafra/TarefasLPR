using System;

namespace exerciciotres
{

    internal class Program
    {
        static void Main (string[] args)
            
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("===========================================================================");
                Console.WriteLine("                             Exercicio-3                               ");
                Console.WriteLine("                             Tarefa A4                                 ");
                Console.WriteLine("Este programa permite que você escolha a classe do seu personagem em um rpg");
                Console.WriteLine("===========================================================================\n ");


                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Você pode escolher entre estas três classes: \n");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("1 - Guerreira \n2 - Mago \n3 - Arqueira\n ");
                Console.ResetColor();  

                Console.Write("Indique o número da sua escolha e a seguir mostraremos suas habilidades: ");
                int escolha = int.Parse(Console.ReadLine());


                if(escolha == 1){

                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("\n Suas habilidades são: Ataque pesado e defesa total\n");
                
                }else if (escolha == 2){

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n Suas habilidades são: Bola de fogo e escudo de gelo\n");
                    
                }else if (escolha == 3){
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("\n Suas habilidades são: Flecha precisa e disparo triplo\n");

                }else{

                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\n Você deve escolher entre as opções pre-indicadas\n");

                }

                Console.ResetColor();
            
            }
    }
}

/* o programa deve fazer:

(classes)
Guerreira: Ataque Pesado, Defesa Total

Mago: Bola de Fogo, Escudo de Gelo

Arqueira: Flecha Precisa, Disparo Triplo

(entrada)
Escolher uma classe de personagem

(if)
Cada classe tem suas próprias habilidades especiais.

(saída de acordo com a classe escolhida)
Exiba suas habilidades especiais correspondentes. 

*/