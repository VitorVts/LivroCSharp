using System;

namespace ParesMultiplos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int[] vetor = new int[50];
            int pares = 0;
            int multiplosDe5 = 0;

            Console.WriteLine("Digite 50 números inteiros positivos:");

            // Populando o vetor com números positivos fornecidos pelo usuário
            for (int i = 0; i < vetor.Length; i++)
            {
                int numero;
                while (!int.TryParse(Console.ReadLine(), out numero) || numero <= 0)
                {
                    Console.WriteLine("Por favor, insira um número inteiro positivo:");
                }
                vetor[i] = numero;
            }

            // Lendo os valores do vetor e fazendo as validações
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] % 5 == 0)
                {
                    multiplosDe5++;
                }
                if (vetor[i] % 2 == 0)
                {
                    pares++;
                }
            }

            Console.WriteLine($"Quantidade de números pares: {pares}");
            Console.WriteLine($"Quantidade de múltiplos de 5: {multiplosDe5}");
        }
    }
}
