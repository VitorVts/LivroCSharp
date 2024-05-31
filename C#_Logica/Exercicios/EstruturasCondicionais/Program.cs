using  System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EstruturasCondicionais
{
    public class EstruturasCondicionais
    {
        public static void Main(string[] args)
        {
            string nomeUser, nomeProduto;
            double saldoUser, valorProduto,valorPosCompra;
            
            Console.WriteLine("-----Compra Online----");
            Console.WriteLine();
            Console.WriteLine("-----Dados Usuário----");

            Console.Write("Digite Seu Nome: ");
            nomeUser = Console.ReadLine();

            Console.Write("Digite Seu Saldo: ");
            saldoUser = double.Parse(Console.ReadLine());
            
            Console.WriteLine("-----Dados do Produto-----");

            Console.Write("Digite o Produto que Deseja Comprar: ");
            nomeProduto = Console.ReadLine();

            Console.Write("Digite o valor do Produto: ");
            valorProduto = double.Parse(Console.ReadLine());

            double saldoFinal = saldoUser - valorProduto;

            bool compraRealizada = saldoFinal>=0;
            
            Console.WriteLine("------Log------");

            if(compraRealizada)
            {
                Console.WriteLine($"Compra efetuada com sucesso seu saldo atual é : {saldoFinal}");
            }
            else
            {
                Console.WriteLine($"Não foi possível realizar a comprar faltam{saldoFinal}");
            }


        }
    }
}