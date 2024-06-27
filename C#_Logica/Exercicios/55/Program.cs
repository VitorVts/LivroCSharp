using System;

namespace RemovEspaços
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            System.Console.WriteLine("Digite uma frase de até 50 caracteres: ");
            string frase = Console.ReadLine();

            if (frase.Length > 50)
            {
                System.Console.WriteLine("A frase execede 50 caracteres");
                return;
            }

            string fraseSemEspacos = string.Empty;
            int contadorEspacos = 0;
            foreach (char i in frase)
            {
                if (i != ' ')
                {
                    fraseSemEspacos += i;
                }
                else
                {
                    contadorEspacos++;
                }
            }
            System.Console.WriteLine($"Frase sem espaços:{fraseSemEspacos}!");
            System.Console.WriteLine($"A Frase tem {contadorEspacos} de espaço em branco!");
        }
    }
}
