using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    public partial class ADD_PK_COTIZACION : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_cotizacion",
                table: "cotizacion");

            migrationBuilder.AlterColumn<string>(
                name: "nit",
                table: "cotizacion",
                type: "varchar=17",
                maxLength: 17,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar=17",
                oldMaxLength: 17);

            migrationBuilder.AddColumn<int>(
                name: "id_cotizacion",
                table: "cotizacion",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_cotizacion",
                table: "cotizacion",
                column: "id_cotizacion");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_cotizacion",
                table: "cotizacion");

            migrationBuilder.DropColumn(
                name: "id_cotizacion",
                table: "cotizacion");

            migrationBuilder.AlterColumn<string>(
                name: "nit",
                table: "cotizacion",
                type: "varchar=17",
                maxLength: 17,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar=17",
                oldMaxLength: 17,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_cotizacion",
                table: "cotizacion",
                column: "nit");
        }
    }
}
