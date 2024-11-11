namespace TalentsMapping.Models
{
    public class Pergunta
    {
        public int Id { get; set; }
        public string Texto { get; set; }
        public List<Alternativa> Alternativas { get; set; }
    }
}
