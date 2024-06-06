int A, B,valor;




    Console.WriteLine("Digite um valor inteiro , caso seja positivo será armazenado em A e do contrario em B");
    valor = int.Parse(Console.ReadLine());


    string resultado = valor > 0 ? $"o valor de A = {A = valor} é positivo!"
                    : valor < 0 ? $"o valor de B = {B = valor} é Negativo! "
                    :"Digite um valor valido";    
    
    System.Console.WriteLine(resultado);
    

 