using System.Drawing;

namespace ConversaoBaseNumerica
{
    public class Divisao
    {
        public static void Show()
        {
            int a;
            int b;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            System.Console.WriteLine("Divisão:\n");

            System.Console.Write("Digite o Primeiro Número:");
            a = int.Parse(Console.ReadLine());

            System.Console.Write("Digite o Segundo Número:");
            b = int.Parse(Console.ReadLine());

            int result = a / b;

            Console.WriteLine($"\nA Soma Dos Valores é {result}\n");

            Console.WriteLine(
                "Se deseja voltar ao menu Digite S ou s se deseja encerrar aperte enter:"
            );

            string option = Console.ReadLine();

            if (option.ToUpper() == "S")
            {
                Program.Menu();
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
