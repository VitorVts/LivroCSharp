using System;

namespace ParOuImpar
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numero;
            string option;

            do
            {
                Console.Clear();
                System.Console.Write("Digite Um Número para verificar se é Par ou Impar: ");
                bool eNumero = int.TryParse(Console.ReadLine(), out numero);

                if (eNumero)
                {
                    if (numero % 2 == 0)
                        System.Console.WriteLine($"O valor de {numero} é par");
                    else
                        System.Console.WriteLine($"O valor de {numero} é impar");

                    if (numero >= 0)
                        Console.WriteLine($"O valor de {numero} é positivo");
                    else
                        Console.WriteLine($"O valor de {numero} é negativo");
                }
                else
                {
                    Console.WriteLine("\nEntrada inválida. Por favor, digite um número inteiro.\n");
                }
                System.Console.WriteLine("Deseja Sair do Programa? Digite S");
                option = Console.ReadLine().ToUpper();
            } while (option != "S");
        }
    }
}
