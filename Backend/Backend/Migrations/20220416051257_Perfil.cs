using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    public partial class Perfil : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PerfilId",
                table: "Empresa",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Perfil",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    escrituras = table.Column<string>(type: "varchar=100", maxLength: 50, nullable: false),
                    RazonSocial = table.Column<string>(type: "varchar=100", maxLength: 50, nullable: false),
                    Sucursal = table.Column<bool>(type: "bit", nullable: false),
                    Calificacion = table.Column<string>(type: "varchar=1", maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perfil", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Empresa_PerfilId",
                table: "Empresa",
                column: "PerfilId");

            migrationBuilder.AddForeignKey(
                name: "FK_Empresa_Perfil_PerfilId",
                table: "Empresa",
                column: "PerfilId",
                principalTable: "Perfil",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empresa_Perfil_PerfilId",
                table: "Empresa");

            migrationBuilder.DropTable(
                name: "Perfil");

            migrationBuilder.DropIndex(
                name: "IX_Empresa_PerfilId",
                table: "Empresa");

            migrationBuilder.DropColumn(
                name: "PerfilId",
                table: "Empresa");
        }
    }
}
