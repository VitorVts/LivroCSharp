using System;
using System.Threading;

namespace _64
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu()
        {
            int[] vetor = null;

            while (true)
            {
                Console.WriteLine("1 - Carregar Vetor");
                Console.WriteLine("2 - Listar Vetor");
                Console.WriteLine("3 - Exibir apenas os números pares do vetor");
                Console.WriteLine("4 - Exibir apenas os números ímpares do vetor");
                Console.WriteLine(
                    "5 - Exibir a quantidade de números pares que existem nas posições ímpares do vetor"
                );
                Console.WriteLine(
                    "6 - Exibir a quantidade de números ímpares que existem nas posições pares do vetor"
                );
                Console.WriteLine("7 - Sair");

                if (!int.TryParse(Console.ReadLine(), out int option))
                {
                    Console.WriteLine("Por favor, insira uma opção válida.");
                    continue;
                }

                switch (option)
                {
                    case 1:
                        vetor = CarregarVetor();
                        break;
                    case 2:
                        if (vetor != null)
                            ListarVetor(vetor);
                        else
                            Console.WriteLine("Vetor não carregado.");
                        break;
                    case 3:
                        if (vetor != null)
                            ExibirPares(vetor);
                        else
                            Console.WriteLine("Vetor não carregado.");
                        break;
                    case 4:
                        if (vetor != null)
                            ExibirImpares(vetor);
                        else
                            Console.WriteLine("Vetor não carregado.");
                        break;
                    case 5:
                        if (vetor != null)
                            ExibirParesPosicoesImpares(vetor);
                        else
                            Console.WriteLine("Vetor não carregado.");
                        break;
                    case 6:
                        if (vetor != null)
                            ExibirImparesPosicoesPares(vetor);
                        else
                            Console.WriteLine("Vetor não carregado.");
                        break;
                    case 7:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }

        public static int[] CarregarVetor()
        {
            Console.Clear();
            int N;
            Console.WriteLine("Digite o valor para carregar o vetor");
            while (!int.TryParse(Console.ReadLine(), out N) || N <= 0)
            {
                Console.WriteLine("Digite um valor válido para carregar o vetor");
            }

            int[] vetorCarregado = new int[N];
            for (int i = 0; i < N; i++)
            {
                vetorCarregado[i] = i + 1;
            }

            return vetorCarregado;
        }

        public static void ListarVetor(int[] vetor)
        {
            Console.WriteLine("Vetor carregado:");
            foreach (int numero in vetor)
            {
                Console.WriteLine(numero);
            }
        }

        public static void ExibirPares(int[] vetor)
        {
            Console.Clear();
            Console.WriteLine("Números pares no vetor:");
            foreach (int numero in vetor)
            {
                if (numero % 2 == 0)
                {
                    Console.WriteLine(numero);
                }
            }
        }

        public static void ExibirImpares(int[] vetor)
        {
            Console.Clear();
            Console.WriteLine("Números ímpares no vetor:");
            foreach (int numero in vetor)
            {
                if (numero % 2 != 0)
                {
                    Console.WriteLine(numero);
                }
            }
        }

        public static void ExibirParesPosicoesImpares(int[] vetor)
        {
            int contador = 0;
            for (int i = 1; i < vetor.Length; i += 2)
            {
                if (vetor[i] % 2 == 0)
                {
                    contador++;
                }
            }
            Console.WriteLine($"Quantidade de números pares nas posições ímpares: {contador}");
        }

        public static void ExibirImparesPosicoesPares(int[] vetor)
        {
            Console.Clear();
            int contador = 0;
            for (int i = 0; i < vetor.Length; i += 2)
            {
                if (vetor[i] % 2 != 0)
                {
                    contador++;
                }
            }
            Console.WriteLine($"Quantidade de números ímpares nas posições pares: {contador}");
        }
    }
}
