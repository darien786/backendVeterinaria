using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backendVeterinaria.Migrations
{
    /// <inheritdoc />
    public partial class CreacionInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estatus",
                columns: table => new
                {
                    estatusId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre_estatus = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estatus", x => x.estatusId);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    personasId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "text", nullable: false),
                    apellido_paterno = table.Column<string>(type: "text", nullable: false),
                    apellido_materno = table.Column<string>(type: "text", nullable: false),
                    telefono = table.Column<string>(type: "text", nullable: false),
                    tipo_persona = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.personasId);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    rolesId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre_rol = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.rolesId);
                });

            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    empleadosId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    curp = table.Column<string>(type: "text", nullable: false),
                    sexo = table.Column<string>(type: "text", nullable: false),
                    correo = table.Column<string>(type: "text", nullable: false),
                    username = table.Column<string>(type: "text", nullable: false),
                    password = table.Column<string>(type: "text", nullable: false),
                    fecha_ingreso = table.Column<string>(type: "text", nullable: false),
                    fecha_baja = table.Column<string>(type: "text", nullable: false),
                    estatusId = table.Column<int>(type: "integer", nullable: true),
                    personasId = table.Column<int>(type: "integer", nullable: true),
                    rolesId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.empleadosId);
                    table.ForeignKey(
                        name: "FK_Empleados_Estatus_estatusId",
                        column: x => x.estatusId,
                        principalTable: "Estatus",
                        principalColumn: "estatusId");
                    table.ForeignKey(
                        name: "FK_Empleados_Personas_personasId",
                        column: x => x.personasId,
                        principalTable: "Personas",
                        principalColumn: "personasId");
                    table.ForeignKey(
                        name: "FK_Empleados_Roles_rolesId",
                        column: x => x.rolesId,
                        principalTable: "Roles",
                        principalColumn: "rolesId");
                });

            migrationBuilder.InsertData(
                table: "Estatus",
                columns: new[] { "estatusId", "nombre_estatus" },
                values: new object[,]
                {
                    { 1, "Activo" },
                    { 2, "Inactivo" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "rolesId", "nombre_rol" },
                values: new object[,]
                {
                    { 1, "Comercial" },
                    { 2, "General" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_estatusId",
                table: "Empleados",
                column: "estatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_personasId",
                table: "Empleados",
                column: "personasId");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_rolesId",
                table: "Empleados",
                column: "rolesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.DropTable(
                name: "Estatus");

            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
