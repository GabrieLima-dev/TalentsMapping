using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MinhaApi.Models
{
    public class Curso
    {
        [Key]
        public int id_curso { get; set; }

        [MaxLength(100)] // Limite de 100 caracteres para nome_curso, conforme o tipo character varying(100)
        public string nome_curso { get; set; }

        public string descricao { get; set; }

        public string tarefas_diarias { get; set; }

        public string ambiente_trabalho { get; set; }

        [Column(TypeName = "numeric(10,2)[]")]
        public List<decimal> faixa_salarial { get; set; } // Array de valores decimais com precisão

        [Column(TypeName = "numeric(6,2)")]
        public decimal media_corte { get; set; } // Valor decimal com precisão definida

        public ICollection<Recomendacao> Recomendacoes { get; set; } = new List<Recomendacao>(); // Relação 1:N com Recomendacao
    }
}
