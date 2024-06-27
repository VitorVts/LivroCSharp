using System;

namespace MultiplicaVetores
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            System.Console.WriteLine("Digite tamnho dos  vetore x e y : ");
            int tamanho = int.Parse(Console.ReadLine());

            int[] x = new int[tamanho];
            int[] y = new int[tamanho];

            for (int i = 0; i < x.Length; i++)
            {
                x[i] = i;
                y[i] = i;
            }

            int produtoEscalar = 0;

            for (int i = 0; i < tamanho; i++)
            {
                produtoEscalar += x[i] * y[i];
            }
            Console.WriteLine($"Produto escalar: {produtoEscalar}");
        }
    }
}
