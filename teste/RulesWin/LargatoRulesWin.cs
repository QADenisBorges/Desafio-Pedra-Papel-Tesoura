using System;
using System.Collections.Generic;
using System.Text;

namespace teste.RulesWin
{
    public class LargatoRulesWin : BaseRulesWin
    {
        public LargatoRulesWin()
        {
            Casa = JogadaEnum.Largato;
            RulesWin.Add(JogadaEnum.Papel);
            RulesWin.Add(JogadaEnum.Spock);
        }
    }
}
