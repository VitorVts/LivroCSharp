using   System;

namespace MinhaPrimeiraClasse
{
    class ProgramaPrincipal
    {
        static void Main(string[]args)
        {
            //Declaramos uma variavel do tipo string(texto)
              //  String Digitado = new String("");
            //Solicitamos que o usuario digite alguma coisa earmazene na variavel criada 
               // Digitado = Console.ReadLine();
            //Mostramos o que foi digitado 
               // Console.WriteLine(Digitado);

               //Criamos o objeto Pedido herdado da classe InteracaoUsuario
                 InteracaoUsuario Pedido = new InteracaoUsuario();

                //Invocamos os metodos do objeto Pedido herdado da classe mãe InteracaoUsuario
                    var Digitado = Pedido.SolicitarDigitacao();
                    Pedido.MostrarDigitacao(Digitado);
        }
    }
    //Criamos a CLasse InteracaoUsuario com dos metodos principais
    //Metodo que solicita a digitação de algo no terminal 
    //Método ue mostra o que foi digitado 
    
    class InteracaoUsuario
    {
        public string SolicitarDigitacao()
        {
            return Console.ReadLine();
        }
        public void MostrarDigitacao(string Digitado)
        {
            Console.WriteLine(Digitado);
        }
    } 


}