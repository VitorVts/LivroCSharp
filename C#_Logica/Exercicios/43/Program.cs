using System;

namespace ContagemGraos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int totalCasas = 64;
            ulong totalGraos = 0;

            for (int casa = 0; casa < totalCasas; casa++)
            {
                totalGraos += (ulong)Math.Pow(2, casa);
            }

            Console.WriteLine(
                $"O número total de grãos de trigo que o monge esperava receber é: {totalGraos}"
            );
        }
    }
}
