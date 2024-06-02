using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VelocidadeMedia 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double distancia,tempoViagem,velMedia,litrosUsados;


            Console.WriteLine("-----Velocidade Média-----");
            Console.WriteLine();
            Console.Write("Digite o Tempo Gasto na Viagem: ");
            tempoViagem = double.Parse(Console.ReadLine());
            Console.Write("Digite a Velocidad média durante a viagem : ");
            velMedia = double.Parse(Console.ReadLine());

            distancia = tempoViagem*velMedia;
            litrosUsados = distancia/12;

            Console.Write($"A velocidade média foi de {velMedia}km , o tempo da viagem foi {tempoViagem},a distancia percorrida foi de {distancia},e a quantidade de litros usada foi {litrosUsados:F2}l");


        }
    }
}