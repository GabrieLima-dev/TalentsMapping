using System;
using System.Collections.Generic;
using TalentsMapping;

namespace MinhaApi.Data
{
    public class Alternativa
    {
        public int Id { get; set; } // id_alternativa
        public int PerguntaId { get; set; } // FK para Pergunta
        public string TextoAlternativa { get; set; }
        public int Valor { get; set; }

        public Pergunta Pergunta { get; set; } // Navegação para Pergunta
    }

}