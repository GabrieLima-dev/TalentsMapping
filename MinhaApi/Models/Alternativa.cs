using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MinhaApi.Models
{
    public class Alternativa
    {
        [Key]
        public int id_alternativa { get; set; } // id_alternativa
        public int id_pergunta { get; set; } // FK para Pergunta
        public string texto_alternativa { get; set; }
        public string valor { get; set; }

        public Pergunta pergunta { get; set; } // Navegação para Pergunta

        // Adiciona a coleção de Respostas para representar o relacionamento
        public ICollection<Resposta> Respostas { get; set; } = new List<Resposta>();
    }
}
