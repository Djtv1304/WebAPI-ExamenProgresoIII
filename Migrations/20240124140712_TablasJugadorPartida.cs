using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAPI_Productos_ProgramacionIV.Migrations
{
    /// <inheritdoc />
    public partial class TablasJugadorPartida : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Jugador",
                columns: table => new
                {
                    JugadorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jugador", x => x.JugadorID);
                });

            migrationBuilder.CreateTable(
                name: "Partida",
                columns: table => new
                {
                    PartidaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JugadorUnoID = table.Column<int>(type: "int", nullable: false),
                    JugadorDosID = table.Column<int>(type: "int", nullable: false),
                    JugadorUnoIsWin = table.Column<bool>(type: "bit", nullable: false),
                    JugadorDosIsWin = table.Column<bool>(type: "bit", nullable: false),
                    fechaPartida = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partida", x => x.PartidaId);
                });

            migrationBuilder.InsertData(
                table: "Jugador",
                column: "JugadorID",
                values: new object[]
                {
                    1,
                    2
                });

            migrationBuilder.InsertData(
                table: "Partida",
                columns: new[] { "PartidaId", "JugadorDosID", "JugadorDosIsWin", "JugadorUnoID", "JugadorUnoIsWin", "fechaPartida" },
                values: new object[,]
                {
                    { 1, 2, false, 1, true, new DateTime(2024, 1, 24, 9, 7, 12, 7, DateTimeKind.Local).AddTicks(4674) },
                    { 2, 1, false, 2, true, new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jugador");

            migrationBuilder.DropTable(
                name: "Partida");
        }
    }
}
