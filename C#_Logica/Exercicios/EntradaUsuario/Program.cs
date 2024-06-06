int a;
string continua;

while (true)
{
    Console.WriteLine("Digite um Número para saber se é postivo ou negativo : ");
    a = int.Parse(Console.ReadLine());

    if(a>0)
    {
        System.Console.WriteLine("Esse número é positivo") ;
    } 
    if(a<0)
    {
        System.Console.WriteLine("Esse Número é negativo.");
    }
    else
    {
        System.Console.WriteLine("Número invalido tente novamente!");
    }
     

    System.Console.WriteLine("Quer Continuar ? S/N: ");

    continua = Console.ReadLine();
    if( continua.ToLower() != "s")
    {
        break;
    }
}