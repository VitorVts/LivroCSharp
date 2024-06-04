int a, b;

    Console.WriteLine("Compare os números");

    Console.WriteLine("Informe o primeiro número: ");
    a = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe o primeiro número: ");
    b = int.Parse(Console.ReadLine());

    if(a>b)
    {
        Console.WriteLine($"{a} é o Maior Valor e {b} o menor!");
    }
    else if(b>a)
    {
        Console.WriteLine($"{b} é o Maior Valor e {a} o menor!");
    }else
    {
        Console.WriteLine($"Os Números são iguais ! ");
    }