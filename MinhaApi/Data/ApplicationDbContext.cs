using Microsoft.EntityFrameworkCore;
using MinhaApi.Models;

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
        public DbSet<RespostaAlternativa> RespostaAlternativas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("public");

            // Configuração dos nomes das tabelas em minúsculas
            modelBuilder.Entity<Usuario>().ToTable("usuario");
            modelBuilder.Entity<Teste>().ToTable("teste");
            modelBuilder.Entity<Pergunta>().ToTable("pergunta");
            modelBuilder.Entity<Resposta>().ToTable("resposta");
            modelBuilder.Entity<Recomendacao>().ToTable("recomendacao");
            modelBuilder.Entity<Alternativa>().ToTable("alternativa");
            modelBuilder.Entity<Curso>().ToTable("curso");
            modelBuilder.Entity<RespostaAlternativa>().ToTable("resposta_alternativa");

            // Configurações de chaves primárias
            modelBuilder.Entity<Usuario>().HasKey(u => u.id_usuario);
            modelBuilder.Entity<Teste>().HasKey(t => t.id_teste);
            modelBuilder.Entity<Pergunta>().HasKey(p => p.id_pergunta);
            modelBuilder.Entity<Resposta>().HasKey(r => r.id_resposta);
            modelBuilder.Entity<Recomendacao>().HasKey(rec => rec.id_recomendacao);
            modelBuilder.Entity<Alternativa>().HasKey(a => a.id_alternativa);
            modelBuilder.Entity<Curso>().HasKey(c => c.id_curso);
            modelBuilder.Entity<RespostaAlternativa>().HasKey(ra => new { ra.id_resposta, ra.id_alternativa });

            // Configurações de relacionamentos

            // Relacionamento entre Usuario e Teste
            modelBuilder.Entity<Teste>()
                .HasOne(t => t.Usuario)
                .WithMany(u => u.Testes)
                .HasForeignKey(t => t.id_usuario)
                .OnDelete(DeleteBehavior.Cascade);

            // Relacionamento entre Teste e Resposta
            modelBuilder.Entity<Resposta>()
                .HasOne(r => r.Teste)
                .WithMany(t => t.Respostas)
                .HasForeignKey(r => r.id_teste)
                .OnDelete(DeleteBehavior.Cascade);

            // Relacionamento entre Resposta e Pergunta
            modelBuilder.Entity<Resposta>()
                .HasOne(r => r.Pergunta)
                .WithMany(p => p.Respostas)
                .HasForeignKey(r => r.id_pergunta);

            // Relacionamento entre Resposta e Alternativa
            modelBuilder.Entity<Resposta>()
                .HasOne(r => r.Alternativa)
                .WithMany(a => a.Respostas)
                .HasForeignKey(r => r.id_alternativa);

            // Relacionamento entre Teste e Recomendacao
            modelBuilder.Entity<Recomendacao>()
                .HasOne(r => r.Teste)
                .WithMany(t => t.Recomendacoes)
                .HasForeignKey(r => r.id_teste)
                .OnDelete(DeleteBehavior.Cascade);

            // Relacionamento entre Recomendacao e Curso
            modelBuilder.Entity<Recomendacao>()
                .HasOne(r => r.Curso)
                .WithMany(c => c.Recomendacoes)
                .HasForeignKey(r => r.id_curso);
        }
    }
}
