int tabuada;

System.Console.WriteLine("----Gerador de Tabuada-----");
System.Console.WriteLine();
System.Console.Write("Digte o numero que deseja criar a tabuada: ");
tabuada = int.Parse(Console.ReadLine());

System.Console.WriteLine($"Aqui está a sua tabuada de {tabuada}");

for(int i = 0;i<=10;i++)
{
    System.Console.WriteLine($"{tabuada}x{i}={tabuada*i}");
}