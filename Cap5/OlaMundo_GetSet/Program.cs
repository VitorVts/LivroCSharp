using System;   

namespace MinhaPrimeiraClasse  
{
    class ProgramaPrincipal
    {
        static void Main(string[]args)
        {
            //Criamos o objetoPedido herdado da classe InteracaoUsuario
                InteracaoUsuario Pedido = new InteracaoUsuario();
            //Invocamos os metodos do objeto Pedido herdado da class ã~e InteracaoUsuario
                Pedido.SolicitarDigitacao();
                Pedido.MostrarDigitacao();
            //Recupero pelo metodo GET o valor da mensagem digitada para futura maniplucação
                var Digitado = Pedido.Mensagem;
            //Escrveo a nova mensagem colocando toda a mensagemem maiuscula
                Console.WriteLine("Nova Digitação sem Espaços -> " + Digitado.ToUpper());

        }
    }
    class InteracaoUsuario
    {
        private string _MensagemDigitada;
        public string Mensagem
        {
            get{return _MensagemDigitada;}
            set{_MensagemDigitada = value;}
        }
        public void SolicitarDigitacao()
        {
            _MensagemDigitada = Console.ReadLine();
        }
        public void MostrarDigitacao()
        {
            Console.WriteLine(_MensagemDigitada);
        }

    }



}