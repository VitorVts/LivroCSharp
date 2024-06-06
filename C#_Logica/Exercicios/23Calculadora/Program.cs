int a,b;
string option;




while (true)
{
    Console.WriteLine("-----Calculadora------");
    Console.WriteLine("Digite a operação desejada : \n1-Adição\n2-subtração\n3-Multiplicação\n4-Divisão\n5-Sair");
    option = Console.ReadLine();

    switch (option)
    {
        case "1":
        Console.WriteLine("-----Adição-----");
        Console.WriteLine();
        Console.Write("Digite o primeiro valor: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Digite o segundo valor: ");
        b = int.Parse(Console.ReadLine());
        Console.WriteLine($"Resultado:  {a + b} ");
        Console.WriteLine();
        break;

        case "2":
        Console.WriteLine("-----Subtração-----");
        Console.WriteLine();
        Console.Write("Digite o primeiro valor: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Digite o segundo valor: ");
        b = int.Parse(Console.ReadLine());
        Console.WriteLine($"Resultado:  {a - b} ");
        Console.WriteLine();
        break;
        
        case "3":
        Console.WriteLine("-----Multiplicação-----");
        Console.WriteLine();
        Console.Write("Digite o primeiro valor: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Digite o segundo valor: ");
        b = int.Parse(Console.ReadLine());
        Console.WriteLine($"Resultado:  {a * b} ");
        Console.WriteLine();
        break;

        case "4":
        Console.WriteLine("-----Divisão-----");
        Console.WriteLine();
        Console.Write("Digite o primeiro valor: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Digite o segundo valor: ");
        b = int.Parse(Console.ReadLine());
        Console.WriteLine($"Resultado:  {a / b} ");
        Console.WriteLine();
        break;
        
        
    }
    
    Console.WriteLine("Se deseja sair digite 5 caso não digite a opção de acordo  para realizar outra operação :");
    Console.WriteLine();

    if(option == "5")
    {
        break;
    }
}