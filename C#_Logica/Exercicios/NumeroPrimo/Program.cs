using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NumerosPrimos
{
    public static class NumerosPrimos
    {
        public static void Main(string[]args)
        {
            int numero;
            int divisores = 0;
            Console.WriteLine("----------Verifique se o número é Primo----------");
            Console.Write("Digite o número: ");
            numero = int.Parse(Console.ReadLine());

            for(int i = 1;i<=numero;i++)
            {
                if(numero % i ==0)
                {
                     divisores++;   
                }
                    
                

            }

            if(divisores == 2)
            {
                    Console.WriteLine("é um numero primo");
            }
                
            else
            {
                    Console.WriteLine("não é primo");
            }
                

            
        }
    }
}