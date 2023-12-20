using System;
using System.Collections.Generic;
using System.Text;
using teste.RulesWin;
using teste.TipoJogada;

namespace teste
{
    public static class InjectPlay
    {
        public static IList<BasePlay> InjectConfiguration()
        {
            var configuration = new List<BasePlay>
            {
                new LargatoPay(),
                new PapelPlay(),
                new PedraPlay(),
                new SpockPlay(),
                new TesouraPlay()
            };
            return configuration;

        }
    }
}
