using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MinhaApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "public");

            migrationBuilder.CreateTable(
                name: "curso",
                schema: "public",
                columns: table => new
                {
                    id_curso = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome_curso = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    descricao = table.Column<string>(type: "text", nullable: false),
                    tarefas_diarias = table.Column<string>(type: "text", nullable: false),
                    ambiente_trabalho = table.Column<string>(type: "text", nullable: false),
                    faixa_salarial = table.Column<List<decimal>>(type: "numeric(10,2)[]", nullable: false),
                    media_corte = table.Column<decimal>(type: "numeric(6,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_curso", x => x.id_curso);
                });

            migrationBuilder.CreateTable(
                name: "pergunta",
                schema: "public",
                columns: table => new
                {
                    id_pergunta = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    texto_pergunta = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pergunta", x => x.id_pergunta);
                });

            migrationBuilder.CreateTable(
                name: "usuario",
                schema: "public",
                columns: table => new
                {
                    id_usuario = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    email = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    senha = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    data_nascimento = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuario", x => x.id_usuario);
                });

            migrationBuilder.CreateTable(
                name: "alternativa",
                schema: "public",
                columns: table => new
                {
                    id_alternativa = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    id_pergunta = table.Column<int>(type: "integer", nullable: false),
                    texto_alternativa = table.Column<string>(type: "text", nullable: false),
                    valor = table.Column<string>(type: "text", nullable: false),
                    perguntaid_pergunta = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_alternativa", x => x.id_alternativa);
                    table.ForeignKey(
                        name: "FK_alternativa_pergunta_perguntaid_pergunta",
                        column: x => x.perguntaid_pergunta,
                        principalSchema: "public",
                        principalTable: "pergunta",
                        principalColumn: "id_pergunta",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "teste",
                schema: "public",
                columns: table => new
                {
                    id_teste = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    id_usuario = table.Column<int>(type: "integer", nullable: false),
                    data_realizacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_teste", x => x.id_teste);
                    table.ForeignKey(
                        name: "FK_teste_usuario_id_usuario",
                        column: x => x.id_usuario,
                        principalSchema: "public",
                        principalTable: "usuario",
                        principalColumn: "id_usuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "recomendacao",
                schema: "public",
                columns: table => new
                {
                    id_recomendacao = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    id_teste = table.Column<int>(type: "integer", nullable: false),
                    id_curso = table.Column<int>(type: "integer", nullable: false),
                    posicao = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_recomendacao", x => x.id_recomendacao);
                    table.ForeignKey(
                        name: "FK_recomendacao_curso_id_curso",
                        column: x => x.id_curso,
                        principalSchema: "public",
                        principalTable: "curso",
                        principalColumn: "id_curso",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_recomendacao_teste_id_teste",
                        column: x => x.id_teste,
                        principalSchema: "public",
                        principalTable: "teste",
                        principalColumn: "id_teste",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "resposta",
                schema: "public",
                columns: table => new
                {
                    id_resposta = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    id_pergunta = table.Column<int>(type: "integer", nullable: false),
                    id_teste = table.Column<int>(type: "integer", nullable: false),
                    id_alternativa = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_resposta", x => x.id_resposta);
                    table.ForeignKey(
                        name: "FK_resposta_alternativa_id_alternativa",
                        column: x => x.id_alternativa,
                        principalSchema: "public",
                        principalTable: "alternativa",
                        principalColumn: "id_alternativa",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_resposta_pergunta_id_pergunta",
                        column: x => x.id_pergunta,
                        principalSchema: "public",
                        principalTable: "pergunta",
                        principalColumn: "id_pergunta",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_resposta_teste_id_teste",
                        column: x => x.id_teste,
                        principalSchema: "public",
                        principalTable: "teste",
                        principalColumn: "id_teste",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "resposta_alternativa",
                schema: "public",
                columns: table => new
                {
                    id_resposta = table.Column<int>(type: "integer", nullable: false),
                    id_alternativa = table.Column<int>(type: "integer", nullable: false),
                    respostaid_resposta = table.Column<int>(type: "integer", nullable: false),
                    alternativaid_alternativa = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_resposta_alternativa", x => new { x.id_resposta, x.id_alternativa });
                    table.ForeignKey(
                        name: "FK_resposta_alternativa_alternativa_alternativaid_alternativa",
                        column: x => x.alternativaid_alternativa,
                        principalSchema: "public",
                        principalTable: "alternativa",
                        principalColumn: "id_alternativa",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_resposta_alternativa_resposta_respostaid_resposta",
                        column: x => x.respostaid_resposta,
                        principalSchema: "public",
                        principalTable: "resposta",
                        principalColumn: "id_resposta",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_alternativa_perguntaid_pergunta",
                schema: "public",
                table: "alternativa",
                column: "perguntaid_pergunta");

            migrationBuilder.CreateIndex(
                name: "IX_recomendacao_id_curso",
                schema: "public",
                table: "recomendacao",
                column: "id_curso");

            migrationBuilder.CreateIndex(
                name: "IX_recomendacao_id_teste",
                schema: "public",
                table: "recomendacao",
                column: "id_teste");

            migrationBuilder.CreateIndex(
                name: "IX_resposta_id_alternativa",
                schema: "public",
                table: "resposta",
                column: "id_alternativa");

            migrationBuilder.CreateIndex(
                name: "IX_resposta_id_pergunta",
                schema: "public",
                table: "resposta",
                column: "id_pergunta");

            migrationBuilder.CreateIndex(
                name: "IX_resposta_id_teste",
                schema: "public",
                table: "resposta",
                column: "id_teste");

            migrationBuilder.CreateIndex(
                name: "IX_resposta_alternativa_alternativaid_alternativa",
                schema: "public",
                table: "resposta_alternativa",
                column: "alternativaid_alternativa");

            migrationBuilder.CreateIndex(
                name: "IX_resposta_alternativa_respostaid_resposta",
                schema: "public",
                table: "resposta_alternativa",
                column: "respostaid_resposta");

            migrationBuilder.CreateIndex(
                name: "IX_teste_id_usuario",
                schema: "public",
                table: "teste",
                column: "id_usuario");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "recomendacao",
                schema: "public");

            migrationBuilder.DropTable(
                name: "resposta_alternativa",
                schema: "public");

            migrationBuilder.DropTable(
                name: "curso",
                schema: "public");

            migrationBuilder.DropTable(
                name: "resposta",
                schema: "public");

            migrationBuilder.DropTable(
                name: "alternativa",
                schema: "public");

            migrationBuilder.DropTable(
                name: "teste",
                schema: "public");

            migrationBuilder.DropTable(
                name: "pergunta",
                schema: "public");

            migrationBuilder.DropTable(
                name: "usuario",
                schema: "public");
        }
    }
}
