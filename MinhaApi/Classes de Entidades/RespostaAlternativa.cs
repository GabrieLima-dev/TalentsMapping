namespace TalentsMapping;

public class RespostaAlternativa
{
    public int IdResposta { get; set; }
    public int IdAlternativa { get; set; }

    // Relacionamentos
    public Resposta Resposta { get; set; }
    public Alternativa Alternativa { get; set; }
}

