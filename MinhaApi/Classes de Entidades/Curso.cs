using System;
using System.Collections.Generic;
using TalentsMapping;

namespace MinhaApi.Data
{
    public class Curso
    {
        public int Id { get; set; } // id_curso
        public string NomeCurso { get; set; }
        public string Descricao { get; set; }
        public string TarefasDiarias { get; set; }
        public string AmbienteTrabalho { get; set; }
        public string FaixaSalarial { get; set; }
        public decimal MediaCorte { get; set; }

        public ICollection<Recomendacao> Recomendacoes { get; set; } // Relação 1:N com Recomendacao
    }

}
