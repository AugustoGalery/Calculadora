using System;

class Program
{
    static void Main()
    {
        // Gabarito das questões
        int[] gabarito = { 1, 2, 3, 4, 1, 2, 3, 4, 1, 2 };

        // Matriz das provas (5x10)
        int[,] provas = {
            { 1, 2, 3, 4, 1, 2, 3, 4, 1, 2 },
            { 2, 1, 3, 4, 1, 2, 3, 4, 1, 2 },
            { 3, 4, 2, 1, 1, 2, 3, 4, 1, 2 },
            { 1, 2, 3, 4, 4, 3, 2, 1, 1, 2 },
            { 4, 3, 2, 1, 1, 2, 3, 4, 4, 3 }
        };

        // Calcular e imprimir as notas de cada candidato
        Console.WriteLine("Notas dos candidatos:");
        for (int i = 0; i < 5; i++)
        {
            int nota = 0;
            for (int j = 0; j < 10; j++)
            {
                if (provas[i, j] == gabarito[j])
                {
                    nota++;
                }
            }
            Console.WriteLine($"Candidato {i + 1}: {nota}");
        }

        // Calcular a média das notas
        double media = 0;
        for (int i = 0; i < 5; i++)
        {
            int nota = 0;
            for (int j = 0; j < 10; j++)
            {
                if (provas[i, j] == gabarito[j])
                {
                    nota++;
                }
            }
            media += nota;
        }
        media /= 5;

        Console.WriteLine($"Média das notas: {media}");

        // Calcular a maior nota dentre as provas
        int maiorNota = 0;
        for (int i = 0; i < 5; i++)
        {
            int nota = 0;
            for (int j = 0; j < 10; j++)
            {
                if (provas[i, j] == gabarito[j])
                {
                    nota++;
                }
            }
            if (nota > maiorNota)
            {
                maiorNota = nota;
            }
        }

        Console.WriteLine($"Maior nota: {maiorNota}");
    }
}
