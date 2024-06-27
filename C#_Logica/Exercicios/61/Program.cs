using System;

namespace _61
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Digite seu Salário para calcularmos o reajuste:");

            double salario;
            while (!double.TryParse(Console.ReadLine(), out salario) || salario <= 0)
            {
                Console.WriteLine("Digite um valor válido para o salário:");
            }

            Console.WriteLine("Digite o valor em % de reajuste:");
            double reajuste;
            while (!double.TryParse(Console.ReadLine(), out reajuste) || reajuste <= 0)
            {
                Console.WriteLine("Digite um valor válido para o reajuste:");
            }

            REAJUSTE(reajuste, salario);
        }

        public static void REAJUSTE(double reajuste, double salario)
        {
            double salarioReajustado = salario + (salario * (reajuste / 100));

            Console.WriteLine($"O Salário reajustado é: {salarioReajustado:C}");
        }
    }
}
