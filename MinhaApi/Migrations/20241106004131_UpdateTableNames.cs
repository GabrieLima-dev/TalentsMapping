using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MinhaApi.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTableNames : Migration
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
                    NomeCurso = table.Column<string>(type: "text", nullable: false),
                    Descricao = table.Column<string>(type: "text", nullable: false),
                    TarefasDiarias = table.Column<string>(type: "text", nullable: false),
                    AmbienteTrabalho = table.Column<string>(type: "text", nullable: false),
                    FaixaSalarial = table.Column<string>(type: "text", nullable: false),
                    MediaCorte = table.Column<decimal>(type: "numeric", nullable: false)
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
                    TextoPergunta = table.Column<string>(type: "text", nullable: false)
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
                    Nome = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Senha = table.Column<string>(type: "text", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
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
                    PerguntaId = table.Column<int>(type: "integer", nullable: false),
                    TextoAlternativa = table.Column<string>(type: "text", nullable: false),
                    Valor = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_alternativa", x => x.id_alternativa);
                    table.ForeignKey(
                        name: "FK_alternativa_pergunta_PerguntaId",
                        column: x => x.PerguntaId,
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
                    UsuarioId = table.Column<int>(type: "integer", nullable: false),
                    DataRealizacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_teste", x => x.id_teste);
                    table.ForeignKey(
                        name: "FK_teste_usuario_UsuarioId",
                        column: x => x.UsuarioId,
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
                    TesteId = table.Column<int>(type: "integer", nullable: false),
                    CursoId = table.Column<int>(type: "integer", nullable: false),
                    Posicao = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_recomendacao", x => x.id_recomendacao);
                    table.ForeignKey(
                        name: "FK_recomendacao_curso_CursoId",
                        column: x => x.CursoId,
                        principalSchema: "public",
                        principalTable: "curso",
                        principalColumn: "id_curso",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_recomendacao_teste_TesteId",
                        column: x => x.TesteId,
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
                    PerguntaId = table.Column<int>(type: "integer", nullable: false),
                    AlternativaId = table.Column<int>(type: "integer", nullable: false),
                    Testeid_teste = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_resposta", x => x.id_resposta);
                    table.ForeignKey(
                        name: "FK_resposta_alternativa_AlternativaId",
                        column: x => x.AlternativaId,
                        principalSchema: "public",
                        principalTable: "alternativa",
                        principalColumn: "id_alternativa",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_resposta_pergunta_PerguntaId",
                        column: x => x.PerguntaId,
                        principalSchema: "public",
                        principalTable: "pergunta",
                        principalColumn: "id_pergunta",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_resposta_teste_Testeid_teste",
                        column: x => x.Testeid_teste,
                        principalSchema: "public",
                        principalTable: "teste",
                        principalColumn: "id_teste");
                });

            migrationBuilder.CreateTable(
                name: "resposta_alternativa",
                schema: "public",
                columns: table => new
                {
                    IdResposta = table.Column<int>(type: "integer", nullable: false),
                    IdAlternativa = table.Column<int>(type: "integer", nullable: false),
                    Respostaid_resposta = table.Column<int>(type: "integer", nullable: false),
                    Alternativaid_alternativa = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_resposta_alternativa", x => new { x.IdResposta, x.IdAlternativa });
                    table.ForeignKey(
                        name: "FK_resposta_alternativa_alternativa_Alternativaid_alternativa",
                        column: x => x.Alternativaid_alternativa,
                        principalSchema: "public",
                        principalTable: "alternativa",
                        principalColumn: "id_alternativa",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_resposta_alternativa_resposta_Respostaid_resposta",
                        column: x => x.Respostaid_resposta,
                        principalSchema: "public",
                        principalTable: "resposta",
                        principalColumn: "id_resposta",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_alternativa_PerguntaId",
                schema: "public",
                table: "alternativa",
                column: "PerguntaId");

            migrationBuilder.CreateIndex(
                name: "IX_recomendacao_CursoId",
                schema: "public",
                table: "recomendacao",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_recomendacao_TesteId",
                schema: "public",
                table: "recomendacao",
                column: "TesteId");

            migrationBuilder.CreateIndex(
                name: "IX_resposta_AlternativaId",
                schema: "public",
                table: "resposta",
                column: "AlternativaId");

            migrationBuilder.CreateIndex(
                name: "IX_resposta_PerguntaId",
                schema: "public",
                table: "resposta",
                column: "PerguntaId");

            migrationBuilder.CreateIndex(
                name: "IX_resposta_Testeid_teste",
                schema: "public",
                table: "resposta",
                column: "Testeid_teste");

            migrationBuilder.CreateIndex(
                name: "IX_resposta_alternativa_Alternativaid_alternativa",
                schema: "public",
                table: "resposta_alternativa",
                column: "Alternativaid_alternativa");

            migrationBuilder.CreateIndex(
                name: "IX_resposta_alternativa_Respostaid_resposta",
                schema: "public",
                table: "resposta_alternativa",
                column: "Respostaid_resposta");

            migrationBuilder.CreateIndex(
                name: "IX_teste_UsuarioId",
                schema: "public",
                table: "teste",
                column: "UsuarioId");
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
