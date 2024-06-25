using System;
using System.Runtime.InteropServices;

namespace ContaSálario
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int codigo = 0;
            int numero = 0;
            double horastrab = 10.0;
            double extra = 0.0;
            double horaExtra = 0.0;
            string option = "";
            do
            {
                Console.Clear();
                System.Console.WriteLine("Digite seu código de Funcionário:");
                codigo = int.Parse(Console.ReadLine());
                System.Console.WriteLine("Digite Suas horas trabalhadas:");
                numero = int.Parse(Console.ReadLine());

                double salario = numero * horastrab;

                if (numero > 50)
                {
                    extra = numero - 50;
                    horaExtra = extra * 20.0;
                    salario = (50 * horastrab) + horaExtra;
                    Console.WriteLine($"Olá {codigo}, seu salário total é: R${salario}");
                    Console.WriteLine($"E o total de extras é: R${horaExtra}");
                }
                else
                {
                    extra = 0;
                    horaExtra = 0;
                    Console.WriteLine($"\nOlá {codigo}, seu salário total é: R${salario}");
                    Console.WriteLine("E não há salário extra.");
                }
                Console.WriteLine("\nDigite S para sair ou qualquer tecla para rodar novamente");
                option = Console.ReadLine().ToUpper();
            } while (option != "S");
        }
    }
}
