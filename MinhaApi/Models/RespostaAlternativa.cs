using System;
using System.Collections.Generic;

namespace MinhaApi.Models
{
    public class RespostaAlternativa
    {
        public int id_resposta { get; set; } // FK para Resposta
        public int id_alternativa { get; set; } // FK para Alternativa

        // Propriedades de navegação
        public Resposta Resposta { get; set; }
        public Alternativa Alternativa { get; set; }
    }
}
