using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace inverteVariavel
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("-----InverterValorVariavéis-----");
            System.Console.WriteLine("Digite o valor de a : ");
            int a = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o valor de b : ");
            int b = int.Parse(Console.ReadLine());
            
               int troca = a;
                a=b;
                b=troca;
                System.Console.WriteLine($"Valorde a:{a} b:{b}");
            
        
        
            
             
        }
    }
}