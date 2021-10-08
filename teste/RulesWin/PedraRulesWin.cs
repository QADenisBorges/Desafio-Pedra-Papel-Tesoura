using System;
using System.Collections.Generic;
using System.Text;

namespace teste.RulesWin
{
    public class PedraRulesWin : BaseRulesWin
    {
        public PedraRulesWin()
        {
            Casa = JogadaEnum.Pedra;
            RulesWin.Add(JogadaEnum.Tesoura);
            RulesWin.Add(JogadaEnum.Largato);
        }
    }
}
