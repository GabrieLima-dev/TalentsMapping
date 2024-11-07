using System;
using System.Collections.Generic;

namespace MinhaApi.Models
{
    public class RespostaAlternativa
    {
        public int id_resposta { get; set; }
        public int id_alternativa { get; set; }

        // Relacionamentos
        public Resposta resposta { get; set; }
        public Alternativa alternativa { get; set; }
    }
}

