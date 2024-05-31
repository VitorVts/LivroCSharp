using System;
using System.Collections.Generic;   
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ExercicioVariaveis
{
    public class Program
    {
        public static void Main(string[]args)
        {
            char primeiraLetraNome;
            string nome;
            int numero;
            float numeroDecimal;
            double numeroDecimalMaior;
            bool VerdadeiroOuFalso;


            primeiraLetraNome = 'V';
            nome = "Vitor";
            numero = 25;
            numeroDecimal = 0.25f;
            numeroDecimalMaior = 12312313131.213123131321;
            VerdadeiroOuFalso = true;

            Console.WriteLine(primeiraLetraNome);
            Console.WriteLine(nome);
            Console.WriteLine(numeroDecimal);
            Console.WriteLine(numero);
            Console.WriteLine(numeroDecimalMaior);
            Console.WriteLine(VerdadeiroOuFalso);


        }
    }
}