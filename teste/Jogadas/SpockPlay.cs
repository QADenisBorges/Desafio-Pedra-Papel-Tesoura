using System;
using System.Collections.Generic;
using System.Text;
using teste.RulesWin;

namespace teste.TipoJogada
{
    public class SpockPlay : BasePlay
    {
        public SpockPlay() : base(new SpockRulesWin()){}
    }
}
