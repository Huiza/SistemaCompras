using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    public partial class Renombramiento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AgendaTelefonica_Contacto_contactosId",
                table: "AgendaTelefonica");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Contacto",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "contactosId",
                table: "AgendaTelefonica",
                newName: "contactosid");

            migrationBuilder.RenameIndex(
                name: "IX_AgendaTelefonica_contactosId",
                table: "AgendaTelefonica",
                newName: "IX_AgendaTelefonica_contactosid");

            migrationBuilder.AddForeignKey(
                name: "FK_AgendaTelefonica_Contacto_contactosid",
                table: "AgendaTelefonica",
                column: "contactosid",
                principalTable: "Contacto",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AgendaTelefonica_Contacto_contactosid",
                table: "AgendaTelefonica");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Contacto",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "contactosid",
                table: "AgendaTelefonica",
                newName: "contactosId");

            migrationBuilder.RenameIndex(
                name: "IX_AgendaTelefonica_contactosid",
                table: "AgendaTelefonica",
                newName: "IX_AgendaTelefonica_contactosId");

            migrationBuilder.AddForeignKey(
                name: "FK_AgendaTelefonica_Contacto_contactosId",
                table: "AgendaTelefonica",
                column: "contactosId",
                principalTable: "Contacto",
                principalColumn: "Id");
        }
    }
}
