using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NETFLIXLATAM.Migrations
{
    /// <inheritdoc />
    public partial class PeliculasDBExaul : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Peliculas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duracion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genero = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Peliculas", x => x.Id);
                });
            migrationBuilder.InsertData(
       table: "Peliculas",
      columns: new[] { "Id", "Titulo", "Duracion", "Genero" },
       values: new object[] { 1, "Volver al futuro", "1h 56m", "Ciencia ficción/Comedia" });

            migrationBuilder.InsertData(
               table: "Peliculas",
              columns: new[] { "Id", "Titulo", "Duracion", "Genero" },
               values: new object[] { 2, "La Sociedad de los Poetas Muertos", "2h 8m", "Comedia/Suspenso" });

            migrationBuilder.InsertData(
                table: "Peliculas",
               columns: new[] { "Id", "Titulo", "Duracion", "Genero" },
                values: new object[] { 3, "chucky", "1h 27m", "Terror/Crimen" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Peliculas");

            migrationBuilder.DeleteData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 1);

        }
    }
}
