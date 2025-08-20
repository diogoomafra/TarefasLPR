using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Exemplo de entrada
        List<string> nomes = new List<string> {
            "sergio", "ana", "maria", "carlos", "eva", "joaquim",
            "jo", "mara", "laura", "lucas", "ari", "paulo"
        };

        // Lista de filas (para garantir ordem de entrada)
        Dictionary<int, Queue<string>> grupos = new Dictionary<int, Queue<string>>();

        // Organiza em filas por tamanho
        foreach (var nome in nomes)
        {
            int tamanho = nome.Length;
            if (!grupos.ContainsKey(tamanho))
            {
                grupos[tamanho] = new Queue<string>();
            }
            grupos[tamanho].Enqueue(nome);
        }

        bool aindaTemNomes = true;
        while (aindaTemNomes)
        {
            aindaTemNomes = false;
            List<string> linha = new List<string>();

            // Percorre os grupos em ordem de tamanho
            foreach (var tamanho in grupos.Keys.OrderBy(x => x))
            {
                if (grupos[tamanho].Count > 0)
                {
                    linha.Add(grupos[tamanho].Dequeue());
                    aindaTemNomes = true;
                }
            }

            if (linha.Count > 0)
                Console.WriteLine(string.Join(", ", linha));
        }
    }
}
