int CODIGO;


System.Console.WriteLine("Verificar o Codigo(SwitchCase)");
System.Console.WriteLine();
CODIGO = int.Parse(System.Console.ReadLine());

switch (CODIGO)
{
    case 1:
    Console.WriteLine("UM");
    break;
    
    case 2:
    Console.WriteLine("DOIS");
    break;

    case 3:
    Console.WriteLine("Três");
    break;

    default:
    Console.WriteLine("Código invalido");
    break;
}
