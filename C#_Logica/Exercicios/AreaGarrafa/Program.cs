using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AreaGarrafa
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double volume, raio, altura;
            double pi = 3.14159;

            Console.WriteLine("-----Calculao o volume de um produto");
            System.Console.WriteLine();
            System.Console.WriteLine("Digite o Raio do Produto: ");
            raio = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite a Altura do Produto:");
            altura = double.Parse(Console.ReadLine());

            volume = pi*raio*raio* altura;

            System.Console.WriteLine($"O volume do Produto é : {volume}");
        }
    }
}