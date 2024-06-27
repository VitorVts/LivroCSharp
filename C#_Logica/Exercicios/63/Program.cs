namespace _63;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        System.Console.WriteLine("Digite um número para saber se é par ou impar");

        int n;

        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            System.Console.WriteLine("Digite um valor válido acima 0");
        }
        string resultado = Verifica(n);
        Console.WriteLine(resultado);
    }

    public static string Verifica(int n)
    {
        if (n % 2 == 0)
        {
            return "PAR";
        }
        else
        {
            return "PAR";
        }
    }
}
