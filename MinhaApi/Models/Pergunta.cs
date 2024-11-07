using System;
using System.Collections.Generic;

namespace MinhaApi.Models
{
    public class Pergunta
    {
        public int id_pergunta { get; set; }
        public string texto_pergunta { get; set; }

        public ICollection<Alternativa> Alternativa { get; set; } // Relação 1:N com Alternativa

        // Adiciona a coleção de Respostas para representar o relacionamento com Resposta
        public ICollection<Resposta> Respostas { get; set; } = new List<Resposta>();
    }
}
