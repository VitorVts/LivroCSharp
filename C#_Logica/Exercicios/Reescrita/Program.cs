int a,b,c;

Console.WriteLine("Exiba o menor valor lido multiplicado pelo maior e o maior valor dividido pelo menor ");
System.Console.WriteLine();


do
{
    System.Console.Write("Dgite um valor maior que zero para 'a':");

    a =  int.Parse(Console.ReadLine());
    
    System.Console.Write("Dgite um valor maior que zero para 'b':");

    b =  int.Parse(Console.ReadLine());

    System.Console.Write("Dgite um valor maior que zero para 'c':");

    c =  int.Parse(Console.ReadLine());

    if(a<=0)
    {
        Console.WriteLine("Valor inválido! Por favor,insira a novamente.");
    }
    if(b<=0)
    {
        Console.WriteLine("Valor inválido! Por favor,insira b novamente.");
    }
    if(c<=0)
    {
        Console.WriteLine("Valor inválido! Por favor,insira c novamente.");
    }
} while(a<=0 || b<=0 || c<=0);


   int menor = Math.Min(Math.Min(a, b), c);
   int maior = Math.Max(Math.Max(a, b), c);

Console.Write($"Menor valor é {menor} e maior divido pelo menor é {maior/menor}");

