using Microsoft.EntityFrameworkCore.Migrations;

namespace Carga_no_banco_de_dados_correiros.Migrations
{
    public partial class bairro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LogLocalidade",
                columns: table => new
                {
                    LOC_NU = table.Column<int>(type: "int", nullable: false),
                    UFE_SG = table.Column<string>(type: "char(2)", nullable: true),
                    LOC_NO = table.Column<string>(type: "varchar(72)", nullable: true),
                    CEP = table.Column<string>(type: "char(8)", nullable: true),
                    LOC_IN_SIT = table.Column<string>(type: "char(1)", nullable: true),
                    LOC_IN_TIPO_LOC = table.Column<string>(type: "char(1)", nullable: true),
                    LOC_NU_SUB = table.Column<string>(type: "varchar(8)", nullable: true),
                    LOC_NO_ABREV = table.Column<string>(type: "varchar(36)", nullable: true),
                    MUN_NU = table.Column<string>(type: "char(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogLocalidade", x => x.LOC_NU);
                });

            migrationBuilder.CreateTable(
                name: "LogBairro",
                columns: table => new
                {
                    BAI_NU = table.Column<int>(type: "int", nullable: false),
                    UFE_SG = table.Column<string>(type: "char(2)", nullable: true),
                    LogLocalidadeId = table.Column<int>(type: "int", nullable: false),
                    BAI_NO = table.Column<string>(type: "varchar(72)", nullable: true),
                    BAI_NO_ABREV = table.Column<string>(type: "varchar(36)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogBairro", x => x.BAI_NU);
                    table.ForeignKey(
                        name: "FK_LogBairro_LogLocalidade_LogLocalidadeId",
                        column: x => x.LogLocalidadeId,
                        principalTable: "LogLocalidade",
                        principalColumn: "LOC_NU",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LogBairro_LogLocalidadeId",
                table: "LogBairro",
                column: "LogLocalidadeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LogBairro");

            migrationBuilder.DropTable(
                name: "LogLocalidade");
        }
    }
}
