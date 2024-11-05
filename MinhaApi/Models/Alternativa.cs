using System;
using System.Collections.Generic;

namespace MinhaApi.Models
{
    public class Alternativa
    {
        public int id_alternativa { get; set; } // id_alternativa
        public int PerguntaId { get; set; } // FK para Pergunta
        public string TextoAlternativa { get; set; }
        public int Valor { get; set; }

        public Pergunta Pergunta { get; set; } // Navegação para Pergunta
    }

}