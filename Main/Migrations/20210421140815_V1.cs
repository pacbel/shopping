using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Main.Migrations
{
    public partial class V1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empresas",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Ativo = table.Column<byte>(nullable: false),
                    DataLog = table.Column<DateTime>(nullable: false),
                    Sigla = table.Column<string>(nullable: true),
                    NomeFantasia = table.Column<string>(nullable: true),
                    RazaoSocial = table.Column<string>(nullable: true),
                    Endereco = table.Column<string>(nullable: true),
                    Cidade = table.Column<string>(nullable: true),
                    Estado = table.Column<string>(nullable: true),
                    CNPJ = table.Column<string>(nullable: true),
                    InscricaoEstadual = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Indices",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Ativo = table.Column<byte>(nullable: false),
                    DataLog = table.Column<DateTime>(nullable: false),
                    NomeIndice = table.Column<string>(nullable: true),
                    CodBancoCentral = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Indices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UF",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Ativo = table.Column<byte>(nullable: false),
                    DataLog = table.Column<DateTime>(nullable: false),
                    Sigla = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UF", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Shoppings",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Ativo = table.Column<byte>(nullable: false),
                    DataLog = table.Column<DateTime>(nullable: false),
                    EmpresaId = table.Column<Guid>(nullable: true),
                    Sigla = table.Column<string>(nullable: true),
                    Serial = table.Column<int>(nullable: false),
                    NomeFantasia = table.Column<string>(nullable: true),
                    Endereco = table.Column<string>(nullable: true),
                    Bairro = table.Column<string>(nullable: true),
                    UfId = table.Column<Guid>(nullable: true),
                    Cidade = table.Column<string>(nullable: true),
                    Cep = table.Column<string>(nullable: true),
                    CNPJ = table.Column<string>(nullable: true),
                    IncricaoEstadual = table.Column<string>(nullable: true),
                    EmailPrincipal = table.Column<string>(nullable: true),
                    Contato = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shoppings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shoppings_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Shoppings_UF_UfId",
                        column: x => x.UfId,
                        principalTable: "UF",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Shoppings_EmpresaId",
                table: "Shoppings",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Shoppings_UfId",
                table: "Shoppings",
                column: "UfId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Indices");

            migrationBuilder.DropTable(
                name: "Shoppings");

            migrationBuilder.DropTable(
                name: "Empresas");

            migrationBuilder.DropTable(
                name: "UF");
        }
    }
}
