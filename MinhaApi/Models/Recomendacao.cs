using System;
using System.Collections.Generic;

namespace MinhaApi.Models
{
    public class Recomendacao
    {
        public int id_recomendacao { get; set; } // id_recomendacao
        public int TesteId { get; set; } // FK para Teste
        public int CursoId { get; set; } // FK para Curso
        public int Posicao { get; set; }

        public Teste Teste { get; set; } // Navegação para Teste
        public Curso Curso { get; set; } // Navegação para Curso
    }

}
