using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdemDescrescente 
{
    public class Program 
    {
        public static void Main(string[] args)
        {
            
            
            Console.WriteLine("-----Definir a ordem crescente de 3 itens: ");
            System.Console.WriteLine();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

        if (a >= b && a >= c)
        {
            if (b >= c)
                Console.WriteLine($"A ordem decrescente é {a}, {b} e {c}");
            else
                Console.WriteLine($"A ordem decrescente é {a}, {c} e {b}");
        }
        else if (b >= a && b >= c)
        {
            if (a >= c)
                Console.WriteLine($"A ordem decrescente é {b}, {a} e {c}");
            else
                Console.WriteLine($"A ordem decrescente é {b}, {c} e {a}");
        }
        else
        {
            if (a >= b)
                Console.WriteLine($"A ordem decrescente é {c}, {a} e {b}");
            else
                Console.WriteLine($"A ordem decrescente é {c}, {b} e {a}");
        }
        }
    }
}