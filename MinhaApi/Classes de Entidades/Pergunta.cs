using System;
using System.Collections.Generic;
using TalentsMapping;

namespace MinhaApi.Data
{
    public class Pergunta
    {
        public int Id { get; set; } // id_pergunta
        public string TextoPergunta { get; set; }

        public ICollection<Alternativa> Alternativas { get; set; } // Relação 1:N com Alternativa
    }

}
