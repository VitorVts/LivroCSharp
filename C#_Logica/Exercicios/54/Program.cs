using System;

namespace ComparaVetores
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            int[] A = new int[5] { 1, 2, 3, 4, 5 };
            int[] B = new int[8] { 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < B.Length; j++)
                {
                    if (A[i] == B[j])
                    {
                        System.Console.WriteLine(
                            $"Os Valores Comuns entre os vetores A e B são : {A[i]}"
                        );
                        break;
                    }
                }
            }
        }
    }
}
