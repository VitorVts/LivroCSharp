using System;

namespace _59
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Digite a primeira letra do alfabeto: ");
            char primeiroItem = char.Parse(Console.ReadLine().ToUpper());

            Console.WriteLine("Digite a segunda letra do alfabeto: ");
            char segundoItem = char.Parse(Console.ReadLine().ToUpper());

            if (primeiroItem < 'A' || primeiroItem > 'Z' || segundoItem < 'A' || segundoItem > 'Z')
            {
                Console.WriteLine(
                    "Erro: Certifique-se de que ambos os caracteres estejam entre 'A' e 'Z'."
                );
                return;
            }

            if (primeiroItem >= segundoItem)
            {
                Console.WriteLine(
                    "Erro: O primeiro caractere deve ser anterior ao segundo caractere na ordem alfabética."
                );
                return;
            }

            int positionA = primeiroItem - 'A';
            int positionB = segundoItem - 'A';

            int numCaracteresEntre = positionB - positionA - 1;

            Console.WriteLine(
                $"O número de caracteres entre '{primeiroItem}' e '{segundoItem}' é: {numCaracteresEntre}"
            );
        }
    }
}
