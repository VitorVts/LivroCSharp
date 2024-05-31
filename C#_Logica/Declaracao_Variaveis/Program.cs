using System;
using System.Collections.Generic;
using System.Linq;  
using System.Text;
using System.Threading.Tasks;

namespace Logicas_e_Algoritimos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tipo, Identificador.
            
            //Declaração de Variavéis
            char primeiraLetraNome;
            string nome;
            float valor;
            double valorAlto;
            bool primeiraLetraNomeComecaM;


            primeiraLetraNome = 'V';
            nome = "Vitor";
            valor = 0.5f;
            valorAlto = 12345.45;
            primeiraLetraNomeComecaM = false;

            Console.WriteLine(primeiraLetraNome);
            Console.WriteLine(nome);
            Console.WriteLine(valor);
            Console.WriteLine(valorAlto);
            Console.WriteLine(primeiraLetraNomeComecaM);


            int i = default(int);
            Console.WriteLine(i);


        }

    }
}