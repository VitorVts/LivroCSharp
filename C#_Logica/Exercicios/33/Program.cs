Console.WriteLine("Insira um número intero positivo menor que 10 e maior que zero:");

int num = int.Parse(Console.ReadLine());

while (num <= 0 || num>=10)
{
    System.Console.WriteLine("Número inválido. Tente novamente.");
    System.Console.WriteLine("Insira um número inteiro postivo menor que 10 e maior que zero:");

    num = int.Parse(Console.ReadLine());
}

int contador = 0;
int soma = 0; 

while(contador < 20)
{
    if(num % 2 !=0)
    {
        soma += num*num;
        contador++;
    }
    num++;
}
System.Console.WriteLine("A soma dos quadrados dos 20 primeiros números ímpares a partir do número informado é" + soma);