using System;

namespace MediaNota
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            System.Console.WriteLine("Digite a Quantidade de Alunos a terem as notas calculadas");
            int alunos = int.Parse(Console.ReadLine());

            double notaSomadas = 0;
            double[] nota = new double[alunos];
            int aprovado = 0;
            int reprovado = 0;
            for (int i = 0; i < alunos; i++)
            {
                System.Console.WriteLine($"Digite a nota do {i + 1}° Aluno:");
                nota[i] = double.Parse(Console.ReadLine());

                notaSomadas += nota[i];

                if (nota[i] >= 7)
                {
                    aprovado++;
                }
                if (nota[i] < 5)
                {
                    reprovado++;
                }
            }

            if (nota.Length == reprovado)
            {
                Console.WriteLine("Não há nenhum aluno com nota acima de 5.");
            }

            double media = Media(notaSomadas, alunos);
            System.Console.WriteLine(
                $"Média dos alunos foi {media}e a quantidade de alunos com a nota a cima de 7 é {aprovado}"
            );
        }

        public static double Media(double notaSomadas, int alunos)
        {
            return notaSomadas / alunos;
        }
    }
}
