//namespace que irá conter a classe decontrole de livro e seus metodos 

namespace Libraryclass
{
    //principal classe de controle de livros na Biblioteca
    public class Biblioteca
    {
        private string _Titulo;//receber o titulo do livro 
        private string _Autor;//receber o nome do autor do livro 

        private int _Paginas; //recebe o número de pginas que o Livro contem 
        private bool _Status; // recebe saindo (FALSE) ou entrando (TRUE) na biblioteca

        public Biblioteca() //construtor sem parametros 
        {

        }
        //Construtor com parametros 
        public Biblioteca(string Titulo,string Autor,int Paginas,bool Status )
        {
            _Titulo = Titulo;
            _Autor = Autor;
            _Paginas = Paginas;
            _Status = Status;
        }
        public string Titulo//metodo para acesso a propriedade Titulo da classe
        {
            get{return _Titulo;} set {_Titulo = value;}
        }
        public string Autor
        {
            get{return _Autor;} set {_Autor = value;}
        }
        public int Paginas{
            get {return _Paginas;} set {_Paginas = value;} 
        }
        public bool Status
        {
            get{return _Status;} set{_Status = value;}
        }
    }
}