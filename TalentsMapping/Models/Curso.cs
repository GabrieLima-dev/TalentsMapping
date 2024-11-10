namespace TalentsMapping.Models
{
    public class Curso
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public string tarefas_diarias { get; set; }
        public string ambiente_trabalho { get; set; }
        public List<decimal> faixa_salarial { get; set; }
        public decimal media_corte { get; set; }
    }
}
