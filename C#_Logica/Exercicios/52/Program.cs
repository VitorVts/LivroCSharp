using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numeros = new List<int>();
        Console.WriteLine(
            "Digite os números inteiros positivos (máximo 100 números). Digite -1 para terminar a entrada."
        );

        while (numeros.Count < 100)
        {
            int numero;
            bool inputValido = int.TryParse(Console.ReadLine(), out numero);

            if (!inputValido)
            {
                Console.WriteLine("Por favor, digite um número inteiro válido.");
                continue;
            }

            if (numero == -1)
            {
                break;
            }
            else if (numero > 0)
            {
                numeros.Add(numero);
            }
            else
            {
                Console.WriteLine(
                    "Por favor, digite apenas números inteiros positivos ou -1 para terminar."
                );
            }
        }

        int contador1 = 0,
            contador3 = 0,
            contador4 = 0;
        foreach (int num in numeros)
        {
            if (num == 1)
                contador1++;
            else if (num == 3)
                contador3++;
            else if (num == 4)
                contador4++;
        }

        Console.WriteLine($"O número 1 aparece {contador1} vezes.");
        Console.WriteLine($"O número 3 aparece {contador3} vezes.");
        Console.WriteLine($"O número 4 aparece {contador4} vezes.");
    }
}
