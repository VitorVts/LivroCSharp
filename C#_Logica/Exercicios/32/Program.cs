Console.Write("Digite um número inteiro positivo menor que 10 e maior que zero: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero <= 0 || numero >= 10)
        {
            Console.WriteLine("Número inválido. Por favor, insira um número menor que 10 e maior que zero.");
            return;
        }

        int contador = 0;
        int somaQuadrados = 0;

        for (int i = numero; contador < 20; i++)
        {
            if (i % 2 != 0)
            {
                somaQuadrados += i * i;
                contador++;
            }
        }

        Console.WriteLine("A soma dos quadrados dos 20 primeiros números ímpares a partir de " + numero + " é: " + somaQuadrados);