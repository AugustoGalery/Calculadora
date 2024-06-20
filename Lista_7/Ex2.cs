using System;

class Program
{
    static void Main()
    {
        double[] vetor1 = new double[10];
        double[] vetor2 = new double[10];
        double[,] matriz = new double[10, 10];

        Console.WriteLine("Digite os elementos do primeiro vetor:");
        for (int i = 0; i < 10; i++)
        {
            vetor1[i] = double.Parse(Console.ReadLine());
        }

        Console.WriteLine("Digite os elementos do segundo vetor:");
        for (int i = 0; i < 10; i++)
        {
            vetor2[i] = double.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                matriz[i, j] = vetor1[i] * vetor2[j];
            }
        }

        Console.WriteLine("Matriz resultante:");
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
