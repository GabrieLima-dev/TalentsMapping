using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MinhaApi.Models
{
    public class Curso
    {
        [Key]
        public int id_curso { get; set; }
        public string nome_curso { get; set; }
        public string descricao { get; set; }
        public string tarefas_diarias { get; set; }
        public string ambiente_trabalho { get; set; }
        public string faixa_salarial { get; set; }
        public decimal media_corte { get; set; }

        public ICollection<Recomendacao> Recomendacoes { get; set; } // Relação 1:N com Recomendacao
    }
}
