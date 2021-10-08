using System;
using teste.TipoJogada;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogada1 = JogadaEnum.Largato;
            var jogada2 = JogadaEnum.Largato;
            var x = new Jogar(jogada1, jogada2).ValidarJogada();
        }
    }
}
