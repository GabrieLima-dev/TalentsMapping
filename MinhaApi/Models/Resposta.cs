using System;
using System.Collections.Generic;

namespace MinhaApi.Models
{
    public class Resposta
    {
        public int id_resposta { get; set; } // id_resposta
        public int id_pergunta { get; set; } // FK para Pergunta
        public int id_teste { get; set; }
        public int id_alternativa { get; set; }

        public Teste Teste { get; set; }
        public Pergunta Pergunta { get; set; }
        public Alternativa Alternativa { get; set; }
    }

}

