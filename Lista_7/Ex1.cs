using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o número de linhas da matriz:");
        int linhas = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o número de colunas da matriz:");
        int colunas = int.Parse(Console.ReadLine());

        int[,] matriz = new int[linhas, colunas];
        Random random = new Random();

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                matriz[i, j] = random.Next(1, 101);
            }
        }

        int[] somaLinhas = new int[linhas];
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                somaLinhas[i] += matriz[i, j];
            }
        }

        Console.WriteLine("Somas acumuladas das linhas:");
        for (int i = 0; i < linhas; i++)
        {
            Console.WriteLine($"Linha {i + 1}: {somaLinhas[i]}");
        }
    }
}
