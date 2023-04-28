using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ESH_CarteiraInvestimentos.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ativos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ticket = table.Column<string>(type: "varchar(10)", nullable: true),
                    CNPJ = table.Column<string>(type: "varchar(20)", nullable: true),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    QtdTotal = table.Column<int>(type: "int", nullable: false),
                    TotalInvestido = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PrecoMedio = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ativos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Aportes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AtivoId = table.Column<int>(type: "int", nullable: false),
                    QtdCompra = table.Column<int>(type: "int", nullable: false),
                    DtCompra = table.Column<DateTime>(type: "date", nullable: false),
                    VlCompra = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aportes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Aportes_Ativos_AtivoId",
                        column: x => x.AtivoId,
                        principalTable: "Ativos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Aportes_AtivoId",
                table: "Aportes",
                column: "AtivoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aportes");

            migrationBuilder.DropTable(
                name: "Ativos");
        }
    }
}
