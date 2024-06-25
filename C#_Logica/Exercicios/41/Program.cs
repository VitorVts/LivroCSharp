using System;

namespace AgeClassifier
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string option;
            int idade;

            do
            {
                Console.Clear();
                Console.WriteLine("Digite sua idade:");

                bool eNumero = !int.TryParse(Console.ReadLine(), out idade);

                if (eNumero || idade < 0)
                {
                    Console.WriteLine("Por favor, digite uma idade válida.");
                }
                else
                {
                    if (idade >= 18)
                    {
                        Console.WriteLine("Categoria: Adulto");
                    }
                    else if (idade >= 14)
                    {
                        Console.WriteLine("Categoria: Juvenil B");
                    }
                    else if (idade >= 12)
                    {
                        Console.WriteLine("Categoria: Juvenil A");
                    }
                    else if (idade >= 8)
                    {
                        Console.WriteLine("Categoria: Infantil B");
                    }
                    else if (idade >= 5)
                    {
                        Console.WriteLine("Categoria: Infantil A");
                    }
                    else
                    {
                        Console.WriteLine("Idade fora das categorias especificadas.");
                    }
                }

                Console.WriteLine(
                    "\nDeseja encerrar o programa? Digite S para sair ou qualquer outra tecla para continuar."
                );
                option = Console.ReadLine().ToUpper();
            } while (option != "S");
        }
    }
}
