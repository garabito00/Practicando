using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class RecreateDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Proyecto",
                columns: table => new
                {
                    Proyecto_Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    compania = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proyecto", x => x.Proyecto_Id);
                });

            migrationBuilder.CreateTable(
                name: "Ubicacion",
                columns: table => new
                {
                    Ubicacion_Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    lugar = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ubicacion", x => x.Ubicacion_Id);
                });

            migrationBuilder.CreateTable(
                name: "Posicion",
                columns: table => new
                {
                    Posicion_Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    titulo = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    proyecto_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posicion", x => x.Posicion_Id);
                    table.ForeignKey(
                        name: "FK_Posicion_Proyecto_Posicion_Id",
                        column: x => x.Posicion_Id,
                        principalTable: "Proyecto",
                        principalColumn: "Proyecto_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "empelados",
                columns: table => new
                {
                    Empleado_Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(type: "VARCHAR(25)", maxLength: 25, nullable: false),
                    apellido = table.Column<string>(type: "VARCHAR(25)", maxLength: 25, nullable: false),
                    cedula = table.Column<string>(type: "VARCHAR(25)", maxLength: 25, nullable: false),
                    posicion_id = table.Column<int>(type: "int", nullable: false),
                    salario_hora = table.Column<double>(type: "double", nullable: false),
                    ubicacion_id = table.Column<int>(type: "int", nullable: false),
                    tipo_empleado = table.Column<string>(type: "VARCHAR(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_empelados", x => x.Empleado_Id);
                    table.ForeignKey(
                        name: "FK_empelados_Posicion_posicion_id",
                        column: x => x.posicion_id,
                        principalTable: "Posicion",
                        principalColumn: "Posicion_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_empelados_Ubicacion_ubicacion_id",
                        column: x => x.ubicacion_id,
                        principalTable: "Ubicacion",
                        principalColumn: "Ubicacion_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "bolantePago",
                columns: table => new
                {
                    Bolante_Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    bonificacion_asistencia = table.Column<bool>(type: "boolean", nullable: false),
                    bono_extra = table.Column<double>(type: "double", nullable: false),
                    horas_normales = table.Column<double>(type: "double", nullable: false),
                    horas_extra = table.Column<double>(type: "double", nullable: false),
                    afp = table.Column<double>(type: "double", nullable: false),
                    seguro_salud = table.Column<double>(type: "double", nullable: false),
                    pagos_horas_normales = table.Column<double>(type: "double", nullable: false),
                    pagos_horas_extra = table.Column<double>(type: "double", nullable: false),
                    total_periodo = table.Column<double>(type: "double", nullable: false),
                    empleado_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bolantePago", x => x.Bolante_Id);
                    table.ForeignKey(
                        name: "FK_bolantePago_empelados_empleado_id",
                        column: x => x.empleado_id,
                        principalTable: "empelados",
                        principalColumn: "Empleado_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CuentaBanco",
                columns: table => new
                {
                    Cuenta_Banco_Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    banco = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    tipo_cuenta = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: true),
                    numero_cuenta = table.Column<int>(type: "int", nullable: false),
                    Empleado_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuentaBanco", x => x.Cuenta_Banco_Id);
                    table.ForeignKey(
                        name: "FK_CuentaBanco_empelados_Empleado_Id",
                        column: x => x.Empleado_Id,
                        principalTable: "empelados",
                        principalColumn: "Empleado_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_bolantePago_empleado_id",
                table: "bolantePago",
                column: "empleado_id");

            migrationBuilder.CreateIndex(
                name: "IX_CuentaBanco_Empleado_Id",
                table: "CuentaBanco",
                column: "Empleado_Id");

            migrationBuilder.CreateIndex(
                name: "IX_empelados_posicion_id",
                table: "empelados",
                column: "posicion_id");

            migrationBuilder.CreateIndex(
                name: "IX_empelados_ubicacion_id",
                table: "empelados",
                column: "ubicacion_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bolantePago");

            migrationBuilder.DropTable(
                name: "CuentaBanco");

            migrationBuilder.DropTable(
                name: "empelados");

            migrationBuilder.DropTable(
                name: "Posicion");

            migrationBuilder.DropTable(
                name: "Ubicacion");

            migrationBuilder.DropTable(
                name: "Proyecto");
        }
    }
}
