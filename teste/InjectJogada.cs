using System;
using System.Collections.Generic;
using System.Text;
using teste.RulesWin;
using teste.TipoJogada;

namespace teste
{
    public static class InjectJogada
    {
        public static IList<BaseJogada> InjectConfiguration()
        {
            var configuration = new List<BaseJogada>();
            configuration.Add(new LargatoJogada());
            configuration.Add(new PapelJogada());
            configuration.Add(new PedraJogada());
            configuration.Add(new SpockJogada());
            configuration.Add(new TesouraJogada());
            return configuration;
        }
    }
}
