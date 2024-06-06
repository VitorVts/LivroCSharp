int a;


System.Console.Write("Escreva um número entre 1 e 9 ");
a = int.Parse(Console.ReadLine());


if(a>=0 && a<=9)
    System.Console.WriteLine("Valor Válido");
else
    System.Console.WriteLine("Valor Invalido");
