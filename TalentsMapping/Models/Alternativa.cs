namespace TalentsMapping.Models
{
    public class Alternativa
    {
        public string Texto { get; set; } // Texto da alternativa, ex.: "Sim", "Não"
        public string Valor { get; set; } // Identificador da alternativa, ex.: "a" ou "b"
        public List<string> Cursos { get; set; } // Lista de cursos associados a essa alternativa
    }
}
