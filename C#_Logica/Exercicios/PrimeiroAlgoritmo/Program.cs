using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PrimeiroAlgoritimo
{
    public class Program
    {
        public static void Main(string[]args)
        {
            string nomeUsuario, nomeProduto;
            double saldoUsuario, valorProduto;

            
            Console.WriteLine("-----Compra Online-----");

            Console.Write($"Digite Seu Nome:");
            nomeUsuario = Console.ReadLine();

            Console.Write($"Digite Seu Saldo:");
            saldoUsuario = double.Parse(Console.ReadLine());

            Console.WriteLine("-----Produto-----");
            
            Console.Write($"Digite o nome do Produto: ");
            nomeProduto = Console.ReadLine();
            
            Console.Write($"Digite o valor do Produto: ");
            valorProduto = double.Parse(Console.ReadLine());

            System.Console.WriteLine("-----Dados da Compra-----");
            Console.WriteLine($"Certo {nomeUsuario} segue os dados do produto caso deseje realizar compra : ");
            Console.WriteLine($"Seu saldo: {saldoUsuario}");    
            Console.WriteLine($"O Produto a ser adquirido: {nomeProduto}");
            Console.WriteLine($"O valor do produto é : {valorProduto}");
            Console.WriteLine($"Caso efetue a compra seu saldo será de : {saldoUsuario - valorProduto}");
        }
    }
}