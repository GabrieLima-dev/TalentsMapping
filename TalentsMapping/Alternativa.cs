namespace TalentsMapping;

public class Alternativa
{
    public int IdAlternativa { get; set; }
    public int IdPergunta { get; set; }
    public string TextoAlternativa { get; set; }
    public decimal Valor { get; set; }

    // Relacionamentos
    public Pergunta Pergunta { get; set; }
}

