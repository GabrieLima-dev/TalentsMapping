using System;
using System.Collections.Generic;

namespace MinhaApi.Data
{

    public class Teste
    {
        public int Id { get; set; } // id_teste
        public int UsuarioId { get; set; } // FK para Usuario
        public DateTime DataRealizacao { get; set; }

        public Usuario Usuario { get; set; } // Navegação para Usuario
        public ICollection<Resposta> Respostas { get; set; } // Relação 1:N com Resposta
        public ICollection<Recomendacao> Recomendacoes { get; set; } // Relação 1:N com Recomendacao
    }
}