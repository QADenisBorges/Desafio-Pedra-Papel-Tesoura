using System;
using System.Collections.Generic;
using System.Text;

namespace teste.RulesWin
{
    public class PapelRulesWin : BaseRulesWin
    {
        public PapelRulesWin()
        {
            Casa = JogadaEnum.Papel;
            RulesWin.Add(JogadaEnum.Pedra);
            RulesWin.Add(JogadaEnum.Spock);
        }
    }
}
