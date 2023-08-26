using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace TP1ORM.AccessData.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            _ = migrationBuilder.CreateTable(
                name: "Peliculas",
                columns: table => new
                {
                    PeliculaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Poster = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Sinopsis = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Trailer = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_Peliculas", x => x.PeliculaId);
                });

            _ = migrationBuilder.CreateTable(
                name: "Salas",
                columns: table => new
                {
                    SalaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Capacidad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_Salas", x => x.SalaId);
                });

            _ = migrationBuilder.CreateTable(
                name: "Funciones",
                columns: table => new
                {
                    FuncionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PeliculaId = table.Column<int>(type: "int", nullable: false),
                    SalaId = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Horario = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_Funciones", x => x.FuncionId);
                    _ = table.ForeignKey(
                        name: "FK_Funciones_Peliculas_PeliculaId",
                        column: x => x.PeliculaId,
                        principalTable: "Peliculas",
                        principalColumn: "PeliculaId",
                        onDelete: ReferentialAction.Cascade);
                    _ = table.ForeignKey(
                        name: "FK_Funciones_Salas_SalaId",
                        column: x => x.SalaId,
                        principalTable: "Salas",
                        principalColumn: "SalaId",
                        onDelete: ReferentialAction.Cascade);
                });

            _ = migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    TicketId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FuncionId = table.Column<int>(type: "int", nullable: false),
                    Usuario = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_Tickets", x => new { x.TicketId, x.FuncionId });
                    _ = table.ForeignKey(
                        name: "FK_Tickets_Funciones_FuncionId",
                        column: x => x.FuncionId,
                        principalTable: "Funciones",
                        principalColumn: "FuncionId",
                        onDelete: ReferentialAction.Cascade);
                });

            _ = migrationBuilder.InsertData(
                table: "Peliculas",
                columns: new[] { "PeliculaId", "Poster", "Sinopsis", "Titulo", "Trailer" },
                values: new object[,]
                {
                    { 1, "https://bit.ly/3u3wJIn", "https://bit.ly/2VXsVMj", "Rapido y Furioso", "https://bit.ly/2XrPglr" },
                    { 2, "https://bit.ly/3At1JnE", "https://bit.ly/3zrETvp", "En busca de la felicidad", "https://bit.ly/3zpfp1x" },
                    { 3, "https://bit.ly/2XygzdK", "https://bit.ly/3lNVPrc", "Mision Imposible", "https://bit.ly/3EAIlYo" },
                    { 4, "https://bit.ly/3nQWyub", "https://bit.ly/3nV2wtZ", "Celular", "https://bit.ly/3EATp7z" },
                    { 5, "https://bit.ly/3nSbhFk", "https://bit.ly/3lLgE6e", "Bastardos sin gloria ", "https://bit.ly/3EDUyLA" },
                    { 6, "https://bit.ly/2XAxjSl", "https://bit.ly/2ZktTnf", "Busqueda Implacable", "https://bit.ly/2XygPcI" },
                    { 7, "https://bit.ly/3u03Z39", "https://bit.ly/3CuWqVj", "Harry Potter Prisionero de Azkaban", "https://bit.ly/2XIIdVZ" },
                    { 8, "https://bit.ly/3nRE90c", "https://bit.ly/39tpCiN", "Invicto 3", "https://bit.ly/3lEU2od" },
                    { 9, "https://bit.ly/3u3xv8f", "https://bit.ly/3Cy6qwP", "Nueve Reinas", "https://bit.ly/3krQypO" },
                    { 10, "https://bit.ly/2XKIhof", "https://bit.ly/39npiCg", "Atrapame si puedes", "https://bit.ly/2VWI7ZX" }
                });

            _ = migrationBuilder.InsertData(
                table: "Salas",
                columns: new[] { "SalaId", "Capacidad" },
                values: new object[,]
                {
                    { 1, 5 },
                    { 2, 15 },
                    { 3, 35 }
                });

            _ = migrationBuilder.CreateIndex(
                name: "IX_Funciones_PeliculaId",
                table: "Funciones",
                column: "PeliculaId");

            _ = migrationBuilder.CreateIndex(
                name: "IX_Funciones_SalaId",
                table: "Funciones",
                column: "SalaId");

            _ = migrationBuilder.CreateIndex(
                name: "IX_Tickets_FuncionId",
                table: "Tickets",
                column: "FuncionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            _ = migrationBuilder.DropTable(
                name: "Tickets");

            _ = migrationBuilder.DropTable(
                name: "Funciones");

            _ = migrationBuilder.DropTable(
                name: "Peliculas");

            _ = migrationBuilder.DropTable(
                name: "Salas");
        }
    }
}
