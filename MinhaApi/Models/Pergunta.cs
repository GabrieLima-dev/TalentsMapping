using System;
using System.Collections.Generic;

namespace MinhaApi.Models
{
    public class Pergunta
    {
        public int id_pergunta { get; set; }
        public string TextoPergunta { get; set; }

        public ICollection<Alternativa> Alternativas { get; set; } // Relação 1:N com Alternativa
    }

}
