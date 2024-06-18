int menorValor = int.MaxValue;
int maiorValor = int.MinValue;
int soma = 0;

for(int i = 0; i < 10; i++)
{
    System.Console.Write("Digite um número: ");
    int valorLido = int.Parse(Console.ReadLine()); 

    //if(valorLido > maiorValor)
    //{
     //   maiorValor = valorLido;
    //}
    //if(valorLido < menorValor)
    //{
     //   menorValor = valorLido;
    //}

    maiorValor = (valorLido>maiorValor) ? valorLido : maiorValor;
    menorValor = (valorLido<menorValor) ? valorLido : menorValor;



    soma += valorLido;
}

double media = soma / 10.0;

System.Console.WriteLine($"Maior: {maiorValor}, Menor: {menorValor}, Média: {media}");
