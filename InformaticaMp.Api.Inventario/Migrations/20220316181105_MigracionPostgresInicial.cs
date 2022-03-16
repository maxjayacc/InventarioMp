using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace InformaticaMp.Api.Inventario.Migrations
{
    public partial class MigracionPostgresInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PersonalMp",
                columns: table => new
                {
                    PersonalMpId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(nullable: true),
                    Apellidos = table.Column<string>(nullable: true),
                    Cargo = table.Column<string>(nullable: true),
                    FechaNacimiento = table.Column<DateTime>(nullable: false),
                    Dni = table.Column<string>(nullable: true),
                    RegimenLaboral = table.Column<string>(nullable: true),
                    AreaDespacho = table.Column<string>(nullable: true),
                    DistritoFiscal = table.Column<string>(nullable: true),
                    Sede = table.Column<string>(nullable: true),
                    Local = table.Column<string>(nullable: true),
                    DespachoAnterior = table.Column<string>(nullable: true),
                    Correo = table.Column<string>(nullable: true),
                    Telefono = table.Column<string>(nullable: true),
                    Estado = table.Column<string>(nullable: true),
                    PersonalMpGuid = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalMp", x => x.PersonalMpId);
                });

            migrationBuilder.CreateTable(
                name: "BienInformatico",
                columns: table => new
                {
                    BienInformaticoId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CodigoPatrimonial = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true),
                    Marca = table.Column<string>(nullable: true),
                    Modelo = table.Column<string>(nullable: true),
                    Serie = table.Column<string>(nullable: true),
                    Ip = table.Column<string>(nullable: true),
                    EstadoBien = table.Column<string>(nullable: true),
                    TipoBien = table.Column<string>(nullable: true),
                    Estado = table.Column<string>(nullable: true),
                    CodigoInventario = table.Column<string>(nullable: true),
                    Procesador = table.Column<string>(nullable: true),
                    MemoriaGB = table.Column<string>(nullable: true),
                    DiscoDuro = table.Column<string>(nullable: true),
                    FuncionEquipo = table.Column<string>(nullable: true),
                    TipoImpresion = table.Column<string>(nullable: true),
                    TipoSoftware = table.Column<string>(nullable: true),
                    PersonalMpId = table.Column<int>(nullable: false),
                    BienInformaticoGuid = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BienInformatico", x => x.BienInformaticoId);
                    table.ForeignKey(
                        name: "FK_BienInformatico_PersonalMp_PersonalMpId",
                        column: x => x.PersonalMpId,
                        principalTable: "PersonalMp",
                        principalColumn: "PersonalMpId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BienInformatico_PersonalMpId",
                table: "BienInformatico",
                column: "PersonalMpId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BienInformatico");

            migrationBuilder.DropTable(
                name: "PersonalMp");
        }
    }
}
