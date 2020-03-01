using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ContractApi.Migrations
{
    public partial class MyFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contratos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ConsumoPrevisto = table.Column<decimal>(nullable: false),
                    ConsumoRealizado = table.Column<decimal>(nullable: false),
                    DataAssinatura = table.Column<DateTime>(nullable: false),
                    DataFim = table.Column<DateTime>(nullable: false),
                    DataInicio = table.Column<DateTime>(nullable: false),
                    FaturamentoMax = table.Column<decimal>(nullable: false),
                    FaturamentoMin = table.Column<decimal>(nullable: false),
                    FaturamentoPrevisto = table.Column<decimal>(nullable: false),
                    FaturamentoRealizado = table.Column<decimal>(nullable: false),
                    Modalidade = table.Column<string>(nullable: true),
                    NomeContrato = table.Column<string>(nullable: true),
                    Pld = table.Column<decimal>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    Tarifa = table.Column<decimal>(nullable: false),
                    Tipo = table.Column<string>(nullable: true),
                    VolumeContrato = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contratos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Empresas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CEP = table.Column<string>(nullable: true),
                    CNPJ = table.Column<string>(nullable: true),
                    Cidade = table.Column<string>(nullable: true),
                    CriadoEm = table.Column<DateTime>(nullable: false),
                    Endereco = table.Column<string>(nullable: true),
                    Estado = table.Column<string>(nullable: true),
                    InscricaEestadual = table.Column<string>(nullable: true),
                    ModificadoEm = table.Column<DateTime>(nullable: false),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contratos");

            migrationBuilder.DropTable(
                name: "Empresas");
        }
    }
}
