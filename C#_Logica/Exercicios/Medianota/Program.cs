int nt1, nt2, nt3, nt4, rec, media;


System.Console.WriteLine("-----Média Nota-----\n");

System.Console.Write("Digite a Primeira nota:");
nt1 = int.Parse(System.Console.ReadLine());
System.Console.Write("Digite a Segunda nota:");
nt2 = int.Parse(System.Console.ReadLine());
System.Console.Write("Digite a terceira nota:");
nt3 = int.Parse(System.Console.ReadLine());
System.Console.Write("Digite a Quarta nota:");
nt4 = int.Parse(System.Console.ReadLine());

media = nt1+nt2+nt3+nt4/4;

if(media>=7)
{
    System.Console.Write("Aprovado!!!!!!!");
    
}else if(media<7)
{
    System.Console.WriteLine("Digite a sua nota da Recuperação: ");
    rec = int.Parse(System.Console.ReadLine());

    media = (media+rec)/2;
    if(rec+media>=7)
    {
        System.Console.WriteLine($"Aprovado na recuperação {media}");
    }
    else 
    {
        System.Console.WriteLine($"Tente no outro Ano! {media}");
    }

}