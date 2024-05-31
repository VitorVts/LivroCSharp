using System;
using System.Collections.Generic;
using System.Linq;  
using System.Text;
using System.Threading.Tasks;


namespace ParouImpar
{
    public class ParouImpar
    {
        public static void Main(string[]args)
        {
            int num ;
            
            Console.Write("Verifique se é par ou é impar: ");
            num = int.Parse(Console.ReadLine());

            if (num % 2 ==0)
            {
                System.Console.WriteLine($"{num} é par! ");
            }
            else
            {
                System.Console.WriteLine($"{num} não é par! ");
            }
        }
    }
}