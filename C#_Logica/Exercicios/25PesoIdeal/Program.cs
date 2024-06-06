double h ;
string sexo;
double pesoIdealH,pesoIdealM;




System.Console.WriteLine("Verifique seu pedo ideal:");
System.Console.WriteLine();
System.Console.Write("Para prosseguir informe se você é homem digite h e caso seja mulher M : ");
sexo = Console.ReadLine();
System.Console.Write("Informe Sua altura assim como este exemplo 1.80:");
h = double.Parse(Console.ReadLine());

pesoIdealH = (72.7*h)-58;
pesoIdealM = (62.1*h)-44.7;
switch (sexo)
{
    case "h":
    System.Console.WriteLine($"{pesoIdealH}");
    break;
    case "m":
    System.Console.WriteLine($"{pesoIdealM}");
    break;
}