using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ContaLuz.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataPagamento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateLeitura = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KwGasto = table.Column<int>(type: "int", nullable: false),
                    MediaConsumo = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    NumLeitura = table.Column<int>(type: "int", nullable: false),
                    ValorPagar = table.Column<decimal>(type: "decimal(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contas");
        }
    }
}
