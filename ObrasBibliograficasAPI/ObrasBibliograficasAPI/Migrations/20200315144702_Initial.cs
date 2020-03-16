using Microsoft.EntityFrameworkCore.Migrations;

namespace ObrasBibliograficasAPI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ObrasBibliograficas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NomeAutor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObrasBibliograficas", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ObrasBibliograficas",
                columns: new[] { "Id", "NomeAutor" },
                values: new object[] { 1, "Marcelo da Silva Sousa" });

            migrationBuilder.InsertData(
                table: "ObrasBibliograficas",
                columns: new[] { "Id", "NomeAutor" },
                values: new object[] { 18, "Karina de Gomes" });

            migrationBuilder.InsertData(
                table: "ObrasBibliograficas",
                columns: new[] { "Id", "NomeAutor" },
                values: new object[] { 17, "Fernando" });

            migrationBuilder.InsertData(
                table: "ObrasBibliograficas",
                columns: new[] { "Id", "NomeAutor" },
                values: new object[] { 16, "Guilherme Borges de Souza" });

            migrationBuilder.InsertData(
                table: "ObrasBibliograficas",
                columns: new[] { "Id", "NomeAutor" },
                values: new object[] { 15, "Daniela Costa Filha" });

            migrationBuilder.InsertData(
                table: "ObrasBibliograficas",
                columns: new[] { "Id", "NomeAutor" },
                values: new object[] { 14, "José Junior" });

            migrationBuilder.InsertData(
                table: "ObrasBibliograficas",
                columns: new[] { "Id", "NomeAutor" },
                values: new object[] { 13, "Ingrid" });

            migrationBuilder.InsertData(
                table: "ObrasBibliograficas",
                columns: new[] { "Id", "NomeAutor" },
                values: new object[] { 12, "Rafael Bezerra de Santos" });

            migrationBuilder.InsertData(
                table: "ObrasBibliograficas",
                columns: new[] { "Id", "NomeAutor" },
                values: new object[] { 11, "Vinicius Matheus da Silva Neto" });

            migrationBuilder.InsertData(
                table: "ObrasBibliograficas",
                columns: new[] { "Id", "NomeAutor" },
                values: new object[] { 10, "Isabela Feranandes Rocha" });

            migrationBuilder.InsertData(
                table: "ObrasBibliograficas",
                columns: new[] { "Id", "NomeAutor" },
                values: new object[] { 9, "Amanda Lima" });

            migrationBuilder.InsertData(
                table: "ObrasBibliograficas",
                columns: new[] { "Id", "NomeAutor" },
                values: new object[] { 8, "Matheus Alves" });

            migrationBuilder.InsertData(
                table: "ObrasBibliograficas",
                columns: new[] { "Id", "NomeAutor" },
                values: new object[] { 7, "Anderson Gomes Souza Filho" });

            migrationBuilder.InsertData(
                table: "ObrasBibliograficas",
                columns: new[] { "Id", "NomeAutor" },
                values: new object[] { 6, "Roberto Ferreira Neto" });

            migrationBuilder.InsertData(
                table: "ObrasBibliograficas",
                columns: new[] { "Id", "NomeAutor" },
                values: new object[] { 5, "Guimaraes" });

            migrationBuilder.InsertData(
                table: "ObrasBibliograficas",
                columns: new[] { "Id", "NomeAutor" },
                values: new object[] { 4, "Celso de Araujo" });

            migrationBuilder.InsertData(
                table: "ObrasBibliograficas",
                columns: new[] { "Id", "NomeAutor" },
                values: new object[] { 3, "Paulo Coelho" });

            migrationBuilder.InsertData(
                table: "ObrasBibliograficas",
                columns: new[] { "Id", "NomeAutor" },
                values: new object[] { 2, "João da Silva" });

            migrationBuilder.InsertData(
                table: "ObrasBibliograficas",
                columns: new[] { "Id", "NomeAutor" },
                values: new object[] { 19, "Everton Filho" });

            migrationBuilder.InsertData(
                table: "ObrasBibliograficas",
                columns: new[] { "Id", "NomeAutor" },
                values: new object[] { 20, "Gisele Ferreira Santos" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ObrasBibliograficas");
        }
    }
}
