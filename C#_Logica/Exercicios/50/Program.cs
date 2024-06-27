using System;

namespace Sorteio
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            int N;
            int tentativas = 0;
            Random random = new Random();
            int randomNumber = random.Next(0, 101);
            System.Console.WriteLine(
                "Um Número foi sorteado , Descubra qual o número foi sorteado\n"
            );
            do
            {
                System.Console.WriteLine("Digite UM NÚMERO:");
                N = int.Parse(Console.ReadLine());

                tentativas++;

                if (N > randomNumber)
                {
                    System.Console.WriteLine("Seu número é maior que o sorteado");
                }
                if (N < randomNumber)
                {
                    System.Console.WriteLine("Seu número é menor que  o sorteado");
                }
            } while (N != randomNumber);
            System.Console.WriteLine(
                $"Parabéns acho o númerp {randomNumber} e voce tentou {tentativas} vezes"
            );
        }
    }
}
