using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClinicaVeterinaria.Migrations
{
    public partial class Segunda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animal_Usuario_UsuarioId",
                table: "Animal");

            migrationBuilder.DropTable(
                name: "Mediacamento");

            migrationBuilder.AddColumn<int>(
                name: "ExameId",
                table: "Consulta",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MedicamentoId",
                table: "Consulta",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "Animal",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Medicamento",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    ConsultaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicamento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Medicamento_Consulta_ConsultaId",
                        column: x => x.ConsultaId,
                        principalTable: "Consulta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Medicamento_ConsultaId",
                table: "Medicamento",
                column: "ConsultaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Animal_Usuario_UsuarioId",
                table: "Animal",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animal_Usuario_UsuarioId",
                table: "Animal");

            migrationBuilder.DropTable(
                name: "Medicamento");

            migrationBuilder.DropColumn(
                name: "ExameId",
                table: "Consulta");

            migrationBuilder.DropColumn(
                name: "MedicamentoId",
                table: "Consulta");

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "Animal",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateTable(
                name: "Mediacamento",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ConsultaId = table.Column<int>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mediacamento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mediacamento_Consulta_ConsultaId",
                        column: x => x.ConsultaId,
                        principalTable: "Consulta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mediacamento_ConsultaId",
                table: "Mediacamento",
                column: "ConsultaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Animal_Usuario_UsuarioId",
                table: "Animal",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
