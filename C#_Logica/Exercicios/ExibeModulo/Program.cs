using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExibeModulo
{
    public class Program
    {
        public  static void Main(string[]args)
        {
            System.Console.WriteLine("-----Descubra o Modulo do número----- ");
            System.Console.WriteLine();
            System.Console.Write("Digite seu número: ");
            int a = int.Parse( Console.ReadLine());

            if(a>=1)
            {
                System.Console.WriteLine($"O modulo de {a} é {a} ");
            }
            else if(a==0){
                System.Console.WriteLine($"Zero 0 não possui modulo ! ");
            }
             else if(a<0)
            {
                
                System.Console.WriteLine($"O modulo de {a} é {a*(-1)}");
            }

        }
    }
}