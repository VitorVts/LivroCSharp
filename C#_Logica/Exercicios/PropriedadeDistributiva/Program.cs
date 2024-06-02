using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PropriedadeDistributiva
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int a, b, c, d;
            
            

            Console.WriteLine("-----Propriedade Distributiva-----");
            Console.WriteLine();
            
            Console.Write("Digite o valor de A:  ");
                a = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B:  ");
                b = int.Parse(Console.ReadLine());
                
            Console.Write("Digite o valor de C:  ");
                c = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de D:  ");
                d = int.Parse(Console.ReadLine());

                int[] array = {a, b, c, d};

                Console.WriteLine("-----Adição-----  ");
                for(int i = 1; i < array.Length; i++)
                {
                    Console.WriteLine($"{array[0]} + {array[i]} = {array[0] + array[i]}");
                    
                }
                for(int j = 2;j < array.Length; j++)
                {
                    Console.WriteLine($"{array[1]} + {array[j]} = {array[1] + array[j]}");
                }
                for(int k = 3;k < array.Length; k++){
                    Console.WriteLine($"{array[2]} + {array[k]} = {array[2] + array[k]}");
                }
                Console.WriteLine("-----Multiplicação-----");
                for(int i = 1; i < array.Length; i++)
                {
                    Console.WriteLine($"{array[0]} X {array[i]} = {array[0] * array[i]}");
                    
                }
                for(int j = 2;j < array.Length; j++)
                {
                    Console.WriteLine($"{array[1]} X {array[j]} = {array[1] * array[j]}");
                }
                for(int k = 3;k < array.Length; k++){
                    Console.WriteLine($"{array[2]} X {array[k]} = {array[2] * array[k]}");
                }
                
                

        }
    }
}