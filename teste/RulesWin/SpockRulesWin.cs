using System;
using System.Collections.Generic;
using System.Text;

namespace teste.RulesWin
{
    public class SpockRulesWin : BaseRulesWin
    {
        public SpockRulesWin()
        {
            Casa = JogadaEnum.Spock;
            RulesWin.Add(JogadaEnum.Tesoura);
            RulesWin.Add(JogadaEnum.Pedra);
        }
    }
}
