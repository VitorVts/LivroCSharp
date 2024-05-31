using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TipoDeOperadores
{
    public class TipoDeOperadores
    {
        public static void Main(string[]args)
        {
            int a;
            int b;

            a = 10;
            b = 5;

            Console.WriteLine("-----Operadores aritimeticos-----");
            Console.WriteLine($"Adição: {a+b}");
            Console.WriteLine($"Subtração: {a-b}");
            Console.WriteLine($"Multiplicação: {a*b}");
            Console.WriteLine($"Divisão: {a/b}");
            Console.WriteLine($"Resto: {a%b}");
            Console.WriteLine($"Incremento: {a++}");
            Console.WriteLine($"Decremento: {a--}");

            Console.WriteLine("-----Operadores Relacionais-----");
            Console.WriteLine($"Igual:{a==b} ");
            Console.WriteLine($"Diferente: {a!=b}");
            Console.WriteLine($"Maior: {a>b}");
            Console.WriteLine($"Menor: {a<b}");
            Console.WriteLine($"Maior ou Igual: {b>=a}");
            Console.WriteLine($"Menor ou Igual: {b<=a}");
        }
    }
}