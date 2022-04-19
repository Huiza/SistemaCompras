using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    public partial class Migracion4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empresa_Perfil_perfilId",
                table: "Empresa");

            migrationBuilder.DropForeignKey(
                name: "FK_Empresa_TipoEmpresa_tipoEmpresaId",
                table: "Empresa");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TipoEmpresa",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Perfil",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "tipoEmpresaId",
                table: "Empresa",
                newName: "tipoEmpresaid");

            migrationBuilder.RenameColumn(
                name: "perfilId",
                table: "Empresa",
                newName: "perfilid");

            migrationBuilder.RenameIndex(
                name: "IX_Empresa_tipoEmpresaId",
                table: "Empresa",
                newName: "IX_Empresa_tipoEmpresaid");

            migrationBuilder.RenameIndex(
                name: "IX_Empresa_perfilId",
                table: "Empresa",
                newName: "IX_Empresa_perfilid");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "TipoEmpresa",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "Perfil",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "tipoEmpresaid",
                table: "Empresa",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "perfilid",
                table: "Empresa",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.CreateTable(
                name: "Contacto",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    nombre = table.Column<string>(type: "varchar=100", nullable: false),
                    telefono = table.Column<string>(type: "varchar=9", maxLength: 9, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AgendaTelefonica",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idContacto = table.Column<int>(type: "int", nullable: false),
                    idEmpresa = table.Column<int>(type: "int", nullable: false),
                    contactosId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    empresasnit = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgendaTelefonica", x => x.id);
                    table.ForeignKey(
                        name: "FK_AgendaTelefonica_Contacto_contactosId",
                        column: x => x.contactosId,
                        principalTable: "Contacto",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AgendaTelefonica_Empresa_empresasnit",
                        column: x => x.empresasnit,
                        principalTable: "Empresa",
                        principalColumn: "nit");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AgendaTelefonica_contactosId",
                table: "AgendaTelefonica",
                column: "contactosId");

            migrationBuilder.CreateIndex(
                name: "IX_AgendaTelefonica_empresasnit",
                table: "AgendaTelefonica",
                column: "empresasnit");

            migrationBuilder.AddForeignKey(
                name: "FK_Empresa_Perfil_perfilid",
                table: "Empresa",
                column: "perfilid",
                principalTable: "Perfil",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Empresa_TipoEmpresa_tipoEmpresaid",
                table: "Empresa",
                column: "tipoEmpresaid",
                principalTable: "TipoEmpresa",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empresa_Perfil_perfilid",
                table: "Empresa");

            migrationBuilder.DropForeignKey(
                name: "FK_Empresa_TipoEmpresa_tipoEmpresaid",
                table: "Empresa");

            migrationBuilder.DropTable(
                name: "AgendaTelefonica");

            migrationBuilder.DropTable(
                name: "Contacto");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "TipoEmpresa",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Perfil",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "tipoEmpresaid",
                table: "Empresa",
                newName: "tipoEmpresaId");

            migrationBuilder.RenameColumn(
                name: "perfilid",
                table: "Empresa",
                newName: "perfilId");

            migrationBuilder.RenameIndex(
                name: "IX_Empresa_tipoEmpresaid",
                table: "Empresa",
                newName: "IX_Empresa_tipoEmpresaId");

            migrationBuilder.RenameIndex(
                name: "IX_Empresa_perfilid",
                table: "Empresa",
                newName: "IX_Empresa_perfilId");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "TipoEmpresa",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Perfil",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "tipoEmpresaId",
                table: "Empresa",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "perfilId",
                table: "Empresa",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Empresa_Perfil_perfilId",
                table: "Empresa",
                column: "perfilId",
                principalTable: "Perfil",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Empresa_TipoEmpresa_tipoEmpresaId",
                table: "Empresa",
                column: "tipoEmpresaId",
                principalTable: "TipoEmpresa",
                principalColumn: "Id");
        }
    }
}
