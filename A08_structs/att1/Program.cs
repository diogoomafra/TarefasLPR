using System;
public struct produto
{
    public string Nome;
    public int Codigo;
    public int Preco;
    public int Quantidade;
    
}
class att1 {
    static void Main()
    {
        int[] valor = new int[3];
        Console.WriteLine("Insira os produtos:");

        produto[] vetorProdutos = new produto[3];

        for (int i = 0; i < 3; i++)
        {
            Console.Write("Digite o nome do produto: ");
            vetorProdutos[i].Nome = Console.ReadLine();

            Console.Write($"Digite o codigo do produto {vetorProdutos[i].Nome}: ");
            vetorProdutos[i].Codigo = int.Parse(Console.ReadLine());

            Console.Write($"Digite o preço do produto {vetorProdutos[i].Nome}: ");
            vetorProdutos[i].Preco = int.Parse(Console.ReadLine());

            Console.Write($"Digite a quantidade do produto {vetorProdutos[i].Nome}:");
            vetorProdutos[i].Quantidade = int.Parse(Console.ReadLine());

            valor[i] = vetorProdutos[i].Preco * vetorProdutos[i].Quantidade;

        }
        foreach (int v in valor)
        {
            Console.Write(v);
        }
        Console.WriteLine($"{vetorProdutos[0].Nome} = {valor[0]}");


    }
}