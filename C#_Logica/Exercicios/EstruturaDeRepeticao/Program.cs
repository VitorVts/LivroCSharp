using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EstruturasDeRepeticao
{
    public class Programa
    {
        public static void Main(string[] args)
        {
            string[] nomes = new string[6] {"Vitor","Gabriela","Mariana","Acer","Artorias","Xampson"};

            for(int i=0; i<=nomes.Length; i++)
            {
                Console.WriteLine($"{i}-{nomes[i]}");
                System.Console.WriteLine();
            }
        }
    }
}