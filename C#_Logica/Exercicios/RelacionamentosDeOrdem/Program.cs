using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace RelacionamentoDeOrdem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n1, n2;

            Console.WriteLine("-----Relacionametos De Ordem------");
            Console.Write("Digite um número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite Outro Número:");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"São Iguais? {n1==n2}\n São Diferentes? {n1!=n2}\n N1 é Maior que n2 ?{n1>n2}\n N1 é menor que n2 ? {n1<n2}\n N1é maior ou igual a n2 ?{n1>=n2}\n N1 é menor ou igual n2?\n{n1<=n2} ");
        }
    }
}