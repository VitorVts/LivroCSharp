using System;

namespace _60
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Selecione o quadrante de acordo com as coordenadas de x e y \n");

            int x,
                y;
            Console.Write("Digite o valor de 1 a 4 para X: ");
            while (!int.TryParse(Console.ReadLine(), out x) || x < 1 || x > 4)
            {
                Console.WriteLine("Digite um valor válido entre 1 e 4 para X:");
            }

            Console.Write("Digite o valor de 1 a 4 para Y: ");
            while (!int.TryParse(Console.ReadLine(), out y) || y < 1 || y > 4)
            {
                Console.WriteLine("Digite um valor válido entre 1 e 4 para Y:");
            }

            int quadrante = VERIFICA_QUADRANTE(x, y);
            Console.WriteLine($"O ponto ({x}, {y}) está no quadrante {quadrante}");
        }

        public static int VERIFICA_QUADRANTE(int x, int y)
        {
            if (x > 0 && y > 0)
            {
                if (x > 0 && y > 0)
                {
                    return 1;
                }
                else if (x < 0 && y > 0)
                {
                    return 2;
                }
                else if (x < 0 && y < 0)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
            else
            {
                return 0;
            }
        }
    }
}
