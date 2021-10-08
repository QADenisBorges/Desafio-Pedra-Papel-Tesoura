using System;
using System.Collections.Generic;
using System.Text;

namespace teste.RulesWin
{
    public class TesouraRulesWin : BaseRulesWin
    {
        public TesouraRulesWin()
        {
            Casa = JogadaEnum.Spock;
            RulesWin.Add(JogadaEnum.Tesoura);
            RulesWin.Add(JogadaEnum.Pedra);
        }
    }
}
