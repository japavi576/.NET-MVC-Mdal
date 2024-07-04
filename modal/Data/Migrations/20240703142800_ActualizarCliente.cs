using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace modal.Data.Migrations
{
    /// <inheritdoc />
    public partial class ActualizarCliente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Clientes",
                table: "Cliente");

            migrationBuilder.RenameTable(
                name: "Cliente",
                newName: "Cliente");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Clientes",
                table: "Cliente");

            migrationBuilder.RenameTable(
                name: "Cliente",
                newName: "Cliente");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clientes",
                table: "Cliente",
                column: "Id");
        }
    }
}
