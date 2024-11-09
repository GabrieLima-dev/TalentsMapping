﻿// <auto-generated />
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MinhaApi.Data;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MinhaApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("public")
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("MinhaApi.Models.Alternativa", b =>
                {
                    b.Property<int>("id_alternativa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id_alternativa"));

                    b.Property<int>("Perguntaid_pergunta")
                        .HasColumnType("integer");

                    b.Property<int>("id_pergunta")
                        .HasColumnType("integer");

                    b.Property<string>("texto_alternativa")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("valor")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id_alternativa");

                    b.HasIndex("Perguntaid_pergunta");

                    b.ToTable("alternativa", "public");
                });

            modelBuilder.Entity("MinhaApi.Models.Curso", b =>
                {
                    b.Property<int>("id_curso")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id_curso"));

                    b.Property<string>("ambiente_trabalho")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("descricao")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<List<decimal>>("faixa_salarial")
                        .IsRequired()
                        .HasColumnType("numeric(10,2)[]");

                    b.Property<decimal>("media_corte")
                        .HasColumnType("numeric(6,2)");

                    b.Property<string>("nome_curso")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("tarefas_diarias")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id_curso");

                    b.ToTable("curso", "public");
                });

            modelBuilder.Entity("MinhaApi.Models.Pergunta", b =>
                {
                    b.Property<int>("id_pergunta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id_pergunta"));

                    b.Property<string>("texto_pergunta")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id_pergunta");

                    b.ToTable("pergunta", "public");
                });

            modelBuilder.Entity("MinhaApi.Models.Recomendacao", b =>
                {
                    b.Property<int>("id_recomendacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id_recomendacao"));

                    b.Property<int>("id_curso")
                        .HasColumnType("integer");

                    b.Property<int>("id_teste")
                        .HasColumnType("integer");

                    b.Property<int>("posicao")
                        .HasColumnType("integer");

                    b.HasKey("id_recomendacao");

                    b.HasIndex("id_curso");

                    b.HasIndex("id_teste");

                    b.ToTable("recomendacao", "public");
                });

            modelBuilder.Entity("MinhaApi.Models.Resposta", b =>
                {
                    b.Property<int>("id_resposta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id_resposta"));

                    b.Property<int>("id_pergunta")
                        .HasColumnType("integer");

                    b.Property<int>("id_teste")
                        .HasColumnType("integer");

                    b.HasKey("id_resposta");

                    b.HasIndex("id_pergunta");

                    b.HasIndex("id_teste");

                    b.ToTable("resposta", "public");
                });

            modelBuilder.Entity("MinhaApi.Models.RespostaAlternativa", b =>
                {
                    b.Property<int>("id_resposta")
                        .HasColumnType("integer");

                    b.Property<int>("id_alternativa")
                        .HasColumnType("integer");

                    b.HasKey("id_resposta", "id_alternativa");

                    b.HasIndex("id_alternativa");

                    b.ToTable("resposta_alternativa", "public");
                });

            modelBuilder.Entity("MinhaApi.Models.Teste", b =>
                {
                    b.Property<int>("id_teste")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id_teste"));

                    b.Property<DateTime>("data_realizacao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("id_usuario")
                        .HasColumnType("integer");

                    b.HasKey("id_teste");

                    b.HasIndex("id_usuario");

                    b.ToTable("teste", "public");
                });

            modelBuilder.Entity("MinhaApi.Models.Usuario", b =>
                {
                    b.Property<int>("id_usuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id_usuario"));

                    b.Property<DateTime?>("data_nascimento")
                        .HasColumnType("date");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("senha")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.HasKey("id_usuario");

                    b.ToTable("usuario", "public");
                });

            modelBuilder.Entity("MinhaApi.Models.Alternativa", b =>
                {
                    b.HasOne("MinhaApi.Models.Pergunta", "Pergunta")
                        .WithMany("Alternativa")
                        .HasForeignKey("Perguntaid_pergunta")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pergunta");
                });

            modelBuilder.Entity("MinhaApi.Models.Recomendacao", b =>
                {
                    b.HasOne("MinhaApi.Models.Curso", "Curso")
                        .WithMany("Recomendacoes")
                        .HasForeignKey("id_curso")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MinhaApi.Models.Teste", "Teste")
                        .WithMany("Recomendacoes")
                        .HasForeignKey("id_teste")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Curso");

                    b.Navigation("Teste");
                });

            modelBuilder.Entity("MinhaApi.Models.Resposta", b =>
                {
                    b.HasOne("MinhaApi.Models.Pergunta", "Pergunta")
                        .WithMany("Respostas")
                        .HasForeignKey("id_pergunta")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MinhaApi.Models.Teste", "Teste")
                        .WithMany("Respostas")
                        .HasForeignKey("id_teste")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pergunta");

                    b.Navigation("Teste");
                });

            modelBuilder.Entity("MinhaApi.Models.RespostaAlternativa", b =>
                {
                    b.HasOne("MinhaApi.Models.Alternativa", "Alternativa")
                        .WithMany("RespostaAlternativas")
                        .HasForeignKey("id_alternativa")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MinhaApi.Models.Resposta", "Resposta")
                        .WithMany("RespostaAlternativas")
                        .HasForeignKey("id_resposta")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Alternativa");

                    b.Navigation("Resposta");
                });

            modelBuilder.Entity("MinhaApi.Models.Teste", b =>
                {
                    b.HasOne("MinhaApi.Models.Usuario", "Usuario")
                        .WithMany("Testes")
                        .HasForeignKey("id_usuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("MinhaApi.Models.Alternativa", b =>
                {
                    b.Navigation("RespostaAlternativas");
                });

            modelBuilder.Entity("MinhaApi.Models.Curso", b =>
                {
                    b.Navigation("Recomendacoes");
                });

            modelBuilder.Entity("MinhaApi.Models.Pergunta", b =>
                {
                    b.Navigation("Alternativa");

                    b.Navigation("Respostas");
                });

            modelBuilder.Entity("MinhaApi.Models.Resposta", b =>
                {
                    b.Navigation("RespostaAlternativas");
                });

            modelBuilder.Entity("MinhaApi.Models.Teste", b =>
                {
                    b.Navigation("Recomendacoes");

                    b.Navigation("Respostas");
                });

            modelBuilder.Entity("MinhaApi.Models.Usuario", b =>
                {
                    b.Navigation("Testes");
                });
#pragma warning restore 612, 618
        }
    }
}
