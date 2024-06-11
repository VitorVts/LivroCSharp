int somaPares = 0;
int somaImpares=0;

while(true)
{
    Console.WriteLine("Digite um número positivo (ou um número negativo para fechar):");

    int n = int.Parse(Console.ReadLine());

    if(n<0)
    {
        break;
    }
    if(n%2==0)
    {
        System.Console.WriteLine("O número " + n + " é par.");
        somaPares += n;
    }
    else
    {
        System.Console.WriteLine("O número " +n + " é ímpar.");
        somaImpares += n;
    }
}

Console.WriteLine("A soma total dos números par é " + somaPares);
System.Console.WriteLine("A soma total dos numeros impar é :" + somaImpares);