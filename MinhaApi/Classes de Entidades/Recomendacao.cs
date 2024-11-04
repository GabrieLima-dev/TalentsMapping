using System;
using System.Collections.Generic;
using TalentsMapping;

namespace MinhaApi.Data
{
    public class Recomendacao
    {
        public int Id { get; set; } // id_recomendacao
        public int TesteId { get; set; } // FK para Teste
        public int CursoId { get; set; } // FK para Curso
        public int Posicao { get; set; }

        public Teste Teste { get; set; } // Navegação para Teste
        public Curso Curso { get; set; } // Navegação para Curso
    }

}
