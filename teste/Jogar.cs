using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using teste.TipoJogada;

namespace teste
{
    public class Jogar
    {
        private JogadaEnum jogada1;
        private JogadaEnum jogada2;
        public Jogar(JogadaEnum jogada1, JogadaEnum jogada2)
        {
            this.jogada1 = jogada1;
            this.jogada2 = jogada2;
        }

        public string ValidarJogada()
            => InjectJogada.InjectConfiguration().Where(x => x.BaseRulesWin.Casa == jogada1).FirstOrDefault().ValidarJogada(jogada2);
    }
}
