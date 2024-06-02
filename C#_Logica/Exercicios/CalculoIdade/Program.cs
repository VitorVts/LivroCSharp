using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CalculoIdade
{
    public class CalculoIdade
    {
        public static void Main(string[] args)
        {
            int anos, meses, dias;

            
            System.Console.Write("Digite sua idade em anos: ");
            anos = int.Parse(Console.ReadLine());
            System.Console.Write("Digite quantos meses tem: ");
            meses = int.Parse(Console.ReadLine());
            System.Console.Write("Digite quantos dias tem:");
            dias = int.Parse(Console.ReadLine());

            int calculoDias = anos*365+meses*30+dias;

            System.Console.WriteLine($"Sua idade em dias é : {calculoDias}"); 


        }
    }
}