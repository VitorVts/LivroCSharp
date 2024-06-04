using System;


int a, b ,Dif;


    System.Console.WriteLine("-----Diferença entre numeros----- ");
    System.Console.Write("Digite o Primeiro valor : ");
    a = int.Parse(Console.ReadLine());
    System.Console.Write("Digite o Segundo valor : ");
    b = int.Parse(Console.ReadLine());
    

    if(a>b)
    {
        Dif = a - b;
        Console.WriteLine($"O número maior é {a} e a direfença entre {b} e {a} é {Dif}");
    }
    else
    {
        Dif = b - a;
        Console.WriteLine($"O número maior é {b} e a direfença entre {a} e {b} é {Dif}");
    }