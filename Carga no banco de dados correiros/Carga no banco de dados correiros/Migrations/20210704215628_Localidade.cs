using Microsoft.EntityFrameworkCore.Migrations;

namespace Carga_no_banco_de_dados_correiros.Migrations
{
    public partial class Localidade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LogLocalidade",
                columns: table => new
                {
                    LOC_NU = table.Column<int>(type: "int", nullable: false),
                    UFE_SG = table.Column<string>(type: "char(2)", nullable: false),
                    LOC_NO = table.Column<string>(type: "varchar(72)", nullable: true),
                    CEP = table.Column<string>(type: "char(8)", nullable: false),
                    LOC_IN_SIT = table.Column<string>(type: "char(1)", nullable: false),
                    LOC_IN_TIPO_LOC = table.Column<string>(type: "char(1)", nullable: false),
                    LOC_NU_SUB = table.Column<string>(type: "varchar(8)", nullable: true),
                    LOC_NO_ABREV = table.Column<string>(type: "varchar(36)", nullable: true),
                    MUN_NU = table.Column<string>(type: "char(7)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogLocalidade", x => x.LOC_NU);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LogLocalidade");
        }
    }
}
