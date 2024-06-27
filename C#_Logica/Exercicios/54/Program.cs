using System;

namespace StatusCorrida
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Digite quantas voltas foram percorridas:");
            int voltas;

            while (!int.TryParse(Console.ReadLine(), out voltas) || voltas <= 0)
            {
                Console.WriteLine("Por favor, insira um número válido de voltas.");
            }

            int[] tempoVoltas = new int[voltas];
            int melhorTempo = int.MaxValue;
            int melhorVolta = 0;
            int somaTempo = 0;

            for (int i = 0; i < voltas; i++)
            {
                Console.WriteLine($"Digite o tempo da {i + 1}ª volta (em segundos):");
                int tempoVolta;

                while (!int.TryParse(Console.ReadLine(), out tempoVolta) || tempoVolta < 0)
                {
                    Console.WriteLine("Por favor, insira um tempo válido para a volta.");
                }

                tempoVoltas[i] = tempoVolta;

                if (tempoVoltas[i] < melhorTempo)
                {
                    melhorTempo = tempoVoltas[i];
                    melhorVolta = i + 1;
                }

                somaTempo += tempoVoltas[i];
            }

            double media = (double)somaTempo / voltas;

            Console.WriteLine(
                $"O melhor tempo foi {melhorTempo} segundos na {melhorVolta}ª volta."
            );
            Console.WriteLine($"O tempo médio das {voltas} voltas foi de {media:F2} segundos.");
        }
    }
}
