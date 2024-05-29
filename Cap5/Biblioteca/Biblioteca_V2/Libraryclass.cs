

//namespace que irá conter a classe de controle de livros e seus metodos 
namespace Libraryclass
{
    public class Revistas : Biblioteca
    {
        //Propriedades da Classe
            private int _MesPublicacao;
            private int _AnoPublicacao;
        //Construtor da classe 
            public Revistas(int MesPublicacao,int AnoPublicacao)
            {
                _MesPublicacao  = MesPublicacao;
                _AnoPublicacao  = AnoPublicacao;
            }
            //Metodo para acesso a propriedade da classe 
            public int MesPublicacao 
            {
                get {return _MesPublicacao;} set{MesPublicacao = value;}  
            }
            public int AnoPublicacao
            {
                get {return _AnoPublicacao;} set{AnoPublicacao = value;}
            }
            public override void Descarte()
            {
                this.Titulo = "A Revista Foi Reciclada";
            }
    }
    //principal classe de controle de livros na Biblioteca
     public class Biblioteca
     {
        private string _Titulo;//receba o titulo do livro
        private string _Autor; //receberá o nome do autordo livro 
        private int _Paginas; //receberá o número de paginas que o Livro Contem
        private bool _Status;//receberá saindo (FALSE) ou entrando (TRUE) na biblioteca
        public Biblioteca()//construtor sem parametros
        {

        }
        //construtor com parametros
        //note que o nome do metodo é o mesmo (sobrecarga)
        public Biblioteca (string Titulo,string Autor,int Paginas, bool Status)
        {
            _Titulo = Titulo;
            _Autor = Autor ;
            _Paginas = Paginas;
            _Status = Status;
        }
        public string Titulo //Metodo para acesso a propriedade da classe "Titulo"
        {
            get {return _Titulo;} set{_Titulo = value;}
        }
        public string Autor 
        {
            get {return _Autor;} set{_Autor = value;}
        }
        public int Paginas
        {
            get {return _Paginas;} set{_Paginas = value;}
        }
        public bool Status
        {
            get {return _Status;} set{_Status = value;}
        }
     }
     public class Fotos : Revistas
     {
        //Propriedades da classe
        private string _Tipo;

        //neste construtor preciso referenciar a classe base 
        //Revistas é uma classe já herdade de Biblioteca 
        public Fotos(string Tipo) : base (0,0)
        {
            _Tipo = Tipo;
        }
        //Metodo para acesso a propriedade da classe
        public string Tipo
        {
            get {return _Tipo;} set{_Tipo = value;}
        }
        public override void Descarte()
        {
            this.Titulo = "A Foto foi Destruída";
        }
     }
}