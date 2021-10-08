using System;
using System.Collections.Generic;
using System.Text;

namespace teste.RulesWin
{
    public abstract class BaseRulesWin 
    {
        protected BaseRulesWin()
        {
            RulesWin = new List<JogadaEnum>();
        }

        public List<JogadaEnum> RulesWin { get; }
        public JogadaEnum Casa;
    }
}
