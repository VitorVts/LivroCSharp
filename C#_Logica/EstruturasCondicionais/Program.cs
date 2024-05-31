using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturasCondicionais
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n1 = 2 ;
            int n2 = 2 ;

            bool n1MaiorN2 = n1 > n2;
            bool n1MenorN2 = n1 < n2;
            bool n1IgualN2 = n1 == n2;


            if (n1MaiorN2)
            {
                System.Console.WriteLine("N1 é maior que n2.");
            }
            else if(n1IgualN2)
            {
                System.Console.WriteLine("N1 é igual é n2.");
            }

            else
            {
                System.Console.WriteLine("N1 é menor a n2");
            }


            //Console.WriteLine(n1MaiorN2);
            //Console.WriteLine(n1MenorN2);

        }
    }
}