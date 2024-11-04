using Microsoft.EntityFrameworkCore;

namespace MinhaApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Teste> Testes { get; set; }
        public DbSet<Resposta> Respostas { get; set; }
        public DbSet<Recomendacao> Recomendacoes { get; set; }
        public DbSet<Pergunta> Perguntas { get; set; }
        public DbSet<Alternativa> Alternativas { get; set; }
        public DbSet<Curso> Cursos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Exemplo: Configurar a relação entre Teste e Usuario
            modelBuilder.Entity<Teste>()
                .HasOne(t => t.Usuario)
                .WithMany(u => u.Testes)
                .HasForeignKey(t => t.UsuarioId)
                .OnDelete(DeleteBehavior.Cascade);

            // Configurações para outras entidades conforme necessário
        }
    }
}