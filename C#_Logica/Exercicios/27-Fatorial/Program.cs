using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número para efetuar o fatorial: ");
        int n = int.Parse(Console.ReadLine());

        long fatorial = Fatorial(n);

        Console.WriteLine($"O fatorial de {n} é {fatorial}");
    }

    static long Fatorial(int n)
    {
        long resultado = 1;
        for (int i = 1; i <= n; i++)
        {
            resultado *= i;
        }
        return resultado;
    }
}
