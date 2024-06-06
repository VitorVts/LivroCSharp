int a, b;
string option;


while (true)
{
    System.Console.WriteLine("Digite O Primeiro número:");
    a = int.Parse(Console.ReadLine());
    System.Console.WriteLine("Digite O Primeiro número:");
    b = int.Parse(Console.ReadLine());
    System.Console.WriteLine();
    System.Console.WriteLine("Digite a opção desejada para fazer a verificação entre os dois números :\n1 – Verificar se um dos números lidos é ou não múltiplo do outro\n2 – Verificar se os dois números lidos são pares\n3 – Verificar se a média dos dois números é maior ou igual a 7.\n4-Sair");
    option = Console.ReadLine();
    switch(option)
    {
        case "1" :
        if (a % b == 0)
        {
            Console.WriteLine($"O Número {a} é múltiplo de {b}");
        }
        else
        {
            Console.WriteLine($"O Número {a} não é múltiplo de {b}");
        }
        break;

        case "2" :
        if (a%2==0 && b%2==0)
        {
            Console.WriteLine($"{a} e {b} são pares");
        }
        else
        {
            Console.WriteLine("\nNão são pares\n");
        }
        break;

        case "3" :
        
        if(((a+b)/2==7))
        {
            Console.WriteLine($"A Média é igual a 7");
        }
        else if((a+b)/2>7)
        {
            Console.WriteLine($"A Média é maior que 7");
        }
        break;
    }

    if(option == "4")
    {
        break;
    }
}