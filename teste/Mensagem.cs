using System;
using System.Collections.Generic;
using System.Text;

namespace teste
{
    public static class Mensagem
    {
        public static string CasaGanha()
            => "Jogador 1 Ganhou | Jogador 2 Perdeu";

        public static string CasaPerde()
            => "Jogador 1 Perdeu | Jogador 2 ganhou";
        
        public static string Empate()
            => "Empate";
        public static string Erro()
            => "Erro!!!";
    }
}
