using System;
using static System.Console;
using Libraryclass;

namespace Biblioteca_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            //inicializando nossa nova classe com herança
                Revistas MinhasRevistas = new Revistas(3,2021);
            
            //Inicializano as outras propriedades classe que oram herdadas
                MinhasRevistas.Autor = "Microsoft";
                MinhasRevistas.Titulo = "MSDN MAGAZINE";
                MinhasRevistas.Paginas = 20;
                MinhasRevistas.Status = true;
            
            //imprimindo os valores de minha classe 
                WriteLine("Revista Mes:" + MinhasRevistas.MesPublicacao);
                WriteLine("Revista Ano:" + MinhasRevistas.AnoPublicacao);
                WriteLine("Revista Autors:" + MinhasRevistas.Autor);
                WriteLine("Revista Titulo:" + MinhasRevistas.Titulo);
                WriteLine("Revista Paginas:" + MinhasRevistas.Paginas);
                WriteLine("Revista Status:" + MinhasRevistas.Status);
                
                WriteLine();
            
            //inicializando nossa classe com o construtor nulo 
            Biblioteca MinhaBiblioteca = new Biblioteca();

            //Por isso a necessidade "setar" o valor e cada propriedade 
            MinhaBiblioteca.Autor = "Des Dearlove";
            MinhaBiblioteca.Titulo = "O Estilo Bill Gates de Gerir ";
            MinhaBiblioteca.Paginas = 203;
            MinhaBiblioteca.Status = true;
            //imprimindo os valores de minha classe 
            WriteLine("Autor:"+ MinhaBiblioteca.Autor);
            WriteLine("Titulo:"+ MinhaBiblioteca.Titulo);
            WriteLine("Paginas:"+ MinhaBiblioteca.Paginas);
            WriteLine("Status:"+ MinhaBiblioteca.Status);
            WriteLine();

            //Inicializando nossa classe com o novo construtor 
                Biblioteca MeusLivros = new Biblioteca("Juan Garcia Sola","Linguage C ",296,true);
            //imprimindo os valores de minha classe
                WriteLine("Autor:" + MeusLivros.Autor);
                WriteLine("Titulo:" + MeusLivros.Titulo);
                WriteLine("Pagina:" + MeusLivros.Paginas);
                WriteLine("Status" + MeusLivros.Status);
                WriteLine();

            //inicializando nossa nova classe Fotos
                Fotos MinhasFotos = new Fotos("Colorida");
                MinhasFotos.AnoPublicacao = 2021;
                MinhasFotos.MesPublicacao = 3;
                MinhasFotos.Autor = "Desconhecido";
                MinhasFotos.Titulo = "Vida Eterna";
                MinhasFotos.Paginas = 1;
                MinhasFotos.Status = true;
            //imprimindo os valores de minha classe
                WriteLine("Foto Tipo:" + MinhasFotos.Tipo);
                WriteLine("Foto Mes:" + MinhasFotos.MesPublicacao);
                WriteLine("Foto Ano:" + MinhasFotos.AnoPublicacao);
                WriteLine("Foto Autor:" + MinhasFotos.Autor);
                WriteLine("Foto Titulo:" + MinhasFotos.Titulo);
                WriteLine("Foto Paginas:" + MinhasFotos.Paginas);
                WriteLine("Foto Status:" + MinhasFotos.Status);
                WriteLine();
        }
    }
}