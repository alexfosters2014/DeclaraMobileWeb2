using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServerDeclara.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BPCs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Anio = table.Column<int>(type: "int", nullable: false),
                    Valor = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BPCs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeclaracionsMensualesIRPFs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IngIndependiente = table.Column<int>(type: "int", nullable: false),
                    DeduccionTreintaPorciento = table.Column<double>(type: "float", nullable: false),
                    IngTotalIndependiente = table.Column<double>(type: "float", nullable: false),
                    IngDependenciaCess = table.Column<double>(type: "float", nullable: false),
                    IngDependenciaNoCess = table.Column<double>(type: "float", nullable: false),
                    IngSalVacacional = table.Column<double>(type: "float", nullable: false),
                    IngIncrementoSeisPorciento = table.Column<double>(type: "float", nullable: false),
                    IngTotalDependencia = table.Column<double>(type: "float", nullable: false),
                    IngOtros = table.Column<double>(type: "float", nullable: false),
                    IngParaAnticipo = table.Column<double>(type: "float", nullable: false),
                    DeduccionSDmenores = table.Column<double>(type: "float", nullable: false),
                    DeduccionCD = table.Column<double>(type: "float", nullable: false),
                    DeduccionSDMenoresCincuenta = table.Column<double>(type: "float", nullable: false),
                    DeduccionCDCincuenta = table.Column<double>(type: "float", nullable: false),
                    DeduccionTotalDeducir = table.Column<double>(type: "float", nullable: false),
                    DeduccionFondoSolidaridad = table.Column<double>(type: "float", nullable: false),
                    DeduccionFondoSolidaridadAdicional = table.Column<double>(type: "float", nullable: false),
                    DeduccionCJPPU = table.Column<double>(type: "float", nullable: false),
                    DeduccionJubilatorio = table.Column<double>(type: "float", nullable: false),
                    DeduccionFonasa = table.Column<double>(type: "float", nullable: false),
                    DeduccionFRL = table.Column<double>(type: "float", nullable: false),
                    DeduccionOtros = table.Column<double>(type: "float", nullable: false),
                    DeduccionTotal = table.Column<double>(type: "float", nullable: false),
                    AnticipoNF = table.Column<double>(type: "float", nullable: false),
                    AnticipoMensual = table.Column<double>(type: "float", nullable: false),
                    AnticipoRetenciones = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeclaracionsMensualesIRPFs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ParametrosIRPFs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RangoDesde = table.Column<int>(type: "int", nullable: false),
                    RangoHasta = table.Column<int>(type: "int", nullable: false),
                    Tasa = table.Column<int>(type: "int", nullable: false),
                    Anio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParametrosIRPFs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdGoogle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BimensualesRPFs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    DeclaracionMes1Id = table.Column<int>(type: "int", nullable: false),
                    DeclaracionMes2Id = table.Column<int>(type: "int", nullable: false),
                    AnticipoExcedente = table.Column<double>(type: "float", nullable: false),
                    AnticipoBimestre = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BimensualesRPFs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BimensualesRPFs_DeclaracionsMensualesIRPFs_DeclaracionMes1Id",
                        column: x => x.DeclaracionMes1Id,
                        principalTable: "DeclaracionsMensualesIRPFs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_BimensualesRPFs_DeclaracionsMensualesIRPFs_DeclaracionMes2Id",
                        column: x => x.DeclaracionMes2Id,
                        principalTable: "DeclaracionsMensualesIRPFs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_BimensualesRPFs_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Comercios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    RazonSocial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NombreFantasia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RUT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Porcentaje = table.Column<double>(type: "float", nullable: false),
                    Suspendido = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comercios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comercios_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EntradasIVAsDiarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ComercioId = table.Column<int>(type: "int", nullable: false),
                    MontoTotal = table.Column<double>(type: "float", nullable: false),
                    MontoMasIVA = table.Column<double>(type: "float", nullable: false),
                    MontoIVA = table.Column<double>(type: "float", nullable: false),
                    MontoIvaRetenido = table.Column<double>(type: "float", nullable: false),
                    NombreArchivoPDF = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntradasIVAsDiarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EntradasIVAsDiarios_Comercios_ComercioId",
                        column: x => x.ComercioId,
                        principalTable: "Comercios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_EntradasIVAsDiarios_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BimensualesRPFs_DeclaracionMes1Id",
                table: "BimensualesRPFs",
                column: "DeclaracionMes1Id");

            migrationBuilder.CreateIndex(
                name: "IX_BimensualesRPFs_DeclaracionMes2Id",
                table: "BimensualesRPFs",
                column: "DeclaracionMes2Id");

            migrationBuilder.CreateIndex(
                name: "IX_BimensualesRPFs_UsuarioId",
                table: "BimensualesRPFs",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Comercios_UsuarioId",
                table: "Comercios",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_EntradasIVAsDiarios_ComercioId",
                table: "EntradasIVAsDiarios",
                column: "ComercioId");

            migrationBuilder.CreateIndex(
                name: "IX_EntradasIVAsDiarios_UsuarioId",
                table: "EntradasIVAsDiarios",
                column: "UsuarioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BimensualesRPFs");

            migrationBuilder.DropTable(
                name: "BPCs");

            migrationBuilder.DropTable(
                name: "EntradasIVAsDiarios");

            migrationBuilder.DropTable(
                name: "ParametrosIRPFs");

            migrationBuilder.DropTable(
                name: "DeclaracionsMensualesIRPFs");

            migrationBuilder.DropTable(
                name: "Comercios");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
