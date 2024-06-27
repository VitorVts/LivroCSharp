namespace _57;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Digite um frase: ");
        string frase = Console.ReadLine();
        string fraseSemEspacos = string.Empty;
        // foreach (char i in frase)
        // {
        //     if (i == 'a')
        //     {
        //         fraseSemEspaços += i;
        //     }
        //     if (i == 'e')
        //     {
        //         fraseSemEspaços += i;
        //     }
        //     if (i == 'i')
        //     {
        //         fraseSemEspaços += i;
        //     }
        //     if (i == 'o')
        //     {
        //         fraseSemEspaços += i;
        //     }
        //     if (i == 'u')
        //     {
        //         fraseSemEspaços += i;
        //     }
        // }
        // System.Console.WriteLine(fraseSemEspaços);

        //Correção

        char[] vogais = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

        foreach (char i in frase)
        {
            if (Array.Exists(vogais, element => element == i))
            {
                fraseSemEspacos += i;
            }
        }
        Console.WriteLine(fraseSemEspacos);

        { }
    }
}
