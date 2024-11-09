using System.Collections.Generic;

namespace MinhaApi.Models
{
    public class Resposta
    {
        public int id_resposta { get; set; } // id_resposta
        public int id_pergunta { get; set; } // FK para Pergunta
        public int id_teste { get; set; } // FK para Teste

        // Navegação para Teste e Pergunta
        public Teste Teste { get; set; }
        public Pergunta Pergunta { get; set; }

        // Propriedade de navegação para RespostaAlternativas (muitos-para-muitos com Alternativa)
        public ICollection<RespostaAlternativa> RespostaAlternativas { get; set; } = new List<RespostaAlternativa>();
    }
}
