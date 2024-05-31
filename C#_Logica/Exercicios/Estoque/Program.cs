using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Estoque
{
    public class Programa 
    {
        public static void Main(string[]args)
        {
            double qntMin;
            double qntMax;
            double estoqueMedio;

            Console.WriteLine("-------Média estoque------");
            Console.Write("Digite a Quantidade mínima do estoque: ");
            qntMin = double.Parse(Console.ReadLine());

            Console.Write("Digite a Quantidade Máxima do estoque: ");
            qntMax = double.Parse(Console.ReadLine());
            estoqueMedio = (qntMin+qntMax)/2;


            Console.WriteLine($"Estoque Médio é : {estoqueMedio}");



        }
    }
}