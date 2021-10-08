using System;
using System.Collections.Generic;
using System.Text;
using teste.RulesWin;

namespace teste.TipoJogada
{
    public class SpockJogada : BaseJogada
    {
        public SpockJogada() : base(new SpockRulesWin()){}
    }
}
