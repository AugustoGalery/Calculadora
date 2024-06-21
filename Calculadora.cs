using System;

namespace CalculadoraCompleta
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Calculadora Completa");
                Console.WriteLine("1. Adição");
                Console.WriteLine("2. Subtração");
                Console.WriteLine("3. Multiplicação");
                Console.WriteLine("4. Divisão");
                Console.WriteLine("5. Potenciação");
                Console.WriteLine("6. Raiz Quadrada");
                Console.WriteLine("7. Sair");
                Console.Write("Escolha uma opção: ");

                int opcao = int.Parse(Console.ReadLine());

                if (opcao == 7)
                {
                    break;
                }

                double num1 = 0, num2 = 0;

                if (opcao >= 1 && opcao <= 5)
                {
                    Console.Write("Digite o primeiro número: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.Write("Digite o segundo número: ");
                    num2 = double.Parse(Console.ReadLine());
                }

                double resultado = 0;

                switch (opcao)
                {
                    case 1:
                        resultado = Adicao(num1, num2);
                        break;
                    case 2:
                        resultado = Subtracao(num1, num2);
                        break;
                    case 3:
                        resultado = Multiplicacao(num1, num2);
                        break;
                    case 4:
                        resultado = Divisao(num1, num2);
                        break;
                    case 5:
                        resultado = Potenciacao(num1, num2);
                        break;
                    case 6:
                        Console.Write("Digite o número: ");
                        num1 = double.Parse(Console.ReadLine());
                        resultado = RaizQuadrada(num1);
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

                Console.WriteLine($"Resultado: {resultado}");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }

        static double Adicao(double a, double b)
        {
            return a + b;
        }

        static double Subtracao(double a, double b)
        {
            return a - b;
        }

        static double Multiplicacao(double a, double b)
        {
            return a * b;
        }

        static double Divisao(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Erro: Divisão por zero!");
                return double.NaN;
            }
            return a / b;
        }

        static double Potenciacao(double a, double b)
        {
            return Math.Pow(a, b);
        }

        static double RaizQuadrada(double a)
        {
            if (a < 0)
            {
                Console.WriteLine("Erro: Número negativo não possui raiz quadrada real!");
                return double.NaN;
            }
            return Math.Sqrt(a);
        }
    }
}
