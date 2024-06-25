using System;

namespace utils
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string fim;
            do
            {
                Console.Clear();
                System.Console.WriteLine("Calculos úteis: ");
                System.Console.WriteLine("1 - Conversão de Graus Celsius em Graus Fahrenheit");
                System.Console.WriteLine("2 – Conversão de Graus Fahrenheit em Graus Celsius");
                System.Console.WriteLine("3 – Peso ideal do homem");
                System.Console.WriteLine("4 – Peso ideal da mulher ");
                System.Console.Write("Digite a Opção desejada: ");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Celsius();
                        break;
                    case 2:
                        Fahrenheit();
                        break;
                    case 3:
                        ImcHomem();
                        break;
                    case 4:
                        ImcMulher();
                        break;
                    default:
                        System.Console.WriteLine("Opção inválida!");
                        break;
                }
                System.Console.WriteLine(
                    "Deseja encerrar? Digite S. Para voltar ao menu, aperte Enter."
                );
                fim = Console.ReadLine().ToLower();
            } while (fim != "s");
        }

        public static void Celsius()
        {
            Console.Clear();
            System.Console.WriteLine("Conversor De Celsius para Fahrenheit");
            System.Console.WriteLine("------------------------------------\n");
            System.Console.Write("Digite o Valor em Celsius a Ser Convertido: ");
            int c = int.Parse(Console.ReadLine());

            int fahrenheit = (c * 9 / 5) + 32;
            System.Console.WriteLine($"O Valor em Fahrenheit é: {fahrenheit}°F");
        }

        public static void Fahrenheit()
        {
            Console.Clear();
            System.Console.WriteLine("Conversor De Fahrenheit para Celsius");
            System.Console.WriteLine("------------------------------------\n");
            System.Console.Write("Digite o Valor em Fahrenheit a Ser Convertido: ");
            int f = int.Parse(Console.ReadLine());

            int celsius = (f - 32) * 5 / 9;
            System.Console.WriteLine($"O Valor em Celsius é: {celsius}°C");
        }

        public static void ImcHomem()
        {
            Console.Clear();
            System.Console.WriteLine("Calculadora de Peso Ideal(IMC) Masculino");
            System.Console.WriteLine("------------------------------------\n");
            System.Console.Write("Digite Seu Peso atual em Kg: ");
            double peso = double.Parse(Console.ReadLine());
            System.Console.Write("Digite Sua altura em Cm: ");
            double altura = double.Parse(Console.ReadLine());

            double alturaMetros = altura / 100.0;
            double imc = peso / (alturaMetros * alturaMetros);

            double pesoIdeal = 22 * (alturaMetros * alturaMetros);

            System.Console.WriteLine($"Seu IMC é: {imc:F2} Kg/m²");
            System.Console.WriteLine($"Seu peso ideal é: {pesoIdeal:F2} Kg");

            if (peso < pesoIdeal)
            {
                System.Console.WriteLine("Você está abaixo do peso ideal.");
            }
            else if (peso > pesoIdeal)
            {
                System.Console.WriteLine("Você está acima do peso ideal.");
            }
            else
            {
                System.Console.WriteLine("Você está no peso ideal.");
            }
        }

        public static void ImcMulher()
        {
            Console.Clear();
            System.Console.WriteLine("Calculadora de Peso Ideal(IMC) Feminino");
            System.Console.WriteLine("------------------------------------\n");
            System.Console.Write("Digite Seu Peso atual em Kg: ");
            double peso = double.Parse(Console.ReadLine());
            System.Console.Write("Digite Sua altura em Cm: ");
            double altura = double.Parse(Console.ReadLine());

            double alturaMetros = altura / 100.0;
            double imc = peso / (alturaMetros * alturaMetros);

            double pesoIdeal = 21 * (alturaMetros * alturaMetros);

            System.Console.WriteLine($"\nSeu IMC é: {imc:F2} Kg/m²");
            System.Console.WriteLine($"Seu peso ideal é: {pesoIdeal:F2} Kg\n");

            if (peso < pesoIdeal)
            {
                System.Console.WriteLine("Você está abaixo do peso ideal.");
            }
            else if (peso > pesoIdeal)
            {
                System.Console.WriteLine("Você está acima do peso ideal.");
            }
            else
            {
                System.Console.WriteLine("Você está no peso ideal.");
            }
        }
    }
}
