using Microsoft.EntityFrameworkCore;
using TalentsMapping.Models; // Substitua pelo namespace correto, se necessário

namespace MinhaApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // DbSets para cada entidade
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

            // Configuração de chave composta para a entidade RespostaAlternativa
            modelBuilder.Entity<RespostaAlternativa>()
                .HasKey(ra => new { ra.id_resposta, ra.id_alternativa });

            // Exemplo de configuração de relacionamento
            modelBuilder.Entity<Resposta>()
                .HasOne(r => r.Pergunta)
                .WithMany(p => p.Respostas)
                .HasForeignKey(r => r.id_pergunta);

            modelBuilder.Entity<Alternativa>()
                .HasOne(a => a.Pergunta)
                .WithMany(p => p.Alternativas)
                .HasForeignKey(a => a.id_pergunta);

            // Configuração de relacionamentos adicionais, conforme necessário
            // Exemplo: relacionamento entre Teste e Recomendacao
            modelBuilder.Entity<Recomendacao>()
                .HasOne(r => r.Teste)
                .WithMany(t => t.Recomendacoes)
                .HasForeignKey(r => r.id_teste);

            // Configuração de relacionamento entre Teste e Usuario
            modelBuilder.Entity<Teste>()
                .HasOne(t => t.Usuario)
                .WithMany(u => u.Testes)
                .HasForeignKey(t => t.id_usuario);

            // Adicione outras configurações de relacionamento se necessário
        }
    }
}

