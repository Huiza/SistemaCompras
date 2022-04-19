using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    public partial class MigracionInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empresa",
                columns: table => new
                {
                    Nit = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nombre = table.Column<string>(type: "varchar=100", maxLength: 50, nullable: false),
                    Representante = table.Column<string>(type: "varchar=100", maxLength: 50, nullable: false),
                    Direccion = table.Column<string>(type: "varchar=100", maxLength: 50, nullable: false),
                    Telefono = table.Column<string>(type: "varchar=9", maxLength: 9, nullable: false),
                    Fax = table.Column<string>(type: "varchar=9", maxLength: 9, nullable: false),
                    TelefonoMovil = table.Column<string>(type: "varchar=9", maxLength: 9, nullable: false),
                    Email = table.Column<string>(type: "varchar=150", maxLength: 50, nullable: false),
                    Website = table.Column<string>(type: "varchar=100", maxLength: 50, nullable: false),
                    Nrc = table.Column<string>(type: "varchar=17", maxLength: 17, nullable: false),
                    Rubro = table.Column<int>(type: "varchar=100", nullable: false),
                    Fecha = table.Column<string>(type: "varchar=5", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresa", x => x.Nit);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Empresa");
        }
    }
}
