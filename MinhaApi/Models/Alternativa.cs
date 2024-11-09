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

        // Propriedade de navegação para a pergunta associada
        public Pergunta Pergunta { get; set; }

        // Propriedade de navegação para RespostaAlternativas (muitos-para-muitos com Resposta)
        public ICollection<RespostaAlternativa> RespostaAlternativas { get; set; } = new List<RespostaAlternativa>();
    }
}