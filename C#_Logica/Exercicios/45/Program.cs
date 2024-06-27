using System;

class Program
{
    static void Main()
    {
        int tamanho;
        Console.Clear();
        System.Console.WriteLine("Digite o tamanho da sequencia: ");
        tamanho = int.Parse(Console.ReadLine());

        int[] sequencia = new int[50];

        for (int i = 0; i < tamanho; i++)
        {
            System.Console.Write($"Digite o {i + 1}° número: ");
            sequencia[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Sequência na ordem inversa: ");
        for (int i = tamanho - 1; i >= 0; i--)
        {
            System.Console.Write(sequencia[i] + " ");
        }
    }
}
