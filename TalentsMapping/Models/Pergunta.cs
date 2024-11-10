namespace TalentsMapping.Models
{
    public class Pergunta
    {
        public int id { get; set; }
        public string texto { get; set; }
        public List<Alternativa> alternativas { get; set; }
    }
}
