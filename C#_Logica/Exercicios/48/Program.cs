using System;

namespace ModeloApta
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            int candidaturas = 20;

            int[] idadeModelo = new int[candidaturas];
            string[] nomeModelo = new string[candidaturas];
            string[] aprovadas = new string[candidaturas];

            System.Console.WriteLine(
                "Bem vindo a Campanha da Luz & Beleza Preencha os dados para prosseguir\n"
            );

            for (int i = 0; i < candidaturas; i++)
            {
                System.Console.Write("Seu Nome:");
                nomeModelo[i] = Console.ReadLine();
                System.Console.Write("Sua Idade:");
                idadeModelo[i] = int.Parse(Console.ReadLine());

                if (idadeModelo[i] >= 18 && idadeModelo[i] <= 20)
                {
                    aprovadas[i] = nomeModelo[i];
                }
            }
            CandidatasAptas(aprovadas, candidaturas);
        }

        public static bool ValidateModels(string aprovada)
        {
            if (aprovada == null)
            {
                return false;
            }
            return true;
        }

        public static void CandidatasAptas(string[] aprovadas, int candidaturas)
        {
            for (int i = 0; i < candidaturas; i++)
            {
                if (ValidateModels(aprovadas[i]))
                {
                    System.Console.WriteLine($"{aprovadas[i].ToUpper()} Reprovada");
                    continue;
                }
                System.Console.WriteLine($"{aprovadas[i].ToUpper()} Apta");
            }
        }
    }
}
