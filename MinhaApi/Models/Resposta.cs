using System;
using System.Collections.Generic;

namespace MinhaApi.Models
{
    public class Resposta
    {
        public int id_resposta { get; set; } // id_resposta
        public int PerguntaId { get; set; } // FK para Pergunta
        public int AlternativaId { get; set; } // FK para Alternativa

        public Pergunta Pergunta { get; set; } // Navegação para Pergunta
        public Alternativa Alternativa { get; set; } // Navegação para Alternativa
    }

}

