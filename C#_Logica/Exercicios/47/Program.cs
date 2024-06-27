using System;

namespace Vetores
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            int[] vetor = new int[10];
            int n;
            int maior = 0;
            int menor = 0;
            int igual = 0;

            for (int i = 0; i < vetor.Length; i++)
            {
                int valueVetor;
                do
                {
                    System.Console.Write(
                        $"Digite o valor {1 + i}° do Vetor (positivo e maior que zero): "
                    );
                    valueVetor = int.Parse(Console.ReadLine());
                } while (valueVetor <= 0);
                vetor[i] = valueVetor;
            }
            System.Console.WriteLine(
                "\nDigite o valor de N a Ser comparado com o numeros dentro do vetor (positivo e maior que zero):"
            );

            do
            {
                n = int.Parse(Console.ReadLine());
            } while (n <= 0);

            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] > n)
                {
                    maior++;
                }
                if (vetor[i] < n)
                {
                    menor++;
                }
                if (vetor[i] == n)
                {
                    igual++;
                }
            }
            System.Console.WriteLine(
                $"{maior} são maiores que N, {menor} são menores que N e {igual} são iguais a N"
            );
        }
    }
}
