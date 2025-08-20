using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Criar dicionário de pessoas e idades
        Dictionary<string, int> pessoas = new Dictionary<string, int>
        {
            { "Joao", 20 },
            { "Maria", 25 },
            { "Pedro", 30 },
            { "Ana", 18 },
            { "Lucas", 22 }
        };

        // Calcular média das idades
        double media = pessoas.Values.Average();
        Console.WriteLine($"Idade média: {media}");

        // Pessoas acima da média
        Console.WriteLine("Pessoas acima da média:");
        foreach (var p in pessoas)
        {
            if (p.Value > media)
                Console.WriteLine($"{p.Key} ({p.Value})");
        }

        // Pessoa mais velha e mais nova
        var maisVelha = pessoas.Aggregate((x, y) => x.Value > y.Value ? x : y);
        var maisNova = pessoas.Aggregate((x, y) => x.Value < y.Value ? x : y);

        Console.WriteLine($"Pessoa mais velha: {maisVelha.Key} ({maisVelha.Value})");
        Console.WriteLine($"Pessoa mais nova: {maisNova.Key} ({maisNova.Value})");

        // Remover idade igual a Y
        Console.Write("Digite um valor Y para remover: ");
        int y = int.Parse(Console.ReadLine());

        var removidos = pessoas.Where(p => p.Value == y).Select(p => p.Key).ToList();
        foreach (var nome in removidos)
            pessoas.Remove(nome);

        Console.WriteLine("Dicionário atualizado:");
        foreach (var p in pessoas)
        {
            Console.WriteLine($"{p.Key} - {p.Value}");
        }
    }
}
