using System;

namespace ConversaoBaseNumerica
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            Menu();
        }

        public static void Menu()
        {
            Console.Clear();
            System.Console.WriteLine("Conversão de Base Númerica:\n");
            System.Console.WriteLine("Selecione uma Opção");
            System.Console.WriteLine("___________________");
            System.Console.WriteLine("1 - Adição");
            System.Console.WriteLine("2 - Subtração");
            System.Console.WriteLine("3 - Multiplicação");
            System.Console.WriteLine("4 - Divisão");
            System.Console.WriteLine("0 - Sair");

            var option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 0:
                    Environment.Exit(0);
                    break;
                case 1:
                    Adicao.Show();
                    break;
                case 2:
                    Subtracao.Show();
                    break;
                case 3:
                    Multiplicacao.Show();
                    break;
                case 4:
                    Divisao.Show();
                    break;
                default:
                    System.Console.WriteLine("Opção Inválida.Tente Novamente.");
                    Menu();
                    break;
            }
        }
    }
}
