using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;


namespace EntradaSaidaDados
{
    public class Program
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("-------- Programa de Pagamentos-------");
            
            Console.Write("Digite o seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite sua idade:");
            int idade = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Resultados:");
            Console.WriteLine($"Meu nome é : {nome}");
            Console.WriteLine($"Idade : {idade}");


            string primeiroNome, segundoNome;

            primeiroNome = "Vitor";
            segundoNome = "Gomes";

            string nomeCompleto = string.Concat(primeiroNome," ",segundoNome," Guimarães ");


            System.Console.WriteLine(nomeCompleto);


        }
    }
}