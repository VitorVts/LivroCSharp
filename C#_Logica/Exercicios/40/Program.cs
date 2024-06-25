using System;

namespace IndicePoluicao
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double ind1,
                ind2,
                ind3;
            string option;

            do
            {
                Console.Clear();
                Console.WriteLine("Medidor de Índice de Poluição\n");

                Console.Write("Digite o índice do grupo de indústrias número 1: ");
                ind1 = double.Parse(Console.ReadLine());
                Console.Write("Digite o índice do grupo de indústrias número 2: ");
                ind2 = double.Parse(Console.ReadLine());
                Console.Write("Digite o índice do grupo de indústrias número 3: ");
                ind3 = double.Parse(Console.ReadLine());

                double media = Media(ind1, ind2, ind3);

                if (media >= 0.5)
                {
                    Console.WriteLine("Todos os grupos são intimados a suspender suas atividades");
                }
                else if (media >= 0.4)
                {
                    Console.WriteLine(
                        "Empresas do Grupo 1 e 2 são intimadas a suspender suas atividades"
                    );
                }
                else if (media >= 0.3)
                {
                    Console.WriteLine(
                        "Empresas do Grupo 1 são intimadas a suspender suas atividades"
                    );
                }
                else
                {
                    Console.WriteLine(
                        "Índice de poluição dentro do aceitável. Nenhum grupo precisa suspender atividades."
                    );
                }

                Console.WriteLine(
                    "\nDeseja encerrar o programa? Digite S para sair ou qualquer outra tecla para continuar."
                );
                option = Console.ReadLine().ToUpper();
            } while (option != "S");
        }

        public static double Media(double a, double b, double c)
        {
            return (a + b + c) / 3;
        }
    }
}
