using System;
using System.Collections.Generic;
using System.Text;
using teste.RulesWin;

namespace teste.TipoJogada
{
    public abstract class BaseJogada
    {
        public BaseRulesWin BaseRulesWin;

        protected BaseJogada(BaseRulesWin baseRulesWin)
        {
            BaseRulesWin = baseRulesWin;
        }

        public string ValidarJogada(JogadaEnum Adversario)
        {
            if (BaseRulesWin.Casa == Adversario)
                return Mensagem.Empate();

            foreach (var jogada in BaseRulesWin.RulesWin)
                if (jogada == Adversario)
                    return Mensagem.CasaGanha();
            
            return Mensagem.CasaPerde();
        }
    }
}
