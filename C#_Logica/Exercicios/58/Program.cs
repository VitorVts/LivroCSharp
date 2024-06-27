namespace _58;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        System.Console.WriteLine("Digite o tamnho do vetor a ser lido");
        int N;
        while (!int.TryParse(Console.ReadLine(), out N) || N <= 0)
        {
            Console.WriteLine("Por favor, insira um número inteiro positivo:");
        }

        int[] vetor = new int[N];
        int maior = int.MinValue;
        int somaValores = 0;
        int media;
        for (int i = 0; i < vetor.Length; i++)
        {
            int numero;
            Console.WriteLine("Digite um número inteiro positivo a ser inserido:");
            while (!int.TryParse(Console.ReadLine(), out numero) || numero <= 0)
            {
                Console.WriteLine("Por favor, insira um número inteiro positivo:");
            }

            vetor[i] = numero;

            if (vetor[i] >= maior)
            {
                maior = vetor[i];
            }
            somaValores += vetor[i];
        }
        media = somaValores / N;

        System.Console.WriteLine($"\nO Maior valor é : {maior}");
        System.Console.WriteLine($"\nA Media dos valores do vetor é  é : {media}\n");
    }
}
