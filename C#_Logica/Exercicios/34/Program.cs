int maior = int.MinValue;
int menor = int.MaxValue;

while(true)
{
    System.Console.WriteLine("Digite um número (digite negativo para fechar):");
    int num = int.Parse(Console.ReadLine());

    if(num<0)
    {
        break;
    }

    maior = Math.Max(maior,num);
    menor = Math.Min(menor,num);
}
System.Console.WriteLine("O maior número é : " + maior);
System.Console.WriteLine("O menor número é : " + menor);