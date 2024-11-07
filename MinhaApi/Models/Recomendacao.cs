using System;
using System.Collections.Generic;

namespace MinhaApi.Models
{
    public class Recomendacao
    {
        public int id_recomendacao { get; set; } // id_recomendacao
        public int id_teste { get; set; } // FK para Teste
        public int id_curso { get; set; } // FK para Curso
        public int posicao { get; set; }

        public Teste Teste { get; set; } // Navegação para Teste (ajustada com "T" maiúsculo)
        public Curso Curso { get; set; } // Navegação para Curso (ajustada com "C" maiúsculo)
    }
}
