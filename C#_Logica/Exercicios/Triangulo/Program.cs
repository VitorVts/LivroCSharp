int A, B, C;

System.Console.WriteLine("Descubra qual o triangulo é  : ");
System.Console.WriteLine();
System.Console.Write("Digite o valor do lado 1 do triangulo : ");
A = int.Parse(Console.ReadLine());
System.Console.Write("Digite o valor do lado 2 do triangulo : ");
B = int.Parse(Console.ReadLine());
System.Console.Write("Digite o valor do lado 3 do triangulo : ");
C = int.Parse(Console.ReadLine());

if (A < B + C && B < A + C && C < A + B)
{
    if (A == B && B == C)
    {
        System.Console.WriteLine("Triangulo equilatero");
    }
    else if (A == B || A == C || B == C)
    {
        System.Console.WriteLine("Triangulo isosceles");
    }
    else
    {
        System.Console.WriteLine("Triangulo escaleno");
    }
}
else
{
    System.Console.WriteLine("Os valores fornecidos não formam um triangulo");
}
