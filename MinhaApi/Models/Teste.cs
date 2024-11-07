using System;
using System.Collections.Generic;

namespace MinhaApi.Models
{

    public class Teste
    {
        public int id_teste { get; set; } // id_teste
        public int id_usuario { get; set; } // FK para Usuario
        public DateTime data_realizacao { get; set; }

        // Propriedade de navegação
        public Usuario Usuario { get; set; }
        public ICollection<Resposta> Respostas { get; set; } = new List<Resposta>();
        public ICollection<Recomendacao> Recomendacoes { get; set; } = new List<Recomendacao>();
    }
}