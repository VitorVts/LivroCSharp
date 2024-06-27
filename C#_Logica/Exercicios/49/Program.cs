using System;

namespace ComparaVetores
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int N;

            Console.Clear();

            do
            {
                Console.WriteLine("Digite o tamanho dos vetores (máximo 50): ");
                N = int.Parse(Console.ReadLine());
            } while (N < 1 || N > 50);

            int[] V1 = new int[N];
            int[] V2 = new int[N];

            for (int i = 0; i < N; i++)
            {
                System.Console.WriteLine($"Digite o {i + 1}° valor para v1: ");
                V1[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < N; i++)
            {
                System.Console.WriteLine($"Digite o {i + 1}° valor para v2: ");
                V2[i] = int.Parse(Console.ReadLine());
            }

            int contador = 0;

            for (int i = 0; i < N; i++)
            {
                if (V1[i] == V2[i])
                {
                    contador++;
                    System.Console.WriteLine($"V1 e V2 são iguais na posição {i}");
                }
            }
            Console.WriteLine(
                $"Os vetores V1 e V2 possuem valores idênticos nas mesmas posições {contador} vezes."
            );
        }
    }
}
