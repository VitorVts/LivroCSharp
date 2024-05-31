using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DividePor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numTotal = 10000;


            Console.WriteLine("Quais os número divisivéis por 9 e 5 ? ");

            for(int i=1;i<=numTotal;i++)
            {
                if(i%5 == 0 && i%9==0)
                {
                    Console.WriteLine($"Estes numeros são divisiveis por 9 e 5 :{i} ");
                }
            }

        }
    }
}