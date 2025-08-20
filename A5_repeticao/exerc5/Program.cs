using System;
using System.ComponentModel;

namespace exerc5
{
    internal class Program
    {
        static void Main(string[] args)
        {


            double horaTrain, HTsemana, diasp1000h, semanasp1000h, mesesp1000h;

            Console.WriteLine("Insira o valor de horas treinadas por dia: ");
            horaTrain = Console.Read();

            HTsemana = 5 * horaTrain; 
            semanasp1000h = 1000 / horaTrain;
            diasp1000h = semanasp1000h*5;
            mesesp1000h = semanasp1000h/4.5;

            Console.WriteLine($"Horas de treinamento por semana: {HTsemana:F2} horas");
            Console.WriteLine($"Seriam necessários: {diasp1000h:F2} dkas de treinemanto");
            Console.WriteLine($"{semanasp1000h:F2} semanas de treinamento");
            Console.WriteLine($"Ou aprocimadamente {mesesp1000h:F2} meses de treino");


        }
    }
}
