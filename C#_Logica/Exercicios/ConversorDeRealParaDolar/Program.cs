using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorDeMoeda
{
    public class ConversorDeMoeda
    {
        public static void Main(string[]args)
        {
            double cotacao,dolar,dolarToReal;


            System.Console.WriteLine("-----Conversor de Dolar Real------");
            Console.Write("Digite a cotação do dolar de Hoje: ");
            cotacao = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor em dolares a ser convertido em Real: ");
            dolar = double.Parse(Console.ReadLine());
            dolarToReal = dolar*cotacao;
            Console.WriteLine($"O valor dos dolares em reais é : {dolarToReal}");

        }
    }
}