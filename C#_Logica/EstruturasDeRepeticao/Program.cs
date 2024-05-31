using System;  
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EstruturasDeRepeticao
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] nomes = new string[3] {"maria","joao","jose"};


            for(int cont = 0; cont < 3; cont++)
            {
                Console.WriteLine(nomes[cont]);
            }
        }
    }
}