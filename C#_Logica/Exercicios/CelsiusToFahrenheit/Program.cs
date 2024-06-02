using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CelsiusToFahrenheit
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double celsius, convert;
            
            Console.WriteLine("-----Conversor de Celsius para Farenheit-----");
            Console.WriteLine();
            Console.Write("Digite o Valor em Celsius a ser convertido: ");
            celsius = double.Parse(Console.ReadLine());

            convert = (9*celsius+160)/5;

            Console.WriteLine($"O Valor da temperatura em Fahrenheit é:{convert}F ");
            
            double fahren,convertToCelsius;
            Console.WriteLine("-----Conversos de Fahrenheite para Celsius-----");
            Console.WriteLine();
            Console.WriteLine("Digite o Valor em Fahrenheit a ser convertido:");
            fahren = double.Parse(Console.ReadLine());
            
            convertToCelsius =(fahren-32)*5/9;

            Console.WriteLine($"O Valor da Temperatura  em celsius é : {convertToCelsius}");

        }
    }
}