using static System.Console;
using System;
using System.Linq;

namespace LIVROCSHARP
{
    class funcoesTexto
    {
        static void Main(string[]args)
        {
            WriteLine("-----Funções de Textos-----");
            string  empresa = "  Microsoft Corporation  ";

            WriteLine("TREM - retira os espaços em branco antes e após a exŕessão");
            WriteLine($"Nome sem espaços:{empresa.Trim()}");

            WriteLine("Length- retorna a qtde de caracteres");
            WriteLine($"Tamanho do texto: {empresa.Length}");

            empresa = empresa.Trim();
            WriteLine($"Tamanhp do texto após o TRIM(): {empresa.Length}");

            WriteLine("ToUpper - converte todo os caracteres para maiúsculo");
            WriteLine($"Converte para maiúsculo:{empresa.ToUpper()}");

            WriteLine("ToLower - converte todo os caracteres para minúsculo");
            WriteLine($"Converte para minúsculo:{empresa.ToLower()}");



            var nomeUpper = "AIRTON SENNA";
            var nomeLower = "airton senna";

            //Comparação 1
            if(nomeUpper == nomeLower)
                WriteLine("1- nomes iguais");
            else
                WriteLine("1- nomes diferentes");

            //Comparação 2
            if(nomeUpper.ToLower()== nomeLower)
                WriteLine("2- nomes iguais");
            else
                WriteLine("2- nomes diferentes");
            
            //Comparação 3
            if(nomeUpper.Equals(nomeLower,StringComparison.OrdinalIgnoreCase))
                WriteLine("3- nomes iguais");
            else
                WriteLine("3- nomes diferentes");

            
        }
    }
}