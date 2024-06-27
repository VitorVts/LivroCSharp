using System;

namespace _62
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Calculadora de Hipotenusa");

            double altura;
            double bases;
            Console.WriteLine("Digite o valor da base: ");
            while (!double.TryParse(Console.ReadLine(), out bases) || bases <= 0)
            {
                Console.WriteLine("Digite um valor válido para a base:");
            }

            Console.WriteLine("Digite o valor da altura: ");
            while (!double.TryParse(Console.ReadLine(), out altura) || altura <= 0)
            {
                Console.WriteLine("Digite um valor válido para a altura:");
            }

            double hipotenusa = Hipotenusa(bases, altura);
            Console.WriteLine($"A hipotenusa é: {hipotenusa}");
        }

        public static double Hipotenusa(double bases, double altura)
        {
            double hipotenusa = Math.Sqrt(Math.Pow(bases, 2) + Math.Pow(altura, 2));
            return hipotenusa;
        }
    }
}
