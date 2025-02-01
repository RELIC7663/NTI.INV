using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WEB.INV.Migrations
{
    /// <inheritdoc />
    public partial class _6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Codigo = table.Column<string>(type: "varchar(5)", nullable: false),
                    Nombre = table.Column<string>(type: "varchar(50)", nullable: true),
                    Correo = table.Column<string>(type: "varchar(50)", nullable: true),
                    Usuario = table.Column<string>(type: "varchar(50)", nullable: true),
                    Password = table.Column<string>(type: "varchar(50)", nullable: true),
                    IdPermisos = table.Column<string>(type: "varchar(5)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Codigo);
                    table.ForeignKey(
                        name: "FK_Usuarios_Permisos_IdPermisos",
                        column: x => x.IdPermisos,
                        principalTable: "Permisos",
                        principalColumn: "IdPermisos");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_IdPermisos",
                table: "Usuarios",
                column: "IdPermisos");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
