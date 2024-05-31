using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VerificarIdade 
{
    public class VerificarIdade 
    {
        public static void Main(string[]args)
        {
            int idadeAdulto;

            Console.WriteLine("------Verificador de Idade------");
            Console.Write("Digite sua idade: ");
            idadeAdulto = int.Parse(Console.ReadLine());

            if(idadeAdulto < 18)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sem Permissão !");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Permissão Concedida!");
                Console.ResetColor();
            }

        }
    }
}