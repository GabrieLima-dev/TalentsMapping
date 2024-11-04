using Microsoft.EntityFrameworkCore;
using TalentsMapping;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Teste> Testes { get; set; }
    public DbSet<Recomendacao> Recomendacoes { get; set; }
    public DbSet<Curso> Cursos { get; set; }
    public DbSet<Pergunta> Perguntas { get; set; }
    public DbSet<Alternativa> Alternativas { get; set; }
    public DbSet<Resposta> Respostas { get; set; }
    public DbSet<RespostaAlternativa> RespostasAlternativas { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configurações adicionais, se necessárias
        // Exemplo de configuração de chave composta para a entidade RespostaAlternativa
        modelBuilder.Entity<RespostaAlternativa>()
            .HasKey(ra => new { ra.IdResposta, ra.IdAlternativa });
    }
}
