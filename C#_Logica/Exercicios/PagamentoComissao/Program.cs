using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PagamentoComissao
{
    public class PagamentoComissao
    {
        public static void Main(string[] args)
        {
            int id,codigoPeca,qtnVenda;
            double precoPeca,valorComissao;

            Console.WriteLine("-----Pagamento Comissões-----");
            Console.Write("Digite seu ID de Vendedor: ");
            id = int.Parse(Console.ReadLine());
            Console.Write("Digite o Código da Peça: ");
            codigoPeca = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor unitário da peça: ");
            precoPeca = double.Parse(Console.ReadLine());
            Console.Write("Digite a Quatidade de peças vendidas: ");
            qtnVenda = int.Parse(Console.ReadLine());
            Console.WriteLine();

            double totalVendas = precoPeca * qtnVenda;
            valorComissao = totalVendas * 0.05;

            Console.WriteLine($"O valor comissão para o vendedor de ID: {id} é {valorComissao}");


        }
    }
}