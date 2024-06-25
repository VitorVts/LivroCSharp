using System;

namespace MaiorMenor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int N;
            int Maior = int.MinValue;
            int Menor = int.MaxValue;
            do
            {
                Console.Clear();
                Console.WriteLine("Maior e Menor valor\n");
                System.Console.WriteLine("Digite um valor(0 para sair):");
                N = int.Parse(Console.ReadLine());

                if (N != 0)
                {
                    if (N > Maior)
                    {
                        Maior = N;
                    }
                    if (N < Menor)
                    {
                        Menor = N;
                    }
                }
                if (N != 0)
                {
                    Console.WriteLine($"Maior valor até agora: {Maior}");
                    Console.WriteLine($"Menor valor até agora: {Menor}");
                }
            } while (N != 0);

            Console.WriteLine($"Maior valor final: {Maior}");
            Console.WriteLine($"Menor valor final: {Menor}");
            Thread.Sleep(3000);
            Console.WriteLine("\nPrograma encerrado.");
        }
    }
}
