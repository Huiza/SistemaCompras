using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    public partial class TipoEmpresa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empresa_Perfil_PerfilId",
                table: "Empresa");

            migrationBuilder.DropColumn(
                name: "Fecha",
                table: "Empresa");

            migrationBuilder.RenameColumn(
                name: "Sucursal",
                table: "Perfil",
                newName: "sucursal");

            migrationBuilder.RenameColumn(
                name: "RazonSocial",
                table: "Perfil",
                newName: "razonSocial");

            migrationBuilder.RenameColumn(
                name: "Calificacion",
                table: "Perfil",
                newName: "calificacion");

            migrationBuilder.RenameColumn(
                name: "Website",
                table: "Empresa",
                newName: "website");

            migrationBuilder.RenameColumn(
                name: "TelefonoMovil",
                table: "Empresa",
                newName: "telefonoMovil");

            migrationBuilder.RenameColumn(
                name: "Telefono",
                table: "Empresa",
                newName: "telefono");

            migrationBuilder.RenameColumn(
                name: "Rubro",
                table: "Empresa",
                newName: "rubro");

            migrationBuilder.RenameColumn(
                name: "Representante",
                table: "Empresa",
                newName: "representante");

            migrationBuilder.RenameColumn(
                name: "PerfilId",
                table: "Empresa",
                newName: "perfilId");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Empresa",
                newName: "nombre");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Empresa",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Direccion",
                table: "Empresa",
                newName: "direccion");

            migrationBuilder.RenameColumn(
                name: "Nit",
                table: "Empresa",
                newName: "nit");

            migrationBuilder.RenameIndex(
                name: "IX_Empresa_PerfilId",
                table: "Empresa",
                newName: "IX_Empresa_perfilId");

            migrationBuilder.AlterColumn<string>(
                name: "perfilId",
                table: "Empresa",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tipoEmpresaId",
                table: "Empresa",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TipoEmpresa",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    tipo = table.Column<string>(type: "varchar=100", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoEmpresa", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Empresa_tipoEmpresaId",
                table: "Empresa",
                column: "tipoEmpresaId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empresa_Perfil_perfilId",
                table: "Empresa");

            migrationBuilder.DropForeignKey(
                name: "FK_Empresa_TipoEmpresa_tipoEmpresaId",
                table: "Empresa");

            migrationBuilder.DropTable(
                name: "TipoEmpresa");

            migrationBuilder.DropIndex(
                name: "IX_Empresa_tipoEmpresaId",
                table: "Empresa");

            migrationBuilder.DropColumn(
                name: "tipoEmpresaId",
                table: "Empresa");

            migrationBuilder.RenameColumn(
                name: "sucursal",
                table: "Perfil",
                newName: "Sucursal");

            migrationBuilder.RenameColumn(
                name: "razonSocial",
                table: "Perfil",
                newName: "RazonSocial");

            migrationBuilder.RenameColumn(
                name: "calificacion",
                table: "Perfil",
                newName: "Calificacion");

            migrationBuilder.RenameColumn(
                name: "website",
                table: "Empresa",
                newName: "Website");

            migrationBuilder.RenameColumn(
                name: "telefonoMovil",
                table: "Empresa",
                newName: "TelefonoMovil");

            migrationBuilder.RenameColumn(
                name: "telefono",
                table: "Empresa",
                newName: "Telefono");

            migrationBuilder.RenameColumn(
                name: "rubro",
                table: "Empresa",
                newName: "Rubro");

            migrationBuilder.RenameColumn(
                name: "representante",
                table: "Empresa",
                newName: "Representante");

            migrationBuilder.RenameColumn(
                name: "perfilId",
                table: "Empresa",
                newName: "PerfilId");

            migrationBuilder.RenameColumn(
                name: "nombre",
                table: "Empresa",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Empresa",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "direccion",
                table: "Empresa",
                newName: "Direccion");

            migrationBuilder.RenameColumn(
                name: "nit",
                table: "Empresa",
                newName: "Nit");

            migrationBuilder.RenameIndex(
                name: "IX_Empresa_perfilId",
                table: "Empresa",
                newName: "IX_Empresa_PerfilId");

            migrationBuilder.AlterColumn<string>(
                name: "PerfilId",
                table: "Empresa",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "Fecha",
                table: "Empresa",
                type: "varchar=5",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Empresa_Perfil_PerfilId",
                table: "Empresa",
                column: "PerfilId",
                principalTable: "Perfil",
                principalColumn: "Id");
        }
    }
}
